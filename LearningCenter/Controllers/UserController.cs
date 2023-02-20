using LearningCenter.Core.Contract;
using LearningCenter.Core.Domain.RequestModel;
using LearningCenter.Core.Service;
using LearningCenter.Infra.Repesitory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserRequestModel userRequestModel)
        {
            var result = _userService.AddUserAsync(userRequestModel);
            return Ok(result);
        }
    }
}
