using DraftSiteModels.InputModels;
using DraftSiteService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public class MultiPlayerDraftHub : DraftHub
    {
        public MultiPlayerDraftHub(IDraftService draftService, IUserService userService) : base(draftService, userService) { }

        public async Task SelectPlayer(PlayerChoiceInputModel playerSelection)
        {
            var user = _connections.SingleOrDefault(connection => connection.ConnectionId == Context.ConnectionId);
            //var teams = _draftService.SelectTeam(user.UserId, teamSelection);
            //await Clients.Group(user.DraftId.ToString()).SendAsync("receiveTeamsUpdate", teams);
        }

        public async Task EnterDraftLobby()
        {

        }

        public async Task DeselectTeam(TeamChoiceInputModel teamSelection)
        {
            var user = _connections.SingleOrDefault(connection => connection.ConnectionId == Context.ConnectionId);
            var teams = _draftService.DeselectTeam(user.UserId, teamSelection);
            //await Clients.Group(user.DraftId.ToString()).SendAsync("receiveTeamsUpdate", teams);
        }


        public async Task UpdateTimer(string time)
        {
            await Clients.All.SendAsync("updateTimer", time);
        }

        protected async Task StartDraft()
        {

        }


        protected async Task ChoosePlayer(int playerId)
        {
            // create the entity through the service

            // find next team decision

            // send basic update to all players except next team decision send decision data model
        }
    }
}
