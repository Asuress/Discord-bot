using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Discord_bot.Dependencies;

namespace Discord_bot.Types
{
    public class DiscordClient
    {
        JsonSerializerOptions jsonOptions;
        private string token;
        private DiscordHttpClient discordHttpClient;
        private DiscordWebSocket discordWebSocket;

        CancellationTokenSource cancellationTokenSource;
        CancellationToken cancellationToken;

        private Task heartBeatTask;
        private DateTime lastHeartBeat;
        private int heartBeatInterval;
        private int lastSeq;
        private JsonResponse gatewayInfo;

        public int Intents { get; private set; }

        public DiscordClient(string token)
        {
            this.jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            this.jsonOptions.PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance;
            this.token = token;
            this.discordHttpClient = new DiscordHttpClient();
            this.discordWebSocket = new DiscordWebSocket();

            // temporary
            discordWebSocket.MessageReceived += MessageHandler;
            discordWebSocket.Connected += Connected;
        }
        // temporary

        private void Connected(object sender, WebSocketConnectedEventArgs args)
        {
            // Console.WriteLine(args.D);
            // SendIdentify().Wait();
        }

        public void MessageHandler(object sender, WebSocketMessageReceivedEventArgs args)
        {
            Console.WriteLine(args.Message);
            var payload = JsonSerializer.Deserialize<GatewayPayload>(args.Message);
            this.lastSeq = payload.S ?? this.lastSeq;
            switch (payload.Op)
            {
                case GatewayOpcodes.DISCPATCH:
                    HandleDispatch(payload);
                    break;
                case GatewayOpcodes.HEARTBEAT:
                    HandleHeartbeat();
                    break;
                case GatewayOpcodes.RECONNECT:
                    HandleReconnect();
                    break;
                case GatewayOpcodes.INVALID_SESSION:
                    HandleInvalidSession(payload);
                    break;
                case GatewayOpcodes.HELLO:
                    HandleHello(payload);
                    break;
                case GatewayOpcodes.HEARTBEAT_ACK:
                    HandleHeartbeatACK();
                    break;
                default:
                    break;
            }
        }

        private void HandleDispatch(GatewayPayload payload)
        {
            
        }

        private void HandleHeartbeat()
        {
            throw new NotImplementedException();
        }

        private void HandleReconnect()
        {
            throw new NotImplementedException();
        }

        private void HandleInvalidSession(GatewayPayload payload)
        {
            var invalidSessionPL = new GatewayInvalidSession();
        }

        private void HandleHello(GatewayPayload payload)
        {
            var helloOp = new GatewayHello()
            {
                Op = payload.Op,
                D = JsonSerializer.Deserialize<HelloEvent>(payload.D),
                S = payload.S,
                T = payload.T,
            };
            this.heartBeatInterval = helloOp.D.heartbeatInterval;
        }

        private void HandleHeartbeatACK()
        {
            throw new NotImplementedException();
        }

        private async Task SendIdentify()
        {
            var identify = new Identify()
            {
                Token = token,
                Intents = this.Intents,
                Properties = new IdentifyConnectionProperties()
                {
                    Browser = "discord bot",
                    Os = "windows",
                    Device = "discord bot"
                },
                Compress = false,
            };
            var identifyJsonStr = JsonSerializer.Serialize(identify, jsonOptions);
            var payload = new GatewayPayload()
            {
                Op = GatewayOpcodes.IDENTIFY,
                D = identifyJsonStr
            };
            var payloadJsonStr = JsonSerializer.Serialize(payload, jsonOptions);
            await discordWebSocket.SendMessageAsync(payloadJsonStr);
        }

        // temporary ended

        public async Task AuthorizeAsync()
        {
            gatewayInfo = await discordHttpClient.AuthorizeAsync(token);
        }

        public async Task ConnectAsync(List<GatewayIntents> intents)
        {
            this.Intents = (from i in intents select (int)i).Sum();
            await discordWebSocket.ConnectAsync(new Uri(gatewayInfo.Url + $"?v=9&encoding=json"));
        }

        private async Task SendHeartbeatAsync(int seq)
        {
            await discordWebSocket.SendMessageAsync(JsonSerializer.Serialize(new HeartbeatOpcode() { D = seq }, jsonOptions));
        }

        private async Task HeartbeatLoopAsync()
        {
            await Task.Yield();

            while (!cancellationToken.IsCancellationRequested)
            {
                await SendHeartbeatAsync(lastSeq).ConfigureAwait(false);
                await Task.Delay(heartBeatInterval).ConfigureAwait(false);
            }
        }

