using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plataforma_de_banca_digital.Dominio.Entidades;
using Plataforma_de_banca_digital.Dominio.Interfaces.Empleados;
using Plataforma_de_banca_digital.Infrastructure.Persistence;

namespace Plataforma_de_banca_digital.Infrastructure.Respositories
{
    public class EmpleadoRespository : IEmpleadoRespository
    {

        private readonly DbContextSQL _context;

        public EmpleadoRespository(DbContextSQL context)
        {
            _context = context;
        }

        public async Task AddEmpleado(Empleado empleado)
        {
            await _context.Empleados.AddAsync(empleado);
        }
    }
}
