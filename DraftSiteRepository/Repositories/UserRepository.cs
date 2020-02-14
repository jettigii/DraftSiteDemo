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

        public async Task<DraftSiteUser> Authenticate(string token)
        {
            var user = await _context.DraftSiteUsers.SingleOrDefaultAsync(user => user.Token == token);
            return user;
        }

        public async Task<DraftSiteUser> GetUserById(int id)
        {
            var userEntity = await _context.DraftSiteUsers.SingleOrDefaultAsync(user => user.Id == id);
            return userEntity;
        }

        public async Task<DraftSiteUser> GetUserByUsername(string username)
        {
            var userEntity = await _context.DraftSiteUsers.SingleOrDefaultAsync(user => user.Username == username);
            return userEntity;
        }
    }
}
