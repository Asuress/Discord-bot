using Discord_bot.Types.Enums;


namespace Discord_bot.Types
{
    public class StageInstance
    {
        string id;
        string guild_id;
        string channel_id;
        string topic;
        bool discoverable_disabled;
        PrivacyLevel privacy_level;
    }
}
