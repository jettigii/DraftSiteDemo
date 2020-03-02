using DraftSiteModels.HubModels;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public class DraftLobbyHub : DraftHub
    {
        public DraftLobbyHub(IDraftService draftService, IUserService userService) : base(draftService, userService) { }

        public async Task<DraftLobbyViewModel> GetUserLobby(DraftSiteToken model)
        {
            try
            {
                var authenticatedUser = await _userService.Authenticate(model.Token);

                var user = new HubUser()
                {
                    DraftId = 0,
                    Username = authenticatedUser.Username,
                    UserId = authenticatedUser.Id
                };

                await EnterDraftAsync(user);

                var drafts = await _draftService.GetUserLobby();

                if (drafts == null)
                {
                    drafts = new List<DraftViewModel>();
                }

                var lookups = await _draftService.GetDraftLookupsAsync();

                var userLobby = new DraftLobbyViewModel()
                {
                    Drafts =  drafts,
                    Lookups = lookups,
                    User = new DraftSiteUserViewModel()
                    {
                        Id = authenticatedUser.Id,
                        Username = user.Username
                    }
                };
                
                return userLobby;
            }
            catch
            {
                return new DraftLobbyViewModel()
                {
                    Drafts = new List<DraftViewModel>(),
                    User = new DraftSiteUserViewModel()
                };
            }
        }

        public async Task CreateDraft(DraftInputModel draft)
        {
            try
            {
                var user = GetHubUserByConnectionId();
                draft.UserId = user.UserId;
                await _draftService.CreateDraftAsync(draft);
                await UpdateDraftLobby();
            }
            catch (Exception ex)
            {
            }
        }

        private async Task UpdateDraftLobby()
        {
            var userLobby = await _draftService.GetUserLobby();
            await Clients.All.SendAsync("receiveDraftLobbyUpdate", userLobby);
        }
    }
}
