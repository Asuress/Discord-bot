using System;

namespace Discord_bot.Types
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public MessageReceivedEventArgs(string data)
        {
            this.Data = data;
        }
        User sender;
        Message message;
        private string data;

        public User Sender { get => sender; set => sender = value; }
        public Message Message { get => message; set => message = value; }
        public string Data { get => data; set => data = value; }
    }
}