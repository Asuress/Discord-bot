using System;
using System.Collections.Generic;

namespace Discord_bot.Types.Guild
{
    public class GuildMember
    {
        string nick;
        string permissions;
        bool deaf;
        bool mute;
        bool? pending;
        LinkedList<string> roles;
        User.User user;
        DateTime joined_at;
        DateTime? premium_since;
    }
}  