using DraftSiteModels.ViewModels;
using System.Threading.Tasks;

namespace DraftSiteModels.HubModels
{
    public class HubUser
    {
        public string ConnectionId { get; set; }

        public int DraftId { get; set; }
        
        public int UserId { get; set; }

        public int TeamId { get; set; }

        public string Username { get; set; }
    }
}
