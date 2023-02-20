using LearningCenter.Infra.Domain.Entities;

namespace LearningCenter.Infra.Repesitory
{
    public interface IUserRepository
    {
        Task<int> AddUser(User users);
    }
}