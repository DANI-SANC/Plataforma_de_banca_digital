using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public class TipoCuenta : BaseEntity
    {
        public string? NombreCuenta { get; set; }

        public string? Descripcion { get; set; }

        public ICollection<Cuenta> Cuentas { get; set; } = new List<Cuenta>();
    }
}
