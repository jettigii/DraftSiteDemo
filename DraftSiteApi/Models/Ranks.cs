using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class Ranks
    {
        public ulong Id { get; set; }
        public uint Player { get; set; }
        public uint Draft { get; set; }
        public byte Type { get; set; }
        public ushort Rank { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
