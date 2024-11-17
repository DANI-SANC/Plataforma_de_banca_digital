// entrada que configura el servidor y el pipeline de la aplicación.

// y aplica migraciones automáticas para la base de datos durante el arranque.

using Microsoft.EntityFrameworkCore;
using Plataforma_de_banca_digital.Application.CargosCommands;
using Plataforma_de_banca_digital.Application;


// Inyección de dependencia para DbContext
// Agrega `DbContextSQL` a los servicios, configurado con la cadena de conexión de la base de datos.
using Plataforma_de_banca_digital.Infrastructure.Persistence;
using Plataforma_de_banca_digital.Dominio.Interfaces.IUnitOfWork;
using Plataforma_de_banca_digital.Infrastructure.UnitOfWork;



var builder = WebApplication.CreateBuilder(args);


//imyeccion de dependencia DbContext
builder.Services.AddPersistence(builder.Configuration);// Agrega `DbContextSQL` a los servicios, configurado con la cadena de conexión de la base de datos.

builder.Services.AddControllers();// Agrega el soporte para los controladores, que manejan las solicitudes HTTP.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Asegúrate de que este registro esté en el contenedor de dependencias
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddApplication();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Solo habilita Swagger en entorno de desarrollo para documentar y probar la API
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();// Redirige automáticamente las solicitudes HTTP a HTTPS.

app.UseAuthorization();// Habilita la autorización para las solicitudes.

app.MapControllers(); // Mapea las rutas de los controladores, permitiendo que la API responda a solicitudes en los endpoints configurados.


// Uso de un `scope` para manejar servicios con alcance limitado (scope) durante la configuración de la aplicación.
using (var scope = app.Services.CreateScope())
{
    var service= scope.ServiceProvider;  // Obtiene el proveedor de servicios con alcance limitado.
    var loggerFactory = service.GetRequiredService<ILoggerFactory>(); // Obtiene el `ILoggerFactory` para registrar mensajes de error.
    try
    {
        var context = service.GetRequiredService<DbContextSQL>(); // Obtiene el contexto de base de datos `DbContextSQL`.
        await context.Database.MigrateAsync();// Aplica migraciones de la base de datos para garantizar que esté actualizada.
        await DbContextSQLData.LoadDataAsync(context, loggerFactory); // Carga datos iniciales en la base de datos, si es necesario.
    }
    catch (Exception ex)
    {
        var logger = loggerFactory.CreateLogger<Program>(); // Crea un registrador para el programa principal.
        logger.LogError(ex, "Error en la migraciom"); // Registra un mensaje de error si ocurre un problema durante la migración.
    }
}



    app.Run();// Inicia la aplicación, permitiendo que acepte solicitudes entrantes.
