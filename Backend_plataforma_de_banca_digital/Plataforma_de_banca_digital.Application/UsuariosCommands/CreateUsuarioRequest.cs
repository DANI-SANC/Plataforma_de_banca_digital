using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application.UsuariosCommands
{
    public class CreateUsuarioRequest
    {

        public Guid? EmpleadoId { get; set; }
        public Guid? RolId { get; set; }
        public string? NombreUsuario { get; set; }

        public string? Contrasena { get; set; }

        public string? Correo { get; set; }

        public DateTime? FechaDeCreacion { get; set; }

    }
}
