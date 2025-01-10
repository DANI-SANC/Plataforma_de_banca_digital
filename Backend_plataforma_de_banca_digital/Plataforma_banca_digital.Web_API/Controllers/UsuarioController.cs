using MediatR;
using Microsoft.AspNetCore.Mvc;
using Plataforma_de_banca_digital.Application.UsuariosCommands;

namespace Plataforma_banca_digital.Web_API.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {

        private readonly ISender _sender;

        public UsuarioController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsuario([FromBody] CreateUsuarioRequest request, CancellationToken cancellationToken)
        {
            var command = new CreateUsuarioCommandRequest(request);

            var result = await _sender.Send(command, cancellationToken);

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result.Error);

        }
    }
}
