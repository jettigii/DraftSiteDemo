using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class DraftPlayers
    {
        public uint PlayerId { get; set; }
        public uint DraftId { get; set; }
        public byte RankType { get; set; }
        public ushort Rank { get; set; }
        public string Comments { get; set; }
    }
}
