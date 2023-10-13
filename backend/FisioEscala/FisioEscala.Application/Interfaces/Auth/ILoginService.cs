using FisioEscala.Application.ViewModels.Requests.Auth;
using FisioEscala.Application.ViewModels.Responses.Auth;
using FisioEscala.Application.ViewModels.Responses.Base;

namespace FisioEscala.Application.Interfaces.Auth
{
    public interface ILoginService
    {
        Task<ResultModel<LoginResponse>> LoginAsync(LoginRequest loginRequest);
        Task<ResultModel<string>> LogoutAsync(LoginRequest logoutRequest);
    }
}
