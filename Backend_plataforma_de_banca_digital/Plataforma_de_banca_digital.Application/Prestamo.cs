using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public class Prestamo : BaseEntity
    {
        public Guid? ClienteId { get; set; }

        public Cliente? Cliente { get; set; }
        public decimal MontoPrestamo { get; set; }

        public decimal SaldoPendiente { get; set; }

        public float InteresAnual {  get; set; }

        public DateTime? FechaDeDesembolso {  get; set; }

        public int PlazoMeses {  get; set; }

        public Guid? EstadoPrestamoId { get; set; }

        public EstadoPrestamo? EstadoPrestamo { get; set; }

        public ICollection<PagoPrestamo> PagoPrestamos { get; set; } = new List<PagoPrestamo>();

    }
}
