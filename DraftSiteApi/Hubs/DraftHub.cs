using DraftSiteModels.HubModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public class DraftHub : Hub
    {
        protected readonly IDraftService _draftService;
        protected readonly IUserService _userService;        
        protected readonly ConcurrentBag<HubUser> _connections;

        public DraftHub(IDraftService draftService, IUserService userService)
        {
            _draftService = draftService;
            _userService = userService;            
            _connections = new ConcurrentBag<HubUser>();
        }

        public async Task SendUserMessage(string message)
        {
            await SendMessage(Context.User.Identity.Name, message);
        }

        public async Task SendMessage(string author, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", author, message);
        }

        protected async Task<HubUser> EnterDraft(int draftId)
        {
            var dbUser = await _userService.GetUserByUsername(Context.User.Identity.Name);

            var user = new HubUser()
            {
                ConnectionId = Context.ConnectionId,
                DraftId = draftId,
                Username = Context.User.Identity.Name,
                UserId = dbUser.Id
            };

            return user;
        }

        protected async Task<List<int>> CheckForActiveDrafts(int userId)
        {
            return new List<int>();
        }
    }
}
