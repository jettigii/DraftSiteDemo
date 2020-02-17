using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class UserGamificationCalculation
    {
        public ulong Id { get; set; }
        public uint UserId { get; set; }
        public uint CreateMocks { get; set; }
        public uint CorrectMocks { get; set; }
        public uint PlayerAdditions { get; set; }
        public uint PlayerComparison { get; set; }
        public uint ScoutingReports { get; set; }
        public uint Videos { get; set; }
        public uint TeamNeeds { get; set; }
        public uint TeamPreview { get; set; }
        public uint MocksVoted { get; set; }
        public uint MockVotes { get; set; }
        public uint Total { get; set; }
    }
}
