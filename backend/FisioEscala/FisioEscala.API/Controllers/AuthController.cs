using FisioEscala.Application.Interfaces.Auth;
using FisioEscala.Application.ViewModels.Requests.Auth;
using Microsoft.AspNetCore.Mvc;

namespace FisioEscala.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerApi
    {
        private readonly ILoginService loginService;
        public AuthController(ILoginService loginService)
            => this.loginService = loginService;
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
            => Result(await loginService.LoginAsync(loginRequest));

        [HttpPost]
        [Route("logout")]
        public async Task<IActionResult> Logout(LoginRequest logoutRequest)
            => Result(await loginService.LogoutAsync(logoutRequest));
    }
}
