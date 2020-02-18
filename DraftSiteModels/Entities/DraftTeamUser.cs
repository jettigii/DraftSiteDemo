using DraftSiteModels.DraftSiteModels;
using System.Collections.Generic;

namespace DraftSiteModels.Entities
{
    public class DraftTeamUser
    {
        public int Id { get; set; }

        public virtual MultiplayerDraft MultiPlayerDraft { get; set; }
        public int DraftId { get; set; }

        public virtual Users User { get; set; }        
        public int UserId { get; set; }

        public virtual Teams Team { get; set; }
        public int TeamId { get; set; }

        public bool IsComputer { get; set; }
        public virtual IEnumerable<DraftTeamUserPlayer> DraftTeamUserPlayers { get; set; }
    }
}
