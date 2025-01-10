using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plataforma_de_banca_digital.Dominio.Entidades;

namespace Plataforma_de_banca_digital.Dominio.Interfaces.Usuarios
{
    public interface IUsuariosRepository
    {

        Task AddUsuario(Usuario usuario);

        Task <Usuario?>GetUsuarioEmpleado(Usuario usuario);

        Task<Usuario?> GetUsuarioCorreo(Usuario usuario);

        Task<Usuario?> GetUsuarioNombre(Usuario usuario);
    }
}
