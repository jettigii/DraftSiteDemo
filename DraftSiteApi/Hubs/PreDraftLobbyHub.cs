using DraftSiteModels.HubModels;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public class PreDraftLobbyHub : DraftHub
    {
        private readonly IDraftService _draftService;
        private readonly IUserService _userService;
        private readonly ConcurrentBag<HubUser> _connections;

        public PreDraftLobbyHub(IDraftService draftService, IUserService userService)
        {
            _draftService = draftService;
            _userService = userService;
            _connections = new ConcurrentBag<HubUser>();
        }

        public async Task<PreDraftViewModel> EnterPreDraftLobby(PreDraftInputModel draftLobbyRequest)
        {
            try
            {
                var dbUser = await _userService.GetUserByUsername(Context.User.Identity.Name);

                var user = new HubUser()
                {
                    ConnectionId = Context.ConnectionId,
                    DraftId = draftLobbyRequest.DraftId,
                    Username = Context.User.Identity.Name,
                    UserId = dbUser.Id
                };

                var preDraftLobbyData = await _draftService.GetPreDraftLobby(draftLobbyRequest.DraftId, user.Username, draftLobbyRequest.Password);
                _connections.Add(user);

                await Groups.AddToGroupAsync(Context.ConnectionId, draftLobbyRequest.DraftId.ToString());
                await Clients.Group(draftLobbyRequest.DraftId.ToString()).SendAsync("receiveChatMessage", user.Username + " has joined the lobby.");

                return preDraftLobbyData;
            }
            catch (Exception ex)
            {
                await Clients.Client(Context.ConnectionId).SendAsync("receiveChatMessage", "Lobby join error.");
            }
            return null;
        }

        // select team - create DraftTeamUser - send team update
        public async Task SelectTeam(TeamChoiceInputModel teamSelection)
        {
            var user = _connections.SingleOrDefault(connection => connection.ConnectionId == Context.ConnectionId);
            var teams = _draftService.SelectTeam(user.UserId, teamSelection);
            await Clients.Group(user.DraftId.ToString()).SendAsync("receiveTeamUpdate", teams);
        }

        public async Task DeselectTeam(TeamChoiceInputModel teamSelection)
        {
            var user = _connections.SingleOrDefault(connection => connection.ConnectionId == Context.ConnectionId);
            var teams = _draftService.DeselectTeam(user.UserId, teamSelection);
            await Clients.Group(user.DraftId.ToString()).SendAsync("receiveTeamUpdate", teams);
        }

        public async Task UpdateSettings(DraftInputModel draft)
        {
            var user = _connections.SingleOrDefault(connection => connection.ConnectionId == Context.ConnectionId);
            var newSettings = await _draftService.UpdateDraftSettings(user.DraftId, draft);
            await Clients.Group(newSettings.Id.ToString()).SendAsync("receiveSettings", newSettings);
        }

        public void SetComputerPlayer(int teamId)
        {

        }
    }
}
