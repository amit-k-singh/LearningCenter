using AutoMapper;
using LearningCenter.Core.Builder;
using LearningCenter.Core.Contract;
using LearningCenter.Core.Domain.RequestModel;
using LearningCenter.Core.Domain.ResponseModel;
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
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository ,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<UserResponseModel>> GetUserAsync()
        {
            var user = await _userRepository.GetUsers();
            if (user == null)
            {
                throw new NullReferenceException("User not found...!!!");
            }
            var result = _mapper.Map<List<UserResponseModel>>(user);
            return result;

        }
        public async Task<UserResponseModel> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null)
            {
                throw new NullReferenceException("Uesr not found...!!!");
            }
            var result = _mapper.Map<UserResponseModel>(user);
            return result;
        }

        public async Task<int> AddUserAsync(UserRequestModel userRequestModel)
        {
            try
            {

                int age = DateTime.Now.Year - userRequestModel.Dob.Year;
                var user = UserBuilder.Build(userRequestModel, age);
                var userCount = await _userRepository.AddUser(user);

                if (userCount == 0)
                {
                    throw new Exception("User not added...!!!");
                }

                return userCount;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<int> UpdateUserAsync(UserRequestModel userRequestModel, int id)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null)
            {
                throw new NullReferenceException("User not found...!!!");
            }
            user.Name = userRequestModel.Name;
            user.Dob = userRequestModel.Dob;
            user.Phone = userRequestModel.Phone;
            user.Address = userRequestModel.Address;
            user.Age=DateTime.Now.Year - user.Dob.Year;
            user.Email = userRequestModel.Email;

            var result = await _userRepository.UpdateUser(user);
            if (result == 0)
            {
                throw new Exception("User not updated, Enter valid data...!!!");
            }
            return result;
        }

        public async Task<int> DeleteUserAsync(int id)
        {
            var result = await _userRepository.DeleteUser(id);
            return result;
        }

    }
}
