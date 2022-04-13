namespace Discord_bot.Types
{
    class UpdateVoiceState
    {
        string guildId;
        string channelId;
        bool selfMute;
        bool selfDeaf;

        public string GuildId { get => guildId; set => guildId = value; }
        public string ChannelId { get => channelId; set => channelId = value; }
        public bool SelfMute { get => selfMute; set => selfMute = value; }
        public bool SelfDeaf { get => selfDeaf; set => selfDeaf = value; }
    }
}