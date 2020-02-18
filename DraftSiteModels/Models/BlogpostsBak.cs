using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class BlogpostsBak
    {
        public int Id { get; set; }
        public int Writer { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public byte Status { get; set; }
        public byte Sport { get; set; }
    }
}
