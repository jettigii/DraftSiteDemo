using DraftSiteModels.DraftSiteModels;

namespace DraftSiteModels.Entities
{
    public class DraftTeamUserPlayer
    {
        public DraftTeamUser DraftTeamUser { get; set; }
        public int DraftTeamUserId { get; set; }

        public virtual Players Player { get; set; }
        public int PlayerId { get; set; }
    }
}
