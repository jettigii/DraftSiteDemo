using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class FantasyRankings
    {
        public uint Id { get; set; }
        public uint FantasyId { get; set; }
        public uint PlayerId { get; set; }
        public ushort Rank { get; set; }
        public uint TeamId { get; set; }
        public string Positions { get; set; }
    }
}
