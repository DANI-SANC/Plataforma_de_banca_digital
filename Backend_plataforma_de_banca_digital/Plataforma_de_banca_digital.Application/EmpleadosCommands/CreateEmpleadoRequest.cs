using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plataforma_de_banca_digital.Dominio.Entidades;

namespace Plataforma_de_banca_digital.Application.EmpleadosCommands
{
    public class CreateEmpleadoRequest
    {

        public Guid? SucursalId { get; set; }

        public Guid? CargoId { get; set; }

        public string? NombreCompleto { get; set; }

        public string? Correo { get; set; }

        public int Telefono { get; set; }

        public int DNI { get; set; }

    }
}
