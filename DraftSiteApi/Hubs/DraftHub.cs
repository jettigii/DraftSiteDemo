using DraftSiteApi.Data;
using DraftSiteModels.HubModels;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace DraftSiteApi.Hubs
{
    public class DraftHub : Hub<IDraftHubClient>
    {
        // Services
        protected readonly IDraftService _draftService;
        protected readonly IUserService _userService;
        private readonly ConnectionMultiplexer _redis;

        // Groups
        private const string DRAFT_LOBBY = "DraftLobby";
        private const string DRAFT_LOBBY_CHAT = "DraftLobbyChat";
        private const string MULTI_PLAYER_DRAFT_LOBBY = "MultiPlayerDraftLobby";

        // Client Method Names
        private const string RECEIVE_DRAFT_LOBBY_UPDATE = "receiveDraftLobbyUpdate";

        private static bool IsInitialized = false;

        private const string PreDraftGroup = "PreDraftGroup";
        private const string PostDraftGroup = "PostDraftGroup";

        private static Dictionary<string, HubUser> _userMap = new Dictionary<string, HubUser>();

        public DraftHub(IServiceScopeFactory scopeFactory)
        {
            _draftService = scopeFactory.CreateScope().ServiceProvider.GetRequiredService<IDraftService>();
            _userService = scopeFactory.CreateScope().ServiceProvider.GetRequiredService<IUserService>();
            _redis = ConnectionMultiplexer.Connect("localhost,allowAdmin=true");
        }

        public async Task<DraftLobbyViewModel> JoinDraftLobbyAsync(DraftSiteToken token)
        {
            var user = await _userService.AuthenticateAsync(token.Token);

            // Join Draft Lobby Group
            await Groups.AddToGroupAsync(Context.ConnectionId, DRAFT_LOBBY);

            // Join Draft Lobby Chat Room
            await Groups.AddToGroupAsync(Context.ConnectionId, DRAFT_LOBBY_CHAT);

            var subscription = _redis.GetSubscriber();
            await subscription.SubscribeAsync(DRAFT_LOBBY, async (channel, message) =>
            {
                var lobby = JsonSerializer.Deserialize<List<DraftViewModel>>(message);
                await SendDraftLobbyUpdate(message);
            });

            if (!IsInitialized)
            {
                var endpoints = _redis.GetEndPoints();
                var server = _redis.GetServer(endpoints[0]);
                server.FlushAllDatabases();

                await UpdateDraftLobby();
            }

            await UpdateDraftLobby();

            var lookups = await _draftService.GetDraftLookupsAsync();

            var draftSiteViewModel = new DraftLobbyViewModel()
            {
                Lookups = lookups,
                User = user
            };

            var hubUser = new HubUser()
            {
                connectionId = Context.ConnectionId,
                DraftId = 0,
                TeamId = 0,
                UserId = user.Id,
                Username = user.Username
            };

            _userMap.TryAdd(Context.ConnectionId, hubUser);

            return draftSiteViewModel;
        }

        private async Task SendDraftLobbyUpdate(string draftString)
        {
            var drafts = JsonSerializer.Deserialize<List<DraftViewModel>>(draftString);
            await Clients.Groups(DRAFT_LOBBY).receiveDraftLobbyUpdate(drafts);
        }

        private async Task UpdateDraftLobby()
        {
            try
            {
                var drafts = await _draftService.GetUserLobby();
                var draftString = JsonSerializer.Serialize(drafts);
                var publisher = _redis.GetSubscriber();
                await publisher.PublishAsync(DRAFT_LOBBY, draftString);
            }
            catch (Exception ex)
            {
            }
        }

        public async Task CreateDraft(DraftInputModel draft)
        {
            try
            {
                _userMap.TryGetValue(Context.ConnectionId, out var currentUser);
                draft.UserId = currentUser.UserId;


                var draftString = JsonSerializer.Serialize(draft);
                var publisher = _redis.GetSubscriber();
                await publisher.PublishAsync(DraftSiteConstants.CREATE_DRAFT, draftString);
            }
            catch (Exception ex)
            {
            }
        }

        public async Task UpdateDraftSettings(DraftInputModel draft)
        {
            try
            {
                _userMap.TryGetValue(Context.ConnectionId, out var currentUser);
                draft.UserId = currentUser.UserId;
                draft.DraftId = currentUser.DraftId;

                var draftString = JsonSerializer.Serialize(draft);
                var publisher = _redis.GetSubscriber();
                await publisher.PublishAsync(DraftSiteConstants.UPDATE_DRAFT_SETTINGS, draftString);
            }
            catch (Exception ex)
            {
            }
        }




        //#region Draft
        public async Task SendMessage(string message)
        {
            //var user = GetHubUserByConnectionId();

            //var newMessage = new ChatMessageViewModel()
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    Username = user.Username,
            //    Message = message
            //};

            //await Clients.Group(user.DraftId.ToString()).SendAsync("receiveMessage", newMessage);
        }



        //protected async Task<HubUser> EnterDraftAsync(HubUser user)
        //{
        //    user.connectionId = Context.ConnectionId;
        //    var isConnected = _users.Keys.Any(key => key == user.UserId);

        //    if (isConnected)
        //    {
        //        _users.SingleOrDefault(u => u.Key == user.UserId).Value.Add(user);
        //    }
        //    else
        //    {
        //        _users.TryAdd(user.UserId, new List<HubUser>()
        //        {
        //            user
        //        });
        //    }

        //    await Groups.AddToGroupAsync(Context.ConnectionId, user.DraftId.ToString());
        //    return user;
        //}

        //protected async Task<List<int>> CheckForActiveDrafts(int userId)
        //{
        //    return new List<int>();
        //}

        //public override Task OnConnectedAsync()
        //{
        //    return base.OnConnectedAsync();
        //}

        public override Task OnDisconnectedAsync(Exception exception)
        {
            //try
            //{
            // TODO Remove from all groups
            //    var hubUser = GetHubUserByConnectionId();
            //    _users.Single(u => u.Key == hubUser.UserId).Value.Remove(hubUser);
            //}
            //catch { }

            return base.OnDisconnectedAsync(exception);
        }

        //protected KeyValuePair<int, List<HubUser>> GetUser(int userId)
        //{
        //    return _users.SingleOrDefault(connection => connection.Key == userId);
        //}

        //protected HubUser GetHubUserByConnectionId()
        //{
        //    var users = _users.SelectMany(u => u.Value).ToList();
        //    var user = users.SingleOrDefault(u => u.connectionId == Context.ConnectionId);
        //    return user;
        //}
        //#endregion

        //#region DraftLobby
        //public async Task CreateDraft(DraftInputModel draft)
        //{
        //    try
        //    {
        //        var user = GetHubUserByConnectionId();
        //        draft.UserId = user.UserId;
        //        await _draftService.CreateDraftAsync(draft);
        //        await UpdateDraftLobby();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        //public async Task<DraftLobbyViewModel> EnterDraftLobby(DraftSiteToken model)
        //{
        //    var authenticatedUser = await _userService.Authenticate(model.Token);

        //    var user = new HubUser()
        //    {
        //        DraftId = 0,
        //        Username = authenticatedUser.Username,
        //        UserId = authenticatedUser.Id
        //    };

        //    await EnterDraftAsync(user);

        //    var drafts = await _draftService.GetUserLobby();

        //    if (drafts == null)
        //    {
        //        drafts = new List<DraftViewModel>();
        //    }

        //    var lookups = await _draftService.GetDraftLookupsAsync();

        //    var userLobby = new DraftLobbyViewModel()
        //    {
        //        Drafts = drafts,
        //        Lookups = lookups,
        //        User = new DraftSiteUserViewModel()
        //        {
        //            Id = authenticatedUser.Id,
        //            Username = user.Username
        //        }
        //    };

        //    return userLobby;
        //}
        //#endregion

        //#region PreDraft Lobby
        //public async Task<PreDraftViewModel> EnterPreDraftLobby(PreDraftInputModel draftLobbyRequest)
        //{
        //    try
        //    {
        //        var draftId = Convert.ToInt32(draftLobbyRequest.DraftId);

        //        var user = GetUser(draftLobbyRequest.UserId);

        //        var draftUser = new HubUser()
        //        {
        //            DraftId = draftId,
        //            UserId = user.Key,
        //            Username = user.Value.First().Username
        //        };

        //        await EnterDraftAsync(draftUser);

        //        var preDraftLobbyData = await _draftService.GetPreDraftLobby(draftId, draftUser.Username, draftLobbyRequest.Password);
        //        preDraftLobbyData.Lookups = await _draftService.GetDraftLookupsAsync();

        //        await Groups.AddToGroupAsync(Context.ConnectionId, draftLobbyRequest.DraftId.ToString());

        //        var alert = new ChatMessageViewModel()
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Username = "System",
        //            Message = draftUser.Username + " has joined the lobby."
        //        };

        //        await Clients.Group(draftLobbyRequest.DraftId.ToString()).SendAsync("receiveMessage", alert);

        //        return preDraftLobbyData;
        //    }
        //    catch (Exception ex)
        //    {
        //        await Clients.Client(Context.ConnectionId).SendAsync("receiveMessage", "Lobby join error.");
        //    }
        //    return null;
        //}

        //public async Task SelectTeam(TeamChoiceInputModel teamSelection)
        //{
        //    var user = GetHubUserByConnectionId();
        //    var teams = await _draftService.SelectTeam(user.UserId, user.DraftId, teamSelection);
        //    await Clients.Group(user.DraftId.ToString()).SendAsync("receiveTeamsUpdate", teams);
        //}

        //public async Task UpdateSettings(DraftInputModel draft)
        //{
        //    var user = GetHubUserByConnectionId();
        //    var newSettings = await _draftService.UpdateDraftSettings(user.DraftId, user.UserId, draft);
        //    await Clients.Group(newSettings.Id.ToString()).SendAsync("receiveSettingsUpdate", newSettings);
        //}

        //public void SetComputerPlayer(int teamId)
        //{

        //}

        //public async Task StartDraft(int draftId)
        //{
        //    await _draftService.StartDraftAsync(draftId);

        //    // start the draft for real
        //}
        //#endregion

        //#region MultiPlayer Draft
        //public async Task SelectPlayer(PlayerChoiceInputModel playerSelection)
        //{
        //    var user = GetHubUserByConnectionId();
        //    //var draft = _drafts.SingleOrDefault(d => d.Key == user.DraftId).Value;
        //    //await _draftService.SelectPlayer(user.UserId, user.DraftId, draft.ActiveTeamId, playerSelection);





        //    //draft.StartTimer();
        //    //var teams = _draftService.SelectTeam(user.UserId, teamSelection);
        //    //await Clients.Group(user.DraftId.ToString()).SendAsync("receiveTeamsUpdate", teams);
        //}

        //public async Task UpdateTimer(string time)
        //{
        //    await Clients.All.SendAsync("updateTimer", "draft-update", time);
        //}
        //#endregion
    }
}
