USE [master]
GO
/****** Object:  Database [TP_LABORATORIO_FINAL3]    Script Date: 24/11/2023 11:58:14 ******/
CREATE DATABASE [TP_LABORATORIO_FINAL3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP_LABORATORIO_FINAL3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TP_LABORATORIO_FINAL3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP_LABORATORIO_FINAL3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TP_LABORATORIO_FINAL3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP_LABORATORIO_FINAL3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET  MULTI_USER 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET QUERY_STORE = ON
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TP_LABORATORIO_FINAL3]
GO
/****** Object:  Table [dbo].[Actores]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actores](
	[id_actor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[id_pais] [int] NULL,
 CONSTRAINT [PK_ACTORES] PRIMARY KEY CLUSTERED 
(
	[id_actor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Butacas]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Butacas](
	[id_Butaca] [int] IDENTITY(1,1) NOT NULL,
	[id_funcion] [int] NULL,
	[estado] [varchar](20) NULL,
	[fila] [varchar](20) NULL,
	[columna] [int] NULL,
 CONSTRAINT [pk_id_butaca] PRIMARY KEY CLUSTERED 
(
	[id_Butaca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLASIFICACIONES_PELICULAS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLASIFICACIONES_PELICULAS](
	[id_clasificacion] [int] IDENTITY(1,1) NOT NULL,
	[edad] [int] NULL,
 CONSTRAINT [pk_clasificacion] PRIMARY KEY CLUSTERED 
(
	[id_clasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPROBANTES]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPROBANTES](
	[id_comprobante] [int] IDENTITY(1,1) NOT NULL,
	[id_forma_pago] [int] NULL,
	[Total] [decimal](10, 2) NULL,
	[id_descuento] [int] NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [pk_comprobante] PRIMARY KEY CLUSTERED 
(
	[id_comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DESCUENTOS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DESCUENTOS](
	[id_descuento] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[porcentaje] [float] NULL,
 CONSTRAINT [pk_descuento] PRIMARY KEY CLUSTERED 
(
	[id_descuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIRECTORES]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIRECTORES](
	[id_director] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[edad] [int] NULL,
	[id_pais] [int] NULL,
 CONSTRAINT [pk_id_director] PRIMARY KEY CLUSTERED 
(
	[id_director] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formas_pago]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formas_pago](
	[id_forma_pago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](20) NULL,
 CONSTRAINT [pk_forma_pago] PRIMARY KEY CLUSTERED 
(
	[id_forma_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FUNCIONES]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FUNCIONES](
	[id_funcion] [int] IDENTITY(1,1) NOT NULL,
	[id_pelicula] [int] NULL,
	[id_sala] [int] NULL,
	[Fecha] [date] NULL,
	[Horario_Inicio] [time](7) NULL,
	[Horario_Fin] [time](7) NULL,
 CONSTRAINT [pk_id_funcion] PRIMARY KEY CLUSTERED 
(
	[id_funcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GENEROS_PELICULAS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GENEROS_PELICULAS](
	[id_genero] [int] IDENTITY(1,1) NOT NULL,
	[genero] [varchar](50) NULL,
 CONSTRAINT [pk_genero] PRIMARY KEY CLUSTERED 
(
	[id_genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[id_pais] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](40) NULL,
 CONSTRAINT [PK_PAIS] PRIMARY KEY CLUSTERED 
(
	[id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PELICULAS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PELICULAS](
	[id_pelicula] [int] IDENTITY(1,1) NOT NULL,
	[id_genero] [int] NULL,
	[id_clasificacion] [int] NULL,
	[id_productora] [int] NULL,
	[id_director] [int] NULL,
	[titulo] [varchar](60) NULL,
	[duracion] [int] NULL,
	[fecha_estreno] [datetime] NULL,
 CONSTRAINT [pk_pelicula] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productoras]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productoras](
	[id_productora] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](40) NULL,
	[id_pais] [int] NULL,
 CONSTRAINT [PK_PRODUCTORAS] PRIMARY KEY CLUSTERED 
(
	[id_productora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REPARTO_PELICULA]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REPARTO_PELICULA](
	[id_pelicula] [int] NOT NULL,
	[id_actor] [int] NOT NULL,
 CONSTRAINT [pk_reparto_pelicula] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC,
	[id_actor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservas]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservas](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[id_comprobante] [int] NULL,
	[estado] [varchar](20) NULL,
 CONSTRAINT [PK_RESERVAS] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salas]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salas](
	[id_Sala] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](20) NULL,
	[id_Tipo] [int] NULL,
	[Pre_unit] [money] NULL,
 CONSTRAINT [pk_id_Sala] PRIMARY KEY CLUSTERED 
(
	[id_Sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TICKETS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TICKETS](
	[id_ticket] [int] IDENTITY(1,1) NOT NULL,
	[id_comprobante] [int] NULL,
	[id_butaca] [int] NULL,
 CONSTRAINT [pk_ticket] PRIMARY KEY CLUSTERED 
(
	[id_ticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_Sala]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_Sala](
	[id_Tipo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](20) NULL,
 CONSTRAINT [pk_idTipo] PRIMARY KEY CLUSTERED 
(
	[id_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] NOT NULL,
	[usuario] [varchar](20) NULL,
	[password] [varchar](20) NULL,
 CONSTRAINT [pk_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Actores] ON 

INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (1, N'Leonardo', N'DiCaprio', 1)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (2, N'Tom', N'Hardy', 1)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (3, N'Brad', N'Pitt', 2)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (4, N'Margot', N'Robbie', 2)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (5, N'Ricardo', N'Darín', 3)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (6, N'Érica', N'Rivas', 3)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (7, N'Leonardo', N'Sbaraglia', 3)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (8, N'Oscar', N'Martínez', 3)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (9, N'Guillermo', N'Francella', 3)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (10, N'Pablo', N'Rago', 3)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (11, N'Gastón', N'Pauls', 3)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (12, N'Leticia', N'Brédice', 3)
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [id_pais]) VALUES (13, N'Tomás', N'Fonzi', 3)
SET IDENTITY_INSERT [dbo].[Actores] OFF
GO
SET IDENTITY_INSERT [dbo].[Butacas] ON 

INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (434, 1, N'Ocupada', N'A', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (435, 1, N'Ocupada', N'A', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (436, 1, N'Disponible', N'A', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (437, 1, N'Ocupada', N'A', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (438, 1, N'Disponible', N'A', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (439, 1, N'Disponible', N'A', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (440, 1, N'Ocupada', N'A', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (441, 1, N'Disponible', N'B', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (442, 1, N'Disponible', N'B', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (443, 1, N'Disponible', N'B', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (444, 1, N'Disponible', N'B', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (445, 1, N'Disponible', N'B', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (446, 1, N'Disponible', N'B', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (447, 1, N'Disponible', N'B', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (448, 1, N'Ocupada', N'C', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (449, 1, N'Disponible', N'C', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (450, 1, N'Disponible', N'C', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (451, 1, N'Disponible', N'C', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (452, 1, N'Disponible', N'C', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (453, 1, N'Disponible', N'C', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (454, 1, N'Disponible', N'C', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (455, 1, N'Disponible', N'D', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (456, 1, N'Disponible', N'D', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (457, 1, N'Disponible', N'D', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (458, 1, N'Disponible', N'D', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (459, 1, N'Disponible', N'D', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (460, 1, N'Disponible', N'D', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (461, 1, N'Disponible', N'D', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (462, 1, N'Disponible', N'E', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (463, 1, N'Disponible', N'E', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (464, 1, N'Disponible', N'E', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (465, 1, N'Disponible', N'E', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (466, 1, N'Disponible', N'E', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (467, 1, N'Disponible', N'E', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (468, 1, N'Disponible', N'E', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (469, 2, N'Ocupada', N'A', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (470, 2, N'Disponible', N'A', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (471, 2, N'Disponible', N'A', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (472, 2, N'Disponible', N'A', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (473, 2, N'Ocupada', N'A', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (474, 2, N'Disponible', N'A', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (475, 2, N'Ocupada', N'A', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (476, 2, N'Disponible', N'B', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (477, 2, N'Ocupada', N'B', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (478, 2, N'Disponible', N'B', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (479, 2, N'Disponible', N'B', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (480, 2, N'Ocupada', N'B', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (481, 2, N'Disponible', N'B', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (482, 2, N'Disponible', N'B', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (483, 2, N'Ocupada', N'C', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (484, 2, N'Disponible', N'C', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (485, 2, N'Ocupada', N'C', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (486, 2, N'Disponible', N'C', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (487, 2, N'Disponible', N'C', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (488, 2, N'Disponible', N'C', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (489, 2, N'Disponible', N'C', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (490, 2, N'Disponible', N'D', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (491, 2, N'Disponible', N'D', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (492, 2, N'Disponible', N'D', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (493, 2, N'Disponible', N'D', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (494, 2, N'Disponible', N'D', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (495, 2, N'Disponible', N'D', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (496, 2, N'Disponible', N'D', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (497, 2, N'Ocupada', N'E', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (498, 2, N'Disponible', N'E', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (499, 2, N'Disponible', N'E', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (500, 2, N'Disponible', N'E', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (501, 2, N'Disponible', N'E', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (502, 2, N'Disponible', N'E', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (503, 2, N'Disponible', N'E', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (504, 3, N'Disponible', N'A', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (505, 3, N'Disponible', N'A', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (506, 3, N'Disponible', N'A', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (507, 3, N'Ocupada', N'A', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (508, 3, N'Disponible', N'A', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (509, 3, N'Disponible', N'A', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (510, 3, N'Disponible', N'A', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (511, 3, N'Disponible', N'B', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (512, 3, N'Disponible', N'B', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (513, 3, N'Disponible', N'B', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (514, 3, N'Disponible', N'B', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (515, 3, N'Ocupada', N'B', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (516, 3, N'Disponible', N'B', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (517, 3, N'Disponible', N'B', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (518, 3, N'Disponible', N'C', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (519, 3, N'Disponible', N'C', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (520, 3, N'Disponible', N'C', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (521, 3, N'Disponible', N'C', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (522, 3, N'Disponible', N'C', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (523, 3, N'Disponible', N'C', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (524, 3, N'Disponible', N'C', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (525, 3, N'Disponible', N'D', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (526, 3, N'Disponible', N'D', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (527, 3, N'Disponible', N'D', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (528, 3, N'Disponible', N'D', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (529, 3, N'Disponible', N'D', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (530, 3, N'Disponible', N'D', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (531, 3, N'Disponible', N'D', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (532, 3, N'Disponible', N'E', 1)
GO
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (533, 3, N'Disponible', N'E', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (534, 3, N'Disponible', N'E', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (535, 3, N'Disponible', N'E', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (536, 3, N'Disponible', N'E', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (537, 3, N'Disponible', N'E', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (538, 3, N'Disponible', N'E', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (539, 4, N'Ocupada', N'A', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (540, 4, N'Disponible', N'A', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (541, 4, N'Disponible', N'A', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (542, 4, N'Disponible', N'A', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (543, 4, N'Disponible', N'A', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (544, 4, N'Disponible', N'A', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (545, 4, N'Disponible', N'A', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (546, 4, N'Disponible', N'B', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (547, 4, N'Disponible', N'B', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (548, 4, N'Disponible', N'B', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (549, 4, N'Disponible', N'B', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (550, 4, N'Disponible', N'B', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (551, 4, N'Disponible', N'B', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (552, 4, N'Disponible', N'B', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (553, 4, N'Disponible', N'C', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (554, 4, N'Disponible', N'C', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (555, 4, N'Disponible', N'C', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (556, 4, N'Disponible', N'C', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (557, 4, N'Ocupada', N'C', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (558, 4, N'Disponible', N'C', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (559, 4, N'Disponible', N'C', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (560, 4, N'Disponible', N'D', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (561, 4, N'Disponible', N'D', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (562, 4, N'Disponible', N'D', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (563, 4, N'Disponible', N'D', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (564, 4, N'Disponible', N'D', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (565, 4, N'Disponible', N'D', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (566, 4, N'Disponible', N'D', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (567, 4, N'Ocupada', N'E', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (568, 4, N'Disponible', N'E', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (569, 4, N'Disponible', N'E', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (570, 4, N'Disponible', N'E', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (571, 4, N'Disponible', N'E', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (572, 4, N'Disponible', N'E', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (573, 4, N'Ocupada', N'E', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (574, 5, N'Disponible', N'A', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (575, 5, N'Disponible', N'A', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (576, 5, N'Disponible', N'A', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (577, 5, N'Disponible', N'A', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (578, 5, N'Disponible', N'A', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (579, 5, N'Disponible', N'A', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (580, 5, N'Disponible', N'A', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (581, 5, N'Disponible', N'B', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (582, 5, N'Disponible', N'B', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (583, 5, N'Disponible', N'B', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (584, 5, N'Disponible', N'B', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (585, 5, N'Disponible', N'B', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (586, 5, N'Disponible', N'B', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (587, 5, N'Disponible', N'B', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (588, 5, N'Disponible', N'C', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (589, 5, N'Disponible', N'C', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (590, 5, N'Disponible', N'C', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (591, 5, N'Disponible', N'C', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (592, 5, N'Disponible', N'C', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (593, 5, N'Disponible', N'C', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (594, 5, N'Disponible', N'C', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (595, 5, N'Disponible', N'D', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (596, 5, N'Disponible', N'D', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (597, 5, N'Disponible', N'D', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (598, 5, N'Disponible', N'D', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (599, 5, N'Disponible', N'D', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (600, 5, N'Disponible', N'D', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (601, 5, N'Disponible', N'D', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (602, 5, N'Disponible', N'E', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (603, 5, N'Disponible', N'E', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (604, 5, N'Disponible', N'E', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (605, 5, N'Disponible', N'E', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (606, 5, N'Disponible', N'E', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (607, 5, N'Disponible', N'E', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (608, 5, N'Disponible', N'E', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (609, 6, N'Disponible', N'A', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (610, 6, N'Disponible', N'A', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (611, 6, N'Disponible', N'A', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (612, 6, N'Disponible', N'A', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (613, 6, N'Disponible', N'A', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (614, 6, N'Disponible', N'A', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (615, 6, N'Disponible', N'A', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (616, 6, N'Disponible', N'B', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (617, 6, N'Disponible', N'B', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (618, 6, N'Disponible', N'B', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (619, 6, N'Disponible', N'B', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (620, 6, N'Disponible', N'B', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (621, 6, N'Disponible', N'B', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (622, 6, N'Disponible', N'B', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (623, 6, N'Disponible', N'C', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (624, 6, N'Disponible', N'C', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (625, 6, N'Disponible', N'C', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (626, 6, N'Disponible', N'C', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (627, 6, N'Disponible', N'C', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (628, 6, N'Disponible', N'C', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (629, 6, N'Disponible', N'C', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (630, 6, N'Disponible', N'D', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (631, 6, N'Disponible', N'D', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (632, 6, N'Disponible', N'D', 3)
GO
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (633, 6, N'Disponible', N'D', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (634, 6, N'Disponible', N'D', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (635, 6, N'Disponible', N'D', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (636, 6, N'Disponible', N'D', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (637, 6, N'Ocupada', N'E', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (638, 6, N'Disponible', N'E', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (639, 6, N'Disponible', N'E', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (640, 6, N'Disponible', N'E', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (641, 6, N'Disponible', N'E', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (642, 6, N'Disponible', N'E', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (643, 6, N'Disponible', N'E', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (644, 7, N'Disponible', N'A', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (645, 7, N'Disponible', N'A', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (646, 7, N'Disponible', N'A', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (647, 7, N'Disponible', N'A', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (648, 7, N'Disponible', N'A', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (649, 7, N'Disponible', N'A', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (650, 7, N'Disponible', N'A', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (651, 7, N'Disponible', N'B', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (652, 7, N'Disponible', N'B', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (653, 7, N'Disponible', N'B', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (654, 7, N'Disponible', N'B', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (655, 7, N'Disponible', N'B', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (656, 7, N'Disponible', N'B', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (657, 7, N'Disponible', N'B', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (658, 7, N'Disponible', N'C', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (659, 7, N'Disponible', N'C', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (660, 7, N'Disponible', N'C', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (661, 7, N'Disponible', N'C', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (662, 7, N'Disponible', N'C', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (663, 7, N'Disponible', N'C', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (664, 7, N'Disponible', N'C', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (665, 7, N'Disponible', N'D', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (666, 7, N'Disponible', N'D', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (667, 7, N'Disponible', N'D', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (668, 7, N'Disponible', N'D', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (669, 7, N'Disponible', N'D', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (670, 7, N'Disponible', N'D', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (671, 7, N'Disponible', N'D', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (672, 7, N'Disponible', N'E', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (673, 7, N'Disponible', N'E', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (674, 7, N'Disponible', N'E', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (675, 7, N'Disponible', N'E', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (676, 7, N'Disponible', N'E', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (677, 7, N'Disponible', N'E', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (678, 7, N'Disponible', N'E', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (679, 9, N'Disponible', N'A', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (680, 9, N'Disponible', N'A', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (681, 9, N'Disponible', N'A', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (682, 9, N'Disponible', N'A', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (683, 9, N'Disponible', N'A', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (684, 9, N'Disponible', N'A', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (685, 9, N'Disponible', N'A', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (686, 9, N'Disponible', N'B', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (687, 9, N'Disponible', N'B', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (688, 9, N'Disponible', N'B', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (689, 9, N'Disponible', N'B', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (690, 9, N'Disponible', N'B', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (691, 9, N'Disponible', N'B', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (692, 9, N'Disponible', N'B', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (693, 9, N'Disponible', N'C', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (694, 9, N'Disponible', N'C', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (695, 9, N'Disponible', N'C', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (696, 9, N'Disponible', N'C', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (697, 9, N'Disponible', N'C', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (698, 9, N'Disponible', N'C', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (699, 9, N'Disponible', N'C', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (700, 9, N'Disponible', N'D', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (701, 9, N'Disponible', N'D', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (702, 9, N'Disponible', N'D', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (703, 9, N'Disponible', N'D', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (704, 9, N'Disponible', N'D', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (705, 9, N'Disponible', N'D', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (706, 9, N'Disponible', N'D', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (707, 9, N'Disponible', N'E', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (708, 9, N'Disponible', N'E', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (709, 9, N'Disponible', N'E', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (710, 9, N'Disponible', N'E', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (711, 9, N'Disponible', N'E', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (712, 9, N'Disponible', N'E', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (713, 9, N'Disponible', N'E', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (714, 10, N'Disponible', N'A', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (715, 10, N'Disponible', N'A', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (716, 10, N'Disponible', N'A', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (717, 10, N'Disponible', N'A', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (718, 10, N'Disponible', N'A', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (719, 10, N'Disponible', N'A', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (720, 10, N'Disponible', N'A', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (721, 10, N'Disponible', N'B', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (722, 10, N'Disponible', N'B', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (723, 10, N'Ocupada', N'B', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (724, 10, N'Ocupada', N'B', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (725, 10, N'Disponible', N'B', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (726, 10, N'Disponible', N'B', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (727, 10, N'Disponible', N'B', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (728, 10, N'Disponible', N'C', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (729, 10, N'Disponible', N'C', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (730, 10, N'Disponible', N'C', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (731, 10, N'Disponible', N'C', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (732, 10, N'Disponible', N'C', 5)
GO
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (733, 10, N'Disponible', N'C', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (734, 10, N'Disponible', N'C', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (735, 10, N'Disponible', N'D', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (736, 10, N'Disponible', N'D', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (737, 10, N'Disponible', N'D', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (738, 10, N'Disponible', N'D', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (739, 10, N'Disponible', N'D', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (740, 10, N'Disponible', N'D', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (741, 10, N'Disponible', N'D', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (742, 10, N'Disponible', N'E', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (743, 10, N'Disponible', N'E', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (744, 10, N'Disponible', N'E', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (745, 10, N'Disponible', N'E', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (746, 10, N'Disponible', N'E', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (747, 10, N'Disponible', N'E', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (748, 10, N'Disponible', N'E', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (749, 11, N'Disponible', N'A', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (750, 11, N'Disponible', N'A', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (751, 11, N'Disponible', N'A', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (752, 11, N'Disponible', N'A', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (753, 11, N'Disponible', N'A', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (754, 11, N'Disponible', N'A', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (755, 11, N'Disponible', N'A', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (756, 11, N'Disponible', N'B', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (757, 11, N'Disponible', N'B', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (758, 11, N'Disponible', N'B', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (759, 11, N'Disponible', N'B', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (760, 11, N'Disponible', N'B', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (761, 11, N'Disponible', N'B', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (762, 11, N'Disponible', N'B', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (763, 11, N'Disponible', N'C', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (764, 11, N'Disponible', N'C', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (765, 11, N'Disponible', N'C', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (766, 11, N'Ocupada', N'C', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (767, 11, N'Disponible', N'C', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (768, 11, N'Disponible', N'C', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (769, 11, N'Disponible', N'C', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (770, 11, N'Disponible', N'D', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (771, 11, N'Disponible', N'D', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (772, 11, N'Disponible', N'D', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (773, 11, N'Disponible', N'D', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (774, 11, N'Disponible', N'D', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (775, 11, N'Disponible', N'D', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (776, 11, N'Disponible', N'D', 7)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (777, 11, N'Disponible', N'E', 1)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (778, 11, N'Disponible', N'E', 2)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (779, 11, N'Ocupada', N'E', 3)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (780, 11, N'Ocupada', N'E', 4)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (781, 11, N'Disponible', N'E', 5)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (782, 11, N'Disponible', N'E', 6)
INSERT [dbo].[Butacas] ([id_Butaca], [id_funcion], [estado], [fila], [columna]) VALUES (783, 11, N'Disponible', N'E', 7)
SET IDENTITY_INSERT [dbo].[Butacas] OFF
GO
SET IDENTITY_INSERT [dbo].[CLASIFICACIONES_PELICULAS] ON 

INSERT [dbo].[CLASIFICACIONES_PELICULAS] ([id_clasificacion], [edad]) VALUES (1, 12)
INSERT [dbo].[CLASIFICACIONES_PELICULAS] ([id_clasificacion], [edad]) VALUES (2, 18)
INSERT [dbo].[CLASIFICACIONES_PELICULAS] ([id_clasificacion], [edad]) VALUES (3, 8)
INSERT [dbo].[CLASIFICACIONES_PELICULAS] ([id_clasificacion], [edad]) VALUES (4, 21)
INSERT [dbo].[CLASIFICACIONES_PELICULAS] ([id_clasificacion], [edad]) VALUES (5, 0)
SET IDENTITY_INSERT [dbo].[CLASIFICACIONES_PELICULAS] OFF
GO
SET IDENTITY_INSERT [dbo].[COMPROBANTES] ON 

INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (1, 1, CAST(3000.00 AS Decimal(10, 2)), 1, CAST(N'2023-11-18T00:00:00.000' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (2, 2, CAST(3200.00 AS Decimal(10, 2)), 2, CAST(N'2023-11-18T00:00:00.000' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (3, 3, CAST(6400.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-18T00:00:00.000' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (4, 4, CAST(6000.00 AS Decimal(10, 2)), 2, CAST(N'2023-11-18T00:00:00.000' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (5, 1, CAST(6000.00 AS Decimal(10, 2)), 1, CAST(N'2023-11-18T00:00:00.000' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (7, 3, CAST(6400.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-18T00:00:00.000' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (15, 1, CAST(3000.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-23T11:12:36.047' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (16, 1, CAST(3000.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-23T14:01:16.627' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (17, 1, CAST(3000.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-23T14:03:28.253' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (18, 1, CAST(3000.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-23T14:04:59.500' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (19, 1, CAST(3000.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-23T14:11:35.740' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (20, 1, CAST(3000.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-23T14:16:58.253' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (21, 1, CAST(6000.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-23T14:43:09.267' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (22, 1, CAST(6000.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-23T18:54:16.943' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (23, 1, CAST(3000.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-24T01:08:01.023' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (24, 1, CAST(6400.00 AS Decimal(10, 2)), NULL, CAST(N'2023-11-24T07:15:06.913' AS DateTime))
INSERT [dbo].[COMPROBANTES] ([id_comprobante], [id_forma_pago], [Total], [id_descuento], [fecha]) VALUES (25, 4, CAST(4800.00 AS Decimal(10, 2)), 1, CAST(N'2023-11-24T11:54:13.863' AS DateTime))
SET IDENTITY_INSERT [dbo].[COMPROBANTES] OFF
GO
SET IDENTITY_INSERT [dbo].[DESCUENTOS] ON 

INSERT [dbo].[DESCUENTOS] ([id_descuento], [descripcion], [porcentaje]) VALUES (1, N'Menor', 25)
INSERT [dbo].[DESCUENTOS] ([id_descuento], [descripcion], [porcentaje]) VALUES (2, N'Jubilado', 50)
INSERT [dbo].[DESCUENTOS] ([id_descuento], [descripcion], [porcentaje]) VALUES (3, N'Estudiante', 15)
SET IDENTITY_INSERT [dbo].[DESCUENTOS] OFF
GO
SET IDENTITY_INSERT [dbo].[DIRECTORES] ON 

INSERT [dbo].[DIRECTORES] ([id_director], [nombre], [apellido], [edad], [id_pais]) VALUES (1, N'Christopher', N'Nolan', 50, 1)
INSERT [dbo].[DIRECTORES] ([id_director], [nombre], [apellido], [edad], [id_pais]) VALUES (2, N'Quentin', N'Tarantino', 58, 2)
INSERT [dbo].[DIRECTORES] ([id_director], [nombre], [apellido], [edad], [id_pais]) VALUES (3, N'Fabián', N'Bielinsky', 64, 3)
INSERT [dbo].[DIRECTORES] ([id_director], [nombre], [apellido], [edad], [id_pais]) VALUES (4, N'Juan José', N'Campanella', 64, 3)
INSERT [dbo].[DIRECTORES] ([id_director], [nombre], [apellido], [edad], [id_pais]) VALUES (5, N'Damián', N'Szifron', 48, 3)
SET IDENTITY_INSERT [dbo].[DIRECTORES] OFF
GO
SET IDENTITY_INSERT [dbo].[Formas_pago] ON 

INSERT [dbo].[Formas_pago] ([id_forma_pago], [descripcion]) VALUES (1, N'Efectivo')
INSERT [dbo].[Formas_pago] ([id_forma_pago], [descripcion]) VALUES (2, N'Tarjeta de credito')
INSERT [dbo].[Formas_pago] ([id_forma_pago], [descripcion]) VALUES (3, N'Tarjeta de debito')
INSERT [dbo].[Formas_pago] ([id_forma_pago], [descripcion]) VALUES (4, N'Transferencia')
SET IDENTITY_INSERT [dbo].[Formas_pago] OFF
GO
SET IDENTITY_INSERT [dbo].[FUNCIONES] ON 

INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (1, 1, 1, CAST(N'2023-11-15' AS Date), CAST(N'20:30:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (2, 2, 1, CAST(N'2023-11-16' AS Date), CAST(N'21:30:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (3, 3, 2, CAST(N'2023-11-17' AS Date), CAST(N'22:30:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (4, 8, 1, CAST(N'2023-11-17' AS Date), CAST(N'22:30:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (5, 6, 2, CAST(N'2023-11-18' AS Date), CAST(N'18:30:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (6, 7, 1, CAST(N'2023-11-18' AS Date), CAST(N'18:30:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (7, 8, 1, CAST(N'2023-12-01' AS Date), CAST(N'18:30:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (8, 1, 1, CAST(N'2023-11-21' AS Date), CAST(N'03:07:14.6966667' AS Time), CAST(N'03:07:14.7000000' AS Time))
INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (9, 1, 1, CAST(N'2023-11-26' AS Date), CAST(N'00:00:00' AS Time), CAST(N'02:00:00' AS Time))
INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (10, 6, 2, CAST(N'2023-12-05' AS Date), CAST(N'18:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[FUNCIONES] ([id_funcion], [id_pelicula], [id_sala], [Fecha], [Horario_Inicio], [Horario_Fin]) VALUES (11, 9, 2, CAST(N'2023-11-30' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[FUNCIONES] OFF
GO
SET IDENTITY_INSERT [dbo].[GENEROS_PELICULAS] ON 

INSERT [dbo].[GENEROS_PELICULAS] ([id_genero], [genero]) VALUES (1, N'Acción')
INSERT [dbo].[GENEROS_PELICULAS] ([id_genero], [genero]) VALUES (2, N'Drama')
INSERT [dbo].[GENEROS_PELICULAS] ([id_genero], [genero]) VALUES (3, N'Comedia')
INSERT [dbo].[GENEROS_PELICULAS] ([id_genero], [genero]) VALUES (4, N'Ciencia Ficción')
INSERT [dbo].[GENEROS_PELICULAS] ([id_genero], [genero]) VALUES (5, N'Crimen')
SET IDENTITY_INSERT [dbo].[GENEROS_PELICULAS] OFF
GO
SET IDENTITY_INSERT [dbo].[Paises] ON 

INSERT [dbo].[Paises] ([id_pais], [nombre]) VALUES (1, N'Estados Unidos')
INSERT [dbo].[Paises] ([id_pais], [nombre]) VALUES (2, N'Reino Unido')
INSERT [dbo].[Paises] ([id_pais], [nombre]) VALUES (3, N'Argentina')
SET IDENTITY_INSERT [dbo].[Paises] OFF
GO
SET IDENTITY_INSERT [dbo].[PELICULAS] ON 

INSERT [dbo].[PELICULAS] ([id_pelicula], [id_genero], [id_clasificacion], [id_productora], [id_director], [titulo], [duracion], [fecha_estreno]) VALUES (1, 1, 1, 1, 1, N'Inception', 150, CAST(N'2010-07-16T00:00:00.000' AS DateTime))
INSERT [dbo].[PELICULAS] ([id_pelicula], [id_genero], [id_clasificacion], [id_productora], [id_director], [titulo], [duracion], [fecha_estreno]) VALUES (2, 1, 1, 1, 2, N'The Dark Knight', 152, CAST(N'2008-07-18T00:00:00.000' AS DateTime))
INSERT [dbo].[PELICULAS] ([id_pelicula], [id_genero], [id_clasificacion], [id_productora], [id_director], [titulo], [duracion], [fecha_estreno]) VALUES (3, 2, 2, 2, 1, N'Pulp Fiction', 154, CAST(N'1994-10-14T00:00:00.000' AS DateTime))
INSERT [dbo].[PELICULAS] ([id_pelicula], [id_genero], [id_clasificacion], [id_productora], [id_director], [titulo], [duracion], [fecha_estreno]) VALUES (4, 2, 2, 2, 2, N'Once Upon a Time in Hollywood', 161, CAST(N'2019-07-26T00:00:00.000' AS DateTime))
INSERT [dbo].[PELICULAS] ([id_pelicula], [id_genero], [id_clasificacion], [id_productora], [id_director], [titulo], [duracion], [fecha_estreno]) VALUES (5, 1, 1, 1, 1, N'Interstellar', 169, CAST(N'2014-11-07T00:00:00.000' AS DateTime))
INSERT [dbo].[PELICULAS] ([id_pelicula], [id_genero], [id_clasificacion], [id_productora], [id_director], [titulo], [duracion], [fecha_estreno]) VALUES (6, 3, 2, 5, 3, N'Nueve Reinas', 115, CAST(N'2000-08-31T00:00:00.000' AS DateTime))
INSERT [dbo].[PELICULAS] ([id_pelicula], [id_genero], [id_clasificacion], [id_productora], [id_director], [titulo], [duracion], [fecha_estreno]) VALUES (7, 5, 2, 4, 4, N'El secreto de sus ojos', 127, CAST(N'2009-08-13T00:00:00.000' AS DateTime))
INSERT [dbo].[PELICULAS] ([id_pelicula], [id_genero], [id_clasificacion], [id_productora], [id_director], [titulo], [duracion], [fecha_estreno]) VALUES (8, 3, 2, 4, 5, N'Relatos Salvajes', 122, CAST(N'2014-08-21T00:00:00.000' AS DateTime))
INSERT [dbo].[PELICULAS] ([id_pelicula], [id_genero], [id_clasificacion], [id_productora], [id_director], [titulo], [duracion], [fecha_estreno]) VALUES (9, 3, 5, 5, 1, N'Cenicienta', 120, CAST(N'2009-12-03T11:26:59.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[PELICULAS] OFF
GO
SET IDENTITY_INSERT [dbo].[Productoras] ON 

INSERT [dbo].[Productoras] ([id_productora], [nombre], [id_pais]) VALUES (1, N'Warner Bros', 1)
INSERT [dbo].[Productoras] ([id_productora], [nombre], [id_pais]) VALUES (2, N'Universal Pictures', 2)
INSERT [dbo].[Productoras] ([id_productora], [nombre], [id_pais]) VALUES (3, N'Kramer & Sigman Films', 3)
INSERT [dbo].[Productoras] ([id_productora], [nombre], [id_pais]) VALUES (4, N'Telefe', 3)
INSERT [dbo].[Productoras] ([id_productora], [nombre], [id_pais]) VALUES (5, N'Patagonik Film', 3)
SET IDENTITY_INSERT [dbo].[Productoras] OFF
GO
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (1, 1)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (1, 2)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (1, 3)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (1, 4)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (2, 1)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (2, 2)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (2, 3)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (2, 4)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (3, 1)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (3, 2)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (3, 3)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (3, 4)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (4, 1)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (4, 2)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (4, 3)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (4, 4)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (5, 1)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (5, 2)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (5, 3)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (5, 4)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (6, 5)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (6, 11)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (6, 12)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (6, 13)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (7, 5)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (7, 9)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (7, 10)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (8, 5)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (8, 6)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (8, 7)
INSERT [dbo].[REPARTO_PELICULA] ([id_pelicula], [id_actor]) VALUES (8, 8)
GO
SET IDENTITY_INSERT [dbo].[Reservas] ON 

INSERT [dbo].[Reservas] ([id_reserva], [id_comprobante], [estado]) VALUES (1, 1, N'Pagado')
INSERT [dbo].[Reservas] ([id_reserva], [id_comprobante], [estado]) VALUES (2, 5, N'Pagado')
INSERT [dbo].[Reservas] ([id_reserva], [id_comprobante], [estado]) VALUES (3, 7, N'Pagado')
INSERT [dbo].[Reservas] ([id_reserva], [id_comprobante], [estado]) VALUES (4, 4, N'Pagado')
SET IDENTITY_INSERT [dbo].[Reservas] OFF
GO
SET IDENTITY_INSERT [dbo].[Salas] ON 

INSERT [dbo].[Salas] ([id_Sala], [descripcion], [id_Tipo], [Pre_unit]) VALUES (1, N'Sala 1', 1, 3000.0000)
INSERT [dbo].[Salas] ([id_Sala], [descripcion], [id_Tipo], [Pre_unit]) VALUES (2, N'Sala 2', 2, 3200.0000)
SET IDENTITY_INSERT [dbo].[Salas] OFF
GO
SET IDENTITY_INSERT [dbo].[TICKETS] ON 

INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (2, 1, 500)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (3, 1, 501)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (4, 1, 502)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (5, 15, 440)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (6, 16, 539)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (7, 17, 539)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (8, 18, 475)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (9, 19, 557)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (10, 20, 637)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (11, 21, 469)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (12, 21, 477)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (13, 22, 497)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (14, 22, 483)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (15, 23, 473)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (16, 24, 723)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (17, 24, 724)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (18, 25, 780)
INSERT [dbo].[TICKETS] ([id_ticket], [id_comprobante], [id_butaca]) VALUES (19, 25, 779)
SET IDENTITY_INSERT [dbo].[TICKETS] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipos_Sala] ON 

INSERT [dbo].[Tipos_Sala] ([id_Tipo], [descripcion]) VALUES (1, N'2D')
INSERT [dbo].[Tipos_Sala] ([id_Tipo], [descripcion]) VALUES (2, N'3D')
SET IDENTITY_INSERT [dbo].[Tipos_Sala] OFF
GO
INSERT [dbo].[Usuarios] ([id], [usuario], [password]) VALUES (1, N'1234', N'1234')
GO
ALTER TABLE [dbo].[Actores]  WITH CHECK ADD  CONSTRAINT [FK_ACTORES_PAISES] FOREIGN KEY([id_pais])
REFERENCES [dbo].[Paises] ([id_pais])
GO
ALTER TABLE [dbo].[Actores] CHECK CONSTRAINT [FK_ACTORES_PAISES]
GO
ALTER TABLE [dbo].[Butacas]  WITH CHECK ADD  CONSTRAINT [fk_funcion_B] FOREIGN KEY([id_funcion])
REFERENCES [dbo].[FUNCIONES] ([id_funcion])
GO
ALTER TABLE [dbo].[Butacas] CHECK CONSTRAINT [fk_funcion_B]
GO
ALTER TABLE [dbo].[COMPROBANTES]  WITH CHECK ADD  CONSTRAINT [fk_comprobante_descuento] FOREIGN KEY([id_descuento])
REFERENCES [dbo].[DESCUENTOS] ([id_descuento])
GO
ALTER TABLE [dbo].[COMPROBANTES] CHECK CONSTRAINT [fk_comprobante_descuento]
GO
ALTER TABLE [dbo].[COMPROBANTES]  WITH CHECK ADD  CONSTRAINT [fk_comprobante_pagos] FOREIGN KEY([id_forma_pago])
REFERENCES [dbo].[Formas_pago] ([id_forma_pago])
GO
ALTER TABLE [dbo].[COMPROBANTES] CHECK CONSTRAINT [fk_comprobante_pagos]
GO
ALTER TABLE [dbo].[DIRECTORES]  WITH CHECK ADD  CONSTRAINT [fk_id_pais] FOREIGN KEY([id_pais])
REFERENCES [dbo].[Paises] ([id_pais])
GO
ALTER TABLE [dbo].[DIRECTORES] CHECK CONSTRAINT [fk_id_pais]
GO
ALTER TABLE [dbo].[FUNCIONES]  WITH CHECK ADD  CONSTRAINT [fk_id_pelicula] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[PELICULAS] ([id_pelicula])
GO
ALTER TABLE [dbo].[FUNCIONES] CHECK CONSTRAINT [fk_id_pelicula]
GO
ALTER TABLE [dbo].[FUNCIONES]  WITH CHECK ADD  CONSTRAINT [fk_id_sala] FOREIGN KEY([id_sala])
REFERENCES [dbo].[Salas] ([id_Sala])
GO
ALTER TABLE [dbo].[FUNCIONES] CHECK CONSTRAINT [fk_id_sala]
GO
ALTER TABLE [dbo].[PELICULAS]  WITH CHECK ADD  CONSTRAINT [fk_clasificacion_p] FOREIGN KEY([id_clasificacion])
REFERENCES [dbo].[CLASIFICACIONES_PELICULAS] ([id_clasificacion])
GO
ALTER TABLE [dbo].[PELICULAS] CHECK CONSTRAINT [fk_clasificacion_p]
GO
ALTER TABLE [dbo].[PELICULAS]  WITH CHECK ADD  CONSTRAINT [fk_director_pelicula] FOREIGN KEY([id_director])
REFERENCES [dbo].[DIRECTORES] ([id_director])
GO
ALTER TABLE [dbo].[PELICULAS] CHECK CONSTRAINT [fk_director_pelicula]
GO
ALTER TABLE [dbo].[PELICULAS]  WITH CHECK ADD  CONSTRAINT [fk_genero_p] FOREIGN KEY([id_genero])
REFERENCES [dbo].[GENEROS_PELICULAS] ([id_genero])
GO
ALTER TABLE [dbo].[PELICULAS] CHECK CONSTRAINT [fk_genero_p]
GO
ALTER TABLE [dbo].[PELICULAS]  WITH CHECK ADD  CONSTRAINT [fk_productora_p] FOREIGN KEY([id_productora])
REFERENCES [dbo].[Productoras] ([id_productora])
GO
ALTER TABLE [dbo].[PELICULAS] CHECK CONSTRAINT [fk_productora_p]
GO
ALTER TABLE [dbo].[Productoras]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTORA_PAIS] FOREIGN KEY([id_pais])
REFERENCES [dbo].[Paises] ([id_pais])
GO
ALTER TABLE [dbo].[Productoras] CHECK CONSTRAINT [FK_PRODUCTORA_PAIS]
GO
ALTER TABLE [dbo].[REPARTO_PELICULA]  WITH CHECK ADD  CONSTRAINT [fk_id_actor] FOREIGN KEY([id_actor])
REFERENCES [dbo].[Actores] ([id_actor])
GO
ALTER TABLE [dbo].[REPARTO_PELICULA] CHECK CONSTRAINT [fk_id_actor]
GO
ALTER TABLE [dbo].[REPARTO_PELICULA]  WITH CHECK ADD  CONSTRAINT [fk_reparto_pelicula] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[PELICULAS] ([id_pelicula])
GO
ALTER TABLE [dbo].[REPARTO_PELICULA] CHECK CONSTRAINT [fk_reparto_pelicula]
GO
ALTER TABLE [dbo].[Reservas]  WITH CHECK ADD  CONSTRAINT [FK_RESERVAS_COMPROBANTES] FOREIGN KEY([id_comprobante])
REFERENCES [dbo].[COMPROBANTES] ([id_comprobante])
GO
ALTER TABLE [dbo].[Reservas] CHECK CONSTRAINT [FK_RESERVAS_COMPROBANTES]
GO
ALTER TABLE [dbo].[Salas]  WITH CHECK ADD  CONSTRAINT [fk_idTipo_ts] FOREIGN KEY([id_Tipo])
REFERENCES [dbo].[Tipos_Sala] ([id_Tipo])
GO
ALTER TABLE [dbo].[Salas] CHECK CONSTRAINT [fk_idTipo_ts]
GO
ALTER TABLE [dbo].[TICKETS]  WITH CHECK ADD  CONSTRAINT [fk_ticket_butaca] FOREIGN KEY([id_butaca])
REFERENCES [dbo].[Butacas] ([id_Butaca])
GO
ALTER TABLE [dbo].[TICKETS] CHECK CONSTRAINT [fk_ticket_butaca]
GO
ALTER TABLE [dbo].[TICKETS]  WITH CHECK ADD  CONSTRAINT [fk_ticket_comprobante] FOREIGN KEY([id_comprobante])
REFERENCES [dbo].[COMPROBANTES] ([id_comprobante])
GO
ALTER TABLE [dbo].[TICKETS] CHECK CONSTRAINT [fk_ticket_comprobante]
GO
/****** Object:  StoredProcedure [dbo].[SP_ADD_COMPROBANTE]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_ADD_COMPROBANTE]
@id_pago int,
@total decimal(10,2),
@id_descuento int,
@id_compr int output
as
begin
insert into COMPROBANTES(id_forma_pago,Total,id_descuento, fecha)
			values(@id_pago,@total,@id_descuento, GETDATE())
set @id_compr = SCOPE_IDENTITY()
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ADD_TICKET]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ADD_TICKET]
@id_comprobante int,
@id_butaca int
as
begin
insert into TICKETS(id_comprobante,id_butaca)
			values(@id_comprobante,@id_butaca)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BORRAR_FUNCION]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_BORRAR_FUNCION]
@id_funcion int
as
begin
delete FUNCIONES
where id_funcion = @id_funcion
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Buscar_Butacas]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Buscar_Butacas]
@IdFuncion int 
as begin 
select * from BUTACAS where id_funcion =@IdFuncion
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAR_PELICULAS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_BUSCAR_PELICULAS]
@titulo varchar(20) = null,
@añoEstreno int= null,
@id_Genero int =null


as 
begin 

  SELECT    P.id_pelicula  PeliculasID,
            P.titulo  PeliculaTitulo,
            P.duracion  PeliculaDuracion,
              P.fecha_estreno  PeliculaEstreno,

            G.id_genero  GeneroID,
            G.genero  GeneroDescripcion,

            C.id_clasificacion  CalificacionID,
            C.edad  CalificacionEdad,

            PR.id_productora  ProductoraID,
            PR.nombre  ProductoraNombre


    FROM PELICULAS  P
    JOIN GENEROS_PELICULAS G ON P.id_genero = G.id_genero
    JOIN CLASIFICACIONES_PELICULAS  C ON P.id_clasificacion = C.id_clasificacion
    JOIN PRODUCTORAS PR ON P.id_productora = PR.id_productora

    WHERE 
            (P.titulo LIKE '%' + @titulo + '%' OR @titulo IS NULL)
        and (@id_Genero=P.id_genero OR @id_Genero IS NULL)
         and( @añoEstreno=year(P.fecha_estreno)  OR @añoEstreno IS NULL);
        end
GO
/****** Object:  StoredProcedure [dbo].[SP_CREAR_FUNCION]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_CREAR_FUNCION]

@id_pelicula int,
@id_sala int,
@horario_inicio time,
@horario_fin time,
@fecha datetime
as
begin

insert into FUNCIONES(id_pelicula,id_sala,Horario_Inicio,Horario_Fin,Fecha)
values(@id_pelicula,@id_sala,@horario_inicio,@horario_fin,@fecha)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DESOCUPAR_BUTACA]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_DESOCUPAR_BUTACA]
@id_funcion int,
@fila varchar(1),
@col int
as
begin
update Butacas
set estado = 'Disponible'
where id_funcion = @id_funcion and fila = @fila and @col = columna
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Funciones_Fecha]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Funciones_Fecha]
@fecha datetime
as
begin 
select titulo TITULO, genero GENERO, Horario_Inicio 'HORARIO_INICIO', Horario_Fin 'HORARIO_FIN', descripcion SALA
from FUNCIONES f
join PELICULAS p on f.id_pelicula = p.id_pelicula 
join Salas s on s.id_Sala = f.id_sala
join GENEROS_PELICULAS g on g.id_genero = p.id_genero
where @fecha = Fecha
END
GO
/****** Object:  StoredProcedure [dbo].[sp_gen_por_anio]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_gen_por_anio]
@aniomin int,
@aniomax int,
@genero varchar(30)
as
select apellido, nombre, titulo, year(fecha_estreno) 'año' , 'Actor' clasificación
from peliculas p 
join REPARTO_PELICULA r on r.id_pelicula = p.id_pelicula
join actores a on r.id_actor = a.id_actor
join GENEROS_PELICULAS g on g.id_genero = p.id_genero
where year(fecha_estreno) between @aniomin and @aniomax
and genero = @genero
union
select apellido, nombre, titulo, year(fecha_estreno) 'año' , 'Director' clasificación
from peliculas p 
join DIRECTORES d on d.id_director = p.id_director
join GENEROS_PELICULAS g on g.id_genero = p.id_genero
where year(fecha_estreno) between @aniomin and @aniomax
and genero = @genero
order by 4, 1, 3 desc 
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_BUTACAS_FUNCION]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_GET_BUTACAS_FUNCION]
@id_funcion int
as
begin
select fila Fila, columna Col, estado Estado
from Butacas
where id_funcion = @id_funcion
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_BUTACAS_X_FUNCION]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_GET_BUTACAS_X_FUNCION]
@id_Funcion int
as
begin
select id_Butaca ID, fila Fila, columna Columna, estado Estado
from Butacas
where id_funcion = @id_Funcion
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_CLASIFICACIONES]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_GET_CLASIFICACIONES]
as
select * from CLASIFICACIONES_PELICULAS
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_DESCUENTOS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_GET_DESCUENTOS]
as
begin 
select * from DESCUENTOS
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_FORMA_PAGO]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_GET_FORMA_PAGO]
as
begin
select id_forma_pago ID, descripcion DESCRIPCION
from Formas_pago 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_FUNCIONES]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_GET_FUNCIONES]
@fecha date,
@titulo varchar(20)
as
begin
select f.id_funcion Id_Funcion, Horario_Inicio Inicio, Horario_Fin Fin, 
	f.id_sala Id_Sala, s.descripcion Sala, Pre_unit Pre_Unit, s.id_Tipo Id_Tipo_Sala, ts.descripcion Tipo_Sala,
	f.id_pelicula Id_Pelicula, titulo Titulo, duracion Duracion, fecha_estreno Fecha_Estreno,
	p.id_genero Id_Genero, genero Genero,
	p.id_clasificacion Id_Clasificacion, c.edad Edad_Clasf,
	p.id_productora Id_Productora, pr.nombre Productora, pr.id_pais Id_Pais_Productora,
	p.id_director Id_Director, di.nombre Nombre_Dir, di.apellido Ape_Dir, di.edad Edad_Dir, di.id_pais Id_Pais_Dir,
	pa.nombre Pais_Productora, pa2.nombre Pais_Director
from FUNCIONES f
	join PELICULAS p on p.id_pelicula = f.id_pelicula
	join Salas s on s.id_Sala = f.id_sala
	join Tipos_Sala ts on ts.id_Tipo = s.id_Tipo
	join GENEROS_PELICULAS g on g.id_genero = p.id_genero
	join CLASIFICACIONES_PELICULAS c on c.id_clasificacion = p.id_clasificacion
	join Productoras pr on pr.id_productora = p.id_productora
	join Paises pa on pa.id_pais = pr.id_pais
	join DIRECTORES di on di.id_director = p.id_director
	join Paises pa2 on pa2.id_pais = di.id_pais
	where	(Fecha = @fecha or @fecha is null) and
			(Titulo LIKE '%' + @Titulo + '%' OR @Titulo IS NULL)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_GENEROS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_GET_GENEROS] as begin select *  from GENEROS_PELICULAS end
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_PELICULAS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_GET_PELICULAS]
as
begin 
select *
from PELICULAS p join GENEROS_PELICULAS g on g.id_genero = p.id_genero
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_PRODUCTORAS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_GET_PRODUCTORAS] 
as
select p.id_productora, p.nombre, pa.id_pais, pa.nombre pais
from productoras p join paises pa on p.id_pais = pa.id_pais
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_SALAS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_GET_SALAS]
as
begin
select s.id_Sala id_Sala, s.id_Tipo id_Tipo, s.descripcion Sala, t.descripcion Tipo 
from Salas s join Tipos_Sala t on s.id_Tipo = t.id_Tipo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_USUARIOS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_GET_USUARIOS]
as
begin
select *
from usuarios
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Insertar_Pelicula]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Insertar_Pelicula]
@IdGenero int,
@IdClasificacion int,
@IdProductora int ,
@Titulo varchar (20),
@DuracionMinutos int, 
@Fecha datetime
as 
begin
 insert into PELICULAS (id_genero,id_clasificacion,id_productora,titulo,duracion,fecha_estreno,id_director)
 values (@IdGenero,@IdClasificacion,@IdProductora,@Titulo,@DuracionMinutos,@Fecha,1)
    end;
GO
/****** Object:  StoredProcedure [dbo].[SP_OCUPAR_BUTACA]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_OCUPAR_BUTACA]
@id_funcion int,
@fila varchar(1),
@col int
as
begin
update Butacas
set estado = 'Ocupada'
where id_funcion = @id_funcion and fila = @fila and @col = columna
end
GO
/****** Object:  StoredProcedure [dbo].[SP_PELICULA_ACTUALIZAR]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_PELICULA_ACTUALIZAR]

@Id int,
@IdGenero int,
@IdClasificacion int,
@IdProductora int,
@Titulo varchar (20),
@DuracionMinutos int, 
@Fecha datetime
as
begin

update PELICULAS 
       set
         id_genero = @IdGenero,
         id_clasificacion=@IdClasificacion,
         id_productora= @IdProductora,
         titulo =@Titulo,
         duracion=@DuracionMinutos,
         fecha_estreno=@Fecha
         where id_pelicula =@Id
         end
GO
/****** Object:  StoredProcedure [dbo].[SP_PELICULA_DELETE]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_PELICULA_DELETE]
@id int 

as begin



    if exists(select id_ticket  from TICKETS t
    join Butacas b on b.id_Butaca = t.id_butaca
    join FUNCIONES f on  f.id_funcion=b.id_funcion 
    join PELICULAS p on p.id_pelicula = f.id_pelicula
                            where p.id_pelicula = @id)
    begin

    raiserror('Hay tickets emitidos , violando integridad referencial',16,2)
    end
    else
    begin
            delete FUNCIONES  where id_pelicula =@id
            delete PELICULAS where id_pelicula =@id
    end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_PELICULIA_X_ID]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_PELICULIA_X_ID]
@ID int 
as 

begin 

SELECT    
			P.id_pelicula as PeliculasID,
			P.titulo  as PeliculaTitulo,
			P.duracion as PeliculaDuracion,
	   		P.fecha_estreno as PeliculaEstreno,

			G.id_genero as GeneroID,
			G.genero as GeneroDescripcion,
       
			C.id_clasificacion as CalificacionID,
			C.edad as CalificacionEdad,

			PR.id_productora as ProductoraID,
			PR.nombre as ProductoraNombre

      
        

    FROM PELICULAS AS P
    JOIN GENEROS_PELICULAS AS G ON P.id_genero = G.id_genero
    JOIN CLASIFICACIONES_PELICULAS AS C ON P.id_clasificacion = C.id_clasificacion
    JOIN PRODUCTORAS AS PR ON P.id_productora = PR.id_productora

    WHERE p.id_pelicula = @ID
	end;

GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_COMPROBANTES]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_REPORTE_COMPROBANTES]
@desde datetime,
@hasta datetime
as
begin
select  c.id_comprobante ID, c.fecha Fecha,count(*)'Cantidad_de_tickets', d.descripcion 'Razon_descuento', d.porcentaje 'Valor_del_descuento',sum(Pre_unit)'Total_sin_descuentos_aplicados', Total 'Total_real'
from COMPROBANTES c join TICKETS t on c.id_comprobante = t.id_comprobante 
join DESCUENTOS d on d.id_descuento = c.id_descuento
join Butacas b on b.id_Butaca = t.id_butaca
join FUNCIONES f on f.id_funcion = b.id_funcion
join Salas s on s.id_Sala = f.id_sala
where c.fecha between @desde and @hasta
group by c.id_comprobante,c.fecha,d.descripcion,d.porcentaje,Total
end
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_PELICULAS]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_REPORTE_PELICULAS]
@seleccion int
AS
begin 
if @seleccion = 1
begin
select count(*) Cantidad_Total, g.genero Genero
from PELICULAS p join GENEROS_PELICULAS g on p.id_genero = g.id_genero
group by  g.genero
end
if @seleccion = 2
begin
select count(*) Cantidad_Total, cast(c.edad as varchar(20)) Edad
from PELICULAS p join CLASIFICACIONES_PELICULAS c on p.id_clasificacion = c.id_clasificacion
group by c.edad
end
if @seleccion = 3
begin 
select count(*) Cantidad_Total, pr.nombre Nombre
from PELICULAS p join Productoras pr on p.id_productora = pr.id_productora
group by pr.nombre
end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TICKET_X_FUNCION]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_TICKET_X_FUNCION]
@id int
as
begin
select id_ticket Id_Ticket, id_comprobante Id_Comprobante, t.id_butaca Id_Butaca
from TICKETS t join Butacas b on t.id_butaca = b.id_Butaca
join FUNCIONES f on f.id_funcion = b.id_funcion
where f.id_funcion = @id
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TICKET_X_ID]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_TICKET_X_ID]
@IdTicket int
as 
begin
select t.id_ticket ,t.id_butaca,s.Pre_unit
from TICKETS T  join Butacas b on t.id_butaca = b.id_Butaca
join FUNCIONES f on b.id_funcion = f.id_funcion
join Salas s on s.id_Sala = f.id_sala
where t.id_ticket = @IdTicket
end
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_FUNCION]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_UPDATE_FUNCION]
@id_funcion int,
@id_pelicula int,
@id_sala int,
@horario_inicio time,
@horario_fin time,
@fecha datetime
as
begin
update FUNCIONES
set 
id_pelicula = @id_pelicula,
id_sala = @id_sala,
Horario_Inicio = @horario_inicio,
Horario_Fin = @horario_fin,
Fecha = @fecha
where id_funcion = @id_funcion
end
GO
/****** Object:  Trigger [dbo].[TR_CrearButacas]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[TR_CrearButacas]
on [dbo].[FUNCIONES]
after insert
as
begin
    declare @fila varchar(1)
    declare @columna int
    declare @total int
    set @fila = 'A'
    set @columna = 1
    set @total = 0
    while @total < 35
    begin
        insert into butacas values ((select id_funcion from inserted), 'Disponible', @fila, @columna)
        set @columna = @columna +1
        if @columna = 8
            begin
            set @fila = CHAR(ASCII(@fila) + 1)
            set @columna = 1
            end
        set @total = @total + 1
    end
end
GO
ALTER TABLE [dbo].[FUNCIONES] ENABLE TRIGGER [TR_CrearButacas]
GO
/****** Object:  Trigger [dbo].[TR_EliminarButacas]    Script Date: 24/11/2023 11:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[TR_EliminarButacas]
on [dbo].[FUNCIONES]
instead of delete
as 
begin
    delete butacas where id_funcion = (select id_funcion from deleted)
    delete funciones where id_funcion = (select id_funcion from deleted)
end
GO
ALTER TABLE [dbo].[FUNCIONES] ENABLE TRIGGER [TR_EliminarButacas]
GO
USE [master]
GO
ALTER DATABASE [TP_LABORATORIO_FINAL3] SET  READ_WRITE 
GO
