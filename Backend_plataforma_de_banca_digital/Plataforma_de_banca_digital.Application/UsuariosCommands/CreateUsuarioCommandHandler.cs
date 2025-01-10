using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Plataforma_de_banca_digital.Application.Result;
using Plataforma_de_banca_digital.Dominio.Entidades;
using Plataforma_de_banca_digital.Dominio.Interfaces.IUnitOfWork;
using Plataforma_de_banca_digital.Application.Pass;
namespace Plataforma_de_banca_digital.Application.UsuariosCommands
{
    public record CreateUsuarioCommandRequest(CreateUsuarioRequest createUsuarioRequest) : IRequest<Result<Guid>>;
    public class CreateUsuarioCommandHandler : IRequestHandler<CreateUsuarioCommandRequest, Result<Guid>>
    {

        private readonly IUnitOfWork _unitOfWork;

        public CreateUsuarioCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<Guid>> Handle(CreateUsuarioCommandRequest request, CancellationToken cancellationToken)
        {

            var contrasenaHash = PasswordService.HashPass(request.createUsuarioRequest.Contrasena!);
            var usuario = new Usuario
            {
               EmpleadoId = request.createUsuarioRequest.EmpleadoId,
               RolId = request.createUsuarioRequest.RolId,
               NombreUsuario = request.createUsuarioRequest.NombreUsuario,
               ContrasenaHash = contrasenaHash,
               Correo = request.createUsuarioRequest.Correo,
               FechaDeCreacion = request.createUsuarioRequest.FechaDeCreacion,
               IntentosFallidos = 0
               
               
            };


            var EmpleadoID = await _unitOfWork.Usuarios!.GetUsuarioEmpleado(usuario);

            if (EmpleadoID != null) return Result<Guid>.Failure("Este empleado ya tiene un usuario");
        
            var Correo = await _unitOfWork.Usuarios!.GetUsuarioCorreo(usuario);

            if (Correo != null) return Result<Guid>.Failure("Este correo ya esta asociado a un usuario");


            var nombreUsuario = await _unitOfWork.Usuarios!.GetUsuarioNombre(usuario);

            if (nombreUsuario != null) return Result<Guid>.Failure("Este nombre de usuario ya existe");



            await _unitOfWork.Usuarios!.AddUsuario(usuario);

            var resultado = await _unitOfWork.SaveChangesAsync(cancellationToken)>0;

            return resultado ? Result<Guid>.Success(usuario.Id!.Value) : Result<Guid>.Failure("No se pudo insertar usuario");
        }
    }
}
