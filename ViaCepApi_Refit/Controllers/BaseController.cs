using MediatR;
using Microsoft.AspNetCore.Mvc;
using OperationResult;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace ViaCepApi_Refit.Controllers
{
    public class BaseController : ControllerBase
    {
        protected readonly IMediator Mediator;

        public BaseController(IMediator mediator) 
            => Mediator = mediator;

        protected async Task<IActionResult> SendRequest<T>(IRequest<Result<T>> request, int statusCode = Status200OK) where T : class
        {
            try
            {
                var (isSuccess, value, exception) = await Mediator.Send(request).ConfigureAwait(false);

                if (!isSuccess)
                    return BadRequest(exception);
                else if (value is null)
                    return new NoContentResult();
                else
                    return new ObjectResult(value) { StatusCode = statusCode };

            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }
    }
}
