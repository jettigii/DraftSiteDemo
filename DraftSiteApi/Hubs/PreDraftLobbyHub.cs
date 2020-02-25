using DraftSiteModels.HubModels;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public class PreDraftLobbyHub : DraftHub
    {
        public PreDraftLobbyHub(IDraftService draftService, IUserService userService) : base(draftService, userService) { }

        public async Task<PreDraftViewModel> EnterPreDraftLobby(PreDraftInputModel draftLobbyRequest)
        {
            try
            {
                var user = await EnterDraft(draftLobbyRequest.DraftId);

                var preDraftLobbyData = await _draftService.GetPreDraftLobby(draftLobbyRequest.DraftId, user.Username, draftLobbyRequest.Password);
                _connections.Add(user);

                await Groups.AddToGroupAsync(Context.ConnectionId, draftLobbyRequest.DraftId.ToString());

                var alert = new ChatMessageViewModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    Username = "System",
                    Message = user.Username + " has joined the lobby."
                };

                await Clients.Group(draftLobbyRequest.DraftId.ToString()).SendAsync("receiveMessage", alert);

                return preDraftLobbyData;
            }
            catch (Exception ex)
            {
                await Clients.Client(Context.ConnectionId).SendAsync("receiveMessage", "Lobby join error.");
            }
            return null;
        }

        public async Task SelectTeam(TeamChoiceInputModel teamSelection)
        {
            var user = _connections.SingleOrDefault(connection => connection.ConnectionId == Context.ConnectionId);
            var teams = _draftService.SelectTeam(user.UserId, user.DraftId, teamSelection);
            await Clients.Group(user.DraftId.ToString()).SendAsync("receiveTeamsUpdate", teams);
        }

        public async Task DeselectTeam(TeamChoiceInputModel teamSelection)
        {
            var user = _connections.SingleOrDefault(connection => connection.ConnectionId == Context.ConnectionId);
            var teams = _draftService.DeselectTeam(user.UserId, teamSelection);
            await Clients.Group(user.DraftId.ToString()).SendAsync("receiveTeamsUpdate", teams);
        }

        public async Task UpdateSettings(DraftInputModel draft)
        {
            var user = _connections.SingleOrDefault(connection => connection.ConnectionId == Context.ConnectionId);
            var newSettings = await _draftService.UpdateDraftSettings(user.DraftId, draft);
            await Clients.Group(newSettings.Id.ToString()).SendAsync("receiveSettingsUpdate", newSettings);
        }

        public void SetComputerPlayer(int teamId)
        {

        }
    }
}
