using DraftSiteModels.Entities;
using System.Collections.Generic;

namespace DraftSiteModels.Models
{
    public class DraftTime
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TimeInSeconds { get; set; }

        public string Value { get; set; }

        public virtual IEnumerable<Draft> Drafts { get; set; }
    }
}
