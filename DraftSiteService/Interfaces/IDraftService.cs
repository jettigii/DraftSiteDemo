using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteService.Interfaces
{
    public interface IDraftService
    {
        Task<DraftViewModel> CreateDraft(DraftInputModel draft);

        Task<List<DraftTeamSummaryViewModel>> DeselectTeam(string username, int draftId, int teamId);

        Task<DraftDataViewModel> GetDraftLookups();

        Task<PreDraftViewModel> GetPreDraftLobby(int draftId, string username, string password);

        Task<List<DraftViewModel>> GetUserLobby();

        Task<List<DraftTeamSummaryViewModel>> SelectTeam(string username, TeamChoiceInputModel teamSelection);

        Task<DraftViewModel> UpdateDraftSettings(DraftInputModel draft);        
    }
}
