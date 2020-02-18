using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Schools
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teamname { get; set; }
        public string Display { get; set; }
        public string City { get; set; }
        public int State { get; set; }
        public int Country { get; set; }
        public int Conference { get; set; }
        public byte Private { get; set; }
        public byte Type { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
