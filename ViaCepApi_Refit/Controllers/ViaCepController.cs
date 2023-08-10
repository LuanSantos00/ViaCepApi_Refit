using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViaCepApi_Refit.Domain;

namespace ViaCepApi_Refit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaCepController : ControllerBase
    {//adicionar validators
        private readonly IMediator _mediator;
        public ViaCepController(IMediator mediator)
            => _mediator = mediator;

        [HttpGet("{cep}")]
        public async Task<IActionResult> GetCep(string cep)
        {
            var (isSuccess, value, exception) = await _mediator.Send(new GetCepRequest() { Cep = cep }).ConfigureAwait(false);

            if (!isSuccess)
                return BadRequest(exception);

            return Ok(value);
        }
    }
}
