
using CodeChalengeForTest.Domain;
using CodeChalengeForTest.Infrustrcture.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CodeChalengeForTest.Infrustrcture
{ 
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
