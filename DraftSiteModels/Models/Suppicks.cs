using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Suppicks
    {
        public uint Id { get; set; }
        public uint Draft { get; set; }
        public byte Round { get; set; }
        public uint Pick { get; set; }
        public uint Team { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
