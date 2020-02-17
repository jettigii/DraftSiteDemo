using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class MockTradesDeleted
    {
        public int MockDraftId { get; set; }
        public short PickOrder { get; set; }
        public int TradeTransId { get; set; }
        public string TeamIds { get; set; }
    }
}
