using System.Collections.Generic;

namespace Discord_bot.Types
{
    class ReadyEvent
    {
        int v;
        User user;
        List<Guild> guilds;
        string sessionId;
        int[] shard;
        Application application;

        public int V { get => v; set => v = value; }
        public User User { get => user; set => user = value; }
        public List<Guild> Guilds { get => guilds; set => guilds = value; }
        public string SessionId { get => sessionId; set => sessionId = value; }
        public int[] Shard { get => shard; set => shard = value; }
        public Application Application { get => application; set => application = value; }
    }
}