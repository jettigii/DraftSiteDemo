﻿using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class Positions
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Fullname { get; set; }
        public byte Game { get; set; }
        public sbyte Sort { get; set; }
    }
}
