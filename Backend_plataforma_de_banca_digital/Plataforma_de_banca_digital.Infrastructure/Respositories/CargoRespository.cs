using Plataforma_de_banca_digital.Dominio.Entidades;
using Plataforma_de_banca_digital.Dominio.Interfaces.Cargos;
using Plataforma_de_banca_digital.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Infrastructure.Respositories
{
    public class CargoRespository : ICargoRespository
    {

        private readonly DbContextSQL _context;

        public CargoRespository(DbContextSQL context)
        {
            _context = context;
        }

        public async  Task AddCargo(Cargo cargo)
        {
            await _context.Cargos.AddAsync(cargo);
        }
    }
}
