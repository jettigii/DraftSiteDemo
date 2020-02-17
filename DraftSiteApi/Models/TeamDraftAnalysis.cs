using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class TeamDraftAnalysis
    {
        public uint Id { get; set; }
        public uint Team { get; set; }
        public uint Draft { get; set; }
        public string Positions { get; set; }
        public byte[] Preview { get; set; }
        public byte[] Analysis { get; set; }
    }
}
