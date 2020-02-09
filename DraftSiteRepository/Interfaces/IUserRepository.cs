using DraftSiteModels.Entities;
using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IUserRepository
    {
        Task<DraftSiteUser> Authenticate(string token);
    }
}
