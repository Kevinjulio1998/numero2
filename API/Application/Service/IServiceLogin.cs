using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface IServiceLogin
    {
        Task<IdentityResult> SignUp(UserSignUpResource userSignUpResource);
        Task<bool> SignIn(UserLoginResource userLoginResource);

        User GetInformation(UserLoginResource userLoginResource);

    }
}
