using System;
using System.Collections.Generic;
using System.Text;

namespace DraftSiteModels.Entities
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string College { get; set; }

        public virtual ICollection<DraftTeamUserPlayer> DraftTeamUserPlayers { get; set; }
    }
}
