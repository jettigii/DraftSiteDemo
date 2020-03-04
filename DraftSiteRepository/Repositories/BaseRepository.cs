using DraftSiteRepository.Interfaces;
using DraftSiteRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DraftSiteRepository.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        protected readonly DraftSiteContext _context;

        public BaseRepository(DraftSiteContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
