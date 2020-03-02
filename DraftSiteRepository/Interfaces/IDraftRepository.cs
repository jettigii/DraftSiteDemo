using DraftSiteModels.DraftSiteModels;
using DraftSiteModels.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteRepository.Interfaces
{
    public interface IDraftRepository
    {
        Task<MultiplayerDraft> CreateDraft(MultiplayerDraft draft);

        Task<DraftTeamUser> CreateDraftTeamUser(DraftTeamUser user);

        Task<DraftTeamUser> UpdateDraftTeamUser(DraftTeamUser user);

        Task<DraftTeamUser> DeleteDraftTeamUser(int userId, int draftId, string teamName);

        Task<MultiplayerDraft> GetDraft(int id);

        Task<List<MultiplayerDraft>> GetDrafts();

        Task<List<DraftStartType>> GetStartTypes();

        Task<List<DraftStatus>> GetDraftStatuses();

        Task<List<DraftTime>> GetDraftTimes();

        Task<List<Players>> GetPlayers();

        Task<List<Teams>> GetTeams();

        Task<MultiplayerDraft> UpdateDraftSettings(MultiplayerDraft draft);
        Task<DraftTeamUser> GetDraftTeamAsync(int draftId, int teamId);
        Task<List<DraftTeamUser>> CreateDraftTeams(List<DraftTeamUser> draftTeamUsers);
        Task<List<DraftTeamUserPlayer>> CreateDraftPlayers(List<DraftTeamUserPlayer> draftTeamUserPlayers);

        Task<List<DraftTeamUserPlayer>> GetDraftPlayersAsync(int draftId);

        Task<List<DraftTeamUser>> GetDraftTeamsAsync(int draftId);
        Task<List<DraftTeamUser>> GetDraftTeamPickOrderAsync(int draftId);
    }
}
