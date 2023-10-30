using FisioEscala.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace FisioEscala.Infra.Contexts
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
            => Database.EnsureCreated();

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => base.OnModelCreating(modelBuilder);
    }
}
