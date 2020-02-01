namespace DraftSiteModels.Entities
{
    public class DraftTeamUserPlayer
    {
        public DraftTeamUser DraftTeamUser { get; set; }
        public int DraftId { get; set; }
        public int TeamId { get; set; }
        public int UserId { get; set; }

        public virtual Player Player { get; set; }
        public int PlayerId { get; set; }
    }
}
