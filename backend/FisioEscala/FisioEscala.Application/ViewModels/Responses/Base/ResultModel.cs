namespace FisioEscala.Application.ViewModels.Responses.Base
{
    public class ResultModel<T>
    {
        public bool Success => string.IsNullOrEmpty(Error?.Description);
        public T? Result { get; private set; }
        public ErrorResponse? Error { get; private set; }

        public ResultModel(T result)
            => Result = result;
        public ResultModel(ErrorResponse error)
            => Error = error;
    }
}
