using FisioEscala.Application.ViewModels.Responses.Base;
using Microsoft.AspNetCore.Mvc;

namespace FisioEscala.API.Controllers
{
    public abstract class ControllerApi : ControllerBase
    {
        public IActionResult Result<T>(ResultModel<T> result)
            => result.Success ? Ok(result) : BadRequest(result);
    }
}
