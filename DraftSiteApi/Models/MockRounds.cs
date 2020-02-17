using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class MockRounds
    {
        public int MockDraftId { get; set; }
        public sbyte Order { get; set; }
        public string Name { get; set; }
    }
}
