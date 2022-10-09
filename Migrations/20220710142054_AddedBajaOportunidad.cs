using Microsoft.EntityFrameworkCore.Migrations;

namespace VoluntariosAPI.Migrations
{
    public partial class AddedBajaOportunidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Baja",
                table: "Oportunidad",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Baja",
                table: "Oportunidad");
        }
    }
}
