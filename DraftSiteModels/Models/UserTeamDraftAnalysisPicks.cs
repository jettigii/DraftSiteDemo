using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class UserTeamDraftAnalysisPicks
    {
        public int Id { get; set; }
        public int UserTeamDraftAnalysisId { get; set; }
        public int PositionId { get; set; }
        public int Order { get; set; }
    }
}
