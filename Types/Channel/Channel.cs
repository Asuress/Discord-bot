using System;
using System.Collections.Generic;
using Discord_bot.Types.Enums;

namespace Discord_bot.Types
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
            get => guildId;
            set => guildId = value;
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
            get => lastMessageId;
            set => lastMessageId = value;
        }

        public int? Bitrate
        {
            get => bitrate;
            set => bitrate = value;
        }

        public int? UserLimit
        {
            get => userLimit;
            set => userLimit = value;
        }

        public int? RateLimitPerUser
        {
            get => rateLimitPerUser;
            set => rateLimitPerUser = value;
        }

        public LinkedList<User> Recipients
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
            get => ownerId;
            set => ownerId = value;
        }

        public string ApplicationId
        {
            get => applicationId;
            set => applicationId = value;
        }

        public string ParentId
        {
            get => parentId;
            set => parentId = value;
        }

        public DateTime LastPinTimestamp
        {
            get => lastPinTimestamp;
            set => lastPinTimestamp = value;
        }

        public string RtcRegion
        {
            get => rtcRegion;
            set => rtcRegion = value;
        }

        public VideoQualityModes VideoQualityMode
        {
            get => videoQualityMode;
            set => videoQualityMode = value;
        }

        public int? MessageCount
        {
            get => messageCount;
            set => messageCount = value;
        }

        public int? MemberCount
        {
            get => memberCount;
            set => memberCount = value;
        }

        public ThreadMember Member
        {
            get => member;
            set => member = value;
        }

        public ThreadMetadata ThreadMetadata
        {
            get => threadMetadata;
            set => threadMetadata = value;
        }

        private string id;
        private ChannelTypes type;
        private string guildId;
        private int? position;
        private LinkedList<Overwrite> permission_overwrites;
        private string name;
        private string topic;
        private bool? nsfw;
        private string lastMessageId;
        private int? bitrate;
        private int? userLimit;
        private int? rateLimitPerUser;
        private LinkedList<User> recipients;
        private string icon;
        private string ownerId;
        private string applicationId;
        private string parentId;
        private DateTime lastPinTimestamp;
        private string rtcRegion;
        private VideoQualityModes videoQualityMode;
        private int? messageCount;
        private int? memberCount;
        private ThreadMetadata threadMetadata;
        private ThreadMember member;
        private int defaultAutoArchiveDuration;
        private string permissions;
    }
}
