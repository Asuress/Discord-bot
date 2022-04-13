using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Discord_bot.Types
{

    class Identify
    {
        string token;
        IdentifyConnectionProperties properties;
        bool compress;
        int large_threshold;
        int[] shard;
        UpdatePresence prescene;
        int intents;

        public string Token { get => token; set => token = value; }
        public int Intents { get => intents; set => intents = value; }
        public IdentifyConnectionProperties Properties { get => properties; set => properties = value; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Compress { get => compress; set => compress = value; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Large_threshold { get => large_threshold; set => large_threshold = value; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int[] Shard { get => shard; set => shard = value; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public UpdatePresence Prescene { get => prescene; set => prescene = value; }
    }
}