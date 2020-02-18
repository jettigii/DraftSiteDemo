using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class FantasyRankings
    {
        public int Id { get; set; }
        public int FantasyId { get; set; }
        public int PlayerId { get; set; }
        public ushort Rank { get; set; }
        public int TeamId { get; set; }
        public string Positions { get; set; }
    }
}
