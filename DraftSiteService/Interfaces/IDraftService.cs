using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteService.Interfaces
{
    public interface IDraftService
    {
        Task<List<DraftViewModel>> GetUserLobby();

        Task<DraftViewModel> CreateDraft(DraftInputModel draft);

       Task< DraftDataViewModel> GetDraftLookups();
    }
}
