using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VoluntariosAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entorno",
                columns: table => new
                {
                    EntornoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEntorno = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entorno", x => x.EntornoID);
                });

            migrationBuilder.CreateTable(
                name: "Estadopostulacion",
                columns: table => new
                {
                    EstadopostulacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadopostulacion", x => x.EstadopostulacionID);
                });

            migrationBuilder.CreateTable(
                name: "Intensidad",
                columns: table => new
                {
                    IntensidadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIntensidad = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intensidad", x => x.IntensidadID);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    PaisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePais = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.PaisID);
                });

            migrationBuilder.CreateTable(
                name: "Social",
                columns: table => new
                {
                    SocialID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoSocial = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Social", x => x.SocialID);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    ProvinciaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaisID = table.Column<int>(nullable: false),
                    NombreProvincia = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.ProvinciaID);
                    table.ForeignKey(
                        name: "FK_Provincia_Pais_PaisID",
                        column: x => x.PaisID,
                        principalTable: "Pais",
                        principalColumn: "PaisID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    LocalidadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinciaID = table.Column<int>(nullable: false),
                    TipoLocalidad = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.LocalidadID);
                    table.ForeignKey(
                        name: "FK_Localidad_Provincia_ProvinciaID",
                        column: x => x.ProvinciaID,
                        principalTable: "Provincia",
                        principalColumn: "ProvinciaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizacion",
                columns: table => new
                {
                    OrganizacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(nullable: true),
                    RazonSocial = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    CUIT = table.Column<string>(maxLength: 11, nullable: false),
                    NombreResponsable = table.Column<string>(nullable: false),
                    ApellidoResponsable = table.Column<string>(nullable: false),
                    DNIResponsable = table.Column<string>(maxLength: 9, nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    LocalidadID = table.Column<int>(nullable: true),
                    ProvinciaID = table.Column<int>(nullable: true),
                    PaisID = table.Column<int>(nullable: true),
                    Mail = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false),
                    Verificacion = table.Column<bool>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FechaVerificacion = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizacion", x => x.OrganizacionID);
                    table.ForeignKey(
                        name: "FK_Organizacion_Localidad_LocalidadID",
                        column: x => x.LocalidadID,
                        principalTable: "Localidad",
                        principalColumn: "LocalidadID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organizacion_Pais_PaisID",
                        column: x => x.PaisID,
                        principalTable: "Pais",
                        principalColumn: "PaisID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organizacion_Provincia_ProvinciaID",
                        column: x => x.ProvinciaID,
                        principalTable: "Provincia",
                        principalColumn: "ProvinciaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Voluntario",
                columns: table => new
                {
                    VolutnarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    DNI = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    LocalidadID = table.Column<int>(nullable: true),
                    ProvinciaID = table.Column<int>(nullable: true),
                    PaisID = table.Column<int>(nullable: true),
                    Mail = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false),
                    EntornoID = table.Column<int>(nullable: false),
                    IntensidadID = table.Column<int>(nullable: false),
                    SocialID = table.Column<int>(nullable: false),
                    Verificacion = table.Column<bool>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FechaVerificacion = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voluntario", x => x.VolutnarioID);
                    table.ForeignKey(
                        name: "FK_Voluntario_Entorno_EntornoID",
                        column: x => x.EntornoID,
                        principalTable: "Entorno",
                        principalColumn: "EntornoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voluntario_Intensidad_IntensidadID",
                        column: x => x.IntensidadID,
                        principalTable: "Intensidad",
                        principalColumn: "IntensidadID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voluntario_Localidad_LocalidadID",
                        column: x => x.LocalidadID,
                        principalTable: "Localidad",
                        principalColumn: "LocalidadID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voluntario_Pais_PaisID",
                        column: x => x.PaisID,
                        principalTable: "Pais",
                        principalColumn: "PaisID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voluntario_Provincia_ProvinciaID",
                        column: x => x.ProvinciaID,
                        principalTable: "Provincia",
                        principalColumn: "ProvinciaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voluntario_Social_SocialID",
                        column: x => x.SocialID,
                        principalTable: "Social",
                        principalColumn: "SocialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oportunidad",
                columns: table => new
                {
                    OportunidadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(nullable: true),
                    OrganizacionID = table.Column<int>(nullable: false),
                    Actividad = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    Rol = table.Column<string>(nullable: false),
                    EntornoID = table.Column<int>(nullable: false),
                    IntensidadID = table.Column<int>(nullable: false),
                    SocialID = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    LocalidadID = table.Column<int>(nullable: true),
                    ProvinciaID = table.Column<int>(nullable: true),
                    PaisID = table.Column<int>(nullable: true),
                    FechaPublicacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oportunidad", x => x.OportunidadID);
                    table.ForeignKey(
                        name: "FK_Oportunidad_Entorno_EntornoID",
                        column: x => x.EntornoID,
                        principalTable: "Entorno",
                        principalColumn: "EntornoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oportunidad_Intensidad_IntensidadID",
                        column: x => x.IntensidadID,
                        principalTable: "Intensidad",
                        principalColumn: "IntensidadID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oportunidad_Localidad_LocalidadID",
                        column: x => x.LocalidadID,
                        principalTable: "Localidad",
                        principalColumn: "LocalidadID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Oportunidad_Organizacion_OrganizacionID",
                        column: x => x.OrganizacionID,
                        principalTable: "Organizacion",
                        principalColumn: "OrganizacionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oportunidad_Pais_PaisID",
                        column: x => x.PaisID,
                        principalTable: "Pais",
                        principalColumn: "PaisID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Oportunidad_Provincia_ProvinciaID",
                        column: x => x.ProvinciaID,
                        principalTable: "Provincia",
                        principalColumn: "ProvinciaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Oportunidad_Social_SocialID",
                        column: x => x.SocialID,
                        principalTable: "Social",
                        principalColumn: "SocialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Postulacion",
                columns: table => new
                {
                    PostulacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OportunidadID = table.Column<int>(nullable: false),
                    VoluntarioID = table.Column<int>(nullable: true),
                    FechaPostulacion = table.Column<DateTime>(nullable: false),
                    EstadopostulacionID = table.Column<int>(nullable: false),
                    Mensaje = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postulacion", x => x.PostulacionID);
                    table.ForeignKey(
                        name: "FK_Postulacion_Estadopostulacion_EstadopostulacionID",
                        column: x => x.EstadopostulacionID,
                        principalTable: "Estadopostulacion",
                        principalColumn: "EstadopostulacionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Postulacion_Oportunidad_OportunidadID",
                        column: x => x.OportunidadID,
                        principalTable: "Oportunidad",
                        principalColumn: "OportunidadID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Postulacion_Voluntario_VoluntarioID",
                        column: x => x.VoluntarioID,
                        principalTable: "Voluntario",
                        principalColumn: "VolutnarioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Localidad_ProvinciaID",
                table: "Localidad",
                column: "ProvinciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Oportunidad_EntornoID",
                table: "Oportunidad",
                column: "EntornoID");

            migrationBuilder.CreateIndex(
                name: "IX_Oportunidad_IntensidadID",
                table: "Oportunidad",
                column: "IntensidadID");

            migrationBuilder.CreateIndex(
                name: "IX_Oportunidad_LocalidadID",
                table: "Oportunidad",
                column: "LocalidadID");

            migrationBuilder.CreateIndex(
                name: "IX_Oportunidad_OrganizacionID",
                table: "Oportunidad",
                column: "OrganizacionID");

            migrationBuilder.CreateIndex(
                name: "IX_Oportunidad_PaisID",
                table: "Oportunidad",
                column: "PaisID");

            migrationBuilder.CreateIndex(
                name: "IX_Oportunidad_ProvinciaID",
                table: "Oportunidad",
                column: "ProvinciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Oportunidad_SocialID",
                table: "Oportunidad",
                column: "SocialID");

            migrationBuilder.CreateIndex(
                name: "IX_Organizacion_LocalidadID",
                table: "Organizacion",
                column: "LocalidadID");

            migrationBuilder.CreateIndex(
                name: "IX_Organizacion_PaisID",
                table: "Organizacion",
                column: "PaisID");

            migrationBuilder.CreateIndex(
                name: "IX_Organizacion_ProvinciaID",
                table: "Organizacion",
                column: "ProvinciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Postulacion_EstadopostulacionID",
                table: "Postulacion",
                column: "EstadopostulacionID");

            migrationBuilder.CreateIndex(
                name: "IX_Postulacion_OportunidadID",
                table: "Postulacion",
                column: "OportunidadID");

            migrationBuilder.CreateIndex(
                name: "IX_Postulacion_VoluntarioID",
                table: "Postulacion",
                column: "VoluntarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_PaisID",
                table: "Provincia",
                column: "PaisID");

            migrationBuilder.CreateIndex(
                name: "IX_Voluntario_EntornoID",
                table: "Voluntario",
                column: "EntornoID");

            migrationBuilder.CreateIndex(
                name: "IX_Voluntario_IntensidadID",
                table: "Voluntario",
                column: "IntensidadID");

            migrationBuilder.CreateIndex(
                name: "IX_Voluntario_LocalidadID",
                table: "Voluntario",
                column: "LocalidadID");

            migrationBuilder.CreateIndex(
                name: "IX_Voluntario_PaisID",
                table: "Voluntario",
                column: "PaisID");

            migrationBuilder.CreateIndex(
                name: "IX_Voluntario_ProvinciaID",
                table: "Voluntario",
                column: "ProvinciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Voluntario_SocialID",
                table: "Voluntario",
                column: "SocialID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Postulacion");

            migrationBuilder.DropTable(
                name: "Estadopostulacion");

            migrationBuilder.DropTable(
                name: "Oportunidad");

            migrationBuilder.DropTable(
                name: "Voluntario");

            migrationBuilder.DropTable(
                name: "Organizacion");

            migrationBuilder.DropTable(
                name: "Entorno");

            migrationBuilder.DropTable(
                name: "Intensidad");

            migrationBuilder.DropTable(
                name: "Social");

            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
