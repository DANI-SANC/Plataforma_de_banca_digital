using Microsoft.EntityFrameworkCore;
using Plataforma_de_banca_digital.Infrastructure.Persistence;



var builder = WebApplication.CreateBuilder(args);


//imyeccion de dependencia DbContext
builder.Services.AddPersistence(builder.Configuration);// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var service= scope.ServiceProvider;
    var loggerFactory = service.GetRequiredService<ILoggerFactory>();
    try
    {
        var context = service.GetRequiredService<DbContextSQL>();
        await context.Database.MigrateAsync();
        await DbContextSQLData.LoadDataAsync(context, loggerFactory);
    }
    catch (Exception ex)
    {
        var logger = loggerFactory.CreateLogger<Program>();
        logger.LogError(ex, "Error en la migraciom");
    }
}



    app.Run();
