using Discord_bot.Types.Enums;

namespace Discord_bot.Types
{
    public class ModifyVoiceChannelArgs : ModifyChannelArgs
    {
        public ModifyVoiceChannelArgs() { }
        public ModifyVoiceChannelArgs(Channel channel) : base(channel)
        {
            Bitrate = channel.Bitrate;
            UserLimit = channel.UserLimit;
            VideoQualityMode = channel.VideoQualityMode;
            ParentId = channel.ParentId;
            RtcRegion = channel.RtcRegion;
        }
        int? bitrate;
        int? user_limit;
        string parent_id;
        string rtc_region;
        VideoQualityModes? video_quality_mode;

        public int? Bitrate { get => bitrate; set => bitrate = value; }
        public int? UserLimit { get => user_limit; set => user_limit = value; }
        public string ParentId { get => parent_id; set => parent_id = value; }
        public string RtcRegion { get => rtc_region; set => rtc_region = value; }
        public VideoQualityModes? VideoQualityMode { get => video_quality_mode; set => video_quality_mode = value; }
    }
}