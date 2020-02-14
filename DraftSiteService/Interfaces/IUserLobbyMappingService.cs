using DraftSiteModels.HubModels;

namespace DraftSiteService.Interfaces
{
    public interface IUserLobbyMappingService
    {
        HubUser AddUser(HubUser newUser);

        HubUser GetUser(int draftId, string username);
    }
}
