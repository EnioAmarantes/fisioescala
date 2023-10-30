using FisioEscala.Application.Interfaces.Users;
using FisioEscala.Application.ViewModels.Requests.Users;
using FisioEscala.Application.ViewModels.Responses.Users;
using FisioEscala.Domain.Entities.Users;
using FisioEscala.Domain.Interfaces.Users;

namespace FisioEscala.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
            => _userRepository = userRepository;

        public async Task<ResultModel<IEnumerable<UserResponse>>> GetAllUsers()
        {
            IEnumerable<User> userList = await _userRepository.GetUsers();
            IEnumerable<UserResponse> response = userList.Select(user => new UserResponse(user.Name, user.Email));

            return new ResultModel<IEnumerable<UserResponse>>(response);
        }

        public async Task<ResultModel<UserResponse>> GetUserById(Guid id)
        {
            User user = await _userRepository.GetUserById(id);
            return new ResultModel<UserResponse>(new UserResponse(user.Name, user.Email));
        }

        public async Task<ResultModel<bool>> Update(Guid id, UserUpdateRequest user)
        {
            User userToUpdate = new User(id, user.Name, user.Email);
            return new ResultModel<bool>(await _userRepository.UpdateUser(userToUpdate));
        }
    }
}
