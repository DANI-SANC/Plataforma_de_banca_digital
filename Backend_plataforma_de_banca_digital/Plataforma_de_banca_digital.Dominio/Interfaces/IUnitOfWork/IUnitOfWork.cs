using Plataforma_de_banca_digital.Dominio.Interfaces.Cargos;
using Plataforma_de_banca_digital.Dominio.Interfaces.Empleados;
using Plataforma_de_banca_digital.Dominio.Interfaces.Roles;
using Plataforma_de_banca_digital.Dominio.Interfaces.Usuarios;
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
        IRolRespository? Roles { get; }

        IEmpleadoRespository? Empleados { get; }

        IUsuariosRepository? Usuarios {  get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
