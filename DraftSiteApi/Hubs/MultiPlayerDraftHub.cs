using DraftSiteModels.HubModels;
using DraftSiteModels.InputModels;
using DraftSiteService.Interfaces;
using DraftSiteService.Services;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public class MultiPlayerDraftHub : DraftHub
    {
        private ConcurrentDictionary<int, MultiPlayerDraftService> _drafts;

        public MultiPlayerDraftHub(IDraftService draftService, IUserService userService) : base(draftService, userService)
        {
            _drafts = new ConcurrentDictionary<int, MultiPlayerDraftService>();
        }

        public async Task EnterDraftLobby(int draftId)
        {
            //MultiPlayerDraftService multiPlayerDraftService = new MultiPlayerDraftService();
            
            //await _draftService.StartDraftAsync(draftId);


        }









        public async Task SelectPlayer(PlayerChoiceInputModel playerSelection)
        {
            var user = GetHubUserByConnectionId();
            var draft = _drafts.SingleOrDefault(d => d.Key == user.DraftId).Value;
            //await _draftService.SelectPlayer(user.UserId, user.DraftId, draft.ActiveTeamId, playerSelection);





            //draft.StartTimer();
            //var teams = _draftService.SelectTeam(user.UserId, teamSelection);
            //await Clients.Group(user.DraftId.ToString()).SendAsync("receiveTeamsUpdate", teams);
        }



        public async Task UpdateTimer(string time)
        {
            await Clients.All.SendAsync("updateTimer", "draft-update", time);
        }

        protected async Task StartDraft(int draftId)
        {
            


        }
    }
}
