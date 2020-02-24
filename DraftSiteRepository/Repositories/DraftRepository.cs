using DraftSiteModels.DraftSiteModels;
using DraftSiteModels.Entities;
using DraftSiteRepository.Interfaces;
using DraftSiteRepository.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteRepository.Repositories
{
    public class DraftRepository : IDraftRepository
    {
        private readonly DraftSiteContext _context;

        public DraftRepository(DraftSiteContext context)
        {
            _context = context;
        }

        public async Task<MultiplayerDraft> CreateDraft(MultiplayerDraft draft)
        {
            await _context.MultiPlayerDrafts.AddAsync(draft);
            await _context.SaveChangesAsync();
            return draft;
        }

        public async Task CreateDraftPlayers(List<DraftTeamUserPlayer> draftTeamUserPlayers)
        {
            await _context.DraftTeamUserPlayers.AddRangeAsync(draftTeamUserPlayers);
        }

        public async Task CreateDraftTeams(List<DraftTeamUser> draftTeamUsers)
        {
            await _context.DraftTeamUsers.AddRangeAsync(draftTeamUsers);
        }

        public async Task<DraftTeamUser> CreateDraftTeamUser(DraftTeamUser user)
        {
            await _context.DraftTeamUsers.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<DraftTeamUser> DeleteDraftTeamUser(int userId, int draftId, int teamId)
        {
            // TODO: THIS METHOD NEEDS MULTIPLAYERDRAFTID AS INPUT
            var draftTeamUser = await _context
                .DraftTeamUsers
                .SingleOrDefaultAsync(dtu => dtu.MultiPlayerDraftId == userId);

            _context.DraftTeamUsers.Remove(draftTeamUser);
            await _context.SaveChangesAsync();

            return draftTeamUser;
        }

        public async Task<MultiplayerDraft> GetDraft(int id)
        {
            var draft = await _context
                .MultiPlayerDrafts
                .Include(draft => draft.Owner)
                .Include(draft => draft.PickTime)
                .Include(draft => draft.DraftStatus)
                .SingleOrDefaultAsync(draft => draft.Id == id);
            return draft;
        }

        public async Task<List<DraftTeamUser>> GetDraftTeamsAsync(int draftId)
        {
            var draftTeams = await _context.DraftTeamUsers
                .Where(draftTeamUser => draftTeamUser.MultiPlayerDraftId == draftId)
                .ToListAsync();

            return draftTeams;
        }

        public async Task<List<DraftTeamUserPlayer>> GetDraftPlayersAsync(int draftId)
        {
            var draftTeams = await _context.DraftTeamUserPlayers
                .Include(draftTeamUserPlayer => draftTeamUserPlayer.DraftTeamUser)
                .Where(draftTeamUserPlayer => draftTeamUserPlayer.DraftTeamUser.MultiPlayerDraftId == draftId)
                .ToListAsync();

            return draftTeams;
        }

        public async Task<List<MultiplayerDraft>> GetDrafts()
        {
            var drafts = await _context
                .MultiPlayerDrafts
                .Include(draft => draft.Owner)
                .Include(draft => draft.PickTime)
                .Include(draft => draft.DraftStatus)
                .ToListAsync();
            return drafts;
        }

        public async Task<List<DraftStatus>> GetDraftStatuses()
        {
            var statuses = await _context.DraftStatuses.ToListAsync();
            return statuses;
        }

        public async Task<List<DraftTime>> GetDraftTimes()
        {
            var times = await _context.DraftTimes.ToListAsync();
            return times;
        }

        public async Task<List<Players>> GetPlayers()
        {
            var players = await _context.Players
                .Where(player => player.Draftclass == "2020" && player.Sport == 1 )
                .ToListAsync();

            return players;
        }

        public async Task<List<DraftStartType>> GetStartTypes()
        {
            var draftStartTypes = await _context.DraftStartTypes.ToListAsync();
            return draftStartTypes;
        }

        public async Task<List<Teams>> GetTeams()
        {
            var players = await _context.Teams
                .Where(team => team.Sport == 1 && team.Active == 1)
                .ToListAsync();
            return players;
        }

        public async Task<MultiplayerDraft> UpdateDraftSettings(MultiplayerDraft updatedDraft)
        {
            var entity = await _context
                .MultiPlayerDrafts
                .Include(draft => draft.Owner)
                .Include(draft => draft.PickTime)
                .Include(draft => draft.DraftStatus)
                .SingleAsync(draft => draft.Id == updatedDraft.Id);

            if (entity == null)
            {
                _context.Add(entity);
            }
            else
            {
                _context.Entry(entity).CurrentValues.SetValues(updatedDraft);
                entity.PickTimeId = updatedDraft.PickTimeId;
                entity.DraftStatusId = updatedDraft.DraftStatusId;
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<DraftTeamUser> GetDraftTeamAsync(int draftId, int teamId)
        {
            var draftTeam = await _context.DraftTeamUsers
                .SingleAsync(draftTeamUser => draftTeamUser.MultiPlayerDraftId == draftId && draftTeamUser.TeamId == teamId);

            return draftTeam;
        }

        public Task<List<DraftTeamUser>> GetDraftTeamPickOrderAsync(int draftId)
        {
            throw new System.NotImplementedException();
        }
    }
}
