using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class UserRedrafts
    {
        public int Id { get; set; }
        public int DraftId { get; set; }
        public byte SharedStatus { get; set; }
        public DateTime LastUpdate { get; set; }
        public int UserId { get; set; }
        public bool UserRoundLimit { get; set; }
    }
}
