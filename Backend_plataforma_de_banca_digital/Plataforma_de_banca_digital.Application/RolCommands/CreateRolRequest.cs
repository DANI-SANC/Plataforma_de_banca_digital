using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application.RolCommands
{
    public class CreateRolRequest
    {
        public string? NombreRol {  get; set; }

        public string? Descripcion {  get; set; }

        public DateTime? FechaCreacion { get; set; }

    }
}
