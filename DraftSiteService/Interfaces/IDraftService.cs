using DraftSiteModels.Entities;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteService.Interfaces
{
    public interface IDraftService
    {
        Task<DraftViewModel> CreateDraftAsync(DraftInputModel draft);

        Task DeselectTeam(DraftTeamUser draftTeamUser);

        Task<DraftViewModel> GetDraft(int draftId);

        Task<DraftDataViewModel> GetDraftLookupsAsync();

        Task<PreDraftViewModel> GetPreDraftLobby(int draftId, string username, string password);

        Task<List<DraftViewModel>> GetUserLobby();

        Task<List<DraftTeamSummaryViewModel>> SelectTeam(int userId, int draftId, TeamChoiceInputModel teamSelection);

        Task<DraftViewModel> UpdateDraftSettings(int draftId, int userId, DraftInputModel draft);

        Task<List<DraftPlayerViewModel>> GetPlayers();

        Task<List<DraftTeamSummaryViewModel>> GetTeams();

        Task<List<DraftTeamSummaryViewModel>> GetDraftTeamsAsync(int draftId);

        Task<List<DraftPlayerViewModel>> GetDraftPlayersAsync(int draftId);

        Task<List<DraftTeamSummaryViewModel>> SelectPlayer(int userId, int draftId, int teamId, PlayerChoiceInputModel playerSelection);
        Task StartDraftAsync(int draftId);
    }
}
