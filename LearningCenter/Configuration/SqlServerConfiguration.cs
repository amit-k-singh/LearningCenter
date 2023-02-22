using LearningCenter.Infra.Domain.Context;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Configuration
{
    public static class SqlServerConfiguration
    {
        public static void AddSqlServer(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:default"];

            services.AddDbContext<LearningCenterContext>(option =>
            {
                option.UseSqlServer(connectionString, x =>
                {
                    x.MigrationsAssembly("LearningCenter.Infra.Domain");
                });
            },ServiceLifetime.Singleton);
        }
    }
}
