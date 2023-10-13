using FisioEscala.Domain.Entities.Auth;
using FisioEscala.Domain.Interfaces.Auth;
using FisioEscala.Infra.Contexts;

namespace FisioEscala.Infra.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly AuthDbContext _context;
        public LoginRepository(AuthDbContext AuthDbContext)
            => _context = AuthDbContext;

        public UserAccess GetUserAccesByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }
    }
}
