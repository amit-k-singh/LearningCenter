using LearningCenter.Infra.Contract;
using LearningCenter.Infra.Domain.Context;
using LearningCenter.Infra.Domain.Entities;

namespace LearningCenter.Infra.Repository
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private readonly MyDbContext _myDbContext;

        public TechnologyRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<int> AddTechnology(Technology tech)
        {
            await _myDbContext.technologie.AddAsync(tech);
            return await _myDbContext.SaveChangesAsync();
        }
    }
}
