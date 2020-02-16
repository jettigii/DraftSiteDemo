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

        [StringLength(24)]
        public string Password { get; set; }

        [Range(0, 3600)]
        public int PickTime { get; set; }

        [Range(1, 7)]
        public int RoundCount { get; set; }

        public string StartTime { get; set; }
        
        public int UserId { get; set; }
    }
}
