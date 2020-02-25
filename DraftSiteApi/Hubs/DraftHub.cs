using DraftSiteModels.HubModels;
using DraftSiteModels.ViewModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
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
        protected static readonly ConcurrentBag<HubUser> _connections = new ConcurrentBag<HubUser>();

        public DraftHub(IDraftService draftService, IUserService userService)
        {
            _draftService = draftService;
            _userService = userService;
        }

        public async Task SendMessage(string message)
        {
            var user = _connections.SingleOrDefault(connection => connection.ConnectionId == Context.ConnectionId);

            var newMessage = new ChatMessageViewModel()
            {
                Id = Guid.NewGuid().ToString(),
                Username = user.Username,
                Message = message
            };

            await Clients.Group(user.DraftId.ToString()).SendAsync("receiveMessage", newMessage);
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
