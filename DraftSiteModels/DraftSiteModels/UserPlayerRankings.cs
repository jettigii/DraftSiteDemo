using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class UserPlayerRankings
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public int PlayerId { get; set; }
        public int UserId { get; set; }
        public int DraftId { get; set; }
        public string Visibility { get; set; }
    }
}
