using DraftSiteModels.HubModels;
using DraftSiteService.Interfaces;
using FiniTechSolutions.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public class PreDraftLobbyHub : Hub
    {
        private readonly IDraftService _draftService;
        private readonly IUserMappingService<HubUser> _userMappingService;

        public PreDraftLobbyHub(IDraftService draftService, IUserMappingService<HubUser> userMappingService)
        {
            _draftService = draftService;
            _userMappingService = userMappingService;
        }

        public override async Task OnConnectedAsync()
        {
            var user = new HubUser()
            {
                username = Context.User.Identity.Name
            };

            //string myCookieValue = ((IHttpContextFeature)Context.Features[typeof(IHttpContextFeature)]).HttpContext.Request.Cookies["Value"];

            _userMappingService.Add(Context.ConnectionId, user);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            _userMappingService.Remove(Context.ConnectionId);
            await base.OnDisconnectedAsync(exception);
        }



        //public override Task OnReconnected()
        //{
        //    string name = Context.User.Identity.Name;

        //    if (!_connections.GetConnections(name).Contains(Context.ConnectionId))
        //    {
        //        _connections.Add(name, Context.ConnectionId);
        //    }

        //    return base.OnReconnected();
        //}

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task EnterPreDraftLobby(int draftId, string password = null)
        {
            //var preDraftLobby = _draftService.GetPreDraftLobby(draftId, password);
            //Clients.
            //return preDraftLobby;
        }
    }
}
