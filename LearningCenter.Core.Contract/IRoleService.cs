using LearningCenter.Core.Domain.RequestModel;
using LearningCenter.Core.Domain.ResponseModel;

namespace LearningCenter.Core.Contract
{
    public interface IRoleService
    {
        Task<List<RoleResponseModel>> GetRolesAsync();
        Task<int> AddRoleAsync(RoleRequestModel roleRequestModel);
        Task<int> UpdateRoleAsync(int id, RoleRequestModel roleRequestModel);
        Task<int> DeleteRoleAsync(int id);
    }
}
