using System.Collections.Generic;
using Discord_bot.Types.Enums;

namespace Discord_bot.Types.AuditLog
{
    class AuditLogEntry
    {
        string target_id;
        string user_id;
        string id;
        string reason;
        AuditLogEvent action_type;
        //OptionalAuditEntryInfo options            ???
        LinkedList<AuditLogChange> changes;
    }
}
