using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class UserGamificationCalculation
    {
        public ulong Id { get; set; }
        public int UserId { get; set; }
        public int CreateMocks { get; set; }
        public int CorrectMocks { get; set; }
        public int PlayerAdditions { get; set; }
        public int PlayerComparison { get; set; }
        public int ScoutingReports { get; set; }
        public int Videos { get; set; }
        public int TeamNeeds { get; set; }
        public int TeamPreview { get; set; }
        public int MocksVoted { get; set; }
        public int MockVotes { get; set; }
        public int Total { get; set; }
    }
}
