using AutoMapper;
using DraftSiteModels.Data;
using DraftSiteModels.Entities;
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

            // TODO: Pull these from database
            var draftTime = DraftTimeData.DraftTimes.SingleOrDefault(draftTime => draftTime.Id == draft.PickTime);
            draftEntity.PickTimeId = draftTime.Id;
            draftEntity.OwnerId = Convert.ToUInt32(draft.UserId);
            draftEntity.DraftStatusId = 1;
            draftEntity.password = _passwordService.Hash(draftEntity.password);

            DateTime.TryParse(draft.StartTime, out var startTime);
            draftEntity.StartTime = startTime;

            var newDraft = await _draftRepository.CreateDraft(draftEntity);

            var draftTeams = await _draftRepository.GetTeams();
            var draftTeamUsers = _mapper.Map<List<DraftTeamUser>>(draftTeams);
            draftTeamUsers.Select(draftTeamUser =>
            {
                draftTeamUser.MultiPlayerDraftId = newDraft.Id;
                return draftTeamUser;
            }).ToList();
            await _draftRepository.CreateDraftTeams(draftTeamUsers);

            var draftPlayers = await _draftRepository.GetPlayers();
            var draftTeamUserPlayers = _mapper.Map<List<DraftTeamUserPlayer>>(draftPlayers);
            draftTeamUserPlayers.Select(draftTeamUserPlayer =>
            {
                draftTeamUserPlayer.DraftTeamUser = draftTeamUsers.FirstOrDefault();
                return draftTeamUserPlayer;
            }).ToList();
            await _draftRepository.CreateDraftPlayers(draftTeamUserPlayers);

            var draftViewModel = _mapper.Map<DraftViewModel>(newDraft);
            return draftViewModel;
        }

        public async Task<DraftViewModel> GetDraftAsync(int id)
        {
            var draft = await _draftRepository.GetDraftAsync(id);
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

        public async Task<DraftDataViewModel> GetDraftLookupsAsync()
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
            var draft = await _draftRepository.GetDraftAsync(draftId);

            if (!string.IsNullOrWhiteSpace(draft.password))
            {
                if (!_passwordService.Check(draft.password, password))
                {
                    throw new Exception("Incorrect Password");
                }
            }

            var draftTeams = await GetDraftTeamsAsync(draftId);
            var draftPlayers = await GetDraftPlayersAsync(draftId);

            PreDraftViewModel preDraftViewModel = new PreDraftViewModel()
            {
                Draft = _mapper.Map<DraftViewModel>(draft),
                IsOwner = draft.Owner.Username == username,
                DraftPlayers = draftPlayers,
                DraftTeams = draftTeams
            };

            return preDraftViewModel;
        }

        public async Task<DraftViewModel> UpdateDraftSettings(int draftId, int userId, DraftInputModel draft)
        {
            var draftEntity = await _draftRepository.GetDraftAsync(draftId);

            if (userId != draftEntity.OwnerId)
            {
                throw new Exception("Only owner may update draft settings!");
            }
            DateTime.TryParse(draft.StartTime, out var draftTimeValue);

            // TODO Add various start modes.
            //draftEntity.DraftStartType = draft.DraftStartType ?? draftEntity.DraftStartType;

            // TODO Add this to mapping profile
            draftEntity.DraftStartTypeId = DraftStartTypeData.DraftStartTypes.SingleOrDefault(draftStartType => draftStartType.Value == draft.DraftStartType).Id;
            draftEntity.IsComputerTeams = draft.IsComputerTeams;
            draftEntity.IsMultiSelect = draft.IsMultiSelect;
            draftEntity.IsPublic = draft.IsPublic;
            draftEntity.Name = draft.Name ?? draftEntity.Name;
            draftEntity.PickTimeId = DraftTimeData.DraftTimes.SingleOrDefault(draftTime => draftTime.Id == draft.PickTime).Id;
            draftEntity.RoundCount = draft.RoundCount;
            draftEntity.StartTime = draftTimeValue;

            if (draftEntity.IsPublic)
            {
                draftEntity.password = null;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(draft.Password))
                {
                    draftEntity.password = _passwordService.Hash(draft.Password);
                }
            }

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
            var teams = await _draftRepository.GetDraftTeamsAsync(draftId);
            return _mapper.Map<List<DraftTeamSummaryViewModel>>(teams);
        }

        public async Task DeselectTeam(DraftTeamUser draftTeamUser)
        {
            draftTeamUser.User = null;
            draftTeamUser.UsersId = 0;
            await _draftRepository.UpdateDraftTeamUser(draftTeamUser);
        }

        public async Task<List<DraftTeamSummaryViewModel>> SelectTeam(int userId, int draftId, TeamChoiceInputModel teamSelection)
        {
            var teamDraftUsers = await _draftRepository.GetDraftTeamsAsync(draftId);
            var team = teamDraftUsers.SingleOrDefault(teamDraftUser => teamDraftUser.Team.Name == teamSelection.TeamName);

            if (team.UsersId == 0)
            {
                var teamUsers = teamDraftUsers.Where(teamDraftUser => teamDraftUser.UsersId == userId);
                var draft = await _draftRepository.GetDraftAsync(draftId);

                if (draft.IsMultiSelect || !teamUsers.Any())
                {
                    var teamEntity = new DraftTeamUser()
                    {
                        UsersId = Convert.ToUInt32(userId),
                        MultiPlayerDraftId = draftId,
                        TeamsId = team.TeamsId
                    };

                    await _draftRepository.UpdateDraftTeamUser(teamEntity);
                }
                else
                {
                    throw new Exception("Only one team may be selected.");
                }
            }
            else
            {
                await DeselectTeam(team);
            }

            return await GetDraftTeamsAsync(draftId);
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
            var draft = await _draftRepository.GetDraftAsync(draftId);
            var draftViewModel = _mapper.Map<DraftViewModel>(draft);
            return draftViewModel;
        }

        public async Task StartDraftAsync(int draftId)
        {
            var draft = await _draftRepository.GetDraftAsync(draftId);
            draft.DraftStatusId = DraftStatusData.DraftStatuses.Single(status => status.Name == "InProgress").Id;
            draft.DraftStatus = null;
            await _draftRepository.SaveChangesAsync();
        }





        //var draft = await GetDraftAsync(draftId);
        //var draftTeamPickOrder = await _draftRepository.GetDraftTeamPickOrderAsync(draftId);
        //var players = await _draftRepository.GetDraftPlayersAsync(draftId);

        //var multiPlayerDraftViewModel = new MultiplayerDraftViewModel()
        //{

        //};
    }
}
