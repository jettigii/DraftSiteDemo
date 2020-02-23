using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public class DraftHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await SendMessage(Context.User.Identity.Name, message);
        }

        public async Task SendMessage(string author, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", author, message);
        }
    }
}
