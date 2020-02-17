using DraftSiteModels.Entities;
using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Teams
    {
        public uint Id { get; set; }
        public string Home { get; set; }
        public byte State { get; set; }
        public uint Country { get; set; }
        public string Name { get; set; }
        public string Display { get; set; }
        public byte Sport { get; set; }
        public byte Type { get; set; }
        public uint League { get; set; }
        public byte Active { get; set; }
        public uint Successor { get; set; }
        public uint? CreatedBy { get; set; }
        public uint? LastModifiedBy { get; set; }
        public IEnumerable<DraftTeamUser> DraftTeamUsers { get; set; }
    }
}
