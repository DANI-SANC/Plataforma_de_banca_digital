using MediatR;
using Microsoft.AspNetCore.Mvc;
using Plataforma_de_banca_digital.Application.RolCommands;

namespace Plataforma_banca_digital.Web_API.Controllers

{
    [ApiController]
    [Route("api/rol")]
    public class RolController: ControllerBase
    {

        private readonly ISender _sender;

        public RolController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRol ([FromBody] CreateRolRequest request, CancellationToken cancellationToken)
        {
            var command = new CreateRolCommandRequest(request);
            var result = await _sender.Send(command, cancellationToken);
            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result.Error);
        }
    }
}
