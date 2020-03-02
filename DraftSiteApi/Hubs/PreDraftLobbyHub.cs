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
                var draftId = Convert.ToInt32(draftLobbyRequest.DraftId);

                var user = GetUser(draftLobbyRequest.UserId);

                var draftUser = new HubUser()
                {
                    DraftId = draftId,
                    UserId = user.Key,
                    Username = user.Value.First().Username
                };

                await EnterDraftAsync(draftUser);

                var preDraftLobbyData = await _draftService.GetPreDraftLobby(draftId, draftUser.Username, draftLobbyRequest.Password);
                preDraftLobbyData.Lookups = await _draftService.GetDraftLookupsAsync();

                await Groups.AddToGroupAsync(Context.ConnectionId, draftLobbyRequest.DraftId.ToString());

                var alert = new ChatMessageViewModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    Username = "System",
                    Message = draftUser.Username + " has joined the lobby."
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
            var user = GetHubUserByConnectionId();
            var teams = await _draftService.SelectTeam(user.UserId, user.DraftId, teamSelection);
            await Clients.Group(user.DraftId.ToString()).SendAsync("receiveTeamsUpdate", teams);
        }
        
        public async Task UpdateSettings(DraftInputModel draft)
        {
            var user = GetHubUserByConnectionId();
            var newSettings = await _draftService.UpdateDraftSettings(user.DraftId, draft);
            await Clients.Group(newSettings.Id.ToString()).SendAsync("receiveSettingsUpdate", newSettings);
        }

        public void SetComputerPlayer(int teamId)
        {

        }
    }
}
