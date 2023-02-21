using LearningCenter.Core.Contract;
using LearningCenter.Core.Domain.RequestModel;
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

        [HttpGet("get-users")]
        public async Task<IActionResult> GetAllUser()
        {
            var users = await _userService.GetUserAsync();
            return Ok(users);
        }

        [HttpGet("get-user/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userService.GetUserByIdAsync(id); 
            return Ok(user);
        }

        [HttpPost("add-user")]
        public async Task<IActionResult> Post(UserRequestModel userRequestModel)
        {
            await _userService.AddUserAsync(userRequestModel);
            return Ok("User added successfully...");
        }

        [HttpPut("update-user/{id}")]
        public async Task<IActionResult> Put(int id, UserRequestModel userRequestModel)
        {
            await _userService.UpdateUserAsync(userRequestModel, id);
            return Ok("User updated Successfully...");
        }

        [HttpDelete("delete-user/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.DeleteUserAsync(id);
            return Ok("Deleted successfully...!!!");
        }
    }
}
