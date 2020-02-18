using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Staticpicks
    {
        public ulong Id { get; set; }
        public int Draft { get; set; }
        public int Position { get; set; }
        public int Pick { get; set; }
        public ushort Round { get; set; }
        public ulong Team { get; set; }
        public byte Type { get; set; }
        public string Typename { get; set; }
        public string Tradetext { get; set; }
        public int Tradelink { get; set; }
        public ulong Player { get; set; }
        public byte[] Comments { get; set; }
    }
}
