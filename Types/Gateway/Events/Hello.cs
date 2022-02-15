namespace Discord_bot.Types.Gateway.Events
{
    class Hello
    {
        int heartbeat_interval;

        public int Heartbeat_interval { get => heartbeat_interval; set => heartbeat_interval = value; }
    }
}