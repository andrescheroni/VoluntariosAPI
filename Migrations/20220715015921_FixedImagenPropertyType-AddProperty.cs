using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VoluntariosAPI.Migrations
{
    public partial class FixedImagenPropertyTypeAddProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Voluntario",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Organizacion",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Oportunidad",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Voluntario");

            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Organizacion");

            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Oportunidad");
        }
    }
}
