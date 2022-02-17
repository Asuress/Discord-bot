namespace Discord_bot.Types
{
    public class TeamMember
    {
        public int MembershipState { get; }
        public string[] Permissions { get; }
        public string TeamId { get; }
        public User User { get; }
    }
}