using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class DraftPicks
    {
        public uint DraftId { get; set; }
        public uint RoundId { get; set; }
        public ushort Order { get; set; }
        public ushort Rank { get; set; }
        public uint TeamId { get; set; }
        public byte Type { get; set; }
        public string TypeDesc { get; set; }
    }
}
