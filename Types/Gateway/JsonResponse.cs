namespace Discord_bot.Types
{
    public class JsonResponse
    {
        string url;
        int shards;
        SessionStartLimit sessionStartLimit;

        public string Url { get => url; set => url = value; }
        public int Shards { get => shards; set => shards = value; }
        internal SessionStartLimit SessionStartLimit { get => sessionStartLimit; set => sessionStartLimit = value; }
    }
}