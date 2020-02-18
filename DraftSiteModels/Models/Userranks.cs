using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Userranks
    {
        public int Id { get; set; }
        public int Player { get; set; }
        public int Draft { get; set; }
        public byte Type { get; set; }
        public ushort Rank { get; set; }
        public byte[] Comments { get; set; }
        public DateTime Lastupdate { get; set; }
        public int User { get; set; }
    }
}
