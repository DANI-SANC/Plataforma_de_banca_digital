// Este código define una clase estática `DbContextSQLData` que carga datos iniciales 
// (roles, sucursales, tipos de cuentas y tipos de transacciones) desde archivos JSON a la base de datos 
// si estas tablas están vacías, utilizando el contexto de la base de datos `DbContextSQL`. 
// Además, maneja y registra errores que puedan ocurrir durante la carga de datos.

using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Plataforma_de_banca_digital.Application;
using Plataforma_de_banca_digital.Dominio.Entidades;
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
        public static async Task LoadDataAsync( // Método asíncrono para cargar datos iniciales en la base de datos si ciertas tablas están vacías.

            DbContextSQL context, ILoggerFactory loggerFactory
            )
        {
            try
            {



                // Verifica si la tabla `Roles` está vacía.
                if (!context.Roles!.Any())
                {
                    // Lee el archivo JSON que contiene los datos de roles.
                    var rolesData = File.ReadAllText("../Plataforma_de_banca_digital.Infrastructure/Persistence/Data/Roles.json");
                    // Deserializa el JSON a una lista de objetos `Rol`.
                    var roles = JsonConvert.DeserializeObject<List<Rol>>(rolesData);
                    // Agrega los roles deserializados a la base de datos.
                    await context.Roles.AddRangeAsync(roles!);
                    // Guarda los cambios en la base de datos.
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
                // Si ocurre un error, se crea un logger para registrar el mensaje de error.
                var logger = loggerFactory.CreateLogger<DbContextSQLData>();
                // Registra el error con el mensaje.
                logger.LogError(e.Message + "Error en data");
            }
        }
    }
}
