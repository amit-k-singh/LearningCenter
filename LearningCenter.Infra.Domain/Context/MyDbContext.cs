using LearningCenter.Infra.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infra.Domain.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Technology> technologie { get; set; }
        public DbSet<UserRoles> userRoles { get; set; }
    }
}
