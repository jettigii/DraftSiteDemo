using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Ads
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Text { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
