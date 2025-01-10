using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plataforma_de_banca_digital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class segundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuentas_Cuentas_CuentaId",
                table: "Cuentas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Clientes_ClienteId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ClienteId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Cuentas_CuentaId",
                table: "Cuentas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CuentaId",
                table: "Cuentas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Usuarios",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CuentaId",
                table: "Cuentas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ClienteId",
                table: "Usuarios",
                column: "ClienteId",
                unique: true,
                filter: "[ClienteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_CuentaId",
                table: "Cuentas",
                column: "CuentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuentas_Cuentas_CuentaId",
                table: "Cuentas",
                column: "CuentaId",
                principalTable: "Cuentas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Clientes_ClienteId",
                table: "Usuarios",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