        #region Events

        public delegate void MessageReceivedEventHandler(object sender, MessageReceivedEventArgs args);
        public event MessageReceivedEventHandler MessageReceived;

        #endregion

        public async Task<User> GetMeAsync()
        {
            var httpResponse = await discordHttpClient.GetAsync("/users/@me");
            User bot = JsonSerializer.Deserialize<User>(await httpResponse.Content.ReadAsStringAsync(), jsonOptions);
            return bot;
        }

        public async Task<User> GetUserAsync(string userId)
        {
            var httpResponse = await discordHttpClient.GetAsync($"/users/{userId}");
            User user = JsonSerializer.Deserialize<User>(await httpResponse.Content.ReadAsStringAsync(), jsonOptions);
            return user;
        }

        public async Task<LinkedList<Guild>> GetMyGuildsAsync()
        {
            var httpResponse = await discordHttpClient.GetAsync("/users/@me/guilds");
            var str = await httpResponse.Content.ReadAsStringAsync();
            LinkedList<Guild> guilds = JsonSerializer.Deserialize<LinkedList<Guild>>(str, jsonOptions);
            return guilds;
        }

        public async void LeaveGuildAsync(string guildId)
        {
            await discordHttpClient.DeleteAsync($"/users/@me/guilds/{guildId}");
        }

        public async Task<Channel> GetChannelAsync(string сhannelId)
        {
            var httpResponse = await discordHttpClient.GetAsync($"channels/{сhannelId}");
            Channel channel = JsonSerializer.Deserialize<Channel>(await httpResponse.Content.ReadAsStringAsync(), jsonOptions);
            return channel;
        }

        public async void ModifyChannelAsync(string channelId, string json)
        {
            await discordHttpClient.PatchAsync("/channels/{channelId}?access_token={token}", json);
        }

        public async void DeleteChannelAsync(string channelId)
        {
            await discordHttpClient.DeleteAsync($"/channels/{channelId}"/*, accessToken*/);
        }

        public async Task<LinkedList<Channel>> GetGuildChannelsAsync(string guildId)
        {
            var httpResponse = await discordHttpClient.GetAsync($"/guilds/{guildId}/channels");
            LinkedList<Channel> channels =
                JsonSerializer.Deserialize<LinkedList<Channel>>(await httpResponse.Content.ReadAsStringAsync(), jsonOptions);
            return channels;
        }

        public async Task<Guild> GetGuildAsync(string guildId)
        {
            var httpResponse = await discordHttpClient.GetAsync($"/guilds/{guildId}");
            Guild guild = JsonSerializer.Deserialize<Guild>(await httpResponse.Content.ReadAsStringAsync(), jsonOptions);
            guild.Channels = await GetGuildChannelsAsync(guildId);
            return guild;
        }

        public async void SendMessageAsync(string channelId, string json)
        {
            await discordHttpClient.PostAsync($"/channels/{channelId}/messages", json);
        }

        public async Task<Channel> CreateDMAsync(string recipientId)
        {
            var httpResponce = await discordHttpClient.PostAsync("/users/@me/channels", recipientId);
            Channel channel =
                JsonSerializer.Deserialize<Channel>(await httpResponce.Content.ReadAsStringAsync(), jsonOptions);
            return channel;
        }


        public async Task<LinkedList<Message>> GetChannelMessagesAsync(string channelId, ChannelMessagesOptions.MessagesOptions options, string messageId = null, int limit = 50)
        {
            var httpResponse =
                await discordHttpClient.GetAsync($"/channels/{channelId}/messages",
                    ChannelMessagesOptions.GetOptions(options, messageId, limit));
            LinkedList<Message> messages = JsonSerializer.Deserialize<LinkedList<Message>>(await httpResponse.Content.ReadAsStringAsync(), this.jsonOptions);
            return messages;
        }

        public async Task<LinkedList<GuildMember>> GetGuildMembersAsync(string guildId, int limit = 1, string after = "0")
        {
            // /guilds/{guild.id}/members
            var httpResponse =
               await discordHttpClient.GetAsync($"/guilds/{guildId}/members", $"limit={limit}");
            var content = await httpResponse.Content.ReadAsStringAsync();
            var res = JsonSerializer.Deserialize<LinkedList<GuildMember>>(content, jsonOptions);
            return res;
        }

        public async Task<Channel> CreateGuildChannelAsync(string guildId, string content)
        {
            var response = await discordHttpClient.PostAsync($"/guilds/{guildId}/channels", content);
            var channel = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Channel>(channel, jsonOptions);
        }
    }
}
