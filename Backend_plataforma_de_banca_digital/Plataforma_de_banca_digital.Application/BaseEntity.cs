using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public class BaseEntity
    {
        public Guid? Id { get; set; }

        public DateTime? FechaDeCreacion { get; set; }

        public DateTime? FechaDeModificacion {  get; set; }

        public DateTime? UsuarioCreacion { get; set; }

        public DateTime? UsuarioModificacion { get; set; }

        
    }
}
