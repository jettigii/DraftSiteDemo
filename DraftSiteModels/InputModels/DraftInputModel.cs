using System;
using System.ComponentModel.DataAnnotations;

namespace DraftSiteModels.InputModels
{
    public class DraftInputModel
    {
        public bool IsComputerTeams { get; set; }
        public bool IsPublic { get; set; }

        public bool IsMultiSelect { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(0, 3600)]
        public int? PickTime { get; set; }

        [Range(3, 7)]
        public int? RoundCount { get; set; }

        public DateTimeOffset? StartTime { get; set; }
        
        public int UserId { get; set; }
    }
}
