using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Dominio.Entidades
{
    public class Rol : BaseEntity
    {

        public string? NombreRol {  get; set; }

        public string? Descripcion { get; set; }

        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
