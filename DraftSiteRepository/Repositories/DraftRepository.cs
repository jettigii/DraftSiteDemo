using DraftSiteModels.Entities;
using DraftSiteModels.Models;
using DraftSiteRepository.Interfaces;
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

        public async Task<Draft> CreateDraft(Draft draft)
        {
            await _context.Drafts.AddAsync(draft);
            await _context.SaveChangesAsync();
            return draft;
        }

        public async Task<List<Draft>> GetDrafts(int userId)
        {
            var drafts = await _context.Drafts.Where(draft => draft.IsPublic).ToListAsync();
            return drafts;
        }

        public List<DraftTime> GetDraftTimes()
        {
            return _context.DraftTimeData;
        }
    }
}
