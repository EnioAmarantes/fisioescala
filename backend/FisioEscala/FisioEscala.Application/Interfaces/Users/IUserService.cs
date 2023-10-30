using FisioEscala.Application.ViewModels.Requests.Users;
using FisioEscala.Application.ViewModels.Responses.Base;
using FisioEscala.Application.ViewModels.Responses.Users;

namespace FisioEscala.Application.Interfaces.Users
{
    public interface IUserService
    {
        Task<ResultModel<IEnumerable<UserResponse>>> GetAllUsers();
        Task<ResultModel<UserResponse>> GetUserById(Guid id);
        Task<ResultModel<bool>> Update(Guid id, UserUpdateRequest user);
    }
}
