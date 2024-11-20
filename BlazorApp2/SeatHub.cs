using Microsoft.AspNetCore.SignalR;

namespace BlazorApp2
{
    public class SeatHub : Hub
    {
        public async Task NotifySeatChange(string user, string seatId, bool isSelected)
        {
            await Clients.All.SendAsync("ReceiveSeatChange", user, seatId, isSelected);
        }
    }
}
