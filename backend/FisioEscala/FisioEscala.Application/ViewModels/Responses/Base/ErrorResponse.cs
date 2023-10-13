namespace FisioEscala.Application.ViewModels.Responses.Base
{
    public class ErrorResponse
    {
        public string Description { get; private set; }

        public ErrorResponse(string description)
            => Description = description;
    }
}
