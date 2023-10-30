using FisioEscala.Application.Interfaces.Users;
using FisioEscala.Application.ViewModels.Requests.Users;
using FisioEscala.Application.ViewModels.Responses.Users;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace FisioEscala.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerApi
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
            => _userService = userService;

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllUsers()
            => Result(await _userService.GetAllUsers());

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
            => Result(await _userService.GetUserById(id));

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateUser(Guid id, UserUpdateRequest user)
            => Result(await _userService.Update(id, user));
    }
}
