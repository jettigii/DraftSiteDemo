using System.Collections.Generic;

namespace DraftSiteModels.ViewModels
{
    public class DraftLobbyViewModel
    {
        public DraftSiteUserViewModel User { get; set; }
        public List<DraftViewModel> Drafts { get; set; }
    }
}
