using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public enum UsuarioEstado
    {
        [EnumMember(Value = "Usuario Inactivo")] Inactivo,
        [EnumMember(Value = "Usuario Activo")] Activo
    }
}
