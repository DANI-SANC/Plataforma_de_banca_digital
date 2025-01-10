using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Plataforma_de_banca_digital.Application.EmpleadosCommands;

namespace Plataforma_banca_digital.Web_API.Controllers
{
    [ApiController]
    [Route("api/empleado")]
    public class EmpleadoController : ControllerBase
    {

        private readonly ISender _sender;

        public EmpleadoController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmpleado([FromBody] CreateEmpleadoRequest request, CancellationToken cancellationToken)
        {
            var command = new CreateEmpleadoCommandRequest(request);

            var result = await _sender.Send(command, cancellationToken);


            if (result.IsSuccess)
            {
                return Ok(result);  
            }

            return BadRequest(result.Error);
        }

    }
}
