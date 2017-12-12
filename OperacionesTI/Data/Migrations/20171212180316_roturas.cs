using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OperacionesTI.Data.Migrations
{
    public partial class roturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "Roturas",
                columns: table => new
                {
                    IdRotura = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capex = table.Column<string>(maxLength: 4, nullable: true),
                    FechaEnvioaCD = table.Column<DateTime>(nullable: false),
                    FechaRecibido = table.Column<DateTime>(nullable: false),
                    FechaReparado = table.Column<DateTime>(nullable: false),
                    Fechaautogarencia = table.Column<DateTime>(nullable: false),
                    Fechaenviomicro = table.Column<DateTime>(nullable: false),
                    Fecharecemicro = table.Column<DateTime>(nullable: false),
                    IdBandera = table.Column<int>(nullable: false),
                    IdEstadoReparacion = table.Column<int>(nullable: false),
                    IdFalla = table.Column<int>(nullable: false),
                    IdLocal = table.Column<int>(nullable: false),
                    IdMarca = table.Column<int>(nullable: false),
                    IdModelo = table.Column<int>(nullable: false),
                    IdUn = table.Column<int>(nullable: false),
                    Identificacion = table.Column<string>(nullable: false),
                    Observaciones = table.Column<string>(maxLength: 255, nullable: true),
                    Presupuesto = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(maxLength: 20, nullable: false),
                    Ticket = table.Column<string>(maxLength: 8, nullable: false),
                    valorMyProperty = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roturas", x => x.IdRotura);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Roturas");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
