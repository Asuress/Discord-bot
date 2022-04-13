namespace Discord_bot.Types
{
    //dispatch
    class Opcode0
    {
        GatewayOpcodes op = GatewayOpcodes.DISCPATCH;
        string d;
        int? s;
        string t;
    }
    //heartbeat
    class HeartbeatOpcode
    {
        GatewayOpcodes op = GatewayOpcodes.HEARTBEAT;
        int? d;
        int? s;
        string t;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public int? D { get => d; set => d = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
    }
    // Identify
    class Opcode2
    {
        GatewayOpcodes op = GatewayOpcodes.IDENTIFY;
        int? s;
        string t;
        Identify d;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
        internal Identify D { get => d; set => d = value; }
    }
    // Prescence Update
    class Opcode3
    {
        GatewayOpcodes op = GatewayOpcodes.PRESCENE_UPDATE;
        int? s;
        string t;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
    }
    // Voice State Update
    class Opcode4
    {
        GatewayOpcodes op = GatewayOpcodes.VOICE_STATE_UPDATE;
        int? s;
        string t;
        UpdateVoiceState d;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
        internal UpdateVoiceState D { get => d; set => d = value; }
    }
    //resume gateway
    class Opcode6
    {
        GatewayOpcodes op = GatewayOpcodes.RESUME;
        int? s;
        string t;
        Resume d;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
        internal Resume D { get => d; set => d = value; }
    }
    //reconnect gateway
    class Opcode7
    {
        GatewayOpcodes op = GatewayOpcodes.RECONNECT;
        int? s;
        string t;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
    }
    // Request Guild Members
    class Opcode8
    {
        GatewayOpcodes op = GatewayOpcodes.REQUEST_GUILD_MEMBERS;
        int? s;
        string t;
        RequestGuildMembers d;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
        internal RequestGuildMembers D { get => d; set => d = value; }
    }
    //invalid session
    class GatewayInvalidSession
    {
        GatewayOpcodes op = GatewayOpcodes.INVALID_SESSION;
        int? s;
        string t;
        bool d;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
        public bool D { get => d; set => d = value; }
    }
    // Hello
    class GatewayHello
    {
        GatewayOpcodes op = GatewayOpcodes.HELLO;
        HelloEvent d;
        int? s;
        string t;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public HelloEvent D { get => d; set => d = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
    }
    // Heartbeat ACK
    class Opcode11
    {
        GatewayOpcodes op = GatewayOpcodes.HEARTBEAT_ACK;
        int? s;
        string t;

        public GatewayOpcodes Op { get => op; set => op = value; }
        public int? S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
    }
}