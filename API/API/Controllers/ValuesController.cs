using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IServiceLogin _services;

        public ValuesController(IServiceLogin authServices)
        {
            _services = authServices;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] UserSignUpResource userSignUpResource)
        {
            var userCreateResult = await _services.SignUp(userSignUpResource);

            if (userCreateResult.Succeeded)
            {
                return Created(string.Empty, string.Empty);
            }

            return Problem(userCreateResult.Errors.First().Description, null, 500);
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn([FromBody] UserLoginResource userLoginResource)
        {

            var userSigninResult = await _services.SignIn(userLoginResource);

            if (userSigninResult)
            {
                var getuser = _services.GetInformation(userLoginResource);
                return Ok(new { id = getuser.Id, firstName = getuser.FirstName, lastName = getuser.LastName});
            }
            return Problem(statusCode:401);
        }
    }
}
