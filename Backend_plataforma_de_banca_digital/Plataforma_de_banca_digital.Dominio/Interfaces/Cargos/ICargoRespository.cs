using Plataforma_de_banca_digital.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Dominio.Interfaces.Cargos
{
    public interface ICargoRespository
    {
        Task AddCargo(Cargo cargo);
    }
}
