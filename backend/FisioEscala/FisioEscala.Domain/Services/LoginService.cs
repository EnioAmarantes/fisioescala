using FisioEscala.Application.Interfaces.Auth;
using FisioEscala.Application.ViewModels.Requests.Auth;
using FisioEscala.Application.ViewModels.Responses.Auth;
using FisioEscala.Application.ViewModels.Responses.Base;
using FisioEscala.Domain.Entities.Auth;
using FisioEscala.Domain.Interfaces.Auth;

namespace FisioEscala.Domain.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
            => _loginRepository = loginRepository;

        public Task<ResultModel<LoginResponse>> LoginAsync(LoginRequest loginRequest)
        {
            UserAccess userAccess = _loginRepository.GetUserAccesByEmail(loginRequest.Name);

            if (userAccess is null)
                return Task.FromResult(new ResultModel<LoginResponse>(new ErrorResponse("Erro ao realizar Login")));

            LoginResponse loginResponse = new LoginResponse(userAccess.Name, userAccess.Email);
            ResultModel<LoginResponse> result = new ResultModel<LoginResponse>(loginResponse);

            return Task.FromResult(result);
        }

        public Task<ResultModel<string>> LogoutAsync(LoginRequest logoutRequest)
        {
            return Task.FromResult(new ResultModel<string>("Usuário deslogado com sucesso"));
        }
    }
}
