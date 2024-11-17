using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Dominio.Entidades
{
    public enum CuentaEstado
    {
        [EnumMember(Value ="Cuenta Inactiva")] Inactiva,
        [EnumMember(Value = "Cuenta Activa")] Activa

    }
}
