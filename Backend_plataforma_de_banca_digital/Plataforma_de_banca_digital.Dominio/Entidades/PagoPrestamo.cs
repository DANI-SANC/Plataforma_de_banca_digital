using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Dominio.Entidades
{
    public class PagoPrestamo : BaseEntity
    {
        public Guid? PrestamoId { get; set; }

        public Prestamo? Prestamo { get; set; }
        public DateTime? FechaPago { get; set; }

        public decimal MontoPago { get; set; }

        public decimal SaldoRestante {  get; set; }

        public int NumeroRecibo { get; set; }
    }
}
