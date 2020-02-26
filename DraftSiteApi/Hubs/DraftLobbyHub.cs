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
                await EnterDraft(0);

                var drafts = await _draftService.GetUserLobby();

                if (drafts == null)
                {
                    drafts = new List<DraftViewModel>();
                }

                var userLobby = new DraftLobbyViewModel()
                {
                    Drafts =  drafts,
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
                    {
                        Username = user.Username
                    }
                };
            }
        }

        public async Task CreateDraft(DraftInputModel draft)
        {
            try
            {
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
