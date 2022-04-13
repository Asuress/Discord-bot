namespace Discord_bot.Types
{
    enum WebhookType
    {
        INCOMING = 1,
        CHANNEL_FOLLOWER = 2,
        APPLICATION = 3,
    }
    class Webhook
    {
        // static Webhook CreateWebhook(WebhookType type){

        // }
        string id;
        WebhookType type;
        string guildId;
        string channelId;
        User user;
        string name;
        string avatar;
        string token;
        string applicationId;
        Guild sourceGuild;
        Channel sourceChannel;
        string url;
    }
}
