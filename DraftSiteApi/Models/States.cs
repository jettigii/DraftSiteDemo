﻿using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class States
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
        public int Country { get; set; }
    }
}
