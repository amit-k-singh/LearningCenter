using LearningCenter.Infra.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace LearningCenter.Infra.Domain.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Technology> Technology { get; set; }
    }
}
