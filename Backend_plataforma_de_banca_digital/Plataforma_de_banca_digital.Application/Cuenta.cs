using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public class Cuenta : BaseEntity
    {
        public int NumeroCuenta { get; set; }

        public Guid? ClienteId { get; set; }
        
        public Cliente? Cliente { get; set; }

        
        public Guid? TipoDeCuentaId { get; set; }

        public TipoCuenta? TipoCuenta { get; set; }
        public decimal SaldoActual { get; set; }

        public DateTime? FechaDeApertura { get; set; }

        public CuentaEstado Estado { get; set; } = CuentaEstado.Activa;

      
        
    }
}
