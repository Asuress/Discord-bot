using System.Collections.Generic;

namespace Discord_bot.Types
{
    class Activity
    {
        string name;
        string url;
        string application_id;
        string details;
        string state;
        int type;
        int created_at;
        int? flags;
        bool? instance;
        Timestamps timestamps;
        Emoji emoji;
        // Party party;
        // Assets assets;
        // Secrets secrets;
        // LinkedList<Button> buttons;
    }
}