using System.Collections.Generic;

namespace Discord_bot.Types.Gateway.Commands
{
    class Identify
    {
        string token;
        object properties;
        bool? compress;
        int? large_threshold;
        Dictionary<int, int> shard;
        UpdatePrescene prescene;
        int intents;
    }
}