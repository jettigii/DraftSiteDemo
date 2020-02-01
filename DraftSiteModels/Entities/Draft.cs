using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DraftSiteModels.Entities
{
    public class Draft
    {
        public int Id { get; set; }

        public bool HasComputerTeams { get; set; }
        public bool IsPublic { get; set; }

        public bool IsSinglePick { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(typeof(int), "0", "60")]
        public int PickTime { get; set; }

        [Range(typeof(int), "3", "7")]
        public int RoundCount { get; set; }

        public DateTimeOffset StartTime { get; set; }

        [StringLength(80)]
        public string UserId { get; set; }

        public IEnumerable<DraftTeamUser> DraftTeamUsers { get; set; }

        public IEnumerable<DraftUser> DraftUsers { get; set; }
    }
}
