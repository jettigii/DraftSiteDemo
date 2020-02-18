using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class DraftsUnpublished
    {
        public uint Id { get; set; }
        public uint DraftId { get; set; }
        public uint SportId { get; set; }
        public uint UserId { get; set; }
        public byte Steps { get; set; }
        public byte[] PostVars { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
