﻿using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class RanksTemp
    {
        public ulong Id { get; set; }
        public int Player { get; set; }
        public int Draft { get; set; }
        public byte Type { get; set; }
        public ushort Rank { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
