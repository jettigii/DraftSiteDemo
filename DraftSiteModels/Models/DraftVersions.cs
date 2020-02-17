using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class DraftVersions
    {
        public uint DraftId { get; set; }
        public byte RankType { get; set; }
        public byte PublishedRounds { get; set; }
        public byte SavedRounds { get; set; }
        public bool Status { get; set; }
        public DateTime LastPublished { get; set; }
        public DateTime LastSaved { get; set; }
        public uint? CreatedBy { get; set; }
        public uint? LastModifiedBy { get; set; }
    }
}
