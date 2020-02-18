using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class DraftPlayers
    {
        public int PlayerId { get; set; }
        public int DraftId { get; set; }
        public byte RankType { get; set; }
        public ushort Rank { get; set; }
        public string Comments { get; set; }
    }
}
