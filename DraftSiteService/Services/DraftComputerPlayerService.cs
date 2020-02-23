using DraftSiteModels.ViewModels;
using DraftSiteRepository.Interfaces;
using DraftSiteService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftSiteService.Services
{
    public class DraftComputerPlayerService
    {
        private readonly IDraftRepository _draftRepository;

        public DraftComputerPlayerService(IDraftRepository draftRepository)
        {
            _draftRepository = draftRepository;
        }

        public async Task<DraftPlayerViewModel> GetComputerChoice(int draftId, int teamId)
        {
            var players = await _draftRepository.GetDraftPlayersAsync(draftId);

            // Order by rank
            var availablePlayers = players.Where(player => player.DraftTeamUser == null);

            var draftTeam = await _draftRepository.GetDraftTeamAsync(draftId, teamId);
            //draftTeam.Team.

            // Find the first open position that fits the available players by rank

            // Todo Make this real choice
            return new DraftPlayerViewModel();
        }
    }
}
