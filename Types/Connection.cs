using Discord_bot.Types.Enums;
using System.Collections.Generic;

namespace Discord_bot.Types
{
    public class Connection
    {
        private string id;
        private string name;
        private string type;
        private bool? revoked;
        private bool verified;
        private bool friend_sync;
        private bool show_activity;
        private VisibilityTypes visibility;
        private LinkedList<Integration> integrations;
    }
}