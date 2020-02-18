using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class UserMockDrafts
    {
        public uint Id { get; set; }
        public uint DraftId { get; set; }
        public byte SharedStatus { get; set; }
        public DateTime LastUpdate { get; set; }
        public uint UserId { get; set; }
        public bool UserRoundLimit { get; set; }
        public byte CommentStatus { get; set; }
    }
}
