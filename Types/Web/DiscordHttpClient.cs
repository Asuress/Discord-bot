using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

using Discord_bot.Dependencies;
using System.Net.Http.Headers;

namespace Discord_bot.Types
{
    public class DiscordHttpClient
    {
        HttpClient httpClient;
        DiscordWebSocket webSocket;
        string urlToApi;
        JsonResponse initResponse;
        JsonSerializerOptions webJsonOptions;

        public HttpClient HttpClient { get => httpClient; private set => httpClient = value; }
        public string UrlToApi { get => urlToApi; private set => urlToApi = value; }
        public DiscordWebSocket WebSocket { get => webSocket; private set => webSocket = value; }
        // public bool IsConnected { get; private set; }

        public DiscordHttpClient()
        {
            this.urlToApi = "https://discord.com/api/v9";
            this.httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlToApi);
            webJsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            webJsonOptions.PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance;
        }

        public async Task<JsonResponse> AuthorizeAsync(string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bot {token}");
            // httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue($"Bot {token}");
            var responseFromServer = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, "https://discord.com/api/gateway/bot"));
            var str = await responseFromServer.Content.ReadAsStringAsync();
            return initResponse = JsonSerializer.Deserialize<JsonResponse>(str, webJsonOptions);

            // // old implementation
            // HttpWebRequest rq = HttpWebRequest.CreateHttp("https://discord.com/api/gateway/bot");
            // rq.Headers.Add(HttpRequestHeader.Authorization, $"Bot {token}");
            // var resp = await rq.GetResponseAsync();
            // string responseFromServer;
            // using (Stream dataStream = resp.GetResponseStream())
            // {
            //     StreamReader reader = new StreamReader(dataStream);
            //     responseFromServer = reader.ReadToEnd();
            // }
            // resp.Close();
            // Console.WriteLine(responseFromServer);
            // return initResponse = JsonSerializer.Deserialize<JsonResponse>(responseFromServer, webJsonOptions);
        }

        //временно
        // public async Task ConnectAsync(string token, List<GatewayIntents> intents)
        // {
        //     webSocket = new DiscordWebSocket();
        //     await webSocket.ConnectAsync(new Uri(initResponse.Url + "?v=9&encoding=json"));
        //     var buff = new ArraySegment<byte>(new byte[4096]); // maximum 4096 bytes

        //     var receive = await webSocket.ReceiveAsync(buff, CancellationToken.None);

        //     string s = string.Empty;
        //     s = Encoding.UTF8.GetString(buff.Slice(0, receive.Count));

        //     Console.WriteLine(s);

        //     var op10 = JsonSerializer.Deserialize<Opcode10>(s, webJsonOptions);

        //     var t = StartSendHearbeat(op10.D.HeartbeatInterval, token, intents);
        //     Console.WriteLine("leftHeartbeat");
        // }

        // private async Task StartSendHearbeat(int heartbeatInterval, string token, List<GatewayIntents> intents)
        // {
        //     await Task.Yield();
        //     var lastHeartbeatTime = DateTime.Now;
        //     var reciveBuff = new ArraySegment<byte>(new byte[4096]);
        //     int? seq = null;
        //     Opcode1 op1 = new Opcode1()
        //     {
        //         Op = GatewayOpcodes.HEARTBEAT,
        //         D = seq
        //     };
        //     IsConnected = true;

        //     while (IsConnected)
        //     {
        //         var elapsedTime = DateTime.Now - lastHeartbeatTime;
        //         if (elapsedTime.TotalMilliseconds >= heartbeatInterval)
        //         {
        //             var sendBuff = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(op1, webJsonOptions));
        //             if (webSocket.State == WebSocketState.Open)
        //             {
        //                 Console.WriteLine(Encoding.UTF8.GetString(sendBuff));
        //                 await webSocket.SendAsync(sendBuff, WebSocketMessageType.Text, true, CancellationToken.None);

        //                 var receiveResult = await webSocket.ReceiveAsync(reciveBuff, CancellationToken.None);

        //                 var str = Encoding.UTF8.GetString(reciveBuff.Slice(0, receiveResult.Count));
        //                 Console.WriteLine($"{str}; {DateTime.Now}; RecieveCount={receiveResult.Count}");
        //                 lastHeartbeatTime = DateTime.Now;
        //                 if (!IsIdentifySent)
        //                 {
        //                     SendIdentify(token, intents);
        //                     lastHeartbeatTime = DateTime.Now;
        //                     IsIdentifySent = true;
        //                 }
        //             }
        //             else if (webSocket.State == WebSocketState.CloseReceived)
        //             {
        //                 IsConnected = false;
        //             }
        //         }
        //     }
        // }

        // private async void SendIdentify(string token, List<GatewayIntents> intents)
        // {
        //     var reciveBuff = new ArraySegment<byte>(new byte[4096]);
        //     //Identify opcode
        //     string identifyOpcodeJsonString = //@"{""op"":2,""d"":{""token"":""" + token + @""",""intents"":513,""properties"":{""os"":""linux"",""browser"":""Discord_bot"",""device"":""Discord_bot""}}}";


        //     JsonSerializer.Serialize(
        //         new GatewayPayload()
        //         {
        //             Op = GatewayOpcodes.IDENTIFY,
        //             D = new Identify()
        //             {
        //                 Token = token,
        //                 Properties = new IdentifyConnectionProperties()
        //                 {
        //                     Os = "windows",
        //                     Device = "Discord_bot",
        //                     Browser = "Discord_bot"
        //                 },
        //                 Intents = (from i in intents select ((int)i)).Sum(), //intentsValue
        //             }
        //         },
        //         webJsonOptions
        //     );

        //     Console.WriteLine(identifyOpcodeJsonString);
        //     byte[] bytes = Encoding.UTF8.GetBytes(identifyOpcodeJsonString);
        //     await webSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None);

        //     var receive = await webSocket.ReceiveAsync(reciveBuff, CancellationToken.None);
        //     string s = string.Empty;
        //     s = Encoding.UTF8.GetString(reciveBuff.Slice(0, receive.Count));
        //     Console.WriteLine(s);
        //     //Identify opcode end
        // }

        public async Task<HttpResponseMessage> PostAsync(string endpoint, string content, params string[] parameters)
        {
            var strContent = new StringContent(content);
            strContent.Headers.ContentType.MediaType = "application/json";
            return await httpClient.PostAsync(BuildUrl(endpoint, parameters), strContent);
        }

        public async Task<HttpResponseMessage> PutAsync(string endpoint, string content, params string[] parameters)
        {
            var strContent = new StringContent(content);
            strContent.Headers.ContentType.MediaType = "application/json";
            return await httpClient.PutAsync(BuildUrl($"{endpoint}", parameters), strContent);
        }

        public async Task<HttpResponseMessage> PatchAsync(string endpoint, string content, params string[] parameters)
        {
            var strContent = new StringContent(content);
            strContent.Headers.ContentType.MediaType = "application/json";
            return await httpClient.PatchAsync(BuildUrl($"{endpoint}", parameters), strContent);
        }

        public async Task<HttpResponseMessage> GetAsync(string endpoint, params string[] parameters)
        {
            return await httpClient.GetAsync(BuildUrl(endpoint, parameters));
        }

        public async Task<HttpResponseMessage> DeleteAsync(string endpoint, string[] parameters = null)
        {
            return await httpClient.DeleteAsync(BuildUrl(endpoint, parameters));
        }

        private Uri BuildUrl(string endpoint, /*params string[] paramNames,*/ params string[] parameters)
        {
            UriBuilder builder = new UriBuilder($"{urlToApi}{endpoint}");
            if (parameters != null)
            {
                foreach (var p in parameters)
                {
                    if (builder.Query == string.Empty)
                    {
                        builder.Query = p;
                    }
                    else
                    {
                        builder.Query += "&" + p;
                    }
                }
            }
            Uri uri = builder.Uri;
            return uri;
        }
    }
}