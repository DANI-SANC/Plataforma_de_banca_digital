using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public class Transaccion : BaseEntity
    {
        public Guid CuentaId { get; set; }

        public Cuenta? Cuenta { get; set; }

        public Guid TipoDeTransaccionId { get; set; }

        public TipoTransaccion? TipoTransaccion { get; set; }

        public decimal Monto { get; set; }

        public DateTime? FechaDeTransaccion { get; set; }

        public string? Descripcion { get; set; }

        public int NumeroRecibo { get; set; }

    }
}
