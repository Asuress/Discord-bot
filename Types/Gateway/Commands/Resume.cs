namespace Discord_bot.Types
{
    class Resume
    {
        string token;
        string sessionId;
        int seq;

        public string Token { get => token; set => token = value; }
        public string SessionId { get => sessionId; set => sessionId = value; }
        public int Seq { get => seq; set => seq = value; }
    }
}