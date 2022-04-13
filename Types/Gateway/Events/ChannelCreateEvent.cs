namespace Discord_bot.Types
{
    class ChannelCreateEvent
    {
        GatewayOpcodes op;
        Channel d;
        int s;
        string t;

        public Channel D { get => d; set => d = value; }
        public int S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
        internal GatewayOpcodes Op { get => op; set => op = value; }
    }
}