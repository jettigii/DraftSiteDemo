using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class Draftteams
    {
        public uint Id { get; set; }
        public uint Draft { get; set; }
        public uint Team { get; set; }
        public ushort Rank { get; set; }
        public byte[] Commentary { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
