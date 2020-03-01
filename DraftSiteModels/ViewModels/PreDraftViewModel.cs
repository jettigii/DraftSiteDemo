using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DraftSiteModels.ViewModels
{
    public class PreDraftViewModel
    {
        public List<DraftTeamSummaryViewModel> DraftTeams { get; set; }

        public List<DraftPlayerViewModel> DraftPlayers { get; set; }

        public DraftViewModel Draft { get; set; }

        public bool IsOwner { get; set; }
        public DraftDataViewModel Lookups { get; set; }
    }
}
