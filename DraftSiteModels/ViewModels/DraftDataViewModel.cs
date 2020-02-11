using System.Collections.Generic;

namespace DraftSiteModels.ViewModels
{
    public class DraftDataViewModel
    {
        public List<DraftTimeViewModel> DraftTimes { get; set; }

        public List<DraftStatusViewModel> DraftStatuses { get; set; }
    }
}
