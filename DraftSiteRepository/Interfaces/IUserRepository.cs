using DraftSiteModels.Entities;
using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IUserRepository
    {
        Task<DraftSiteUser> Authenticate(string token);
        
        Task<DraftSiteUser> GetUserById(int id);

        Task<DraftSiteUser> GetUserByUsername(string username);
    }
}
