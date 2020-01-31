using DraftSiteModels.Enums;

namespace DraftSiteModels.ViewModels
{
    public class DraftViewModel
    {
        public DraftStatus DraftStatus { get; set; }
        public string Name { get; set; }
        public int RoundCount { get; set; }
        public bool IsPublic { get; set; }
        public string UserId { get; set; }
    }
}
