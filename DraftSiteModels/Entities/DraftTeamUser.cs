using System.Collections.Generic;

namespace DraftSiteModels.Entities
{
    public class DraftTeamUser
    {
        public virtual DraftUser DraftUser { get; set; }
        public int DraftId { get; set; }
        public int UserId { get; set; }

        public virtual Team Team { get; set; }
        public int TeamId { get; set; }

        public virtual IEnumerable<DraftTeamUserPlayer> DraftTeamUserPlayers { get; set; }
    }
}
