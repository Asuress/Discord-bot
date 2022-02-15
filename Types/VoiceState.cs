using System;
using Discord_bot.Types.Guild;

namespace Discord_bot.Types
{
    public class VoiceState
    {
        private string guild_id; //может не быть в респонсе
        private string channel_id; //nullable
        private string user_id;
        private string session_id;
        private bool deaf;
        private bool mute;
        private bool self_deaf;
        private bool self_mute;
        private bool self_stream; //может не быть в респонсе
        private bool self_video;
        private bool suppress;
        private DateTime request_to_speak_timestamp;//nullable
        private GuildMember member; //может не быть в респонсе


    }
}