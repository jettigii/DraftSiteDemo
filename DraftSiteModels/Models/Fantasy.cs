using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Fantasy
    {
        public int Id { get; set; }
        public int SportId { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int Playerdisplay { get; set; }
        public byte Status { get; set; }
        public DateTime DatePublished { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
