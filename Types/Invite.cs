using System;
using Discord_bot.Types;
using Discord_bot.Types.Enums;
using Discord_bot.Types.Channel;
using Discord_bot.Types.Guild;
using Discord_bot.Types.User;

namespace Discord_bot.Types
{
    class Invite
    {
        string code;
        int? approximate_presence_count;
        int? approximate_member_count;
        InviteTarget target_type;
        DateTime expires_at;
        Guild.Guild guild;
        Channel.Channel channel;
        User.User inviter;
        User.User target_user;
        Application target_application;
    }
}