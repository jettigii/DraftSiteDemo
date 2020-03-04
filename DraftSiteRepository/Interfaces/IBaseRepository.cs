using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IBaseRepository
    {
        Task SaveChangesAsync();
    }
}
