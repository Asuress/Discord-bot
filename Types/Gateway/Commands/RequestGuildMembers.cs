using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discord_bot.Types
{
    class RequestGuildMembers
    {
        string guildId;
        string query;
        int limit;
        bool presences;
        List<string> userIds;
        string nonce;

        public string GuildId { get => guildId; set => guildId = value; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Query { get => query; set => query = value; }
        public int Limit { get => limit; set => limit = value; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Presences { get => presences; set => presences = value; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<string> UserIds { get => userIds; set => userIds = value; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Nonce { get => nonce; set => nonce = value; }
    }
}