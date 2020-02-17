using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class DraftContributors
    {
        public uint Id { get; set; }
        public uint DraftId { get; set; }
        public uint AdminId { get; set; }
    }
}
