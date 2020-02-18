using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Leagues
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Country { get; set; }
    }
}
