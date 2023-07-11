using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ViaCepApi_Refit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaCepController : BaseController
    {
        public ViaCepController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> GetCep(string cep)
        {
            return Ok();
        }
    }
}
