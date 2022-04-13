namespace Discord_bot.Types
{
    class SessionStartLimit
    {
        int total;
        int remainig;
        int resetAfter;
        int maxConcurrency;

        public int Total { get => total; set => total = value; }
        public int Remainig { get => remainig; set => remainig = value; }
        public int ResetAfter { get => resetAfter; set => resetAfter = value; }
        public int MaxConcurrency { get => maxConcurrency; set => maxConcurrency = value; }
    }
}