using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class Blogposts
    {
        public uint Id { get; set; }
        public uint Writer { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public byte[] Text { get; set; }
        public DateTime Time { get; set; }
        public byte Status { get; set; }
        public byte Sport { get; set; }
        public uint? CreatedBy { get; set; }
        public uint? LastModifiedBy { get; set; }
        public string FeaturedImage { get; set; }
        public int AuthorId { get; set; }
    }
}
