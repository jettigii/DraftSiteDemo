using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class Leagues
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public uint Country { get; set; }
    }
}
