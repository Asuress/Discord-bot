namespace Discord_bot.Types.Gateway
{
    class GatewayPayload
    {
        int op;
        dynamic d;
        int? s;
        string t;

        public int Op { get => op; set => op = value; }
        public dynamic D { get => d; set => d = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
    }
}