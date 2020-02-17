using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class MockTrades
    {
        public int MockDraftId { get; set; }
        public short PickOrder { get; set; }
        public int TradeTransId { get; set; }
        public string TeamIds { get; set; }
    }
}
