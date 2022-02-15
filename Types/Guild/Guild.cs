using System;
using System.Collections.Generic;
using Discord_bot.Types.Channel;
using Discord_bot.Types.Enums;

namespace Discord_bot.Types.Guild
{
    public class Guild
    {
        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Icon
        {
            get => icon;
            set => icon = value;
        }

        public string IconHash
        {
            get => icon_hash;
            set => icon_hash = value;
        }

        public string Splash
        {
            get => splash;
            set => splash = value;
        }

        public string DiscoverySplash
        {
            get => discovery_splash;
            set => discovery_splash = value;
        }

        public string OwnerId
        {
            get => owner_id;
            set => owner_id = value;
        }

        public string Permissions
        {
            get => permissions;
            set => permissions = value;
        }

        public string Region
        {
            get => region;
            set => region = value;
        }

        public string AfkChannelId
        {
            get => afk_channel_id;
            set => afk_channel_id = value;
        }

        public string WodgetChannelId
        {
            get => wodget_channel_id;
            set => wodget_channel_id = value;
        }

        public string ApplicationId
        {
            get => application_id;
            set => application_id = value;
        }

        public string SystemChannelId
        {
            get => system_channel_id;
            set => system_channel_id = value;
        }

        public string RulesChannelId
        {
            get => rules_channel_id;
            set => rules_channel_id = value;
        }

        public string VanityUrlCode
        {
            get => vanity_url_code;
            set => vanity_url_code = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string Banner
        {
            get => banner;
            set => banner = value;
        }

        public string PreferredLocale
        {
            get => preferred_locale;
            set => preferred_locale = value;
        }

        public string PublicUpdatesChannelId
        {
            get => public_updates_channel_id;
            set => public_updates_channel_id = value;
        }

        public int AfkTimeout
        {
            get => afk_timeout;
            set => afk_timeout = value;
        }

        public int NsfwLevel
        {
            get => nsfw_level;
            set => nsfw_level = value;
        }

        public int? MemberCount
        {
            get => member_count;
            set => member_count = value;
        }

        public int? MaxVideoChannelUsers
        {
            get => max_video_channel_users;
            set => max_video_channel_users = value;
        }

        public int? ApproximateMemberCount
        {
            get => approximate_member_count;
            set => approximate_member_count = value;
        }

        public int? ApproximatePresenceCount
        {
            get => approximate_presence_count;
            set => approximate_presence_count = value;
        }

        public int? PremiumSubscriptionCount
        {
            get => premium_subscription_count;
            set => premium_subscription_count = value;
        }

        public int? MaxPresences
        {
            get => max_presences;
            set => max_presences = value;
        }

        public int? MaxMembers
        {
            get => max_members;
            set => max_members = value;
        }

        public bool? Large
        {
            get => large;
            set => large = value;
        }

        public bool? Unavailable
        {
            get => unavailable;
            set => unavailable = value;
        }

        public bool? WidgetEnabled
        {
            get => widget_enabled;
            set => widget_enabled = value;
        }

        public bool? Owner
        {
            get => owner;
            set => owner = value;
        }

        public PremiumTier PremiumTier
        {
            get => premium_tier;
            set => premium_tier = value;
        }

        public VerificationLevel VerificationLevel
        {
            get => verification_level;
            set => verification_level = value;
        }

        public DefaultMessageNotificationsLevel DefaultMessageNotifications
        {
            get => default_message_notifications;
            set => default_message_notifications = value;
        }

        public ExplicitContentFilterLevel ExplicitContentFilter
        {
            get => explicit_content_filter;
            set => explicit_content_filter = value;
        }

        public SystemChannelFlags SystemChannelFlags
        {
            get => system_channel_flags;
            set => system_channel_flags = value;
        }

        public MFALevel MfaLevel
        {
            get => mfa_level;
            set => mfa_level = value;
        }

        public WelcomeScreen WelcomeScreen
        {
            get => welcome_screen;
            set => welcome_screen = value;
        }

        public LinkedList<GuildMember> Members
        {
            get => members;
            set => members = value;
        }

        public LinkedList<Channel.Channel> Channels
        {
            get => channels;
            set => channels = value;
        }

        public LinkedList<Thread> Threads
        {
            get => threads;
            set => threads = value;
        }

        public LinkedList<Presence> Presences
        {
            get => presences;
            set => presences = value;
        }

        public LinkedList<VoiceState> VoiceStates
        {
            get => voice_states;
            set => voice_states = value;
        }

        public LinkedList<Role> Roles
        {
            get => roles;
            set => roles = value;
        }

        public LinkedList<Emoji> Emojis
        {
            get => emojis;
            set => emojis = value;
        }

        public LinkedList<StageInstance> StageInstances
        {
            get => stage_instances;
            set => stage_instances = value;
        }

        public LinkedList<string> Features
        {
            get => features;
            set => features = value;
        }

        public DateTime JoinedAt
        {
            get => joined_at;
            set => joined_at = value;
        }

        private string id;
        private string name;
        private string icon;
        private string icon_hash;
        private string splash;
        private string discovery_splash;
        private string owner_id;
        private string permissions;
        private string region;
        private string afk_channel_id;
        private string wodget_channel_id;
        private string application_id;
        private string system_channel_id;
        private string rules_channel_id;
        private string vanity_url_code;
        private string description;
        private string banner;
        private string preferred_locale;
        private string public_updates_channel_id;
        private int afk_timeout;
        private int nsfw_level;
        private int? member_count;
        private int? max_video_channel_users;
        private int? approximate_member_count;
        private int? approximate_presence_count;
        private int? premium_subscription_count;
        private int? max_presences;
        private int? max_members;
        private bool? large;
        private bool? unavailable;
        private bool? widget_enabled;
        private bool? owner;
        private PremiumTier premium_tier;
        private VerificationLevel verification_level;
        private DefaultMessageNotificationsLevel default_message_notifications;
        private ExplicitContentFilterLevel explicit_content_filter;
        private SystemChannelFlags system_channel_flags;
        private MFALevel mfa_level;
        private WelcomeScreen welcome_screen;
        private LinkedList<GuildMember> members;
        private LinkedList<Channel.Channel> channels;
        private LinkedList<Thread> threads;
        private LinkedList<Presence> presences;
        private LinkedList<VoiceState> voice_states;
        private LinkedList<Role> roles;
        private LinkedList<Emoji> emojis;
        private LinkedList<StageInstance> stage_instances;
        private LinkedList<string> features;
        private DateTime joined_at;
    }
}
