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
        protected static readonly ConcurrentDictionary<int, List<HubUser>> _users = new ConcurrentDictionary<int, List<HubUser>>();
        

        public DraftHub(IDraftService draftService, IUserService userService)
        {
            _draftService = draftService;
            _userService = userService;
        }

        public async Task SendMessage(string message)
        {
            var user = GetHubUserByConnectionId();

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
            user.connectionId = Context.ConnectionId;
            var isConnected = _users.Keys.Any(key => key == user.UserId);

            if (isConnected)
            {
                _users.SingleOrDefault(u => u.Key == user.UserId).Value.Add(user);
            }
            else
            {
                _users.TryAdd(user.UserId, new List<HubUser>()
                {
                    user
                });
            }

            await Groups.AddToGroupAsync(Context.ConnectionId, user.DraftId.ToString());
            return user;
        }

        protected async Task<List<int>> CheckForActiveDrafts(int userId)
        {
            return new List<int>();
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            var hubUser = GetHubUserByConnectionId();
            _users.Single(u => u.Key == hubUser.UserId).Value.Remove(hubUser);
            return base.OnDisconnectedAsync(exception);
        }

        protected KeyValuePair<int, List<HubUser>> GetUser(int userId)
        {
            return _users.SingleOrDefault(connection => connection.Key == userId);
        }
        
        protected HubUser GetHubUserByConnectionId()
        {
            var users = _users.SelectMany(u => u.Value).ToList();
            var user = users.SingleOrDefault(u => u.connectionId == Context.ConnectionId);
            return user;
        }
    }
}
