using AutoMapper;
using DraftSiteModels.Entities;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;
using DraftSiteRepository.Interfaces;
using DraftSiteService.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteService.Services
{
    public class DraftService : IDraftService
    {
        private readonly IUserRepository _userRepository;
        private readonly IDraftRepository _draftRepository;
        private readonly IMapper _mapper;

        public DraftService(IUserRepository userRepository, IDraftRepository draftRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _draftRepository = draftRepository;
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
    }
}
