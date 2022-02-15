using Discord_bot.Types.Enums;

namespace Discord_bot.Types.Message
{
    public class MessageActivity
    {
        public MessageActivityTypes? Type
        {
            get => type;
            set => type = value;
        }

        public string PartyId
        {
            get => party_id;
            set => party_id = value;
        }

        private MessageActivityTypes? type;
        private string party_id; //party_id from a Rich Presence event
    }
}