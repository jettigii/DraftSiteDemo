using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class PicksTemp
    {
        public ulong Id { get; set; }
        public uint Round { get; set; }
        public ushort Pick { get; set; }
        public uint Team { get; set; }
        public byte Type { get; set; }
        public string Typename { get; set; }
        public byte[] Comments { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
