using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Plataforma_de_banca_digital.Dominio.Entidades;
using Plataforma_de_banca_digital.Dominio.Interfaces.Usuarios;
using Plataforma_de_banca_digital.Infrastructure.Persistence;

namespace Plataforma_de_banca_digital.Infrastructure.Respositories
{
    public class UsuarioRespository : IUsuariosRepository
    {

        private readonly DbContextSQL _context;

        public UsuarioRespository(DbContextSQL context)
        {
            _context = context;
        }

        public async Task AddUsuario(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
        }

        public async Task<Usuario?> GetUsuarioCorreo(Usuario usuario)
        {
            return await _context.Usuarios!.FirstOrDefaultAsync(u => u.Correo == usuario.Correo);
        }

        public async Task<Usuario?> GetUsuarioEmpleado(Usuario usuario)
        {


          return await _context.Usuarios!.FirstOrDefaultAsync(u => u.EmpleadoId == usuario.EmpleadoId);

          
        }

        public async Task<Usuario?> GetUsuarioNombre(Usuario usuario)
        {
            return await _context.Usuarios!.FirstOrDefaultAsync(u => u.NombreUsuario == usuario.NombreUsuario);
        }
    }
}
