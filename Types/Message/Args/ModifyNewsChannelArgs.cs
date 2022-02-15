using System.Text.Json.Serialization;
using Discord_bot.Types.Enums;

namespace Discord_bot.Types.Channel.Args
{
    public class ModifyNewsChannelArgs : ModifyChannelArgs
    {
        public ModifyNewsChannelArgs(){}
        public ModifyNewsChannelArgs(Channel channel) : base(channel)
        {
            Type = channel.Type;
            Topic = channel.Topic;
            Nsfw = channel.Nsfw;
            ParentId = channel.ParentId;
        }
        ChannelTypes type;
        string topic;
        bool? nsfw;
        string parent_id;
        public ChannelTypes Type { get => type; set => type = value; }
        public string Topic { get => topic; set => topic = value; }
        public bool? Nsfw { get => nsfw; set => nsfw = value; }
        public string ParentId { get => parent_id; set => parent_id = value; }
    }
}