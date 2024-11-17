using MediatR;
using Microsoft.AspNetCore.Mvc;
using Plataforma_de_banca_digital.Application.CargosCommands;
using Plataforma_de_banca_digital.Application.Result;

namespace Plataforma_banca_digital.Web_API.Controllers
{
    [ApiController]
    [Route("api/cargo")]
    public class CargoController : ControllerBase
    {

        private readonly ISender _sender;

        public CargoController(ISender sender)
        {
            _sender = sender;
        }

    

        [HttpPost]
        public async Task<IActionResult> CreateCargo ([FromBody] CreateCargoRequest request, CancellationToken cancellationToken)
        {
            var command = new CreateCargoCommandRequest(request);

            var result = await _sender.Send(command, cancellationToken);

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result.Error);
        }
    }
}
