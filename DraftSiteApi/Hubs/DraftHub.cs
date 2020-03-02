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
        protected static readonly ConcurrentDictionary<string, HubUser> _connections = new ConcurrentDictionary<string, HubUser>();
        protected HubUser user => _connections.First(connection => Context.ConnectionId == Context.ConnectionId).Value;

        public DraftHub(IDraftService draftService, IUserService userService)
        {
            _draftService = draftService;
            _userService = userService;
        }

        public async Task SendMessage(string message)
        {
            var newMessage = new ChatMessageViewModel()
            {
                Id = Guid.NewGuid().ToString(),
                Username = user.Username,
                Message = message
            };

            await Clients.Group(user.DraftId.ToString()).SendAsync("receiveMessage", newMessage);
        }

        protected async Task<HubUser> EnterDraftAsync(HubUser user)
        {           
            await Groups.AddToGroupAsync(Context.ConnectionId, user.DraftId.ToString());
            _connections.TryAdd(Context.ConnectionId, user);
            return user;
        }

        protected async Task<List<int>> CheckForActiveDrafts(int userId)
        {
            return new List<int>();
        }

        public override Task OnConnectedAsync()
        {
            _connections.TryRemove(Context.ConnectionId, out var result);

            return base.OnConnectedAsync();
        }
    }
}
