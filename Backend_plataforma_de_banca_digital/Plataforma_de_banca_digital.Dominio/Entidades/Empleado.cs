using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Dominio.Entidades
{
    public class Empleado : BaseEntity
    {
        public Guid? SucursalId { get; set; }

        public Sucursal? Sucursal { get; set; }

        public string? NombreCompleto { get; set; }

        public Guid? CargoId { get; set; }

        public Cargo? Cargo { get; set; }
        
        public string? Correo { get; set; }

        public int Telefono { get; set; }

        public int DNI { get; set; }

        public Usuario? Usuario { get; set; }

    }
}
