using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class PositionsSub
    {
        public sbyte Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public sbyte MainPositions { get; set; }
    }
}
