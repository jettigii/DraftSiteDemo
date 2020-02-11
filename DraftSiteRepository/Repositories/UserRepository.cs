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
            var user = await _context.DraftSiteUsers.SingleOrDefaultAsync(user => user.Id == id);
            return user;
        }
    }
}
