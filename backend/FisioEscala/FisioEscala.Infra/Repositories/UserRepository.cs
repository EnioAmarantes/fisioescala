using FisioEscala.Domain.Entities.Users;
using FisioEscala.Domain.Interfaces.Users;
using FisioEscala.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FisioEscala.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;
        public UserRepository(UserDbContext context)
            => _context = context;
        public bool CreateUser(User user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserById(Guid id)
        {
            return _context.Users.FirstOrDefault(user => user.Id == id);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return _context.Users;
        }

        public async Task<bool> UpdateUser(User user)
        {
            _context.Users.Attach(user);
            _context.Entry(user).State = EntityState.Modified;
            return (await _context.SaveChangesAsync() > 0);
        }
    }
}
