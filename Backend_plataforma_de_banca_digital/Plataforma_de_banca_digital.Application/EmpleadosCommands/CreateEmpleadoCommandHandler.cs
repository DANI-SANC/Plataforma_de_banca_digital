using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Plataforma_de_banca_digital.Application.Result;
using Plataforma_de_banca_digital.Dominio.Entidades;
using Plataforma_de_banca_digital.Dominio.Interfaces.IUnitOfWork;

namespace Plataforma_de_banca_digital.Application.EmpleadosCommands
{

    public record CreateEmpleadoCommandRequest(CreateEmpleadoRequest createEmpeladoRequest) : IRequest<Result<Guid>>;
    public class CreateEmpleadoCommandHandler : IRequestHandler<CreateEmpleadoCommandRequest, Result<Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateEmpleadoCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<Guid>> Handle(CreateEmpleadoCommandRequest request, CancellationToken cancellationToken)
        {
            var empleado = new Empleado
            {
                NombreCompleto =request.createEmpeladoRequest.NombreCompleto,
                Correo = request.createEmpeladoRequest.Correo,
                Telefono = request.createEmpeladoRequest.Telefono,
                DNI = request.createEmpeladoRequest.DNI,
                SucursalId = request.createEmpeladoRequest.SucursalId,
                CargoId = request.createEmpeladoRequest.CargoId

            };

            await _unitOfWork.Empleados!.AddEmpleado(empleado);

            var resultado = await _unitOfWork.SaveChangesAsync(cancellationToken)>0;

            return resultado ? Result<Guid>.Success(empleado.Id!.Value) : Result<Guid>.Failure("No se pudo insertar empleado");
        }
    }
}
