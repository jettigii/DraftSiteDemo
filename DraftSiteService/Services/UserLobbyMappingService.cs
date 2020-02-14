using DraftSiteModels.HubModels;
using DraftSiteService.Interfaces;
using System.Collections.Concurrent;

namespace DraftSiteService.Services
{
    public class UserLobbyMappingService : IUserLobbyMappingService
    {
        private ConcurrentDictionary<int, ConcurrentDictionary<string, HubUser>> _lobbies;

        public UserLobbyMappingService()
        {
            _lobbies = new ConcurrentDictionary<int, ConcurrentDictionary<string, HubUser>>();
        }

        public HubUser AddUser(HubUser newUser)
        {
            var lobby = _lobbies.GetOrAdd(newUser.DraftId, new ConcurrentDictionary<string, HubUser>());
            var user = lobby.GetOrAdd(newUser.Username, newUser);
            return user;
        }

        public HubUser GetUser(int draftId, string username)
        {
            _lobbies.TryGetValue(draftId, out var preDraftLobby);
            preDraftLobby.TryGetValue(username, out var user);
            return user;
        }
    }
}
