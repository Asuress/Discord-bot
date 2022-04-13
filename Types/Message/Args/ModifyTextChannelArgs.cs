using Discord_bot.Types.Enums;

namespace Discord_bot.Types
{
    public class ModifyTextChannelArgs : ModifyNewsChannelArgs
    {
        public ModifyTextChannelArgs() { }
        public ModifyTextChannelArgs(Channel channel) : base(channel)
        {
            RateLimitPerUser = channel.RateLimitPerUser;
        }
        int? rate_limit_per_user;

        public int? RateLimitPerUser { get => rate_limit_per_user; set => rate_limit_per_user = value; }
    }
}