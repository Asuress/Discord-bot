using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discord_bot.Types
{
    enum StatusType
    {
        online,
        dnd,
        idle,
        invisible,
        offline,
    }
    class UpdatePresence
    {
        int since;
        List<Activity> activities;
        StatusType status;
        bool afk;

        public int Since { get => since; set => since = value; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public StatusType Status { get => status; set => status = value; }
        public bool Afk { get => afk; set => afk = value; }
        internal List<Activity> Activities { get => activities; set => activities = value; }
    }
}