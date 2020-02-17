using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class Rounds
    {
        public uint Id { get; set; }
        public uint Draft { get; set; }
        public byte Round { get; set; }
    }
}
