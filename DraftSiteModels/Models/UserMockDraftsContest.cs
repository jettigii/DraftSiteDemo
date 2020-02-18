using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class UserMockDraftsContest
    {
        public int Id { get; set; }
        public int DraftId { get; set; }
        public int Rank { get; set; }
        public int UserId { get; set; }
        public byte Points { get; set; }
    }
}
