using System.Collections.Generic;

namespace DraftSiteModels.ViewModels
{
    public class MultiplayerDraftViewModel
    {
        public DraftViewModel Draft { get; set; }

        public List<DraftTeamUserViewModel> DraftTeams { get; set; }
    }
}
