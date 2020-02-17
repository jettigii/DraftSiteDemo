using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class MockPicks
    {
        public int MockDraftId { get; set; }
        public sbyte RoundOrder { get; set; }
        public short Order { get; set; }
        public short Rank { get; set; }
        public int TeamId { get; set; }
        public bool Type { get; set; }
        public string TypeDesc { get; set; }
        public int PlayerId { get; set; }
        public string Comments { get; set; }
    }
}
