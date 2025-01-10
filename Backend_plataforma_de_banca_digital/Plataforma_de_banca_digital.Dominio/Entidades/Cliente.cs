using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Dominio.Entidades
{
    public class Cliente : BaseEntity
    {
        public string? NombreCompleto { get; set; }

        public DateOnly? FechaDeNacimiento { get; set; }

        public string? Direccion {  get; set; }

        public int Telefono { get; set; }

        public string? Correo { get; set; }

        public string? DNI { get; set; }


        public ICollection<Cuenta> Cuentas { get; set; } = new List<Cuenta>();

        public ICollection<Notificacion> Notificaciones { get; set; } = new List<Notificacion>();

        public ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();



        

    }
}
