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

        [HttpGet("get-roles")]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleService.GetRolesAsync();
            return Ok(roles);
        }

        [HttpPost("add-role")]
        public async Task<IActionResult> Post(RoleRequestModel roleRequestModel)
        {
            await _roleService.AddRoleAsync(roleRequestModel);
            return Ok("Role Added successfully...");
        }

        [HttpPut("update-role/{id}")]
        public async Task<IActionResult> Put(int id ,RoleRequestModel roleRequestModel)
        {
            await _roleService.UpdateRoleAsync(id, roleRequestModel);
            return Ok("User updated...");
        }

        [HttpDelete("delete-role/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _roleService.DeleteRoleAsync(id);
            return Ok("Role deleted successfully..");
        }
    }
}
