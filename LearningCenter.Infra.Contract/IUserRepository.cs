using LearningCenter.Infra.Domain.Entities;

namespace LearningCenter.Infra.Contract
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserById(int id);
        Task<int> AddUser(User user);
        Task<int> UpdateUser(User user);
        Task<int> DeleteUser(int id);
    }
}