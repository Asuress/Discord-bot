using System;

namespace Discord_bot.Types.Channel
{
    public class ThreadMember
    {
        public string Id
        {
            get => id;
            set => id = value;
        }

        public string UserId
        {
            get => user_id;
            set => user_id = value;
        }

        public DateTime JoinTimestamp
        {
            get => join_timestamp;
            set => join_timestamp = value;
        }

        public int? Flags
        {
            get => flags;
            set => flags = value;
        }

        private string id;
        private string user_id;
        private DateTime join_timestamp;
        private int? flags;//any user-thread settings, currently only used for notifications
    }
}