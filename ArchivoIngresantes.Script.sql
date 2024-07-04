USE [master]
GO
/****** Object:  Database [ArchivoIngresantes]    Script Date: 2/7/2024 23:51:04 ******/
CREATE DATABASE [ArchivoIngresantes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ArchivoIngresantes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ArchivoIngresantes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ArchivoIngresantes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ArchivoIngresantes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ArchivoIngresantes] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ArchivoIngresantes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ArchivoIngresantes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET ARITHABORT OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ArchivoIngresantes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ArchivoIngresantes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ArchivoIngresantes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ArchivoIngresantes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ArchivoIngresantes] SET  MULTI_USER 
GO
ALTER DATABASE [ArchivoIngresantes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ArchivoIngresantes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ArchivoIngresantes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ArchivoIngresantes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ArchivoIngresantes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ArchivoIngresantes] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ArchivoIngresantes] SET QUERY_STORE = ON
GO
ALTER DATABASE [ArchivoIngresantes] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ArchivoIngresantes]
GO
/****** Object:  Table [dbo].[Ingresantes]    Script Date: 2/7/2024 23:51:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingresantes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Direccion] [nvarchar](200) NULL,
	[Edad] [int] NULL,
	[CUIT] [nvarchar](20) NULL,
	[Genero] [nvarchar](50) NULL,
	[Curso] [nvarchar](100) NULL,
	[Pais] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ingresantes] ON 

INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (1, N'Micaela', N'Garibaldi', 18, N'20-39123865-1', N'Femenino', N'C#', N'Argentina')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (2, N'Micaela', N'Garibaldi', 18, N'20-39123865-1', N'Femenino', N'JavaScript', N'Argentina')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (3, N'Mica', N'garibaldi', 18, N'20-39123865-1', N'Femenino', N'C++', N'Argentina')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (4, N'Virginia', N'las heras', 18, N'20-39123865-1', N'Femenino', N'C#', N'Chile')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (5, N'Virginia', N'las heras', 18, N'20-39123865-1', N'Femenino', N'JavaScript', N'Chile')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (6, N'Alejandro', N'las heras', 18, N'20-39123865-1', N'Masculino', N'C++', N'Uruguay')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (7, N'ROLY', N'suiza', 18, N'20-39123865-1', N'Masculino', N'JavaScript', N'Argentina')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (8, N'Federico', N'anduiza', 18, N'20-39123865-1', N'Masculino', N'C#', N'Uruguay')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (9, N'Micaela', N'guemes', 18, N'20-39123865-1', N'Femenino', N'C#', N'Argentina')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (10, N'Micaela', N'guemes', 18, N'20-39123865-1', N'Femenino', N'JavaScript', N'Argentina')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (11, N'Micaela Liotta', N'Garibaldi', 28, N'20-39123865-1', N'Femenino', N'C#', N'Argentina')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (12, N'Micaela Liotta', N'Garibaldi', 28, N'20-39123865-1', N'Femenino', N'JavaScript', N'Argentina')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (13, N'Alejandro', N'guemes', 18, N'20-35463280-3', N'Masculino', N'C#', N'Argentina')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (14, N'Alejandro', N'guemes', 18, N'20-35463280-3', N'Masculino', N'JavaScript', N'Argentina')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (15, N'Juan', N'calle falsa', 18, N'33-50424540-9', N'Femenino', N'C#', N'Chile')
INSERT [dbo].[Ingresantes] ([ID], [Nombre], [Direccion], [Edad], [CUIT], [Genero], [Curso], [Pais]) VALUES (16, N'Juan', N'calle falsa', 18, N'33-50424540-9', N'Femenino', N'JavaScript', N'Chile')
SET IDENTITY_INSERT [dbo].[Ingresantes] OFF
GO
USE [master]
GO
ALTER DATABASE [ArchivoIngresantes] SET  READ_WRITE 
GO
