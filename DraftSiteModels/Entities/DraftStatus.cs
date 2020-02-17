using System.Collections.Generic;

namespace DraftSiteModels.Entities
{
    public class DraftStatus
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public virtual IEnumerable<MultiplayerDraft> Drafts { get; set; }
    }
}
