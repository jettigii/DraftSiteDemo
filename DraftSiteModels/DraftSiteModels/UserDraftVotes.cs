using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class UserDraftVotes
    {
        public string VotingUserId { get; set; }
        public string OwnerUserId { get; set; }
        public string DraftId { get; set; }
        public bool Rating { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}
