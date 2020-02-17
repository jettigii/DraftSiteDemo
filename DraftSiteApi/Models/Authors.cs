using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class Authors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AdminId { get; set; }
    }
}
