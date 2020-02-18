using DraftSiteModels.Entities;
using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Teams
    {
        public int Id { get; set; }
        public string Home { get; set; }
        public byte State { get; set; }
        public int Country { get; set; }
        public string Name { get; set; }
        public string Display { get; set; }
        public byte Sport { get; set; }
        public byte Type { get; set; }
        public int League { get; set; }
        public byte Active { get; set; }
        public int Successor { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public IEnumerable<DraftTeamUser> DraftTeamUsers { get; set; }
    }
}
