using LearningCenter.Infra.Contract;
using LearningCenter.Infra.Domain.Context;
using LearningCenter.Infra.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infra.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly MyDbContext _myDbContext;

        public RoleRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public async Task<List<Role>> GetRoles()
        {
            var roles = await _myDbContext.Role.ToListAsync();
            return roles;
        }

        public async Task<Role> GetRole(int id)
        {
            var role = await _myDbContext.Role.SingleOrDefaultAsync(x => x.Id == id);
            return role;
        }

        public async Task<int> AddRole(Role role)
        {
            await _myDbContext.Role.AddAsync(role);
            return await _myDbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateRole(Role role)
        {
            _myDbContext.Role.Update(role);
            return await _myDbContext.SaveChangesAsync();
        }
    
        public async Task<int> DeleteRole(Role role)
        {
            _myDbContext.Role.Remove(role);
            return await _myDbContext.SaveChangesAsync();
        }
    }
}
