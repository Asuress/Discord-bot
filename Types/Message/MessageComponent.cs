using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Discord_bot.Types.Enums;

namespace Discord_bot.Types
{
    public class MessageComponent
    {
        public ComponentTypes Type
        {
            get => type;
            set => type = value;
        }

        public int? Style
        {
            get => style;
            set => style = value;
        }

        public string Label
        {
            get => label;
            set => label = value;
        }

        public Emoji Emoji
        {
            get => emoji;
            set => emoji = value;
        }

        public string CustomId
        {
            get => custom_id;
            set => custom_id = value;
        }

        public string Url
        {
            get => url;
            set => url = value;
        }

        public bool? Disabled
        {
            get => disabled;
            set => disabled = value;
        }

        public LinkedList<MessageComponent> Components
        {
            get => components;
            set => components = value;
        }

        private ComponentTypes type;
        private int? style; //	one of button styles
        private string label;
        private Emoji emoji;
        private string custom_id;
        private string url;
        private bool? disabled;
        private LinkedList<MessageComponent> components;
    }
}