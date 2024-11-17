using Plataforma_de_banca_digital.Dominio.Interfaces.Cargos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Dominio.Interfaces.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICargoRespository? Cargos { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
