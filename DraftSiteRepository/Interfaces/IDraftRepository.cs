using DraftSiteModels.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IDraftRepository
    {
        Task<Draft> CreateDraft(Draft draft);

        Task<List<Draft>> GetDrafts();

        Task<List<DraftTime>> GetDraftTimes();

        Task<List<DraftStatus>> GetDraftStatuses();
    }
}
