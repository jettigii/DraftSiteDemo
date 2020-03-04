using AutoMapper;
using DraftSiteModels.ViewModels;
using DraftSiteService.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftSiteService.Services
{
    public class MultiPlayerDraftService : IMultiPlayerDraftService
    {
        private readonly IDraftComputerPlayerService _computerPlayerService;
        private readonly IMapper _mapper;

        public Action<int> PlayerSelectionBroadcast { get; set; }
        public Action UnctivePlayerBroadcast { get; set; }
        public AsyncCallback UnactivePlayerBroadcast { get; set; }

        private ConcurrentBag<DraftTeamUserViewModel> _picks;
        private ConcurrentQueue<DraftTeamPlayerUserViewModel> _previousPicks = new ConcurrentQueue<DraftTeamPlayerUserViewModel>();
        private int currentRound = 1;
        private int currentPick = 1;

        public MultiPlayerDraftService(IDraftComputerPlayerService computerPlayerService, IMapper mapper)
        {
            _computerPlayerService = computerPlayerService;
            _mapper = mapper;
        }


        public async Task StartDraft(MultiplayerDraftViewModel Draft)
        {
            _picks = new ConcurrentBag<DraftTeamUserViewModel>(Draft.DraftTeams);

            // More logic to follow
            await DraftTurnAsync();
        }

        public async Task SelectPlayer(int draftPlayerId)
        {
            currentPick++;
            //await Broadcast();
        }

        private async Task DraftTurnAsync()
        {
            if (_picks.Any())
            {
                var activeTeam = _picks.Single(pick => pick.PickNumber == currentPick && pick.PickRound == currentRound);
                //await ActivePlayerBroadcast().ConfigureAwait(false);
                //await UnactivePlayerBroadcast().ConfigureAwait(false);
            }
            else
            {
                await EndDraft();
            }
        }

        private async Task EndDraft()
        {
            throw new NotImplementedException();
        }

        private async Task SendActiveUserData()
        {
            throw new NotImplementedException();
        }

        private async Task DraftPick()
        {

        }

        private async Task StartTimerAsync()
        {

        }
    }
}
