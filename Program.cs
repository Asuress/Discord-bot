using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Discord_bot.Types;
using Discord_bot.Dependencies;
using System;

namespace Discord_bot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            options.PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance;

            DiscordClient client = new DiscordClient("ODQ2MDQyNDg4NTg2MzcxMDcz.YKpwdw.qKJwHDb_c5TFQobBupMfP9d6ViI");

            await client.AuthorizeAsync();

            await client.ConnectAsync(new List<GatewayIntents>()
            {
                GatewayIntents.GUILDS,
                GatewayIntents.GUILD_MEMBERS,
                GatewayIntents.GUILD_BANS,
                GatewayIntents.GUILD_MESSAGES
            });

            User me = await client.GetMeAsync();
            LinkedList<Guild> MyGuilds = await client.GetMyGuildsAsync();

            client.MessageReceived += (o, args) => { Console.WriteLine(args.Data); };

            while (true)
            {

            }
        }
    }
}