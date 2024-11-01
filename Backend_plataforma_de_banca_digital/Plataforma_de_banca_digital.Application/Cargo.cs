using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public class Cargo : BaseEntity
    {

          public string? NombreCargo { get; set; }

          public string? Descripcio { get; set; }

        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
    }
}
