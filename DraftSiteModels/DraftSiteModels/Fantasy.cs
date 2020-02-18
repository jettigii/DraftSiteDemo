using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class Fantasy
    {
        public uint Id { get; set; }
        public uint SportId { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public uint Playerdisplay { get; set; }
        public byte Status { get; set; }
        public DateTime DatePublished { get; set; }
        public uint CreatedBy { get; set; }
        public uint LastModifiedBy { get; set; }
    }
}
