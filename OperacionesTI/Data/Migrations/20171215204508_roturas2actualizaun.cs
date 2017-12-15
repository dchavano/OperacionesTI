using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OperacionesTI.Data.Migrations
{
    public partial class roturas2actualizaun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UnidadNegocio",
                table: "Roturas_UN",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UnidadNegocio",
                table: "Roturas_UN",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 35);
        }
    }
}
