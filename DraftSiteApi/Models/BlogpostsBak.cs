using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class BlogpostsBak
    {
        public uint Id { get; set; }
        public uint Writer { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public byte Status { get; set; }
        public byte Sport { get; set; }
    }
}
