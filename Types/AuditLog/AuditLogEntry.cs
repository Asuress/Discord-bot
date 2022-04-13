using System.Collections.Generic;
using Discord_bot.Types.Enums;

namespace Discord_bot.Types
{
    class AuditLogEntry
    {
        string targetId;
        LinkedList<AuditLogChange> changes;
        string userId;
        string id;
        AuditLogEvents actionType;
        OptionalAuditEntryInfo options;
        string reason;

        public string TargetId { get => targetId; set => targetId = value; }
        public string UserId { get => userId; set => userId = value; }
        public string Id { get => id; set => id = value; }
        public OptionalAuditEntryInfo Options { get => options; set => options = value; }
        public string Reason { get => reason; set => reason = value; }
        internal LinkedList<AuditLogChange> Changes { get => changes; set => changes = value; }
        internal AuditLogEvents ActionType { get => actionType; set => actionType = value; }
    }
}
