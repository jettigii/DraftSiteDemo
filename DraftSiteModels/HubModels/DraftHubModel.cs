using DraftSiteModels.ViewModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DraftSiteModels.HubModels
{
    public class DraftHubModel
    {
        private Timer _timer;

        public int DraftId { get; set; }
        public int DraftTime { get; set; }
        public TimerCallback TimerCallback { get; set; }
        public int ActiveTeamId { get; set; }
        public List<DraftTeamSummaryViewModel> DraftTeams { get; set; }

        public void StartTimer()
        {
            _timer = new Timer(TimerCallback, null, 0, DraftTime);
        }
    }
}
