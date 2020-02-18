using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class DraftContributors
    {
        public int Id { get; set; }
        public int DraftId { get; set; }
        public int AdminId { get; set; }
    }
}
