using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Blogposts
    {
        public int Id { get; set; }
        public int Writer { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public byte[] Text { get; set; }
        public DateTime Time { get; set; }
        public byte Status { get; set; }
        public byte Sport { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public string FeaturedImage { get; set; }
        public int AuthorId { get; set; }
    }
}
