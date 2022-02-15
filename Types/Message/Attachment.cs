namespace Discord_bot.Types.Message
{
    public class Attachment
    {
        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Filename
        {
            get => filename;
            set => filename = value;
        }

        public string ContentType
        {
            get => content_type;
            set => content_type = value;
        }

        public int Size
        {
            get => size;
            set => size = value;
        }

        public string Url
        {
            get => url;
            set => url = value;
        }

        public string ProxyUrl
        {
            get => proxy_url;
            set => proxy_url = value;
        }

        public int? Height
        {
            get => height;
            set => height = value;
        }

        public int? Width
        {
            get => width;
            set => width = value;
        }

        private string id;
        private string filename;
        private string content_type;
        private int size;
        private string url;
        private string proxy_url;
        private int? height;
        private int? width;
    }
}