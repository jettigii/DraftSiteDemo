using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Draftteams
    {
        public int Id { get; set; }
        public int Draft { get; set; }
        public int Team { get; set; }
        public ushort Rank { get; set; }
        public byte[] Commentary { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
