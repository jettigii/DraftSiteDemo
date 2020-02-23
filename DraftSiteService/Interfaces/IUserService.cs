using DraftSiteModels.ViewModels;
using System.Threading.Tasks;

namespace DraftSiteService.Interfaces
{
    public interface IUserService
    {
        Task<DraftSiteUserViewModel> Authenticate(string token);
        Task<DraftSiteUserViewModel> GetUserByUsername(string username);
    }
}
