using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Rules
    {
        public int Id { get; set; }
        public int Sport { get; set; }
        public byte[] Text { get; set; }
        public DateTime Time { get; set; }
    }
}
