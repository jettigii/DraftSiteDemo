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
        private readonly IDraftRepository _draftRepository;
        private readonly IPasswordService _passwordService;
        private readonly IMapper _mapper;

        public DraftService(IDraftRepository draftRepository, IPasswordService passwordService, IMapper mapper)
        {
            _draftRepository = draftRepository;
            _passwordService = passwordService;
            _mapper = mapper;
        }

        public async Task<DraftViewModel> CreateDraft(DraftInputModel draft)
        {
            var draftEntity = _mapper.Map<Draft>(draft);
            var draftTime = await GetDraftTimeFromSeconds(draft.PickTime.Value);
            draftEntity.PickTimeId = draftTime.Id;
            draftEntity.OwnerId = draft.UserId;
            draftEntity.DraftStatusId = 1;

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

            return preDraftLobbyViewModel;
        }

        public async Task<DraftViewModel> UpdateDraftSettings(DraftInputModel draft)
        {
            var draftEntity = _mapper.Map<Draft>(draft);
            var updatedDraft = await _draftRepository.UpdateDraftSettings(draftEntity);
            var preDraftLobbyViewModel = _mapper.Map<DraftViewModel>(updatedDraft);
            return preDraftLobbyViewModel;
        }

        public Task<PreDraftViewModel> GetPreDraftLobby(int draftId, int userId, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}
