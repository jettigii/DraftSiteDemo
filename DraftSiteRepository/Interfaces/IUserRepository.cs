using DraftSiteModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DraftSiteRepository.Interfaces
{
    public interface IUserRepository
    {
        DraftSiteUserViewModel Authenticate(string token);
        DraftSiteUserViewModel GetProfile(string token);
    }
}
