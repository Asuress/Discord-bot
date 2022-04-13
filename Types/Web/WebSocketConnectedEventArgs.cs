namespace Discord_bot.Types
{
    public class WebSocketConnectedEventArgs : GatewayPayload
    {
        string data;

        public string Data { get => data; set => data = value; }
    }
}