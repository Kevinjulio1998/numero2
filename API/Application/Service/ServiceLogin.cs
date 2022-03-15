using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ServiceLogin : IServiceLogin
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public ServiceLogin(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<IdentityResult> SignUp(UserSignUpResource userSignUpResource)
        {
            var user = _mapper.Map<UserSignUpResource,User> (userSignUpResource);

            var identityResult = await _userManager.CreateAsync(user, userSignUpResource.Password);

            return identityResult;
        }

        public async Task<bool> SignIn(UserLoginResource userLoginResource)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.UserName == userLoginResource.Email);

            var userSigninResult = await _userManager.CheckPasswordAsync(user, userLoginResource.Password);

            return userSigninResult;
        }
        public User GetInformation(UserLoginResource userLoginResource)
        {
            return _userManager.Users.SingleOrDefault(u => u.UserName == userLoginResource.Email);
        }

    }
}
