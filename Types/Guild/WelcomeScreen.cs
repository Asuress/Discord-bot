using System.Collections.Generic;

namespace Discord_bot.Types
{
    public class WelcomeScreen
    {
        string description;
        LinkedList<WelcomeScreenChannel> welcome_channels;
        public string Description { get => description; set => description = value; }
        LinkedList<WelcomeScreenChannel> WelcomeChannels { get => welcome_channels; set => welcome_channels = value; }
    }
}
