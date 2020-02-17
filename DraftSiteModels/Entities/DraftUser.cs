using System.Collections.Generic;

namespace DraftSiteModels.Entities
{
    public class DraftUser
    {
        public int DraftId { get; set; }
        public virtual MultiplayerDraft Draft { get; set; }
        public int UserId { get; set; }
        public virtual DraftSiteUser User { get; set; }

        public virtual IEnumerable<DraftTeamUser> DraftTeamUsers { get; set; }
    }
}
