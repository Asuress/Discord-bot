using Discord_bot.Types.Enums;

namespace Discord_bot.Types
{
    public class MessageSticker
    {
        public string Id
        {
            get => id;
            set => id = value;
        }

        public string PackId
        {
            get => pack_id;
            set => pack_id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string Tags
        {
            get => tags;
            set => tags = value;
        }

        public string Asset
        {
            get => asset;
            set => asset = value;
        }

        public MessageStickerFormatTypes FormatType
        {
            get => format_type;
            set => format_type = value;
        }

        private string id;
        private string pack_id;
        private string name;
        private string description;
        private string tags;
        private string asset;
        private MessageStickerFormatTypes format_type;
    }
}