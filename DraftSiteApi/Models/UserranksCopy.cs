using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class UserranksCopy
    {
        public uint Id { get; set; }
        public uint Player { get; set; }
        public uint Draft { get; set; }
        public byte Type { get; set; }
        public ushort Rank { get; set; }
        public byte[] Comments { get; set; }
        public DateTime Lastupdate { get; set; }
        public uint User { get; set; }
    }
}
