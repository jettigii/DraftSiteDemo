using DraftSiteModels.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IDraftRepository
    {
        Task<Draft> CreateDraft(Draft draft);

        Task<DraftTeamUser> CreateDraftTeamUser(int userId, DraftTeamUser user);

        Task<DraftTeamUser> DeleteDraftTeamUser(int userId, int draftId, int teamId);

        Task<Draft> GetDraft(int id);

        Task<List<Draft>> GetDrafts();

        Task<List<DraftStartType>> GetStartTypes();

        Task<List<DraftStatus>> GetDraftStatuses();

        Task<List<DraftTime>> GetDraftTimes();

        Task<List<Player>> GetPlayers();

        Task<List<Team>> GetTeams();

        Task<Draft> UpdateDraftSettings(Draft draft);
    }
}
