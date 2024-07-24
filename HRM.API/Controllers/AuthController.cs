using HRM.Services.API.auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthServices _authServices;
        public AuthController(IAuthServices authServices)
        {
            _authServices = authServices ?? throw new ArgumentNullException(nameof(authServices));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {

                var data = await _authServices.Login(model);
                return Ok(data);
            }
            return BadRequest();
        }
        [HttpPost("register-user")]
        public async Task<IActionResult> RegisterUser(RegisterModel registerModel)
        {
            if (!ModelState.IsValid) return BadRequest();
            var data = await _authServices.RegisterUser(registerModel);
            return Ok(data);
        }
        [HttpPost("register-admin")]
        public async Task<IActionResult> RegisterAdmin(RegisterModel registerModel)
        {
            if (!ModelState.IsValid) return BadRequest();
            var data = await _authServices.RegisterAdmin(registerModel);
            return Ok(data);
        }
        [HttpPost("log-out")]
        public async Task<IActionResult> LogOut()
        {
            var data = await _authServices.LogOutUser();
            return Ok(data);
        }
    }
}
