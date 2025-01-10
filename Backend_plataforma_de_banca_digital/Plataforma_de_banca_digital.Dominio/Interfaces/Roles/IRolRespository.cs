using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plataforma_de_banca_digital.Dominio.Entidades;

namespace Plataforma_de_banca_digital.Dominio.Interfaces.Roles
{
    public interface IRolRespository
    {

        Task AddRol(Rol rol);
    }
}
