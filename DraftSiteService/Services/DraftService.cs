using AutoMapper;
using DraftSiteModels.Entities;
using DraftSiteModels.HubModels;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using DraftSiteRepository.Interfaces;
using DraftSiteService.Interfaces;
using FiniTechSolutions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteService.Services
{
    public class DraftService : IDraftService
    {
        private readonly IPasswordService _passwordService;
        private readonly IDraftRepository _draftRepository;
        private readonly IMapper _mapper;

        public DraftService(IPasswordService passwordService, IDraftRepository draftRepository, IMapper mapper)
        {
            _passwordService = passwordService;
            _draftRepository = draftRepository;
            _mapper = mapper;
        }

        public async Task<DraftViewModel> CreateDraftAsync(DraftInputModel draft)
        {
            var draftEntity = _mapper.Map<MultiplayerDraft>(draft);

            var draftTime = await GetDraftTimeFromSeconds(draft.PickTime);
            draftEntity.PickTimeId = draftTime.Id;
            draftEntity.OwnerId = Convert.ToUInt32(draft.UserId);
            draftEntity.DraftStatusId = 1;
            draftEntity.password = _passwordService.Hash(draftEntity.password);

            DateTime.TryParse(draft.StartTime, out var startTime);
            draftEntity.StartTime = startTime;

            var newDraft = await _draftRepository.CreateDraft(draftEntity);

            var draftTeams = await GetTeams();
            var draftTeamUsers = _mapper.Map<List<DraftTeamUser>>(draftTeams);
            await _draftRepository.CreateDraftTeams(draftTeamUsers);

            var draftPlayers = await GetPlayers();
            var draftTeamUserPlayers = _mapper.Map<List<DraftTeamUserPlayer>>(draftPlayers);
            await _draftRepository.CreateDraftPlayers(draftTeamUserPlayers);

            var draftViewModel = _mapper.Map<DraftViewModel>(newDraft);
            return draftViewModel;
        }

        public async Task<DraftViewModel> GetDraftAsync(int id)
        {
            var draft = await _draftRepository.GetDraft(id);
            var draftViewModel = _mapper.Map<DraftViewModel>(draft);
            return draftViewModel;
        }

        public async Task<List<DraftViewModel>> GetUserLobby()
        {
            var drafts = await _draftRepository.GetDrafts();
            var draftLobbyViewModel = _mapper.Map<List<DraftViewModel>>(drafts);
            return draftLobbyViewModel;
        }

        public async Task<DraftTime> GetDraftTimeFromSeconds(int seconds)
        {
            var draftTimes = await _draftRepository.GetDraftTimes();
            return draftTimes.Single(draftTime => draftTime.TimeInSeconds == seconds);
        }

        public async Task<DraftDataViewModel> GetDraftLookups()
        {
            var draftTimes = await _draftRepository.GetDraftTimes();
            var draftStatuses = await _draftRepository.GetDraftStatuses();
            var draftStartTypes = await _draftRepository.GetStartTypes();

            return new DraftDataViewModel()
            {
                DraftStartTypes = _mapper.Map<List<DraftStartTypeViewModel>>(draftStartTypes),
                DraftStatuses = _mapper.Map<List<DraftStatusViewModel>>(draftStatuses),
                DraftTimes = _mapper.Map<List<DraftTimeViewModel>>(draftTimes),
            };
        }

        public async Task<PreDraftViewModel> GetPreDraftLobby(int draftId, string username, string password)
        {
            var draft = await _draftRepository.GetDraft(draftId);

            if (!string.IsNullOrWhiteSpace(draft.password))
            {
                if (!_passwordService.Check(draft.password, password))
                {
                    throw new Exception("Incorrect Password");
                }
            }

            //var draftPlayers = await GetDraftPlayersAsync(draftId);
            var draftTeams = await GetDraftTeamsAsync(draftId);

            PreDraftViewModel preDraftViewModel = new PreDraftViewModel()
            {
                Draft = _mapper.Map<DraftViewModel>(draft),
                IsOwner = draft.Owner.Username == username,
                //DraftPlayers = draftPlayers,
                DraftTeams = draftTeams
            };

            return preDraftViewModel;
        }

        public async Task<DraftViewModel> UpdateDraftSettings(int draftId, DraftInputModel draft)
        {
            var draftEntity = _mapper.Map<MultiplayerDraft>(draft);
            draftEntity.Id = draftId;
            var updatedDraft = await _draftRepository.UpdateDraftSettings(draftEntity);
            var preDraftLobbyViewModel = _mapper.Map<DraftViewModel>(updatedDraft);
            return preDraftLobbyViewModel;
        }

        public async Task<List<DraftPlayerViewModel>> GetPlayers()
        {
            var players = await _draftRepository.GetPlayers();
            return _mapper.Map<List<DraftPlayerViewModel>>(players);
        }

        public async Task<List<DraftTeamSummaryViewModel>> GetTeams()
        {
            var teams = await _draftRepository.GetTeams();
            return _mapper.Map<List<DraftTeamSummaryViewModel>>(teams);
        }

        public async Task<List<DraftPlayerViewModel>> GetDraftPlayersAsync(int draftId)
        {
            var players = await _draftRepository.GetDraftPlayersAsync(draftId);
            var playerViewModels = _mapper.Map<List<DraftPlayerViewModel>>(players);
            return playerViewModels;
        }

        public async Task<List<DraftTeamSummaryViewModel>> GetDraftTeamsAsync(int draftId)
        {
            var teams = await _draftRepository.GetTeams();
            return _mapper.Map<List<DraftTeamSummaryViewModel>>(teams);
        }

        public async Task<List<DraftTeamSummaryViewModel>> DeselectTeam(int userId, TeamChoiceInputModel teamSelection)
        {
            await _draftRepository.DeleteDraftTeamUser(userId, teamSelection.DraftId, teamSelection.TeamId);
            return await GetTeams();
        }

        public async Task<List<DraftTeamSummaryViewModel>> SelectTeam(int userId, int draftId, TeamChoiceInputModel teamSelection)
        {
            var teamDraftUsers = await _draftRepository.GetDraftTeamsAsync(draftId);
            var teamUsers = teamDraftUsers.Where(teamDraftUser => teamDraftUser.UserId == userId);
            var draft = await _draftRepository.GetDraft(draftId);

            if (draft.IsMultiSelect || teamUsers.Any())
            {
                var teamEntity = _mapper.Map<DraftTeamUser>(teamSelection);
                teamEntity.UserId = Convert.ToUInt32(userId);
                // TODO: THIS NEEDS FIXED
                //teamEntity.UserId = Convert.ToInt32(user.Id);
                await _draftRepository.CreateDraftTeamUser(teamEntity);
                return await GetTeams(); throw new NotImplementedException();
            }
            else
            {
                throw new Exception("Only one team may be selected.");
            }
        }

        public async Task<List<DraftTeamSummaryViewModel>> SelectPlayer(int userId, int draftId, int teamId, PlayerChoiceInputModel playerSelection)
        {
            //var draftTeamPlayerUser = _draftRepository.CreateDraftTeamPlayerUser(userId, teamId, draftId, playerSelection.PlayerId);
            //var teamDraftUsers = await _draftRepository.GetDraftTeamsAsync(draftId);
            //var teamUsers = teamDraftUsers.Where(teamDraftUser => teamDraftUser.UserId == userId);
            //var draft = await _draftRepository.GetDraft(draftId);
            return new List<DraftTeamSummaryViewModel>();

        }

        public async Task<DraftViewModel> GetDraft(int draftId)
        {
            var draft = await _draftRepository.GetDraft(draftId);
            var draftViewModel = _mapper.Map<DraftViewModel>(draft);
            return draftViewModel;
        }

        public async Task StartDraftAsync(int draftId)
        {
            var draft = GetDraftAsync(draftId);
            var draftTeamPickOrder = _draftRepository.GetDraftTeamPickOrderAsync(draftId);

            //var draftHubModel = new DraftHubModel()
            //{
            //    ActiveTeamId
            //};
        }
    }
    }
