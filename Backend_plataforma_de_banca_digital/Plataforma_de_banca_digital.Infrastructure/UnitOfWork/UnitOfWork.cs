using Plataforma_de_banca_digital.Dominio.Interfaces.Cargos;
using Plataforma_de_banca_digital.Dominio.Interfaces.IUnitOfWork;
using Plataforma_de_banca_digital.Infrastructure.Persistence;
using Plataforma_de_banca_digital.Infrastructure.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DbContextSQL _context;

        public UnitOfWork(DbContextSQL context)
        {
            _context = context;
            Cargos = new CargoRespository(_context);
        }

        public ICargoRespository? Cargos { get; }

        

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }


        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
