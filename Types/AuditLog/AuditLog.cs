using System.Collections.Generic;

namespace Discord_bot.Types
{
    class AuditLog
    {
        public LinkedList<Webhook> Webhooks
        {
            get => webhooks;
            set => webhooks = value;
        }

        public LinkedList<User> Users
        {
            get => users;
            set => users = value;
        }

        public LinkedList<AuditLogEntry> AuditLogEntries
        {
            get => auditLogEntries;
            set => auditLogEntries = value;
        }
        public LinkedList<Integration> Integrations { get => integrations; set => integrations = value; }
        public LinkedList<GuildSchelduledEvents> GuildScheduledEvents { get => guildScheduledEvents; set => guildScheduledEvents = value; }

        LinkedList<AuditLogEntry> auditLogEntries;
        LinkedList<GuildSchelduledEvents> guildScheduledEvents;
        LinkedList<Integration> integrations;
        LinkedList<Channel> threads;
        LinkedList<User> users;
        LinkedList<Webhook> webhooks;
    }
}
