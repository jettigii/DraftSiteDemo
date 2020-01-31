using DraftSiteModels.ViewModels;
using DraftSiteRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DraftSiteRepository.Repositories
{
    public class UserRepository : IUserRepository
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
