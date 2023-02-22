using LearningCenter.Core.Contract;
using LearningCenter.Core.Service;
using LearningCenter.Infra.Contract;
using LearningCenter.Infra.Repository;

namespace LearningCenter.Configuration
{
    public static class DependancyConfiguration
    {
        public static void AddDependancy(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository,UserRepository>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IRoleRepository,RoleRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
        }

    }
}
