using DraftSiteApi.Data;
using DraftSiteApi.Hubs;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.SignalR;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteApi.Controllers
{
    public class DraftController : IDraftController
    {
        private readonly IHubContext<DraftHub, IDraftHubClient> _draftHub;
        private readonly IDraftService _draftService;
        private readonly ConnectionMultiplexer _redis;

        public DraftController(IHubContext<DraftHub, IDraftHubClient> draftHub, IDraftService draftService)
        {
           _draftHub = draftHub;
            _draftService = draftService;
            _redis = ConnectionMultiplexer.Connect("localhost,allowAdmin=true");
            var subscription = _redis.GetSubscriber();
            //var draftLobby = _draftHub.g
            //subscription.Publish(DraftSiteConstants.DRAFT_LOBBY, )
            subscription.Subscribe(DraftSiteConstants.DRAFT_LOBBY, async (channel, message) =>
            {
                UpdateLobby();
            });

        }

        private void UpdateLobby()
        {

        }
    }
}
