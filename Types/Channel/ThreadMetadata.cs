using System;

namespace Discord_bot.Types
{
    public class ThreadMetadata
    {
        public bool Archived
        {
            get => archived;
            set => archived = value;
        }

        public string ArchiverId
        {
            get => archiver_id;
            set => archiver_id = value;
        }

        public int AutoArchiveDuration
        {
            get => auto_archive_duration;
            set => auto_archive_duration = value;
        }

        public DateTime ArchiveTimestamp
        {
            get => archive_timestamp;
            set => archive_timestamp = value;
        }

        public bool? Locked
        {
            get => locked;
            set => locked = value;
        }

        private bool archived;
        private string archiver_id;
        private int auto_archive_duration;
        private DateTime archive_timestamp;
        private bool? locked;
    }
}
