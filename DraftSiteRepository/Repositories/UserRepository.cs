using DraftSiteModels.DraftSite;
using DraftSiteModels.Entities;
using DraftSiteRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DraftSiteRepository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DraftSiteContext _context;

        public UserRepository(DraftSiteContext context)
        {
            _context = context;
        }

        public async Task<UserAuthTokens> Authenticate(string token)
        {
            var user = await _context.UserAuthTokens.SingleOrDefaultAsync(user => user.HashedValidator == token);
            return user;
        }

        public async Task<Users> GetUserById(int id)
        {
            var userEntity = await _context.Users.SingleOrDefaultAsync(user => user.Id == id);
            return userEntity;
        }

        public async Task<Users> GetUserByUsername(string username)
        {
            var userEntity = await _context.Users.SingleOrDefaultAsync(user => user.Username == username);
            return userEntity;
        }
    }
}
