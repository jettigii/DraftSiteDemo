using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class UserMockDraftsContest
    {
        public uint Id { get; set; }
        public uint DraftId { get; set; }
        public uint Rank { get; set; }
        public uint UserId { get; set; }
        public byte Points { get; set; }
    }
}
