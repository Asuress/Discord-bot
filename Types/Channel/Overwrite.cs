namespace Discord_bot.Types
{
    public class Overwrite
    {
        public string Id
        {
            get => id;
            set => id = value;
        }

        public int Type
        {
            get => type;
            set => type = value;
        }

        public string Allow
        {
            get => allow;
            set => allow = value;
        }

        public string Deny
        {
            get => deny;
            set => deny = value;
        }

        private string id;
        private int type;
        private string allow;
        private string deny;
        
    }
    
}