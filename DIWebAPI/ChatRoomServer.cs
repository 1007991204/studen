using Microsoft.AspNetCore.SignalR;

namespace DIWebAPI
{
    public class ChatRoomServer : Hub
    {
        public async void send(string message)
        {
            var connectId = Context.ConnectionId;
            await Clients.All.SendAsync("Receivemessage", message);
        }
    }
}
