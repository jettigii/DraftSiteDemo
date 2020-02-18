using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class Ads
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public byte[] Text { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
