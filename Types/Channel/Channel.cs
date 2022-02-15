using System;
using System.Collections.Generic;
using Discord_bot.Types.Enums;

namespace Discord_bot.Types.Channel
{
    public class Channel
    {
        public string Id
        {
            get => id;
            set => id = value;
        }

        public ChannelTypes Type
        {
            get => type;
            set => type = value;
        }

        public string GuildId
        {
            get => guild_id;
            set => guild_id = value;
        }

        public int? Position
        {
            get => position;
            set => position = value;
        }

        public LinkedList<Overwrite> PermissionOverwrites
        {
            get => permission_overwrites;
            set => permission_overwrites = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Topic
        {
            get => topic;
            set => topic = value;
        }

        public bool? Nsfw
        {
            get => nsfw;
            set => nsfw = value;
        }

        public string LastMessageId
        {
            get => last_message_id;
            set => last_message_id = value;
        }

        public int? Bitrate
        {
            get => bitrate;
            set => bitrate = value;
        }

        public int? UserLimit
        {
            get => user_limit;
            set => user_limit = value;
        }

        public int? RateLimitPerUser
        {
            get => rate_limit_per_user;
            set => rate_limit_per_user = value;
        }

        public LinkedList<User.User> Recipients
        {
            get => recipients;
            set => recipients = value;
        }

        public string Icon
        {
            get => icon;
            set => icon = value;
        }

        public string OwnerId
        {
            get => owner_id;
            set => owner_id = value;
        }

        public string ApplicationId
        {
            get => application_id;
            set => application_id = value;
        }

        public string ParentId
        {
            get => parent_id;
            set => parent_id = value;
        }

        public DateTime LastPinTimestamp
        {
            get => last_pin_timestamp;
            set => last_pin_timestamp = value;
        }

        public string RtcRegion
        {
            get => rtc_region;
            set => rtc_region = value;
        }

        public VideoQualityModes VideoQualityMode
        {
            get => video_quality_mode;
            set => video_quality_mode = value;
        }

        public int? MessageCount
        {
            get => message_count;
            set => message_count = value;
        }

        public int? MemberCount
        {
            get => member_count;
            set => member_count = value;
        }

        public ThreadMember Member
        {
            get => member;
            set => member = value;
        }

        public ThreadMetadata ThreadMetadata
        {
            get => thread_metadata;
            set => thread_metadata = value;
        }

        private string id;
        private ChannelTypes type;
        private string guild_id;
        private int? position;
        private LinkedList<Overwrite> permission_overwrites;
        private string name;
        private string topic;
        private bool? nsfw;
        private string last_message_id;
        private int? bitrate;
        private int? user_limit;
        private int? rate_limit_per_user;
        private LinkedList<User.User> recipients;
        private string icon;
        private string owner_id;
        private string application_id;
        private string parent_id;
        private DateTime last_pin_timestamp;
        private string rtc_region;
        private VideoQualityModes video_quality_mode;
        private int? message_count;
        private int? member_count;
        private ThreadMember member;
        private ThreadMetadata thread_metadata;

    }
}
