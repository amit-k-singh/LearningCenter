using LearningCenter.Core.Contract;
using LearningCenter.Core.Service;
using LearningCenter.Infra.Repesitory;

namespace LearningCenter.Configuration
{
    public static class DependancyConfiguration
    {
        public static void AddDependancy(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
        }

    }
}
