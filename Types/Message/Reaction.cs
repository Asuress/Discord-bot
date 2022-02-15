using Discord_bot.Types.Guild;

namespace Discord_bot.Types.Message
{
    public class Reaction
    {
        public int Count
        {
            get => count;
            set => count = value;
        }

        public bool Me
        {
            get => me;
            set => me = value;
        }

        public Emoji Emoji
        {
            get => emoji;
            set => emoji = value;
        }

        private int count;
        private bool me;
        private Emoji emoji;
    }
}