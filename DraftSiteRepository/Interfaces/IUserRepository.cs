using DraftSiteModels.DraftSiteModels;
using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IUserRepository
    {
        Task<UserAuthTokens> Authenticate(string token);

        Task<Users> GetUserById(uint id);

        Task<Users> GetUserByUsername(string username);
    }
}
