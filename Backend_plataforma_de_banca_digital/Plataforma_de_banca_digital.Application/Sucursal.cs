using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public class Sucursal: BaseEntity
    {

        public string? NonbreSucursal {  get; set; }

        public string? Direccion {  get; set; }

        public int Telefono {  get; set; }

        public string? HorarioAtencion { get; set;}

        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();



    }
}
