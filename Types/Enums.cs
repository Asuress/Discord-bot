namespace Discord_bot.Types.Enums
{
    public enum DefaultMessageNotificationsLevel
    {
        ALL_MESSAGES,
        ONLY_MENTIONS
    }

    public enum ExplicitContentFilterLevel
    {
        DISABLED,
        MEMBERS_WITHOUT_ROLES,
        ALL_MEMBERS
    }
    enum GuildNSFWLevel
    {
        DEFAULT,
        EXPLICIT,
        SAFE,
        AGE_RESTRICTED
    }

    public enum MFALevel
    {
        NONE,
        ELEVATED
    }

    public enum PremiumTier
    {
        NONE,
        TIER_1,
        TIER_2,
        TIER_3
    }

    public enum SystemChannelFlags
    {
        SUPPRESS_JOIN_NOTIFICATIONS = 1 << 0,
        SUPPRESS_PREMIUM_SUBSCRIPTIONS = 1 << 1,
        SUPPRESS_GUILD_REMINDER_NOTIFICATIONS = 1 << 2
    }

    public enum VerificationLevel
    {
        NONE,
        LOW,
        MEDIUM,
        HIGH,
        VERY_HIGH
    }
    enum PrivacyLevel
    {
        PUBLIC = 1,
        GUILD_ONLY = 2
    }
    
    enum InviteTarget
    {
        STREAM = 1,
        EMBEDDED_APPLICATION
    }
    public enum UserFlags 
    {
        NONE = 0,
        DISCORD_EMPLOYEE = 1<<0,
        PARTNERED_SERVER_OWNER = 1<<1,
        HYPE_SQUAD_EVENTS = 1 <<2,
        BUG_HUNTER_LEVEL_1 = 1<<3,
        HOUSE_BRAVERY = 1 <<6,
        HOUSE_BRILLIANCE = 1<<7,
        HOUSE_BALANCE = 1 <<8,
        EARLY_SUPPORTER = 1 <<9,
        TEAM_USER = 1<<10,
        BUG_HUNTER_LEVEL_2 = 1<<14,
        VERIFIED_BOT = 1<<16,
        EARLY_VERIFIED_BOT_DEVELOPER = 1<<17,
        DISCORD_CERTIFIED_MODERATOR = 1<<18
        
    }

    public enum PremiumTypes
    {
        NONE,
        NITRO_CLASSIC,
        NITRO
    }
    enum  VisibilityTypes
    {
        NONE,
        EVERYONE
    }

    public enum ChannelTypes
    {
        GUILD_TEXT = 0,
        DM = 1,
        GUILD_VOICE = 2,
        GROUP_DM = 3,
        GUILD_CATEGORY = 4,
        GUILD_NEWS = 5,
        GUILD_STORE = 6,
        GUILD_NEWS_THREAD = 10,
        GUILD_PUBLIC_THREAD = 11,
        GUILD_PRIVATE_THREAD = 12,
        GUILD_STAGE_VOICE = 13
        
    }

    public enum VideoQualityModes
    {
        AUTO = 1,
        FULL = 2
    }

    enum MessageTypes
    {
        DEFAULT = 0,
        RECIPIENT_ADD = 1,
        RECIPIENT_REMOVE = 2,
        CALL = 3,
        CHANNEL_NAME_CHANGE = 4,
        CHANNEL_ICON_CHANGE = 5,
        CHANNEL_PINNED_MESSAGE = 6,
        GUILD_MEMBER_JOIN = 7,
        USER_PREMIUM_GUILD_SUBSCRIPTION = 8,
        USER_PREMIUM_GUILD_SUBSCRIPTION_TIER_1 = 9,
        USER_PREMIUM_GUILD_SUBSCRIPTION_TIER_2 = 10,
        USER_PREMIUM_GUILD_SUBSCRIPTION_TIER_3 = 11,
        CHANNEL_FOLLOW_ADD = 12,
        GUILD_DISCOVERY_DISQUALIFIED = 14,
        GUILD_DISCOVERY_REQUALIFIED = 15,
        GUILD_DISCOVERY_GRACE_PERIOD_INITIAL_WARNING = 16,
        GUILD_DISCOVERY_GRACE_PERIOD_FINAL_WARNING = 17,
        THREAD_CREATED = 18,
        REPLY = 19,
        APPLICATION_COMMAND = 20,
        THREAD_STARTER_MESSAGE = 21,
        GUILD_INVITE_REMINDER = 22
        
    }

    public enum MessageActivityTypes
    {
        JOIN = 1,
        SPECTATE = 2,
        LISTEN = 3,
        JOIN_REQUEST = 5
    }

    public enum MessageFlags
    {
        CROSSPOSTED = 1<<0,
        IS_CROSSPOST = 1<<1,
        SUPPRESS_EMBEDS = 1<<2,
        SOURCE_MESSAGE_DELETED= 1<<3,
        URGENT = 1<<4,
        HAS_THREAD = 1<<5,
        EPHEMERAL = 1<<6,
        LOADING = 1<<7
    }

    public enum MessageStickerFormatTypes

    {
        PNG = 1,
        APNG = 2,
        LOTTIE = 3
    }

    enum InteractionType
    {
        Ping = 1,
        ApplicationCommand = 2,
        MessageComponent = 3
    }

    public enum ComponentTypes
    {
        ActionRow	= 1,
        Button = 2
    }


}
