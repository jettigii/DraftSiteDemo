using System;
using System.Collections.Generic;
using System.Text;

namespace DraftSiteModels.Entities
{
    public class DraftStartType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public bool IsEnabled { get; set; }

        public virtual IEnumerable<MultiplayerDraft> Drafts { get; set; }
    }
}
