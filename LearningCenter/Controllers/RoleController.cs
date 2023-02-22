using LearningCenter.Core.Contract;
using LearningCenter.Core.Domain.RequestModel;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("roles")]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleService.GetRolesAsync();
            return Ok(roles);
        }

        [HttpPost("role")]
        public async Task<IActionResult> Post([FromForm] RoleRequestModel roleRequestModel)
        {
            await _roleService.AddRoleAsync(roleRequestModel);
            return Ok("Role Added successfully...");
        }

        [HttpPut("roles/{id}")]
        public async Task<IActionResult> Put(int id , [FromForm] RoleRequestModel roleRequestModel)
        {
            await _roleService.UpdateRoleAsync(id, roleRequestModel);
            return Ok("User updated...");
        }

        [HttpDelete("roles/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _roleService.DeleteRoleAsync(id);
            return Ok("Role deleted successfully..");
        }
    }
}
