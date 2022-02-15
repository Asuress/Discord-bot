using System.Collections.Generic;

namespace Discord_bot.Types.Guild
{   //пересмотреть
    public class Emoji
    {
        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public LinkedList<string> Roles
        {
            get => roles;
            set => roles = value;
        }

        public User.User User
        {
            get => user;
            set => user = value;
        }

        public bool? RequireColons
        {
            get => require_colons;
            set => require_colons = value;
        }

        public bool? Manages
        {
            get => manages;
            set => manages = value;
        }

        public bool? Animated
        {
            get => animated;
            set => animated = value;
        }

        public bool? Available
        {
            get => available;
            set => available = value;
        }


        private string id;
        private string name;
        private LinkedList<string> roles;
        private User.User user;
        private bool? require_colons;
        private bool? manages;
        private bool? animated;
        private bool? available;


    }
}