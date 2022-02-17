using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Discord_bot.Types.Gateway;
using Discord_bot.Types.Message;

namespace Discord_bot.Types.Bot
{
    public class Bot
    {
        JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
        const string clinet_id = "846042488586371073";
        const string token = "ODQ2MDQyNDg4NTg2MzcxMDcz.YKpwdw.GoD0W2XsJF9tw-0ewiViGAb5Kgk";
        private HttpClient client = new HttpClient();
        private string main_url = "https://discord.com/api/v9";
        private string[] accessToken = { $"access_token={token}" };


        public Bot()
        {
            client.BaseAddress = new Uri("https://discord.com/api/v9"); //работает только если отправлять с помощью HttpreqestMessage
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bot", $"{token}");
        }


        public async void Connect() //временно
        {
            WebRequest request = WebRequest.Create("https://discord.com/api/gateway/bot");
            request.Method = "GET";
            WebHeaderCollection headers = new WebHeaderCollection();
            headers.Add(HttpRequestHeader.Authorization, $"Bot {token}");
            request.Headers = headers;
            WebResponse response = await request.GetResponseAsync();
            Console.WriteLine(((HttpWebResponse)response).ToString());
            string responseFromServer;
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);
            }

            response.Close();
            ClientWebSocket client = new ClientWebSocket();
            var cancellationToken = new CancellationToken();
            await client.ConnectAsync(new Uri("wss://gateway.discord.gg/?v=9&encoding=json"), cancellationToken);
            var buff = new ArraySegment<byte>(new byte[4096]);
            var receive = await client.ReceiveAsync(buff, cancellationToken);
            string s = string.Empty;
            foreach (var b in buff)
            {
                if (b != 0)
                    s += (char)b;
            }

            var payload = JsonSerializer.Deserialize<GatewayPayload>(s);
            string identify = @"{
                                ""op"": 2,
                                ""d"": 
                                    {
                                    ""token"": ""ODQ2MDQyNDg4NTg2MzcxMDcz.YKpwdw.GoD0W2XsJF9tw-0ewiViGAb5Kgk"",
                                    ""intents"": 513,
                                    ""properties"": 
                                        {
                                        ""$os"": ""windows"",
                                        ""$browser"": ""Discord_bot"",
                                        ""$device"": ""Discord_bot""
                                        }
                                    }
                                }";
            byte[] ba = Encoding.UTF8.GetBytes(identify);
            await client.SendAsync(new ArraySegment<byte>(ba), WebSocketMessageType.Text, true, cancellationToken);

            receive = await client.ReceiveAsync(buff, cancellationToken);
            s = string.Empty;
            s = Encoding.UTF8.GetString(buff.Array);
        }

        public async Task<User> GetMe()
        {
            var httpResponse = await GetAsync("/users/@me", accessToken);
            User bot = JsonSerializer.Deserialize<User>(await httpResponse.Content.ReadAsStringAsync(), options);
            return bot;
        }

        public async Task<User> GetUser(string userId)
        {
            var httpResponse = await GetAsync($"/users/{userId}", accessToken);
            User user = JsonSerializer.Deserialize<User>(await httpResponse.Content.ReadAsStringAsync(), options);
            return user;
        }

        public async Task<LinkedList<Guild.Guild>> GetMyGuilds()
        {
            var httpResponse = await GetAsync("/users/@me/guilds", accessToken);
            LinkedList<Guild.Guild> guilds =
                JsonSerializer.Deserialize<LinkedList<Guild.Guild>>(await httpResponse.Content.ReadAsStringAsync(), options);
            foreach (var guild in guilds)
            {
                guild.Channels = await GetGuildChannels(guild.Id);
            }

            return guilds;
        }

        public async void ModifyMe() //dont work
        {

        }

        public async void LeaveGuild(string guildId)
        {
            DeleteAsync($"/users/@me/guilds/{guildId}", accessToken);
        }


        public async Task<Channel.Channel> GetChannel(string сhannelId)
        {
            var httpResponse = await GetAsync($"channels/{сhannelId}", accessToken);
            Channel.Channel channel = JsonSerializer.Deserialize<Channel.Channel>(await httpResponse.Content.ReadAsStringAsync(), options);
            return channel;
        }

        public async void ModifyChannel(string channelId, string json)
        {
            client.PatchAsync(new Uri($"{main_url}/channels/{channelId}?access_token={token}"), new StringContent(json));
        }

        public async void DeleteChannel(string channelId)
        {
            DeleteAsync($"/channels/{channelId}", accessToken);
        }

        public async Task<LinkedList<Channel.Channel>> GetGuildChannels(string guildId)
        {
            var httpResponse = await GetAsync($"/guilds/{guildId}/channels", accessToken);
            LinkedList<Channel.Channel> channels =
                JsonSerializer.Deserialize<LinkedList<Channel.Channel>>(await httpResponse.Content.ReadAsStringAsync(), options);
            return channels;
        }

        public async Task<Guild.Guild> GetGuild(string guildId)
        {
            var httpResponse = await GetAsync($"/guilds/{guildId}", accessToken);
            Guild.Guild guild = JsonSerializer.Deserialize<Guild.Guild>(await httpResponse.Content.ReadAsStringAsync(), options);
            guild.Channels = await GetGuildChannels(guildId);
            return guild;
        }

        public async void SendMessageAsync(string channelId, string json)
        {
            await PostAsync($"/channels/{channelId}/messages", json, accessToken);
        }

        public async Task<Channel.Channel> CreateDMAsync(string recipientId)
        {
            var httpResponce = await PostAsync("/users/@me/channels", recipientId, accessToken);
            Channel.Channel channel =
                JsonSerializer.Deserialize<Channel.Channel>(await httpResponce.Content.ReadAsStringAsync(), options);
            return channel;
        }


        public async Task<LinkedList<Message.Message>> GetChannelMessages(string channelId, ChannelMessagesOptions.MessagesOptions options, string messageId = null, int limit = 50)
        {
            var httpResponse =
                await GetAsync($"/channels/{channelId}/messages",
                    ChannelMessagesOptions.GetOptions(options, messageId, limit));
            LinkedList<Message.Message> messages = JsonSerializer.Deserialize<LinkedList<Message.Message>>(await httpResponse.Content.ReadAsStringAsync()
                                                                                                            , this.options);
            return messages;
        }

        public async Task<Channel.Channel> CreateGuildChannel(string guildId, string content)
        {
            var response = await PostAsync($"/guilds/{guildId}/channels", content, new string[] { $"access_token={token}" });
            var channel = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Channel.Channel>(channel, options);
        }

        private async Task<HttpResponseMessage> PostAsync(string endpoint, string content, string[] parameters)
        {
            var strContent = new StringContent(content);
            strContent.Headers.ContentType.MediaType = "application/json";
            return await client.PostAsync(BuildUrl(endpoint, parameters), strContent);
        }

        private async Task<HttpResponseMessage> GetAsync(string endpoint, string[] parameters)
        {
            return await client.GetAsync(BuildUrl(endpoint, parameters));
        }

        private async Task<HttpResponseMessage> DeleteAsync(string endpoint, string[] parameters)
        {
            return await client.DeleteAsync(BuildUrl(endpoint, parameters));
        }

        private Uri BuildUrl(string endpoint, string[] parameters)
        {
            UriBuilder builder = new UriBuilder($"{main_url}{endpoint}");
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
            Uri uri = builder.Uri;
            return uri;
        }

    }
}
