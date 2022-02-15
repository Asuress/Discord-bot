using System.Collections.Generic;
// using Discord_bot.Types;

namespace Discord_bot.Types.AuditLog
{
    class AuditLog
    {
        public LinkedList<Webhook> Webhooks
        {
            get => webhooks;
            set => webhooks = value;
        }

        public LinkedList<User.User> Users
        {
            get => users;
            set => users = value;
        }

        public LinkedList<AuditLogEntry> AuditLogEntries
        {
            get => audit_log_entries;
            set => audit_log_entries = value;
        }

        public LinkedList<Integration> Integrations
        {
            get => integrations;
            set => integrations = value;
        }

        LinkedList<Webhook> webhooks;
        LinkedList<User.User> users;
        LinkedList<AuditLogEntry> audit_log_entries;
        LinkedList<Integration> integrations;
    }
}
