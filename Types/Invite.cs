using System;
using Discord_bot.Types;
using Discord_bot.Types.Enums;

namespace Discord_bot.Types
{
    class Invite
    {
        string code;
        int? approximate_presence_count;
        int? approximate_member_count;
        InviteTarget target_type;
        DateTime expires_at;
        Guild guild;
        Channel channel;
        User inviter;
        User target_user;
        Application target_application;
    }
}