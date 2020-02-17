using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class TeamsPreviousNames
    {
        public uint Id { get; set; }
        public uint Team { get; set; }
        public string Home { get; set; }
        public string Name { get; set; }
        public string Display { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public uint CreatedBy { get; set; }
        public uint LastModifiedBy { get; set; }
    }
}
