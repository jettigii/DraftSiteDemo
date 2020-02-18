using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Suppicks
    {
        public int Id { get; set; }
        public int Draft { get; set; }
        public byte Round { get; set; }
        public int Pick { get; set; }
        public int Team { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
