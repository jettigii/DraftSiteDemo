using DraftSiteApi.Data;
using DraftSiteApi.Hubs;
using DraftSiteModels.InputModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceStack.Redis;
using StackExchange.Redis;
using System;
using System.Diagnostics;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DraftSiteApi.HostedServices
{
    public class DraftHostedService : BackgroundService
    {
        private readonly IHubContext<DraftHub, IDraftHubClient> _draftHub;
        public IServiceScopeFactory _serviceScopeFactory;
        private readonly ConnectionMultiplexer _redis;

        public DraftHostedService(IHubContext<DraftHub, IDraftHubClient> draftHub, IServiceScopeFactory serviceScopeFactory)
        {
            _draftHub = draftHub;
            _serviceScopeFactory = serviceScopeFactory;
            _redis = ConnectionMultiplexer.Connect("localhost,allowAdmin=true");
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var subscription = _redis.GetSubscriber();
            
            await subscription.SubscribeAsync(DraftSiteConstants.DRAFT_LOBBY_CHANGE, async (channel, message) =>
            {
                await UpdateLobby();
            });

            await subscription.SubscribeAsync(DraftSiteConstants.CREATE_DRAFT, async (channel, message) =>
            {                                
                await CreateDraft(message);
            });

            await subscription.SubscribeAsync(DraftSiteConstants.UPDATE_DRAFT_SETTINGS, async (channel, message) =>
            {
                await UpdateDraftSettings(message);
            });

            await UpdateLobby();
        }

        public async Task UpdateLobby()
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                IDraftService draftService = scope.ServiceProvider.GetRequiredService<IDraftService>();
                var drafts = await draftService.GetUserLobby();
                var draftString = JsonSerializer.Serialize(drafts);
                var publisher = _redis.GetSubscriber();
                await publisher.PublishAsync(DraftSiteConstants.DRAFT_LOBBY, draftString);
            }
        }

        private async Task CreateDraft(string message)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                IDraftService draftService = scope.ServiceProvider.GetRequiredService<IDraftService>();
                Debug.WriteLine("CreateDraft" + message);

                var draft = JsonSerializer.Deserialize<DraftInputModel>(message);
                await draftService.CreateDraftAsync(draft);

                await UpdateLobby();

                var manager = new RedisManagerPool("localhost");

                using (var client = manager.GetClient())
                {
                    message = client.Get<string>(DraftSiteConstants.CREATE_DRAFT);


                }

                Debug.WriteLine("MESSAGE: " + message);
            }
        }

        private async Task UpdateDraft(string message)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                IDraftService draftService = scope.ServiceProvider.GetRequiredService<IDraftService>();
                Debug.WriteLine("CreateDraft" + message);

                var draft = JsonSerializer.Deserialize<DraftInputModel>(message);
                await draftService.UpdateDraftSettings(draft., draft);

                await UpdateLobby();

                var manager = new RedisManagerPool("localhost");

                using (var client = manager.GetClient())
                {
                    message = client.Get<string>(DraftSiteConstants.CREATE_DRAFT);


                }

                Debug.WriteLine("MESSAGE: " + message);
            }
        }
    }
}
