using DraftSiteModels.HubModels;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public class PreDraftLobbyHub : Hub
    {
        private readonly IDraftService _draftService;
        private readonly ConcurrentBag<HubUser> _connections;

        public PreDraftLobbyHub(IDraftService draftService)
        {
            _draftService = draftService;
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task<PreDraftViewModel> EnterPreDraftLobby(PreDraftInputModel draftLobbyRequest)
        {
            try
            {
                var user = new HubUser()
                {
                    ConnectionId = Context.ConnectionId,
                    DraftId = draftLobbyRequest.DraftId,
                    Username = Context.User.Identity.Name,
                };

                await Groups.AddToGroupAsync(Context.ConnectionId, draftLobbyRequest.DraftId.ToString());
                await Clients.Group(draftLobbyRequest.DraftId.ToString()).SendAsync("receiveChatMessage", user.Username + " has joined the lobby.");

                var preDraftLobbyData = await _draftService.GetPreDraftLobby(draftLobbyRequest.DraftId, user.Username, draftLobbyRequest.Password);
                _connections.Add(user);
                return preDraftLobbyData;
            }
            catch (Exception ex)
            {
                await Clients.Client(Context.ConnectionId).SendAsync("receiveChatMessage", "Lobby join error.");
            }
            return null;
        }

        // select team - create DraftTeamUser - send team update
        public void SelectTeam(TeamChoiceInputModel teamSelection)
        {
            _draftService.SelectTeam(Context.User.Identity.Name, teamSelection);
        }

        public void DeselectTeam(int draftId, int teamId)
        {
            _draftService.DeselectTeam(Context.User.Identity.Name, draftId, teamId);
        }

        private void SendSettingsUpdate(DraftViewModel draft)
        {

        }

        private async Task SendTeamsUpdate(int draftId, List<DraftTeamSummaryViewModel> draftTeams)
        {
            await Clients.Group(draftId.ToString()).SendAsync("receiveTeamUpdate", draftTeams);
        }

        public async Task UpdateSettings(DraftViewModel draft)
        {
            await Clients.Group(draft.Id.ToString()).SendAsync("receiveSettings", draft);
        }

        public void SetComputerPlayer(int teamId)
        {

        }
    }
}
