using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Plataforma_de_banca_digital.Application;
using System;

namespace Plataforma_de_banca_digital.Infrastructure.Persistence
{
    public class DbContextSQL : DbContext
    {
        public DbContextSQL(DbContextOptions<DbContextSQL> options) : base(options)
        {
        }
        /*
        // Constructor con cadena de conexión fija
        public DbContextSQL() : base(new DbContextOptionsBuilder<DbContextSQL>()
            .UseSqlServer("Server=DESKTOP-I4C5U4P\\SQLEXPRESS;Database=LocalDatabaseBank;Trusted_Connection=True;TrustServerCertificate=True")
            .Options)
        {
        }
        */

        // Propiedades para los modelos
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<PagoPrestamo> PagoPrestamos { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<TipoCuenta> TipoCuentas { get; set; }
        public DbSet<TipoTransaccion> TipoTransacciones { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de las relaciones
            modelBuilder.Entity<Cuenta>()
                .HasOne(c => c.Cliente)
                .WithMany(c => c.Cuentas)
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Cuenta>()
                .HasOne(c => c.TipoCuenta)
                .WithMany(c => c.Cuentas)
                .HasForeignKey(c => c.TipoDeCuentaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Empleado>()
                .HasOne(e => e.Sucursal)
                .WithMany(e => e.Empleados)
                .HasForeignKey(e => e.SucursalId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Empleado>()
                .HasOne(e => e.Cargo)
                .WithMany(e => e.Empleados)
                .HasForeignKey(e => e.CargoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Notificacion>()
                .HasOne(n => n.Cliente)
                .WithMany(n => n.Notificaciones)
                .HasForeignKey(n => n.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PagoPrestamo>()
                .HasOne(p => p.Prestamo)
                .WithMany(p => p.PagoPrestamos)
                .HasForeignKey(p => p.PrestamoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Cliente)
                .WithMany(p => p.Prestamos)
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transaccion>()
                .HasOne(t => t.TipoTransaccion)
                .WithMany(t => t.Transacciones)
                .HasForeignKey(t => t.TipoDeTransaccionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany(u => u.Usuarios)
                .HasForeignKey(u => u.RolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Empleado)
                .WithOne(u => u.Usuario)
                .HasForeignKey<Usuario>(u => u.EmpleadoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Cliente)
                .WithOne(u => u.Usuario)
                .HasForeignKey<Usuario>(u => u.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración de tipos de columna para propiedades decimal
            modelBuilder.Entity<Cuenta>()
                .Property(c => c.SaldoActual)
                .HasColumnType("decimal(18,2)"); // Especifica la precisión y la escala

            modelBuilder.Entity<PagoPrestamo>()
                .Property(p => p.MontoPago)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<PagoPrestamo>()
                .Property(p => p.SaldoRestante)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Prestamo>()
                .Property(p => p.MontoPrestamo)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Prestamo>()
                .Property(p => p.SaldoPendiente)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Transaccion>()
                .Property(t => t.Monto)
                .HasColumnType("decimal(18,2)");
        }
    }
}
