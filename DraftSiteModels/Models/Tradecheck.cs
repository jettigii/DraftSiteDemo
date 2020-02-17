using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Tradecheck
    {
        public ulong Id { get; set; }
        public uint Trans { get; set; }
        public double Check { get; set; }
    }
}
