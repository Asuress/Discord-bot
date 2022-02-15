using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Discord_bot.Types.User;
using Discord_bot.Types.Bot;
using Discord_bot.Types.Channel;
using Discord_bot.Types.Guild;
using Discord_bot.Dependencies;
using Discord_bot.Types.Channel.Args;

namespace Discord_bot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            options.PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance;
            Bot DiscrodBot = new Bot();
            DiscrodBot.Connect();
            User i = await DiscrodBot.GetMe();
            LinkedList<Guild> MyGuild = await DiscrodBot.GetMyGuilds();
            Channel anyChannel = MyGuild.First.Value.Channels.First.Next.Value;
            string json = "{\"content\": \"Hello, World!\",\"tts\": false,\"embed\": {\"title\": \"Hello, Embed!\",\"description\": \"This is an embedded message.\"}}";
            DiscrodBot.SendMessageAsync(anyChannel.Id, json);
            while (true)
            {
            }
        }
    }
}