using LearningCenter.Infra.Contract;
using LearningCenter.Infra.Domain.Context;
using LearningCenter.Infra.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infra.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly LearningCenterContext _learningCenterContext;

        public RoleRepository(LearningCenterContext learningCenterContext)
        {
            _learningCenterContext = learningCenterContext;
        }
        public async Task<List<Role>> GetRoles()
        {
            var roles = await _learningCenterContext.Role.ToListAsync();
            return roles;
        }

        public async Task<Role> GetRole(int id)
        {
            var role = await _learningCenterContext.Role.SingleOrDefaultAsync(x => x.Id == id);
            return role;
        }

        public async Task<Role> GetRoleByName(string name)
        {
            var role = await _learningCenterContext.Role.SingleOrDefaultAsync(x => x.Name == name);
            return role;
        }

        public async Task<int> AddRole(Role role)
        {
            await _learningCenterContext.Role.AddAsync(role);
            return await _learningCenterContext.SaveChangesAsync();
        }

        public async Task<int> UpdateRole(Role role)
        {
            _learningCenterContext.Role.Update(role);
            return await _learningCenterContext.SaveChangesAsync();
        }
    
        public async Task<int> DeleteRole(Role role)
        {
            _learningCenterContext.Role.Remove(role);
            return await _learningCenterContext.SaveChangesAsync();
        }
    }
}
