using System.Collections.Generic;

namespace Discord_bot.Types.Gateway
{
    class UpdatePrescene
    {
        string status;
        int? since;
        bool afk;
        LinkedList<Activity> activities;
    }
}