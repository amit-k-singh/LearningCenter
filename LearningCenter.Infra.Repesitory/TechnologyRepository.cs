using LearningCenter.Infra.Contract;
using LearningCenter.Infra.Domain.Context;
using LearningCenter.Infra.Domain.Entities;

namespace LearningCenter.Infra.Repository
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private readonly LearningCenterContext _myDbContext;

        public TechnologyRepository(LearningCenterContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<int> AddTechnology(Technology tech)
        {
            await _myDbContext.Technology.AddAsync(tech);
            return await _myDbContext.SaveChangesAsync();
        }
    }
}
