using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OperacionesTI.Data.Migrations
{
    public partial class roturas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roturas_UN",
                columns: table => new
                {
                    IdUN = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UnidadNegocio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roturas_UN", x => x.IdUN);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roturas_IdUn",
                table: "Roturas",
                column: "IdUn");

            migrationBuilder.AddForeignKey(
                name: "FK_Roturas_Roturas_UN_IdUn",
                table: "Roturas",
                column: "IdUn",
                principalTable: "Roturas_UN",
                principalColumn: "IdUN",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roturas_Roturas_UN_IdUn",
                table: "Roturas");

            migrationBuilder.DropTable(
                name: "Roturas_UN");

            migrationBuilder.DropIndex(
                name: "IX_Roturas_IdUn",
                table: "Roturas");
        }
    }
}
