using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class DraftPicks
    {
        public int DraftId { get; set; }
        public int RoundId { get; set; }
        public ushort Order { get; set; }
        public ushort Rank { get; set; }
        public int TeamId { get; set; }
        public byte Type { get; set; }
        public string TypeDesc { get; set; }
    }
}
