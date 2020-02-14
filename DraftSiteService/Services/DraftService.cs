using AutoMapper;
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
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public DraftService(IPasswordService passwordService, IDraftRepository draftRepository, IUserRepository userRepository, IMapper mapper)
        {
            _passwordService = passwordService;
            _draftRepository = draftRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<DraftViewModel> CreateDraft(DraftInputModel draft)
        {
            var draftEntity = _mapper.Map<Draft>(draft);
            var draftTime = await GetDraftTimeFromSeconds(draft.PickTime);
            draftEntity.PickTimeId = draftTime.Id;
            draftEntity.OwnerId = draft.UserId;
            draftEntity.DraftStatusId = 1;
            // TODO Create draft players to allow for custom players or removal of players.
            var newDraft = await _draftRepository.CreateDraft(draftEntity);
            var draftViewModel = _mapper.Map<DraftViewModel>(newDraft);
            return draftViewModel;
        }

        public async Task<DraftViewModel> GetDraft(int id)
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

            return new DraftDataViewModel()
            {
                DraftTimes = _mapper.Map<List<DraftTimeViewModel>>(draftTimes),
                DraftStatuses = _mapper.Map<List<DraftStatusViewModel>>(draftStatuses)
            };
        }

        public async Task<PreDraftViewModel> GetPreDraftLobby(int draftId, string username, string password)
        {
            var draft = await _draftRepository.GetDraft(draftId);

            if (!_passwordService.Check(draft.password, password))
            {
                throw new Exception("Incorrect Password");
            }

            var preDraftLobbyViewModel = _mapper.Map<PreDraftViewModel>(draft);

            if (draft.Owner.Username == username)
            {
                preDraftLobbyViewModel.IsOwner = true;
            }

            preDraftLobbyViewModel.DraftPlayers = await GetPlayers();

            // TODO These players need to be DraftPlayerUserViewModel
            preDraftLobbyViewModel.DraftTeams = await GetTeams();

            return preDraftLobbyViewModel;
        }

        public async Task<DraftViewModel> UpdateDraftSettings(DraftInputModel draft)
        {
            var draftEntity = _mapper.Map<Draft>(draft);
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

        public async Task<List<DraftTeamSummaryViewModel>> DeselectTeam(string username, int draftId, int teamId)
        {
            var user = await _userRepository.GetUserByUsername(username);
            await _draftRepository.DeleteDraftTeamUser(user.Id, draftId, teamId);
            return await GetTeams();
        }

        public async Task<List<DraftTeamSummaryViewModel>> SelectTeam(string username, TeamChoiceInputModel teamSelection)
        {
            var user = await _userRepository.GetUserByUsername(username);
            var teamEntity = _mapper.Map<DraftTeamUser>(teamSelection);
            teamEntity.UserId = user.Id;
            await _draftRepository.CreateDraftTeamUser(user.Id, teamEntity);
            return await GetTeams(); throw new NotImplementedException();
        }
    }
}
