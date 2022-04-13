using System;

namespace Discord_bot.Types
{
    public class WebSocketMessageReceivedEventArgs : EventArgs
    {
        string message;

        public WebSocketMessageReceivedEventArgs(string message)
        {
            this.Message = message;
        }

        public WebSocketMessageReceivedEventArgs()
        {
        }

        public string Message { get => message; set => message = value; }

    }
}