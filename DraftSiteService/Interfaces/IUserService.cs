using DraftSiteModels.ViewModels;

namespace DraftSiteService.Interfaces
{
    public interface IUserService
    {
        DraftSiteUserViewModel Authenticate(string token);
        DraftSiteUserViewModel GetProfile(string token);

    }
}
