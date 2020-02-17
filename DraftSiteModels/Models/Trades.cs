using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Trades
    {
        public uint Id { get; set; }
        public byte[] Description { get; set; }
        public DateTime Date { get; set; }
        public byte Type { get; set; }
        public byte Sport { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
