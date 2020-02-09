using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using System.Threading.Tasks;

namespace DraftSiteService.Interfaces
{
    public interface IDraftService
    {
        Task<DraftLobbyViewModel> GetUserLobby(string token);

        Task<DraftViewModel> CreateDraft(DraftInputModel draft);

        DraftDataViewModel GetDraftLookups();
    }
}
