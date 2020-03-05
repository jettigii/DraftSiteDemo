using DraftSiteModels.HubModels;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public interface IDraftHubClient
    {
        Task receiveDraftLobbyUpdate(List<DraftViewModel> drafts);
        //#region Draft
        //Task SendMessage(string message);
        //Task<HubUser> EnterDraftAsync(HubUser user);
        //KeyValuePair<int, List<HubUser>> GetUser(int userId);
        //HubUser GetHubUserByConnectionId();
        //#endregion

        //#region DraftLobby
        //Task UpdateDraftLobby();
        //Task CreateDraft(DraftInputModel draft);
        //Task<DraftLobbyViewModel> EnterDraftLobby(DraftSiteToken model);
        //#endregion

        //#region
        //Task<PreDraftViewModel> EnterPreDraftLobby(PreDraftInputModel draftLobbyRequest);
        //Task SelectTeam(TeamChoiceInputModel teamSelection);
        //Task UpdateSettings(DraftInputModel draft);
        //void SetComputerPlayer(int teamId);
        //Task StartDraft(int draftId);
        //#endregion

        //#region
        //Task SelectPlayer(PlayerChoiceInputModel playerSelection);
        //Task UpdateTimer(string time);
        //#endregion
    }
}
