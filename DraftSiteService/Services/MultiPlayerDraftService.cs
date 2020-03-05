//using AutoMapper;
//using DraftSiteModels.ViewModels;
//using DraftSiteRepository.Interfaces;
//using DraftSiteService.Interfaces;
//using Microsoft.Extensions.Caching.Distributed;
//using StackExchange.Redis;
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.Json;
//using System.Threading.Tasks;

//namespace DraftSiteService.Services
//{
//    public class MultiPlayerDraftService : IMultiPlayerDraftService
//    {
//        private readonly IDraftComputerPlayerService _computerPlayerService;
//        private readonly IDraftRepository _draftRepository;
//        private readonly ConnectionMultiplexer _redis;
//        private readonly IMapper _mapper;



//        public delegate void UpdateDraftLobby(List<DraftViewModel> drafts);

//        public MultiPlayerDraftService(IDraftComputerPlayerService computerPlayerService, IDraftRepository draftRepository, IMapper mapper)
//        {
//            _computerPlayerService = computerPlayerService;
//            _draftRepository = draftRepository;
//            _redis = ConnectionMultiplexer.Connect("localhost");
//            _mapper = mapper;
//        }

       










//        public async Task StartDraft(MultiplayerDraftViewModel Draft)
//        {
//            _picks = new ConcurrentBag<DraftTeamUserViewModel>(Draft.DraftTeams);

//            // More logic to follow
//            await DraftTurnAsync();
//        }

//        public async Task SelectPlayer(int draftPlayerId)
//        {
//            currentPick++;
//            //await Broadcast();
//        }

//        private async Task DraftTurnAsync()
//        {
//            if (_picks.Any())
//            {
//                var activeTeam = _picks.Single(pick => pick.PickNumber == currentPick && pick.PickRound == currentRound);
//                //await ActivePlayerBroadcast().ConfigureAwait(false);
//                //await UnactivePlayerBroadcast().ConfigureAwait(false);
//            }
//            else
//            {
//                await EndDraft();
//            }
//        }

//        private async Task EndDraft()
//        {
//            throw new NotImplementedException();
//        }

//        private async Task SendActiveUserData()
//        {
//            throw new NotImplementedException();
//        }

//        private async Task DraftPick()
//        {

//        }

//        private async Task StartTimerAsync()
//        {

//        }


//    }
//}
