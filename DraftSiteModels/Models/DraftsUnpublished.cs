using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class DraftsUnpublished
    {
        public int Id { get; set; }
        public int DraftId { get; set; }
        public int SportId { get; set; }
        public int UserId { get; set; }
        public byte Steps { get; set; }
        public byte[] PostVars { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
