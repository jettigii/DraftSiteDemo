﻿using System.Collections.Generic;

namespace DraftSiteModels.ViewModels
{
    public class DraftDataViewModel
    {
        public List<DraftStartTypeViewModel> DraftStartTypes { get; set; }
        
        public List<DraftStatusViewModel> DraftStatuses { get; set; }

        public List<DraftTimeViewModel> DraftTimes { get; set; }
    }
}
