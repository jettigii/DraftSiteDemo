using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class MockDraftsDeleted
    {
        public int Id { get; set; }
        public int DraftId { get; set; }
        public short Version { get; set; }
        public sbyte Status { get; set; }
        public bool Current { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
