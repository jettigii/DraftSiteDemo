using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class TeamsPreviousNames
    {
        public int Id { get; set; }
        public int Team { get; set; }
        public string Home { get; set; }
        public string Name { get; set; }
        public string Display { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
