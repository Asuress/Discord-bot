namespace Discord_bot.Types
{
    public class Application
    {
        public string Id { get; }
        public string Name { get; }
        public string Icon { get; }
        public string Description { get; }
        public string[] RpcOrigins { get; }
        public bool BotPublic { get; }
        public bool BotRequireCodeGrant { get; }
        public string TermsOfServiceUrl { get; }
        public string PrivacyPolicyUrl { get; }
        public User Owner { get; }
        public string Summary { get; }
        public string VerifyKey { get; }
        public Team Team { get; }
        public string GuildId { get; }
        public string PrimarySkuId { get; }
        public string Slug { get; }
        public string CoverImage { get; }
        public int Flags { get; }
    }
}