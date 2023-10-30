using FisioEscala.Domain.Entities.Users;

namespace FisioEscala.Domain.Interfaces.Users
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserById(Guid id);
        bool CreateUser(User user);
        Task<bool> UpdateUser(User user);
        bool DeleteUser(Guid id);
    }
}
