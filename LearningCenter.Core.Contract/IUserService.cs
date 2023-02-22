using LearningCenter.Core.Domain.RequestModel;
using LearningCenter.Core.Domain.ResponseModel;

namespace LearningCenter.Core.Contract
{
    public interface IUserService
    {
        Task<int> AddUserAsync(UserRequestModel userRequestModel);
        Task<UserResponseModel> GetUserByIdAsync(int id);
        Task<List<UserResponseModel>> GetUserAsync();
        Task<int> DeleteUserAsync(int id);
        Task<int> UpdateUserAsync(UserRequestModel userRequestModel, int id);
    }
}
