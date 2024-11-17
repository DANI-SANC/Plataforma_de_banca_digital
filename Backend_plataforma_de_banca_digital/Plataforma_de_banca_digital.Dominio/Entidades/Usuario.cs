using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Dominio.Entidades
{
    public class Usuario : BaseEntity
    {
        public Guid? EmpleadoId { get; set; } // Relación opcional con Empleado
        public Empleado? Empleado { get; set; }
        public Guid? ClienteId { get; set; } // Relación opcional con Cliente
        public Cliente? Cliente { get; set; }
        public Guid? RolId { get; set; }
        public Rol? Rol { get; set; }
        public string? NombreUsuario { get; set; }

        public string? ContrasenaHash { get; set; }

        public string? Correo {  get; set; }

        public DateTime? UltimoAcceso {  get; set; }

        public int IntentosFallidos {  get; set; }

        public UsuarioEstado Estado { get; set; } = UsuarioEstado.Activo;


        
    }
}
