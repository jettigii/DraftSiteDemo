using DraftSiteModels.DraftSiteModels;
using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IUserRepository
    {
        Task<UserAuthTokens> Authenticate(string token);

        Task<Users> GetUserById(int id);

        Task<Users> GetUserByUsername(string username);
    }
}
