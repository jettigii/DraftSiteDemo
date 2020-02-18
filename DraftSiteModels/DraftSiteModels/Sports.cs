using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class Sports
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public byte Game { get; set; }
        public byte[] Message { get; set; }
        public sbyte Sort { get; set; }
        public bool? Active { get; set; }
        public sbyte Sponsortakeover { get; set; }
        public byte Visible { get; set; }
    }
}
