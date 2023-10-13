namespace FisioEscala.Application.ViewModels.Requests.Auth
{
    public record LoginRequest
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}