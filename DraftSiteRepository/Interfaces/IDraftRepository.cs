using DraftSiteModels.Entities;
using DraftSiteModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IDraftRepository
    {
        Task<Draft> CreateDraft(Draft draft);

        Task<List<Draft>> GetDrafts(int userId);

        List<DraftTime> GetDraftTimes();
    }
}
