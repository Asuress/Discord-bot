using System;
using System.Collections.Generic;

namespace Discord_bot.Types.Embed
{
    public class Embed
    {
        private string title;
        private string type;
        private string description;
        private string url;
        private DateTime timestamp;
        private int? color;
        private EmbedFooter footer;
        private EmbedImage image;
        private EmbedThumbnail thumbnail;
        private EmbedVideo video;
        private EmbedProvider provider;
        private EmbedAuthor author;
        private LinkedList<EmbedField> fields;

    }
}