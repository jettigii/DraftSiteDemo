using DraftSiteModels.DraftSiteModels;
using DraftSiteModels.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IDraftRepository
    {
        Task<MultiplayerDraft> CreateDraft(MultiplayerDraft draft);

        Task<DraftTeamUser> CreateDraftTeamUser( DraftTeamUser user);

        Task<DraftTeamUser> DeleteDraftTeamUser(int userId, int draftId, int teamId);

        Task<MultiplayerDraft> GetDraft(int id);

        Task<List<MultiplayerDraft>> GetDrafts();

        Task<List<DraftStartType>> GetStartTypes();

        Task<List<DraftStatus>> GetDraftStatuses();

        Task<List<DraftTime>> GetDraftTimes();

        Task<List<Players>> GetPlayers();

        Task<List<Teams>> GetTeams();

        Task<MultiplayerDraft> UpdateDraftSettings(MultiplayerDraft draft);
        Task CreateDraftTeams(List<DraftTeamUser> draftTeamUsers);
        Task CreateDraftPlayers(List<DraftTeamUserPlayer> draftTeamUserPlayers);

        Task<List<DraftTeamUserPlayer>> GetDraftPlayersAsync(int draftId);

        Task<List<DraftTeamUser>> GetDraftTeamsAsync(int draftId);
    }
}
