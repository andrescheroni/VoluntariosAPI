﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoluntariosAPI.Data;

namespace VoluntariosAPI.Migrations
{
    [DbContext(typeof(VoluntariosAPIContext))]
    [Migration("20220715015921_FixedImagenPropertyType-AddProperty")]
    partial class FixedImagenPropertyTypeAddProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VoluntariosAPI.Models.Entorno", b =>
                {
                    b.Property<int>("EntornoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoEntorno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntornoID");

                    b.ToTable("Entorno");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Estadopostulacion", b =>
                {
                    b.Property<int>("EstadopostulacionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadopostulacionID");

                    b.ToTable("Estadopostulacion");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Intensidad", b =>
                {
                    b.Property<int>("IntensidadID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoIntensidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IntensidadID");

                    b.ToTable("Intensidad");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Localidad", b =>
                {
                    b.Property<int>("LocalidadID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProvinciaID")
                        .HasColumnType("int");

                    b.Property<string>("TipoLocalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocalidadID");

                    b.HasIndex("ProvinciaID");

                    b.ToTable("Localidad");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Oportunidad", b =>
                {
                    b.Property<int>("OportunidadID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Actividad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Baja")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EntornoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("IntensidadID")
                        .HasColumnType("int");

                    b.Property<int?>("LocalidadID")
                        .HasColumnType("int");

                    b.Property<int>("OrganizacionID")
                        .HasColumnType("int");

                    b.Property<int?>("PaisID")
                        .HasColumnType("int");

                    b.Property<int?>("ProvinciaID")
                        .HasColumnType("int");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocialID")
                        .HasColumnType("int");

                    b.HasKey("OportunidadID");

                    b.HasIndex("EntornoID");

                    b.HasIndex("IntensidadID");

                    b.HasIndex("LocalidadID");

                    b.HasIndex("OrganizacionID");

                    b.HasIndex("PaisID");

                    b.HasIndex("ProvinciaID");

                    b.HasIndex("SocialID");

                    b.ToTable("Oportunidad");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Organizacion", b =>
                {
                    b.Property<int>("OrganizacionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoResponsable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CUIT")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("DNIResponsable")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaVerificacion")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("LocalidadID")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreResponsable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaisID")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinciaID")
                        .HasColumnType("int");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Verificacion")
                        .HasColumnType("bit");

                    b.HasKey("OrganizacionID");

                    b.HasIndex("LocalidadID");

                    b.HasIndex("PaisID");

                    b.HasIndex("ProvinciaID");

                    b.ToTable("Organizacion");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Pais", b =>
                {
                    b.Property<int>("PaisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaisID");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Postulacion", b =>
                {
                    b.Property<int>("PostulacionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstadopostulacionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPostulacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mensaje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OportunidadID")
                        .HasColumnType("int");

                    b.Property<int?>("VoluntarioID")
                        .HasColumnType("int");

                    b.HasKey("PostulacionID");

                    b.HasIndex("EstadopostulacionID");

                    b.HasIndex("OportunidadID");

                    b.HasIndex("VoluntarioID");

                    b.ToTable("Postulacion");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Provincia", b =>
                {
                    b.Property<int>("ProvinciaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreProvincia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaisID")
                        .HasColumnType("int");

                    b.HasKey("ProvinciaID");

                    b.HasIndex("PaisID");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Social", b =>
                {
                    b.Property<int>("SocialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialID");

                    b.ToTable("Social");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Voluntario", b =>
                {
                    b.Property<int>("VolutnarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EntornoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaVerificacion")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("IntensidadID")
                        .HasColumnType("int");

                    b.Property<int?>("LocalidadID")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaisID")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinciaID")
                        .HasColumnType("int");

                    b.Property<int>("SocialID")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Verificacion")
                        .HasColumnType("bit");

                    b.HasKey("VolutnarioID");

                    b.HasIndex("EntornoID");

                    b.HasIndex("IntensidadID");

                    b.HasIndex("LocalidadID");

                    b.HasIndex("PaisID");

                    b.HasIndex("ProvinciaID");

                    b.HasIndex("SocialID");

                    b.ToTable("Voluntario");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Localidad", b =>
                {
                    b.HasOne("VoluntariosAPI.Models.Provincia", "Provincia")
                        .WithMany("Localidades")
                        .HasForeignKey("ProvinciaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Oportunidad", b =>
                {
                    b.HasOne("VoluntariosAPI.Models.Entorno", "Entorno")
                        .WithMany("Oportunidades")
                        .HasForeignKey("EntornoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VoluntariosAPI.Models.Intensidad", "Intensidad")
                        .WithMany("Oportunidades")
                        .HasForeignKey("IntensidadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VoluntariosAPI.Models.Localidad", "Localidad")
                        .WithMany("Oportunidades")
                        .HasForeignKey("LocalidadID");

                    b.HasOne("VoluntariosAPI.Models.Organizacion", "Organizacion")
                        .WithMany("Oportunidades")
                        .HasForeignKey("OrganizacionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VoluntariosAPI.Models.Pais", "Pais")
                        .WithMany("Oportunidades")
                        .HasForeignKey("PaisID");

                    b.HasOne("VoluntariosAPI.Models.Provincia", "Provincia")
                        .WithMany("Oportunidades")
                        .HasForeignKey("ProvinciaID");

                    b.HasOne("VoluntariosAPI.Models.Social", "Social")
                        .WithMany("Oportunidades")
                        .HasForeignKey("SocialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entorno");

                    b.Navigation("Intensidad");

                    b.Navigation("Localidad");

                    b.Navigation("Organizacion");

                    b.Navigation("Pais");

                    b.Navigation("Provincia");

                    b.Navigation("Social");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Organizacion", b =>
                {
                    b.HasOne("VoluntariosAPI.Models.Localidad", "Localidad")
                        .WithMany("Organizaciones")
                        .HasForeignKey("LocalidadID");

                    b.HasOne("VoluntariosAPI.Models.Pais", "Pais")
                        .WithMany("Organizaciones")
                        .HasForeignKey("PaisID");

                    b.HasOne("VoluntariosAPI.Models.Provincia", "Provincia")
                        .WithMany("Organizaciones")
                        .HasForeignKey("ProvinciaID");

                    b.Navigation("Localidad");

                    b.Navigation("Pais");

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Postulacion", b =>
                {
                    b.HasOne("VoluntariosAPI.Models.Estadopostulacion", "Estado")
                        .WithMany("Postulaciones")
                        .HasForeignKey("EstadopostulacionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VoluntariosAPI.Models.Oportunidad", "Oportunidad")
                        .WithMany("Postulaciones")
                        .HasForeignKey("OportunidadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VoluntariosAPI.Models.Voluntario", "Voluntario")
                        .WithMany("Postulaciones")
                        .HasForeignKey("VoluntarioID");

                    b.Navigation("Estado");

                    b.Navigation("Oportunidad");

                    b.Navigation("Voluntario");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Provincia", b =>
                {
                    b.HasOne("VoluntariosAPI.Models.Pais", "Pais")
                        .WithMany("Provincias")
                        .HasForeignKey("PaisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Voluntario", b =>
                {
                    b.HasOne("VoluntariosAPI.Models.Entorno", "Entorno")
                        .WithMany("Voluntarios")
                        .HasForeignKey("EntornoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VoluntariosAPI.Models.Intensidad", "Intensidad")
                        .WithMany("Voluntarios")
                        .HasForeignKey("IntensidadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VoluntariosAPI.Models.Localidad", "Localidad")
                        .WithMany("Voluntarios")
                        .HasForeignKey("LocalidadID");

                    b.HasOne("VoluntariosAPI.Models.Pais", "Pais")
                        .WithMany("Voluntarios")
                        .HasForeignKey("PaisID");

                    b.HasOne("VoluntariosAPI.Models.Provincia", "Provincia")
                        .WithMany("Voluntarios")
                        .HasForeignKey("ProvinciaID");

                    b.HasOne("VoluntariosAPI.Models.Social", "Social")
                        .WithMany("Voluntarios")
                        .HasForeignKey("SocialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entorno");

                    b.Navigation("Intensidad");

                    b.Navigation("Localidad");

                    b.Navigation("Pais");

                    b.Navigation("Provincia");

                    b.Navigation("Social");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Entorno", b =>
                {
                    b.Navigation("Oportunidades");

                    b.Navigation("Voluntarios");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Estadopostulacion", b =>
                {
                    b.Navigation("Postulaciones");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Intensidad", b =>
                {
                    b.Navigation("Oportunidades");

                    b.Navigation("Voluntarios");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Localidad", b =>
                {
                    b.Navigation("Oportunidades");

                    b.Navigation("Organizaciones");

                    b.Navigation("Voluntarios");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Oportunidad", b =>
                {
                    b.Navigation("Postulaciones");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Organizacion", b =>
                {
                    b.Navigation("Oportunidades");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Pais", b =>
                {
                    b.Navigation("Oportunidades");

                    b.Navigation("Organizaciones");

                    b.Navigation("Provincias");

                    b.Navigation("Voluntarios");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Provincia", b =>
                {
                    b.Navigation("Localidades");

                    b.Navigation("Oportunidades");

                    b.Navigation("Organizaciones");

                    b.Navigation("Voluntarios");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Social", b =>
                {
                    b.Navigation("Oportunidades");

                    b.Navigation("Voluntarios");
                });

            modelBuilder.Entity("VoluntariosAPI.Models.Voluntario", b =>
                {
                    b.Navigation("Postulaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
