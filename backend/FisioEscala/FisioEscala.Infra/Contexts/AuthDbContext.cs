using FisioEscala.Domain.Entities.Auth;
using Microsoft.EntityFrameworkCore;

namespace FisioEscala.Infra.Contexts
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> context) : base(context)
            => Database.EnsureCreated();

        public DbSet<UserAccess> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserAccess>().HasData(
                    new UserAccess()
                    {
                        Id = Guid.Parse("89336f57-728e-405c-8558-cde47fefb9a5"),
                        Name = "Enio Amarantes",
                        Email = "enio.amarantes@gmail.com",
                        Password = "password",
                    }
                );
        }
    }
}
