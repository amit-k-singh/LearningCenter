using LearningCenter.Infra.Domain.Entities;

namespace LearningCenter.Infra.Contract
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetRoles();
        Task<Role> GetRole(int id);
        Task<Role> GetRoleByName(string name);
        Task<int> AddRole(Role role);
        Task<int> UpdateRole(Role role);
        Task<int> DeleteRole(Role role);
    }
}
