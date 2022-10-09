using Microsoft.EntityFrameworkCore.Migrations;

namespace VoluntariosAPI.Migrations
{
    public partial class FixedImagenPropertyTypeRemoveProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Voluntario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Organizacion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Oportunidad",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
