USE [master]
GO
/****** Object:  Database [VoluntariosDB]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE DATABASE [VoluntariosDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VoluntariosDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VoluntariosDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VoluntariosDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VoluntariosDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VoluntariosDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VoluntariosDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VoluntariosDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VoluntariosDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VoluntariosDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VoluntariosDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VoluntariosDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [VoluntariosDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VoluntariosDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VoluntariosDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VoluntariosDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VoluntariosDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VoluntariosDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VoluntariosDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VoluntariosDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VoluntariosDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VoluntariosDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VoluntariosDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VoluntariosDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VoluntariosDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VoluntariosDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VoluntariosDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VoluntariosDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [VoluntariosDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VoluntariosDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VoluntariosDB] SET  MULTI_USER 
GO
ALTER DATABASE [VoluntariosDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VoluntariosDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VoluntariosDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VoluntariosDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VoluntariosDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VoluntariosDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [VoluntariosDB] SET QUERY_STORE = OFF
GO
USE [VoluntariosDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entorno]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entorno](
	[EntornoID] [int] IDENTITY(1,1) NOT NULL,
	[TipoEntorno] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Entorno] PRIMARY KEY CLUSTERED 
(
	[EntornoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoPostulacion]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoPostulacion](
	[EstadoPostulacionID] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_EstadoPostulacion] PRIMARY KEY CLUSTERED 
(
	[EstadoPostulacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Intensidad]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Intensidad](
	[IntensidadID] [int] IDENTITY(1,1) NOT NULL,
	[TipoIntensidad] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Intensidad] PRIMARY KEY CLUSTERED 
(
	[IntensidadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[LocalidadID] [int] IDENTITY(1,1) NOT NULL,
	[ProvinciaID] [int] NOT NULL,
	[TipoLocalidad] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[LocalidadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oportunidad]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oportunidad](
	[OportunidadID] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [nvarchar](max) NULL,
	[OrganizacionID] [int] NOT NULL,
	[Actividad] [nvarchar](max) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Rol] [nvarchar](max) NOT NULL,
	[EntornoID] [int] NOT NULL,
	[IntensidadID] [int] NOT NULL,
	[SocialID] [int] NOT NULL,
	[FechaInicio] [datetime2](7) NOT NULL,
	[FechaFin] [datetime2](7) NOT NULL,
	[LocalidadID] [int] NULL,
	[ProvinciaID] [int] NULL,
	[PaisID] [int] NULL,
	[FechaPublicacion] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Oportunidad] PRIMARY KEY CLUSTERED 
(
	[OportunidadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organizacion]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organizacion](
	[OrganizacionID] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [nvarchar](max) NULL,
	[RazonSocial] [nvarchar](max) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[CUIT] [nvarchar](11) NOT NULL,
	[NombreResponsable] [nvarchar](max) NOT NULL,
	[ApellidoResponsable] [nvarchar](max) NOT NULL,
	[DNIResponsable] [nvarchar](9) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[LocalidadID] [int] NULL,
	[ProvinciaID] [int] NULL,
	[PaisID] [int] NULL,
	[Mail] [nvarchar](max) NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Verificacion] [bit] NOT NULL,
	[FechaRegistro] [datetime2](7) NOT NULL,
	[FechaVerificacion] [datetime2](7) NULL,
 CONSTRAINT [PK_Organizacion] PRIMARY KEY CLUSTERED 
(
	[OrganizacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[PaisID] [int] IDENTITY(1,1) NOT NULL,
	[NombrePais] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[PaisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Postulacion]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Postulacion](
	[PostulacionID] [int] IDENTITY(1,1) NOT NULL,
	[OportunidadID] [int] NOT NULL,
	[VoluntarioID] [int] NULL,
	[FechaPostulacion] [datetime2](7) NOT NULL,
	[EstadoPostulacionID] [int] NOT NULL,
	[Mensaje] [nvarchar](max) NULL,
 CONSTRAINT [PK_Postulacion] PRIMARY KEY CLUSTERED 
(
	[PostulacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[ProvinciaID] [int] IDENTITY(1,1) NOT NULL,
	[PaisID] [int] NOT NULL,
	[NombreProvincia] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[ProvinciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Social]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Social](
	[SocialID] [int] IDENTITY(1,1) NOT NULL,
	[TipoSocial] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Social] PRIMARY KEY CLUSTERED 
(
	[SocialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voluntario]    Script Date: 6/7/2022 11:08:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voluntario](
	[VolutnarioID] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[FechaNacimiento] [datetime2](7) NOT NULL,
	[DNI] [int] NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[LocalidadID] [int] NULL,
	[ProvinciaID] [int] NULL,
	[PaisID] [int] NULL,
	[Mail] [nvarchar](max) NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[EntornoID] [int] NOT NULL,
	[IntensidadID] [int] NOT NULL,
	[SocialID] [int] NOT NULL,
	[Verificacion] [bit] NOT NULL,
	[FechaRegistro] [datetime2](7) NOT NULL,
	[FechaVerificacion] [datetime2](7) NULL,
 CONSTRAINT [PK_Voluntario] PRIMARY KEY CLUSTERED 
(
	[VolutnarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Localidad_ProvinciaID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Localidad_ProvinciaID] ON [dbo].[Localidad]
(
	[ProvinciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Oportunidad_EntornoID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Oportunidad_EntornoID] ON [dbo].[Oportunidad]
(
	[EntornoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Oportunidad_IntensidadID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Oportunidad_IntensidadID] ON [dbo].[Oportunidad]
(
	[IntensidadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Oportunidad_LocalidadID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Oportunidad_LocalidadID] ON [dbo].[Oportunidad]
(
	[LocalidadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Oportunidad_OrganizacionID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Oportunidad_OrganizacionID] ON [dbo].[Oportunidad]
(
	[OrganizacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Oportunidad_PaisID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Oportunidad_PaisID] ON [dbo].[Oportunidad]
(
	[PaisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Oportunidad_ProvinciaID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Oportunidad_ProvinciaID] ON [dbo].[Oportunidad]
(
	[ProvinciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Oportunidad_SocialID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Oportunidad_SocialID] ON [dbo].[Oportunidad]
(
	[SocialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Organizacion_LocalidadID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Organizacion_LocalidadID] ON [dbo].[Organizacion]
(
	[LocalidadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Organizacion_PaisID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Organizacion_PaisID] ON [dbo].[Organizacion]
(
	[PaisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Organizacion_ProvinciaID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Organizacion_ProvinciaID] ON [dbo].[Organizacion]
(
	[ProvinciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Postulacion_EstadoPostulacionID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Postulacion_EstadoPostulacionID] ON [dbo].[Postulacion]
(
	[EstadoPostulacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Postulacion_OportunidadID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Postulacion_OportunidadID] ON [dbo].[Postulacion]
(
	[OportunidadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Postulacion_VoluntarioID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Postulacion_VoluntarioID] ON [dbo].[Postulacion]
(
	[VoluntarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Provincia_PaisID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Provincia_PaisID] ON [dbo].[Provincia]
(
	[PaisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Voluntario_EntornoID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Voluntario_EntornoID] ON [dbo].[Voluntario]
(
	[EntornoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Voluntario_IntensidadID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Voluntario_IntensidadID] ON [dbo].[Voluntario]
(
	[IntensidadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Voluntario_LocalidadID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Voluntario_LocalidadID] ON [dbo].[Voluntario]
(
	[LocalidadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Voluntario_PaisID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Voluntario_PaisID] ON [dbo].[Voluntario]
(
	[PaisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Voluntario_ProvinciaID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Voluntario_ProvinciaID] ON [dbo].[Voluntario]
(
	[ProvinciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Voluntario_SocialID]    Script Date: 6/7/2022 11:08:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_Voluntario_SocialID] ON [dbo].[Voluntario]
(
	[SocialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Localidad_Provincia_ProvinciaID] FOREIGN KEY([ProvinciaID])
REFERENCES [dbo].[Provincia] ([ProvinciaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Localidad_Provincia_ProvinciaID]
GO
ALTER TABLE [dbo].[Oportunidad]  WITH CHECK ADD  CONSTRAINT [FK_Oportunidad_Entorno_EntornoID] FOREIGN KEY([EntornoID])
REFERENCES [dbo].[Entorno] ([EntornoID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Oportunidad] CHECK CONSTRAINT [FK_Oportunidad_Entorno_EntornoID]
GO
ALTER TABLE [dbo].[Oportunidad]  WITH CHECK ADD  CONSTRAINT [FK_Oportunidad_Intensidad_IntensidadID] FOREIGN KEY([IntensidadID])
REFERENCES [dbo].[Intensidad] ([IntensidadID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Oportunidad] CHECK CONSTRAINT [FK_Oportunidad_Intensidad_IntensidadID]
GO
ALTER TABLE [dbo].[Oportunidad]  WITH CHECK ADD  CONSTRAINT [FK_Oportunidad_Localidad_LocalidadID] FOREIGN KEY([LocalidadID])
REFERENCES [dbo].[Localidad] ([LocalidadID])
GO
ALTER TABLE [dbo].[Oportunidad] CHECK CONSTRAINT [FK_Oportunidad_Localidad_LocalidadID]
GO
ALTER TABLE [dbo].[Oportunidad]  WITH CHECK ADD  CONSTRAINT [FK_Oportunidad_Organizacion_OrganizacionID] FOREIGN KEY([OrganizacionID])
REFERENCES [dbo].[Organizacion] ([OrganizacionID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Oportunidad] CHECK CONSTRAINT [FK_Oportunidad_Organizacion_OrganizacionID]
GO
ALTER TABLE [dbo].[Oportunidad]  WITH CHECK ADD  CONSTRAINT [FK_Oportunidad_Pais_PaisID] FOREIGN KEY([PaisID])
REFERENCES [dbo].[Pais] ([PaisID])
GO
ALTER TABLE [dbo].[Oportunidad] CHECK CONSTRAINT [FK_Oportunidad_Pais_PaisID]
GO
ALTER TABLE [dbo].[Oportunidad]  WITH CHECK ADD  CONSTRAINT [FK_Oportunidad_Provincia_ProvinciaID] FOREIGN KEY([ProvinciaID])
REFERENCES [dbo].[Provincia] ([ProvinciaID])
GO
ALTER TABLE [dbo].[Oportunidad] CHECK CONSTRAINT [FK_Oportunidad_Provincia_ProvinciaID]
GO
ALTER TABLE [dbo].[Oportunidad]  WITH CHECK ADD  CONSTRAINT [FK_Oportunidad_Social_SocialID] FOREIGN KEY([SocialID])
REFERENCES [dbo].[Social] ([SocialID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Oportunidad] CHECK CONSTRAINT [FK_Oportunidad_Social_SocialID]
GO
ALTER TABLE [dbo].[Organizacion]  WITH CHECK ADD  CONSTRAINT [FK_Organizacion_Localidad_LocalidadID] FOREIGN KEY([LocalidadID])
REFERENCES [dbo].[Localidad] ([LocalidadID])
GO
ALTER TABLE [dbo].[Organizacion] CHECK CONSTRAINT [FK_Organizacion_Localidad_LocalidadID]
GO
ALTER TABLE [dbo].[Organizacion]  WITH CHECK ADD  CONSTRAINT [FK_Organizacion_Pais_PaisID] FOREIGN KEY([PaisID])
REFERENCES [dbo].[Pais] ([PaisID])
GO
ALTER TABLE [dbo].[Organizacion] CHECK CONSTRAINT [FK_Organizacion_Pais_PaisID]
GO
ALTER TABLE [dbo].[Organizacion]  WITH CHECK ADD  CONSTRAINT [FK_Organizacion_Provincia_ProvinciaID] FOREIGN KEY([ProvinciaID])
REFERENCES [dbo].[Provincia] ([ProvinciaID])
GO
ALTER TABLE [dbo].[Organizacion] CHECK CONSTRAINT [FK_Organizacion_Provincia_ProvinciaID]
GO
ALTER TABLE [dbo].[Postulacion]  WITH CHECK ADD  CONSTRAINT [FK_Postulacion_EstadoPostulacion_EstadoPostulacionID] FOREIGN KEY([EstadoPostulacionID])
REFERENCES [dbo].[EstadoPostulacion] ([EstadoPostulacionID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Postulacion] CHECK CONSTRAINT [FK_Postulacion_EstadoPostulacion_EstadoPostulacionID]
GO
ALTER TABLE [dbo].[Postulacion]  WITH CHECK ADD  CONSTRAINT [FK_Postulacion_Oportunidad_OportunidadID] FOREIGN KEY([OportunidadID])
REFERENCES [dbo].[Oportunidad] ([OportunidadID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Postulacion] CHECK CONSTRAINT [FK_Postulacion_Oportunidad_OportunidadID]
GO
ALTER TABLE [dbo].[Postulacion]  WITH CHECK ADD  CONSTRAINT [FK_Postulacion_Voluntario_VoluntarioID] FOREIGN KEY([VoluntarioID])
REFERENCES [dbo].[Voluntario] ([VolutnarioID])
GO
ALTER TABLE [dbo].[Postulacion] CHECK CONSTRAINT [FK_Postulacion_Voluntario_VoluntarioID]
GO
ALTER TABLE [dbo].[Provincia]  WITH CHECK ADD  CONSTRAINT [FK_Provincia_Pais_PaisID] FOREIGN KEY([PaisID])
REFERENCES [dbo].[Pais] ([PaisID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Provincia] CHECK CONSTRAINT [FK_Provincia_Pais_PaisID]
GO
ALTER TABLE [dbo].[Voluntario]  WITH CHECK ADD  CONSTRAINT [FK_Voluntario_Entorno_EntornoID] FOREIGN KEY([EntornoID])
REFERENCES [dbo].[Entorno] ([EntornoID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Voluntario] CHECK CONSTRAINT [FK_Voluntario_Entorno_EntornoID]
GO
ALTER TABLE [dbo].[Voluntario]  WITH CHECK ADD  CONSTRAINT [FK_Voluntario_Intensidad_IntensidadID] FOREIGN KEY([IntensidadID])
REFERENCES [dbo].[Intensidad] ([IntensidadID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Voluntario] CHECK CONSTRAINT [FK_Voluntario_Intensidad_IntensidadID]
GO
ALTER TABLE [dbo].[Voluntario]  WITH CHECK ADD  CONSTRAINT [FK_Voluntario_Localidad_LocalidadID] FOREIGN KEY([LocalidadID])
REFERENCES [dbo].[Localidad] ([LocalidadID])
GO
ALTER TABLE [dbo].[Voluntario] CHECK CONSTRAINT [FK_Voluntario_Localidad_LocalidadID]
GO
ALTER TABLE [dbo].[Voluntario]  WITH CHECK ADD  CONSTRAINT [FK_Voluntario_Pais_PaisID] FOREIGN KEY([PaisID])
REFERENCES [dbo].[Pais] ([PaisID])
GO
ALTER TABLE [dbo].[Voluntario] CHECK CONSTRAINT [FK_Voluntario_Pais_PaisID]
GO
ALTER TABLE [dbo].[Voluntario]  WITH CHECK ADD  CONSTRAINT [FK_Voluntario_Provincia_ProvinciaID] FOREIGN KEY([ProvinciaID])
REFERENCES [dbo].[Provincia] ([ProvinciaID])
GO
ALTER TABLE [dbo].[Voluntario] CHECK CONSTRAINT [FK_Voluntario_Provincia_ProvinciaID]
GO
ALTER TABLE [dbo].[Voluntario]  WITH CHECK ADD  CONSTRAINT [FK_Voluntario_Social_SocialID] FOREIGN KEY([SocialID])
REFERENCES [dbo].[Social] ([SocialID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Voluntario] CHECK CONSTRAINT [FK_Voluntario_Social_SocialID]
GO
USE [master]
GO
ALTER DATABASE [VoluntariosDB] SET  READ_WRITE 
GO
