using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public class EstadoPrestamo : BaseEntity
    {
        public string? Nombre {  get; set; }

        public string? Descripcion { get; set; }
    }
}
