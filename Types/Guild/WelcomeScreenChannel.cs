namespace Discord_bot.Types.Guild
{
    class WelcomeScreenChannel
    {
        string channel_id;
        string description;
        string emoji_id;
        string emoji_name;

        public string ChannelId { get => channel_id; set => channel_id = value; }
        public string Description { get => description; set => description = value; }
        public string EmojiId { get => emoji_id; set => emoji_id = value; }
        public string EmojiName { get => emoji_name; set => emoji_name = value; }
    }
}