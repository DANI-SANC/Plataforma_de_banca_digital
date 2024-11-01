using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public class Notificacion : BaseEntity
    {
        public Guid? ClienteId { get; set; }

        public Cliente? Cliente { get; set; }
        public string? Mensaje { get; set; }

        public DateTime? FechaEnvio { get; set; }


    }
}
