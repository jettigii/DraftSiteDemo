using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteService.Interfaces
{
    public interface IDraftService
    {
        Task<DraftViewModel> CreateDraftAsync(DraftInputModel draft);

        Task<List<DraftTeamSummaryViewModel>> DeselectTeam(int userId, TeamChoiceInputModel teamSelection);

        Task<DraftDataViewModel> GetDraftLookups();

        Task<PreDraftViewModel> GetPreDraftLobby(int draftId, string username, string password);

        Task<List<DraftViewModel>> GetUserLobby();

        Task<List<DraftTeamSummaryViewModel>> SelectTeam(int userId, TeamChoiceInputModel teamSelection);

        Task<DraftViewModel> UpdateDraftSettings(int draftId, DraftInputModel draft);

        Task<List<DraftPlayerViewModel>> GetPlayers();

        Task<List<DraftTeamSummaryViewModel>> GetTeams();

    }
}
