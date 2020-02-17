using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class UserTeamDraftAnalysisPicks
    {
        public uint Id { get; set; }
        public uint UserTeamDraftAnalysisId { get; set; }
        public uint PositionId { get; set; }
        public uint Order { get; set; }
    }
}
