using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class Staticpicks
    {
        public ulong Id { get; set; }
        public uint Draft { get; set; }
        public uint Position { get; set; }
        public uint Pick { get; set; }
        public ushort Round { get; set; }
        public ulong Team { get; set; }
        public byte Type { get; set; }
        public string Typename { get; set; }
        public string Tradetext { get; set; }
        public uint Tradelink { get; set; }
        public ulong Player { get; set; }
        public byte[] Comments { get; set; }
    }
}
