using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteService.Interfaces
{
    public interface IDraftService
    {
        Task<DraftViewModel> CreateDraft(DraftInputModel draft);

        Task<DraftDataViewModel> GetDraftLookups();

        Task<PreDraftViewModel> GetPreDraftLobby(int draftId, int userId, string password);

        Task<List<DraftViewModel>> GetUserLobby();

        Task<DraftViewModel> UpdateDraftSettings(DraftInputModel draft);
    }
}
