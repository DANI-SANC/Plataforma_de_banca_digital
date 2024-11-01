using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plataforma_de_banca_digital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreCargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDeNacimiento = table.Column<DateOnly>(type: "date", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPrestamo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPrestamo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreRol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NonbreSucursal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    HorarioAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCuentas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreCuenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCuentas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTransacciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTransacciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Mensaje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEnvio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notificaciones_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MontoPrestamo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaldoPendiente = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InteresAnual = table.Column<float>(type: "real", nullable: false),
                    FechaDeDesembolso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlazoMeses = table.Column<int>(type: "int", nullable: false),
                    EstadoPrestamoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestamos_EstadoPrestamo_EstadoPrestamoId",
                        column: x => x.EstadoPrestamoId,
                        principalTable: "EstadoPrestamo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SucursalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleados_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroCuenta = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TipoDeCuentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SaldoActual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaDeApertura = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    CuentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cuentas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cuentas_Cuentas_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "Cuentas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cuentas_TipoCuentas_TipoDeCuentaId",
                        column: x => x.TipoDeCuentaId,
                        principalTable: "TipoCuentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PagoPrestamos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrestamoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MontoPago = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaldoRestante = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumeroRecibo = table.Column<int>(type: "int", nullable: false),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagoPrestamos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagoPrestamos_Prestamos_PrestamoId",
                        column: x => x.PrestamoId,
                        principalTable: "Prestamos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpleadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RolId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContrasenaHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimoAcceso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IntentosFallidos = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transacciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CuentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoDeTransaccionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaDeTransaccion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroRecibo = table.Column<int>(type: "int", nullable: false),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDeModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transacciones_Cuentas_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "Cuentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacciones_TipoTransacciones_TipoDeTransaccionId",
                        column: x => x.TipoDeTransaccionId,
                        principalTable: "TipoTransacciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_ClienteId",
                table: "Cuentas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_CuentaId",
                table: "Cuentas",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_TipoDeCuentaId",
                table: "Cuentas",
                column: "TipoDeCuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_CargoId",
                table: "Empleados",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SucursalId",
                table: "Empleados",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_ClienteId",
                table: "Notificaciones",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PagoPrestamos_PrestamoId",
                table: "PagoPrestamos",
                column: "PrestamoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_ClienteId",
                table: "Prestamos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_EstadoPrestamoId",
                table: "Prestamos",
                column: "EstadoPrestamoId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_CuentaId",
                table: "Transacciones",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_TipoDeTransaccionId",
                table: "Transacciones",
                column: "TipoDeTransaccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ClienteId",
                table: "Usuarios",
                column: "ClienteId",
                unique: true,
                filter: "[ClienteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EmpleadoId",
                table: "Usuarios",
                column: "EmpleadoId",
                unique: true,
                filter: "[EmpleadoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "PagoPrestamos");

            migrationBuilder.DropTable(
                name: "Transacciones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "TipoTransacciones");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "EstadoPrestamo");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "TipoCuentas");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Sucursales");
        }
    }
}
