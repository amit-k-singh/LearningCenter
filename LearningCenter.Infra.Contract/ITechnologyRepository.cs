using LearningCenter.Infra.Domain.Entities;

namespace LearningCenter.Infra.Contract
{
    public interface ITechnologyRepository
    {
        Task<int> AddTechnology(Technology technology);
    }
}
