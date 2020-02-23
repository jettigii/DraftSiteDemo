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
            var userAuthToken = await _userRepository.Authenticate(token);
            var user = await _userRepository.GetUserById(userAuthToken.UserId);
            var userViewModel = _mapper.Map<DraftSiteUserViewModel>(user);
            return userViewModel;
        }

        public async Task<DraftSiteUserViewModel> GetUserByUsername(string username)
        {
            var user = await _userRepository.GetUserByUsername(username);
            var userViewModel = _mapper.Map<DraftSiteUserViewModel>(user);
            return userViewModel;
        }
    }
}
