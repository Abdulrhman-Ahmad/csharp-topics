using Microsoft.AspNetCore.SignalR;

namespace Server.Hubs
{
    public class ChatHub : Hub
    {
        #region Override Methods
        // When User Connect
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceiveMessage", Context.ConnectionId, "Has Joined!");
            await base.OnConnectedAsync();
        }

        // When User Disconnect
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("ReceiveMessage", Context.ConnectionId, "Has Left!");
            await base.OnDisconnectedAsync(exception);
        }
        #endregion

        #region Methods
        // When Sending a message 
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        } 
        #endregion
    }
}
