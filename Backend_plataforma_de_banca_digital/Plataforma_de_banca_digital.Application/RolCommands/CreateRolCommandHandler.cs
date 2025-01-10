using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Plataforma_de_banca_digital.Application.Result;
using Plataforma_de_banca_digital.Dominio.Entidades;
using Plataforma_de_banca_digital.Dominio.Interfaces.IUnitOfWork;

namespace Plataforma_de_banca_digital.Application.RolCommands
{
    public record CreateRolCommandRequest (CreateRolRequest createRolRequest) : IRequest<Result<Guid>>
    {

        public class CreateRolCommandHandler : IRequestHandler<CreateRolCommandRequest, Result<Guid>>
        {
            private readonly IUnitOfWork _unitOfWork;

            public CreateRolCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<Result<Guid>> Handle(CreateRolCommandRequest request, CancellationToken cancellationToken)
            {
                var rol = new Rol
                {
                    NombreRol = request.createRolRequest.NombreRol,
                    Descripcion = request.createRolRequest.Descripcion,
                    FechaDeCreacion = request.createRolRequest.FechaCreacion
                };

                await _unitOfWork.Roles!.AddRol(rol);

                var resultado = await _unitOfWork.SaveChangesAsync(cancellationToken)>0;

                return resultado ? Result<Guid>.Success(rol.Id!.Value) : Result<Guid>.Failure( "No se puede insertar un rol" );

            }
        }

    }
}
