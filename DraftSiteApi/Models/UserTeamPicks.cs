using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class UserTeamPicks
    {
        public uint Id { get; set; }
        public uint Draft { get; set; }
        public byte Round { get; set; }
        public uint RoundId { get; set; }
        public ushort Rank { get; set; }
        public uint Team { get; set; }
        public byte Type { get; set; }
        public string TypeDesc { get; set; }
        public uint User { get; set; }
    }
}
