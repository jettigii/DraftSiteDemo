using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DraftSiteModels.Entities
{
    public class Draft
    {
        public int Id { get; set; }

        public bool IsComputerTeams { get; set; }
        public bool IsPublic { get; set; }

        public bool IsMultiSelect { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(typeof(int), "0", "60")]
        public virtual DraftTime PickTime { get; set; }

        public int PickTimeId { get; set; }

        [Range(typeof(int), "3", "7")]
        public int RoundCount { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public virtual DraftSiteUser Owner { get; set; }

        public int OwnerId { get; set; }

        public DraftStatus DraftStatus { get; set; }
        public int DraftStatusId { get; set; }

        public IEnumerable<DraftTeamUser> DraftTeamUsers { get; set; }

        public IEnumerable<DraftUser> DraftUsers { get; set; }
    }
}
