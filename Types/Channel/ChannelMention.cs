using Discord_bot.Types.Enums;

namespace Discord_bot.Types
{
    public class ChannelMention
    {
        public string Id
        {
            get => id;
            set => id = value;
        }

        public string GuildId
        {
            get => guild_id;
            set => guild_id = value;
        }

        public ChannelTypes Type
        {
            get => type;
            set => type = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        private string id;
        private string guild_id;
        private ChannelTypes type;
        private string name;
        
    }
}