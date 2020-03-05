using DraftSiteModels.ViewModels;
using System.Threading.Tasks;

namespace DraftSiteService.Interfaces
{
    public interface IUserService
    {
        Task<DraftSiteUserViewModel> AuthenticateAsync(string token);
        Task<DraftSiteUserViewModel> GetUserByUsername(string username);
    }
}
