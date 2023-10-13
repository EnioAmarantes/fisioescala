using FisioEscala.Domain.Entities.Auth;

namespace FisioEscala.Domain.Interfaces.Auth
{
    public interface ILoginRepository
    {
        UserAccess GetUserAccesByEmail(string email);
    }
}
