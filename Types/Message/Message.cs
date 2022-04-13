using System;
using System.Collections.Generic;
using System.Threading.Channels;
using Discord_bot.Types;
using Discord_bot.Types.Enums;

namespace Discord_bot.Types
{
    public class Message
    {
        public string Id
        {
            get => id;
            set => id = value;
        }

        public string ChannelId
        {
            get => channel_id;
            set => channel_id = value;
        }

        public string GuildId
        {
            get => guild_id;
            set => guild_id = value;
        }

        public User Author
        {
            get => author;
            set => author = value;
        }

        public GuildMember Member
        {
            get => member;
            set => member = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public DateTime Timestamp
        {
            get => timestamp;
            set => timestamp = value;
        }

        public DateTime EditedTimestamp
        {
            get => edited_timestamp;
            set => edited_timestamp = value;
        }

        public bool Tts
        {
            get => tts;
            set => tts = value;
        }

        public bool MentionEveryone
        {
            get => mention_everyone;
            set => mention_everyone = value;
        }

        public dynamic Mentions
        {
            get => mentions;
            set => mentions = value;
        }

        public LinkedList<Role> MentionRoles
        {
            get => mention_roles;
            set => mention_roles = value;
        }

        public LinkedList<ChannelMention> MentionChannels
        {
            get => mention_channels;
            set => mention_channels = value;
        }

        public LinkedList<Attachment> Attachments
        {
            get => attachments;
            set => attachments = value;
        }

        public LinkedList<Embed> Embeds
        {
            get => embeds;
            set => embeds = value;
        }

        public LinkedList<Reaction> Reactions
        {
            get => reactions;
            set => reactions = value;
        }

        public dynamic Nonce
        {
            get => nonce;
            set => nonce = value;
        }

        public bool Pinned
        {
            get => pinned;
            set => pinned = value;
        }

        public string WebhookId
        {
            get => webhook_id;
            set => webhook_id = value;
        }

        public int? Type //MessageActivity
        {
            get => type;
            set => type = value;
        }

        public Application Application
        {
            get => application;
            set => application = value;
        }

        public string ApplicationId
        {
            get => application_id;
            set => application_id = value;
        }

        public MessageReference MessageReference
        {
            get => message_reference;
            set => message_reference = value;
        }

        public MessageFlags Flags
        {
            get => flags;
            set => flags = value;
        }

        public LinkedList<MessageSticker> Stickers
        {
            get => stickers;
            set => stickers = value;
        }

        public Message ReferencedMessage
        {
            get => referenced_message;
            set => referenced_message = value;
        }

        public MessageInteraction Interaction
        {
            get => interaction;
            set => interaction = value;
        }

        public Channel Thread
        {
            get => thread;
            set => thread = value;
        }

        public LinkedList<MessageComponent> Components //MessageComponent
        {
            get => components;
            set => components = value;
        }

        public MessageActivity Activity
        {
            get => activity;
            set => activity = value;
        }

        private string id;
        private string channel_id;
        private string guild_id;
        private User author;
        private GuildMember member;
        private string content;
        private DateTime timestamp;
        private DateTime edited_timestamp;
        private bool tts;
        private bool mention_everyone;
        private dynamic mentions; //хуйня какая-то я ебал
        private LinkedList<Role> mention_roles;
        private LinkedList<ChannelMention> mention_channels;
        private LinkedList<Attachment> attachments;
        private LinkedList<Embed> embeds;
        private LinkedList<Reaction> reactions;
        private dynamic nonce; // строка или инт лул
        private bool pinned;
        private string webhook_id;
        private int? type; //MessageActivity
        private MessageActivity activity;
        private Application application;
        private string application_id;
        private MessageReference message_reference;
        private MessageFlags flags;
        private LinkedList<MessageSticker> stickers;
        private Message referenced_message;
        private MessageInteraction interaction;
        private Channel thread;
        private LinkedList<MessageComponent> components; //MessageComponent 
    }
}