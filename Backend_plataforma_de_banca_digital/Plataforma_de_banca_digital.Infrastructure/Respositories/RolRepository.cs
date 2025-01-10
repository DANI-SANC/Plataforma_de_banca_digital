using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plataforma_de_banca_digital.Dominio.Entidades;
using Plataforma_de_banca_digital.Dominio.Interfaces.Roles;
using Plataforma_de_banca_digital.Infrastructure.Persistence;

namespace Plataforma_de_banca_digital.Infrastructure.Respositories
{
    public class RolRepository : IRolRespository
    {

        private readonly DbContextSQL _context;

        public RolRepository(DbContextSQL context)
        {
            _context = context;
        }

        public async Task AddRol(Rol rol)
        {
            await _context.Roles.AddAsync(rol);
        }
    }
}
