using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DraftSiteModels.ViewModels
{
    public class PreDraftViewModel
    {
        public List<DraftTeamSummaryViewModel> DraftTeams { get; set; }

        public bool IsComputerTeams { get; set; }

        public bool IsOwner { get; set; }

        public bool IsMultiSelect { get; set; }

        public bool IsPublic { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(typeof(int), "0", "60")]
        public int PickTime { get; set; }

        [Range(typeof(int), "3", "7")]
        public int RoundCount { get; set; }

        public DateTimeOffset StartTime { get; set; }

        [StringLength(80)]
        public string Username { get; set; }
    }
}
