using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application.CargosCommands
{
    public class CreateCargoRequest
    {
        public string? NombreCargo { get; set; }

        public string? Descripcio {  get; set; }

        public DateTime? FechaCreacion {  get; set; }

    }
}
