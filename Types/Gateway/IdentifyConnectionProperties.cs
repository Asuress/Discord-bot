namespace Discord_bot.Types
{
    class IdentifyConnectionProperties
    {
        string os;
        string browser;
        string device;

        public string Os { get => os; set => os = value; }
        public string Browser { get => browser; set => browser = value; }
        public string Device { get => device; set => device = value; }
    }
}