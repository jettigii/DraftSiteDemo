using DraftSiteModels.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteService.Interfaces
{
    public interface IMultiPlayerDraftService
    {
        Task JoinDraftLobby();
    }
}
