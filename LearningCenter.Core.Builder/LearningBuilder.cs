using LearningCenter.Core.Domain.RequestModel;
using LearningCenter.Infra.Domain.Entities;

namespace LearningCenter.Core.Builder
{
    public class LearningBuilder
    {
        public static Technology Build(TechnologyRequestModel requestModel)
        {
            return new Technology(requestModel.Name);
        }
    }
}
