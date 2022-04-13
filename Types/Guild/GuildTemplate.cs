using System;
namespace Discord_bot.Types
{
    class GuildTemplate
    {
        public string Code
        {
            get => code;
            set => code = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string CreatorId
        {
            get => creator_id;
            set => creator_id = value;
        }

        public string SourceGuildId
        {
            get => source_guild_id;
            set => source_guild_id = value;
        }

        public int UsageCount
        {
            get => usage_count;
            set => usage_count = value;
        }

        public bool? IsDirty
        {
            get => is_dirty;
            set => is_dirty = value;
        }

        public User Creator
        {
            get => creator;
            set => creator = value;
        }

        public Guid SerializedSourceGuild
        {
            get => serialized_source_guild;
            set => serialized_source_guild = value;
        }

        public DateTime CreatedAt
        {
            get => created_at;
            set => created_at = value;
        }

        public DateTime UpdatedAt
        {
            get => updated_at;
            set => updated_at = value;
        }

        string code;
        string name;
        string description;
        string creator_id;
        string source_guild_id;
        int usage_count;
        bool? is_dirty;
        User creator;
        Guid serialized_source_guild;
        DateTime created_at;
        DateTime updated_at;
    }
}