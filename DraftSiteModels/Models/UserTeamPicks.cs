using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class UserTeamPicks
    {
        public int Id { get; set; }
        public int Draft { get; set; }
        public byte Round { get; set; }
        public int RoundId { get; set; }
        public ushort Rank { get; set; }
        public int Team { get; set; }
        public byte Type { get; set; }
        public string TypeDesc { get; set; }
        public int User { get; set; }
    }
}
