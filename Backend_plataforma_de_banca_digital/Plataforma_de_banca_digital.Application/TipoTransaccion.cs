using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public class TipoTransaccion : BaseEntity
    {
        public string? Nombre { get; set; }

        public ICollection<Transaccion> Transacciones { get; set; } = new List<Transaccion>();
    }
}
