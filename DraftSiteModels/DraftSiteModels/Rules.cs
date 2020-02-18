using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class Rules
    {
        public uint Id { get; set; }
        public uint Sport { get; set; }
        public byte[] Text { get; set; }
        public DateTime Time { get; set; }
    }
}
