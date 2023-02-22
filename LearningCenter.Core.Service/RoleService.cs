using AutoMapper;
using LearningCenter.Core.Builder;
using LearningCenter.Core.Contract;
using LearningCenter.Core.Domain.RequestModel;
using LearningCenter.Core.Domain.ResponseModel;
using LearningCenter.Infra.Contract;

namespace LearningCenter.Core.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository roleRepository,IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<int> AddRoleAsync(RoleRequestModel roleRequestModel)
        {
            var role = RoleBuilder.Build(roleRequestModel);
            var result = await _roleRepository.AddRole(role);
            if (result == 0)
            {
                throw new Exception("Role not added...!!!");
            }
            return result;
        }

        public async Task<List<RoleResponseModel>> GetRolesAsync()
        {
            var roles =await _roleRepository.GetRoles();
            if(roles == null)
            {
                throw new Exception("Role not found...");
            }
            var result = _mapper.Map<List<RoleResponseModel>>(roles);
            return result;
        }

        public async Task<int> UpdateRoleAsync( int id ,RoleRequestModel roleRequestModel)
        {
            var role = await _roleRepository.GetRole(id);
            if (role == null)
            {
                throw new Exception("Role not found...!!!");
            }
            role.Name = roleRequestModel.Name;
            var result = await _roleRepository.UpdateRole(role);
            if(result == 0)
            {
                throw new Exception("User not added...!!! , Enter valid data");
            }
            return result;
        }

        public async Task<int> DeleteRoleAsync(int id)
        {
            var role = await _roleRepository.GetRole(id);
            if (role == null)
            {
                throw new Exception("Role not found...!!!");
            }
            return await _roleRepository.DeleteRole(role);
        }
    }
}
