USE [master]
GO
/****** Object:  Database [CuadernoDeComunicaciones]    Script Date: 21/11/2023 18:18:04 ******/
CREATE DATABASE [CuadernoDeComunicaciones]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CuadernoDeComunicaciones', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CuadernoDeComunicaciones.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CuadernoDeComunicaciones_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CuadernoDeComunicaciones_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CuadernoDeComunicaciones].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET ARITHABORT OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET RECOVERY FULL 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET  MULTI_USER 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET PAGE_VERIFY NONE  
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET QUERY_STORE = OFF
GO
USE [CuadernoDeComunicaciones]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 21/11/2023 18:18:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Padre] [nvarchar](50) NULL,
	[Madre] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calificaciones]    Script Date: 21/11/2023 18:18:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calificaciones](
	[CalificacionNro] [int] NOT NULL,
	[Remitente] [nvarchar](255) NULL,
	[Alumno] [nvarchar](255) NULL,
	[Nota] [float] NULL,
	[Materia] [nvarchar](255) NULL,
	[Concepto] [nvarchar](255) NULL,
	[Observaciones] [nvarchar](4000) NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CalificacionNro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comunicaciones]    Script Date: 21/11/2023 18:18:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comunicaciones](
	[ComunicacionNro] [int] NOT NULL,
	[Remitente] [nvarchar](255) NULL,
	[Alumno] [nvarchar](255) NULL,
	[Categoria] [nvarchar](255) NULL,
	[Texto] [nvarchar](4000) NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ComunicacionNro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Elementos]    Script Date: 21/11/2023 18:18:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Elementos](
	[Remitente] [nvarchar](255) NULL,
	[Fecha] [datetime] NULL,
	[Alumno] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 21/11/2023 18:18:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NULL,
	[Perfil] [nvarchar](50) NULL,
	[NombreCompleto] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alumnos]  WITH CHECK ADD FOREIGN KEY([NombreUsuario])
REFERENCES [dbo].[Usuarios] ([NombreUsuario])
GO
USE [master]
GO
ALTER DATABASE [CuadernoDeComunicaciones] SET  READ_WRITE 
GO



-- Agregar columna IdDivision a la tabla Usuarios
ALTER TABLE Usuarios
ADD IdDivision INT NULL;

-- Añadir clave foránea a la columna IdDivision referenciando la tabla Divisiones
ALTER TABLE Usuarios
ADD FOREIGN KEY (IdDivision)
REFERENCES Divisiones(IdDivision);
