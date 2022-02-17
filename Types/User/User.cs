using Discord_bot.Types.Enums;
namespace Discord_bot.Types
{

    public class User
    {
        private string id;
        private string username;
        private string discriminator;
        private string avatar;
        private bool? bot; //может не быть в респонсе
        private bool? system; //может не быть в респонсе
        private bool? mfa_enabled; //может не быть в респонсе
        private string locale; //может не быть в респонсе
        private bool? verified; //может не быть в респонсе
        private string email; //может не быть в респонсе
        private UserFlags flags; //может не быть в респонсе
        private PremiumTypes premium_type; //может не быть в респонсе
        private UserFlags public_flags; //может не быть в респонсе
        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Discriminator { get => discriminator; set => discriminator = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public bool? Bot { get => bot; set => bot = value; }
        public bool? System { get => system; set => system = value; }
        public bool? MfaEnabled { get => mfa_enabled; set => mfa_enabled = value; }
        public string Locale { get => locale; set => locale = value; }
        public bool? Verified { get => verified; set => verified = value; }
        public string Email { get => email; set => email = value; }
        public UserFlags Flags { get => flags; set => flags = value; }
        public PremiumTypes PremiumType { get => premium_type; set => premium_type = value; }
        public UserFlags PublicFlags { get => public_flags; set => public_flags = value; }
    }
}