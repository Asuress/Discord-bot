namespace Discord_bot.Types
{
    class AuditLogChange
    {
        dynamic newValue;
        dynamic oldValue;
        string key;

        public dynamic NewValue { get => newValue; set => newValue = value; }
        public dynamic OldValue { get => oldValue; set => oldValue = value; }
        public string Key { get => key; set => key = value; }
    }
}