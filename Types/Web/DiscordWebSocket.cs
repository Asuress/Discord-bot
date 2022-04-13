using System;
using System.Collections.Generic;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Discord_bot.Types
{
    public class DiscordWebSocket : IDisposable
    {
        const int msgMaxSize = 4096;

        ClientWebSocket ws;
        Task receiverTask;
        Dictionary<string, string> headers;

        SemaphoreSlim locker;

        CancellationTokenSource receiveCancellationTokenSource;
        CancellationToken receiveCancellationToken;
        CancellationTokenSource wsCancellationTokenSource;
        CancellationToken wsCancellationToken;

        bool isConnected;

        public delegate void MessageReceivedEventHandler(object sender, WebSocketMessageReceivedEventArgs args);
        public event MessageReceivedEventHandler MessageReceived;

        public delegate void ErrorReceivedEventHandler(object sender, WebSocketErrorReceivedEventArgs args);
        public event ErrorReceivedEventHandler ErrorReceived;

        public delegate void ConnectedEventHandler(object sender, WebSocketConnectedEventArgs args);
        public event ConnectedEventHandler Connected;

        public delegate void DisconnectedEventHandler(object sender, WebSocketDisconnectedEventArgs args);
        public event DisconnectedEventHandler Disconnected;

        public DiscordWebSocket()
        {
            // set empty lambda for each event to prevent null reference exception
            this.MessageReceived += (o, e) => { return; };
            this.Connected += (o, e) => { return; };
            this.Disconnected += (o, e) => { return; };
            this.ErrorReceived += (o, e) => { return; };

            this.locker = new SemaphoreSlim(1);
            this.isConnected = false;

            wsCancellationTokenSource = null;
            receiveCancellationTokenSource = null;

            wsCancellationToken = CancellationToken.None;
            receiveCancellationToken = CancellationToken.None;
        }

        ~DiscordWebSocket()
        {
            ws?.Dispose();
            receiverTask?.Dispose();

            if (this.wsCancellationToken.CanBeCanceled)
                this.wsCancellationTokenSource?.Cancel();
            this.wsCancellationTokenSource?.Dispose();

            if (this.receiveCancellationToken.CanBeCanceled)
                this.receiveCancellationTokenSource?.Cancel();
            this.receiveCancellationTokenSource?.Dispose();
        }

        public async Task ConnectAsync(Uri uri)
        {
            await Task.Yield();
            if (isConnected)
            {
                await DisconnectAsync().ConfigureAwait(false);
            }

            await locker.WaitAsync().ConfigureAwait(false);
            try
            {
                ws?.Dispose();
                ws = new ClientWebSocket();
                ws.Options.KeepAliveInterval = TimeSpan.Zero;
                if (headers != null)
                {
                    foreach (var (k, v) in headers)
                    {
                        ws.Options.SetRequestHeader(k, v);
                    }
                }
                wsCancellationTokenSource = new CancellationTokenSource();
                wsCancellationToken = wsCancellationTokenSource.Token;

                await ws.ConnectAsync(uri, wsCancellationToken).ConfigureAwait(false);

                if (ws.State == WebSocketState.CloseReceived)
                    throw new Exception("Can't connect to the server");

                receiverTask = Task.Run(ReceiveLoopAsync);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                locker.Release();
            }
        }

        public async Task DisconnectAsync(int code = 1000, string message = "")
        {
            await Task.Yield();

            receiveCancellationTokenSource.Cancel();

            await receiverTask.ConfigureAwait(false);
            await locker.WaitAsync().ConfigureAwait(false);

            await ws.CloseAsync((WebSocketCloseStatus)code, message, CancellationToken.None).ConfigureAwait(false);

            isConnected = false;

            ws?.Abort();
            ws?.Dispose();

            receiverTask?.Dispose();
            locker.Release();
        }

        public async Task SendMessageAsync(string message)
        {
            await Task.Yield();

            if (ws == null || isConnected == false)
                throw new NullReferenceException("websocket is not connected");

            if (ws.State != WebSocketState.Open && ws.State == WebSocketState.CloseReceived)
                throw new WebException("websocket connection is not opened or requested to be closed");

            var bytes = UTF8Encoding.UTF8.GetBytes(message);

            await locker.WaitAsync().ConfigureAwait(false);
            try
            {
                var len = bytes.Length;
                var segmentCount = len / msgMaxSize;

                if (segmentCount % msgMaxSize != 0)
                    segmentCount++;

                for (int i = 0; i < segmentCount; i++)
                {
                    var segmentBegin = i * msgMaxSize;
                    var segmentEnd = Math.Min(msgMaxSize, len - segmentBegin);

                    await ws.SendAsync(new ArraySegment<byte>(bytes, segmentBegin, segmentEnd),
                                        WebSocketMessageType.Text,
                                        i == segmentCount - 1,
                                        CancellationToken.None);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                locker.Release();
            }
        }

        private async Task ReceiveLoopAsync()
        {
            byte[] buff = new byte[msgMaxSize];
            WebSocketReceiveResult receive;
            StringBuilder sb = new StringBuilder();
            try
            {
                while (!receiveCancellationToken.IsCancellationRequested)
                {
                    do
                    {
                        receive = await ws.ReceiveAsync(buff, receiveCancellationToken).ConfigureAwait(false);
                        sb.Append(Encoding.UTF8.GetChars(buff, 0, receive.Count));
                    } while (!receive.EndOfMessage);

                    var message = sb.ToString();

                    if (receive.MessageType == WebSocketMessageType.Close)
                    {
                        // disconnected
                        await DisconnectAsync().ConfigureAwait(false);
                        this.Disconnected?.Invoke(this, new WebSocketDisconnectedEventArgs());
                    }
                    else if (isConnected == false && receive.MessageType != WebSocketMessageType.Close)
                    {
                        // connected
                        isConnected = true;
                        this.Connected?.Invoke(this, new WebSocketConnectedEventArgs());
                    }

                    if (receive.MessageType == WebSocketMessageType.Text)
                    {
                        // message received
                        this.MessageReceived?.Invoke(this, new WebSocketMessageReceivedEventArgs(message));
                    }

                    // not sure if this condition is needed

                    // else if (receive.MessageType == WebSocketMessageType.Binary)
                    // {
                    //     this.MessageReceived?.Invoke(this, new WebSocketMessageReceivedEventArgs(message));
                    // }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                ErrorReceived?.Invoke(this, new WebSocketErrorReceivedEventArgs());
            }
            finally
            {

            }
            // MessageReceived.Invoke(this, new MessageReceivedEventArgs(sb.ToString()));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}