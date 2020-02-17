using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class UserGamificationPoints
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
    }
}
