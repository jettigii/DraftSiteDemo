using AutoMapper;
using DraftSiteModels.Entities;
using DraftSiteModels.InputModels;
using DraftSiteModels.Models;
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
            draftEntity.PickTimeId = GetDraftTimeFromSeconds(draft.PickTime.Value).Id;
            var newDraft = await _draftRepository.CreateDraft(draftEntity);
            var draftViewModel = _mapper.Map<DraftViewModel>(newDraft);
            return draftViewModel;
        }

        public async Task<DraftLobbyViewModel> GetUserLobby(string token)
        {

            var user = await _userRepository.Authenticate(token);
            var drafts = await _draftRepository.GetDrafts(user.Id);

            var userViewModel = _mapper.Map<DraftSiteUserViewModel>(user);
            var draftLobbyViewModel = _mapper.Map<List<DraftViewModel>>(drafts);

            var draftLobby = new DraftLobbyViewModel()
            {
                Drafts = draftLobbyViewModel,
                User = userViewModel
            };

            return draftLobby;
        }

        public DraftTime GetDraftTimeFromSeconds(int seconds)
        {
            return _draftRepository.GetDraftTimes().Single(draftTime => draftTime.TimeInSeconds == seconds);
        }

        public DraftDataViewModel GetDraftLookups()
        {
            return new DraftDataViewModel()
            {
                DraftTimes = _mapper.Map<List<DraftTimeViewModel>>(_draftRepository.GetDraftTimes().ToList())
            };
        }
    }
}
