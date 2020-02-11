using DraftSiteModels.Entities;
using DraftSiteRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        public async Task<Draft> CreateDraft(Draft draft)
        {
            await _context.Drafts.AddAsync(draft);
            await _context.SaveChangesAsync();
            return draft;
        }

        public async Task<List<Draft>> GetDrafts()
        {
            var drafts = await _context
                .Drafts
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
    }
}
