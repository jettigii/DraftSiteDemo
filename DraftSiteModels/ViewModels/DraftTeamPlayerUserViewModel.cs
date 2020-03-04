using System;
using System.Collections.Generic;
using System.Text;

namespace DraftSiteModels.ViewModels
{
    public class DraftTeamPlayerUserViewModel
    {
        public string TeamOwnerUser { get; set; }
        public string TeamName { get; set; }
        public int PickNumber { get; set; }
        public int PickRound { get; set; }
        public string PlayerName { get; set; }
        public string PlayerCollege { get; set; }
    }
}
