namespace Discord_bot.Types
{
    class MessageCreateEvent
    {
        GatewayOpcodes op;
        Message d;
        int s;
        string t;

        public Message D { get => d; set => d = value; }
        public int S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
        internal GatewayOpcodes Op { get => op; set => op = value; }
    }
}