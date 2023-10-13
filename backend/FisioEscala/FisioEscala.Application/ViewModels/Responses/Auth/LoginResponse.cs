namespace FisioEscala.Application.ViewModels.Responses.Auth
{
    public record LoginResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public LoginResponse(string name, string email)
        {
            Name = name;
            Email = email;
        }

    }
}