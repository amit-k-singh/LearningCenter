using LearningCenter.Core.Domain.RequestModel;

namespace LearningCenter.Core.Contract
{
    public interface ITechnologyService
    {
        Task<int> AddTechnologyAsync(TechnologyRequestModel requestModel);
    }
}
