using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Rounds
    {
        public uint Id { get; set; }
        public uint Draft { get; set; }
        public byte Round { get; set; }
    }
}
