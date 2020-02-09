using System;
using System.Collections.Generic;
using System.Text;

namespace DraftSiteModels.Entities
{
    public class DraftSiteUser
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Username { get; set; }

        public IEnumerable<DraftUser> DraftUsers { get; set; }
        public IEnumerable<Draft> Drafts { get; set; }
    }
}
