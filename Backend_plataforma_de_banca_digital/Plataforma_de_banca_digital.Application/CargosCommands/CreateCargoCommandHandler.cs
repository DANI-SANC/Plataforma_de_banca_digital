using MediatR;
using Plataforma_de_banca_digital.Application.Result;
using Plataforma_de_banca_digital.Dominio.Entidades;
using Plataforma_de_banca_digital.Dominio.Interfaces.IUnitOfWork;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application.CargosCommands
{
    // Define la solicitud como un record que implementa IRequest con el tipo de retorno
    public record CreateCargoCommandRequest(CreateCargoRequest createCargoRequest) : IRequest<Result<Guid>>;

    // Define el handler para manejar la solicitud
    public class CreateCargoCommandHandler : IRequestHandler<CreateCargoCommandRequest, Result<Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateCargoCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<Guid>> Handle(CreateCargoCommandRequest request, CancellationToken cancellationToken)
        {
            var cargo = new Cargo
            {
                NombreCargo = request.createCargoRequest.NombreCargo,
                Descripcio = request.createCargoRequest.Descripcio,
                FechaDeCreacion = request.createCargoRequest.FechaCreacion
            };

            await _unitOfWork.Cargos!.AddCargo(cargo);
           var resultado = await _unitOfWork.SaveChangesAsync(cancellationToken)>0;


            // Retorna el resultado con el ID del Cargo creado
            return resultado ? Result<Guid>.Success(cargo.Id!.Value) : Result<Guid>.Failure("No se puede insertar cargo");
        }
    }
}
