using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Plataforma_de_banca_digital.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Infrastructure.Persistence
{
    public class DbContextSQLData
    {
        public static async Task LoadDataAsync(
            
            DbContextSQL context, ILoggerFactory loggerFactory
            )
        {
            try
            {
                

            

                if(!context.Roles!.Any())
                {
                    var rolesData = File.ReadAllText("../Plataforma_de_banca_digital.Infrastructure/Persistence/Data/Roles.json");
                    var roles = JsonConvert.DeserializeObject<List<Rol>>(rolesData);
                    await context.Roles.AddRangeAsync(roles!);
                    await context.SaveChangesAsync();
                }

                if (!context.Sucursales!.Any())
                {
                    var sucursalesData = File.ReadAllText("../Plataforma_de_banca_digital.Infrastructure/Persistence/Data/Sucursales.json");
                    var sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(sucursalesData);
                    await context.Sucursales.AddRangeAsync(sucursales!);
                    await context.SaveChangesAsync();
                }

                if (!context.TipoCuentas!.Any())
                {
                    var tipo_Cuentas_Data = File.ReadAllText("../Plataforma_de_banca_digital.Infrastructure/Persistence/Data/Tipo_cuenta.json");
                    var tipo_cuentas = JsonConvert.DeserializeObject<List<TipoCuenta>>(tipo_Cuentas_Data);
                    await context.TipoCuentas.AddRangeAsync(tipo_cuentas!);
                    await context.SaveChangesAsync();
                }

                if (!context.TipoTransacciones!.Any())
                {
                    var tipo_Transacciones_Data = File.ReadAllText("../Plataforma_de_banca_digital.Infrastructure/Persistence/Data/Tipo_transaccion.json");
                    var tipo_transacciones = JsonConvert.DeserializeObject<List<TipoTransaccion>>(tipo_Transacciones_Data);
                    await context.TipoTransacciones.AddRangeAsync(tipo_transacciones!);
                    await context.SaveChangesAsync();
                }

            }
            catch ( Exception e )
            {
                var logger = loggerFactory.CreateLogger<DbContextSQLData>();
                logger.LogError(e.Message + "Error en data");
            }
        }
    }
}
