using System;
using System.Collections.Generic;

namespace Discord_bot.Types
{
    public class GuildMember
    {
        string nick;
        string permissions;
        bool deaf;
        bool mute;
        bool? pending;
        LinkedList<string> roles;
        User user;
        DateTime joined_at;
        DateTime? premium_since;

        public string Nick { get => nick; set => nick = value; }
        public string Permissions { get => permissions; set => permissions = value; }
        public bool Deaf { get => deaf; set => deaf = value; }
        public bool Mute { get => mute; set => mute = value; }
        public bool? Pending { get => pending; set => pending = value; }
        public LinkedList<string> Roles { get => roles; set => roles = value; }
        public User User { get => user; set => user = value; }
        public DateTime Joined_at { get => joined_at; set => joined_at = value; }
        public DateTime? Premium_since { get => premium_since; set => premium_since = value; }
    }
}