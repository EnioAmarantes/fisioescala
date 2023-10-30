namespace FisioEscala.Application.ViewModels.Responses.Users
{
    public class UserResponse 
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public UserResponse(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
