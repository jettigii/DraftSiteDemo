using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class Schools
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Teamname { get; set; }
        public string Display { get; set; }
        public string City { get; set; }
        public int State { get; set; }
        public uint Country { get; set; }
        public uint Conference { get; set; }
        public byte Private { get; set; }
        public byte Type { get; set; }
        public uint? CreatedBy { get; set; }
        public uint? LastModifiedBy { get; set; }
    }
}
