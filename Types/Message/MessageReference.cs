namespace Discord_bot.Types
{
    public class MessageReference
    {
        private string message_id;
        private string channel_id;
        private string guild_id;
        private bool? fail_if_not_exists;
    }
}