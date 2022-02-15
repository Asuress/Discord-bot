using Discord_bot.Types.Enums;

namespace Discord_bot.Types.Message
{
    public class MessageInteraction
    {
        private string id;
        private InteractionType type;
        private string name;
        private User.User user;
    }
}