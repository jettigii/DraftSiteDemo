using AutoMapper;
using DraftSiteModels.ViewModels;
using DraftSiteRepository.Interfaces;
using DraftSiteService.Interfaces;
using System.Threading.Tasks;

namespace DraftSiteService.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<DraftSiteUserViewModel> Authenticate(string token)
        {
            var user = await _userRepository.Authenticate(token);
            var userViewModel = _mapper.Map<DraftSiteUserViewModel>(user);
            return userViewModel;
        }
    }
}
