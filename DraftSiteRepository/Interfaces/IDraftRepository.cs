using DraftSiteModels.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IDraftRepository
    {
        Task<Draft> CreateDraft(Draft draft);

        Task<Draft> GetDraft(int id);

        Task<List<Draft>> GetDrafts();        

        Task<List<DraftStatus>> GetDraftStatuses();

        Task<List<DraftTime>> GetDraftTimes();

        Task<Draft> UpdateDraftSettings(Draft draft);
    }
}
