using LearningCenter.Core.Builder;
using LearningCenter.Core.Contract;
using LearningCenter.Core.Domain.RequestModel;
using LearningCenter.Infra.Repesitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter.Core.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUserAsync(UserRequestModel userRequestModel)
        {
            int age = 0;
            var user = UserBuilder.Build(userRequestModel, age);
            await _userRepository.AddUser(user);
        }
    }
}
