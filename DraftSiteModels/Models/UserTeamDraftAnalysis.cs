using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class UserTeamDraftAnalysis
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int TeamId { get; set; }
        public int DraftId { get; set; }
        public string Preview { get; set; }
        public string Analysis { get; set; }
        public bool? SharedStatus { get; set; }
        public bool? Approved { get; set; }
    }
}
