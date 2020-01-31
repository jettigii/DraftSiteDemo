using DraftSiteModels.ViewModels;
using DraftSiteService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DraftSiteService.Services
{
    public class UserService : IUserService
    {
        public DraftSiteUserViewModel Authenticate(string token)
        {
            throw new NotImplementedException();
        }

        public DraftSiteUserViewModel GetProfile(string token)
        {
            throw new NotImplementedException();
        }
    }
}
