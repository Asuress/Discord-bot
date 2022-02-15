using Discord_bot.Types.Enums;

namespace Discord_bot.Types.Channel.Args
{
    public static class ModifyChannelArgsBuilder
    {
        public static ModifyChannelArgs CreateAnyChannelArgs(Channel channel)
        {
            return new ModifyChannelArgs(channel);
        }
        public static ModifyTextChannelArgs CreateTextChannelArgs(Channel channel)
        {
            return new ModifyTextChannelArgs(channel);
        }
        public static ModifyVoiceChannelArgs CreateVoiceChannelArgs(Channel channel)
        {
            return new ModifyVoiceChannelArgs(channel);
        }
        public static ModifyNewsChannelArgs CreateNewsChannelArgs(Channel channel)
        {
            return new ModifyNewsChannelArgs(channel);
        }
    }
}