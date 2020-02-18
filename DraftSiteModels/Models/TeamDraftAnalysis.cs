using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class TeamDraftAnalysis
    {
        public int Id { get; set; }
        public int Team { get; set; }
        public int Draft { get; set; }
        public string Positions { get; set; }
        public byte[] Preview { get; set; }
        public byte[] Analysis { get; set; }
    }
}
