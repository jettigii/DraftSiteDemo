using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Picks
    {
        public int Id { get; set; }
        public int Round { get; set; }
        public ushort Pick { get; set; }
        public int Team { get; set; }
        public byte Type { get; set; }
        public string Typename { get; set; }
        public byte[] Comments { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
