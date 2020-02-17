using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class DraftContributors
    {
        public uint Id { get; set; }
        public uint DraftId { get; set; }
        public uint AdminId { get; set; }
    }
}
