using System.Collections.Generic;

namespace Discord_bot.Types
{
    public class GatewayPayload
    {
        GatewayOpcodes op;
        string d;
        int? s;
        string t;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public string D { get => d; set => d = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
    }
}