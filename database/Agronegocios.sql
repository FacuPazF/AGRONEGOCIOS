USE [master]
GO
/****** Object:  Database [Agronegocios]    Script Date: 14/9/2020 21:38:02 ******/
CREATE DATABASE [Agronegocios]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Agronegocios', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Agronegocios.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Agronegocios_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Agronegocios_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Agronegocios] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Agronegocios].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Agronegocios] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Agronegocios] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Agronegocios] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Agronegocios] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Agronegocios] SET ARITHABORT OFF 
GO
ALTER DATABASE [Agronegocios] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Agronegocios] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Agronegocios] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Agronegocios] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Agronegocios] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Agronegocios] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Agronegocios] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Agronegocios] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Agronegocios] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Agronegocios] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Agronegocios] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Agronegocios] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Agronegocios] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Agronegocios] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Agronegocios] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Agronegocios] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Agronegocios] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Agronegocios] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Agronegocios] SET  MULTI_USER 
GO
ALTER DATABASE [Agronegocios] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Agronegocios] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Agronegocios] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Agronegocios] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Agronegocios] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Agronegocios] SET QUERY_STORE = OFF
GO
USE [Agronegocios]
GO
/****** Object:  Table [dbo].[Barrios]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_Barrio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[cod_Postal] [varchar](50) NULL,
	[id_Localidad] [int] NULL,
 CONSTRAINT [PK_Barrios] PRIMARY KEY CLUSTERED 
(
	[id_Barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calidad]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calidad](
	[id_Calidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_Tipo_Semilla] [int] NULL,
	[habilitado] [varchar](2) NULL,
 CONSTRAINT [PK_Calidad] PRIMARY KEY CLUSTERED 
(
	[id_Calidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente_Proveedor]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente_Proveedor](
	[id_Cliente_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[razon_Social] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[cod_Barrio] [int] NULL,
	[id_Tipo] [int] NULL,
	[CUIL_CUIT] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Cliente_Proveedor] PRIMARY KEY CLUSTERED 
(
	[id_Cliente_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_de_Facturas]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_de_Facturas](
	[id_Semilla] [int] NOT NULL,
	[tipo_Factura] [char](1) NOT NULL,
	[numero_Factura] [int] NOT NULL,
	[fecha_Entrega] [date] NULL,
	[precio_Venra] [decimal](15, 2) NULL,
	[cantidad] [decimal](14, 4) NULL,
 CONSTRAINT [PK_Detalles_de_Facturas] PRIMARY KEY CLUSTERED 
(
	[id_Semilla] ASC,
	[tipo_Factura] ASC,
	[numero_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[cod_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[telefono] [int] NULL,
	[fecha_Alta] [date] NULL,
	[cod_barrio] [int] NULL,
	[calle] [varchar](50) NULL,
	[numero_casa] [int] NULL,
	[fecha_nacimiento] [date] NULL,
	[tipo_Empleado] [int] NULL,
	[contraseña] [nchar](8) NULL,
	[usuario] [varchar](8) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[cod_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa_Transporte]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa_Transporte](
	[id_Empresa] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[razon_social] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[id_barrio] [int] NULL,
 CONSTRAINT [PK_Empresa_Transporte] PRIMARY KEY CLUSTERED 
(
	[id_Empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Envios]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Envios](
	[id_Factura] [int] NOT NULL,
	[tipo_Factura] [char](1) NOT NULL,
	[nro_envio] [int] IDENTITY(1,1) NOT NULL,
	[fecha_Hora_envio] [date] NULL,
	[id_Empresa_Transporte] [int] NULL,
	[direccion] [varchar](50) NULL,
	[id_barrio] [int] NULL,
 CONSTRAINT [PK_Envios] PRIMARY KEY CLUSTERED 
(
	[nro_envio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[tipo_Factura] [char](1) NOT NULL,
	[numero] [int] IDENTITY(1,1) NOT NULL,
	[fecha_Factura] [date] NULL,
	[total] [decimal](15, 2) NULL,
	[cod_Empleado] [int] NULL,
	[id_cliente_Proveedor] [int] NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[tipo_Factura] ASC,
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Forma_PagoXfactura]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Forma_PagoXfactura](
	[id_Forma_Pago] [int] IDENTITY(1,1) NOT NULL,
	[tipo_Factura] [char](1) NOT NULL,
	[numero_Factura] [int] NOT NULL,
	[monto] [decimal](15, 2) NULL,
	[dias_de_Plazo] [int] NULL,
 CONSTRAINT [PK_Forma_PagoXfactura] PRIMARY KEY CLUSTERED 
(
	[id_Forma_Pago] ASC,
	[tipo_Factura] ASC,
	[numero_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formas_Pagos]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formas_Pagos](
	[id_Pago] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Formas_Pagos] PRIMARY KEY CLUSTERED 
(
	[id_Pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[id_Localidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_Provincia] [int] NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[id_Localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[id_Provincia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[id_Provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semilla]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semilla](
	[id_Semilla] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[stock_Minimo] [decimal](10, 2) NULL,
	[stock] [decimal](10, 2) NULL,
	[precio_Tonelada] [decimal](15, 3) NULL,
	[tipo_Semilla] [int] NULL,
	[descripcion] [varchar](100) NULL,
	[habilitado] [varchar](2) NULL,
 CONSTRAINT [PK_Semilla] PRIMARY KEY CLUSTERED 
(
	[id_Semilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Cliente_Proveedor]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Cliente_Proveedor](
	[id_Tipo] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_Cliente_Proveedor] PRIMARY KEY CLUSTERED 
(
	[id_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Empleados]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Empleados](
	[id_tipo_Empleado] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_Empleados] PRIMARY KEY CLUSTERED 
(
	[id_tipo_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Semilla]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Semilla](
	[id_Tipo_Semilla] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[habilitado] [varchar](2) NULL,
 CONSTRAINT [PK_Tipo_Semilla] PRIMARY KEY CLUSTERED 
(
	[id_Tipo_Semilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposXsemillas]    Script Date: 14/9/2020 21:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposXsemillas](
	[id_Semilla] [int] NOT NULL,
	[id_Tipo_Semilla] [int] NOT NULL,
	[id_Calidad] [int] NOT NULL,
	[precio_sugerido] [decimal](15, 3) NULL,
 CONSTRAINT [PK_TiposXsemillas] PRIMARY KEY CLUSTERED 
(
	[id_Semilla] ASC,
	[id_Tipo_Semilla] ASC,
	[id_Calidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Barrios] ON 

INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (1, N'Colon', N'5000', 1)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (2, N'Alberdi', N'5000', 1)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (3, N'Centro', N'6270', 1)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (4, N'Centro', N'0000', 2)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (5, N'Centro', N'0000', 3)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (6, N'Barrio Sur', N'000', 2)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (7, N'Barrio Norte', N'999', 2)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (8, N'Nuevo', N'009', 3)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (9, N'barrio 1 de SF', N'00000', 4)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (10, N'barrio 2 de SF', N'121', 4)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (11, N'barrio 3', N'22', 5)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (12, N'exodo', N'222', 5)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (14, N'Centro', NULL, 20)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (19, N'Barrio Norte', NULL, 1)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (27, N'Barrio Sur', NULL, 3)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (28, N'Puente carretero', NULL, 27)
INSERT [dbo].[Barrios] ([id_Barrio], [nombre], [cod_Postal], [id_Localidad]) VALUES (29, N'Centro', NULL, 27)
SET IDENTITY_INSERT [dbo].[Barrios] OFF
GO
SET IDENTITY_INSERT [dbo].[Calidad] ON 

INSERT [dbo].[Calidad] ([id_Calidad], [nombre], [id_Tipo_Semilla], [habilitado]) VALUES (39, N'Excelente', NULL, N'si')
INSERT [dbo].[Calidad] ([id_Calidad], [nombre], [id_Tipo_Semilla], [habilitado]) VALUES (40, N'Muy Bueno', NULL, N'si')
INSERT [dbo].[Calidad] ([id_Calidad], [nombre], [id_Tipo_Semilla], [habilitado]) VALUES (41, N'Malo', NULL, N'si')
SET IDENTITY_INSERT [dbo].[Calidad] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente_Proveedor] ON 

INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (1, N'Lola', N'Street', NULL, N'lola@gmail.com', N'4448888', 1, 1, N'12345678', 1)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (8, N'Huessi', N'Street', N'Huessi.SA', N'huessi@hotmail.com', N'333-778-', 3, 1, N'2345678', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (12, N'cani', N'street', N'N/N', N'cani@hotmail.com', N'91287', 2, 1, N'12345', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (13, N'Alberto', N'Perez', N'YPF', N'albert@dominio.com', N'1235862163', 7, 1, N'3545464', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (14, N'Agus', N'sadsa', N'd', N'sd', N'123', 1, 1, N'1234567890', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (18, N'sdsadasd', N'asdsadasd', N'sadsad', N'2sad', N'12334556', 4, 1, N'123456', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (19, N'sadassasad', N'dasdasdsad', N'dasd', N'dasd', N'sdsd', 1, 1, N'1', 1)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (21, N'Gallardo', N'El emperdor', N'River-Plate', N'r@hotmail.com', N'33444', 2, 1, N'12345678901', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (29, N'aldo', N'aldosivi', N'ALDO SRL', N'r@r', N'123-4  -', 3, 1, N'20341456', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (31, N'nombre', N'apellido', N'razon_Social', N'email', N'telefono', 3, 1, N'4430', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (38, N'asds333', N'sads', N'', N'', N'-   -', 3, 1, N'111', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (39, N'sadasd', N'asdasd', N'asds', N'sd', N'', 12, 1, N'12312312', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (41, N'Altamirano', N'Cesar', N'saasdas', N'sadas', N'213-123-2333', 3, 1, N'00-55555555-2', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (54, N'antonio mario', N'gomez', N'esperanza del obreroSRL', N'', N'-   -', 3, 2, N'-        -', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (58, N'', N'', N'', N'', N'-   -', 3, 2, N'00-00000000-1', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (59, N'', N'', N'', N'', N'-   -', 3, 2, N'00-00000000-2', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (62, N'pepe', N'argento', N'', N'ssdlsd', N'212-121-2121', 3, 2, N'00-00000000-3', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (63, N'pedro', N'', N'', N'', N'-   -', 3, 2, N'00-00000000-4', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (64, N'', N'', N'', N'', N'-   -', 3, 2, N'00-55555555-6', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (65, N'PINKI', N'WIFII', N'', N'sakdska', N'123-123-1231', 3, 2, N'00-00000000-7', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (67, N'saldkjaslkdj', N'lkasjdlkas', N'dasdas', N'asdasd', N'212-321-3123', 3, 2, N'00-00000000-8', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (69, N'VErificacion', N'', N'', N'', N'-   -', 3, 2, N'00-55555551-0', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (71, N'', N'', N'', N'', N'-   -', 3, 2, N'123', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (84, N'juan', N'de los quijotes', N'EsperoSRL', N'sksks@skksksk', N'111-111-111', 3, 2, N'99000000000', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (85, N'ldksjd', N'jhkjashdkjash', N'wqjhqwjh', N'jqwhjhqw33333', N'222-222-2222', 3, 2, N'11111111111', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (87, N'UYUYUYUYUY', N'UYUYUYUYUYUY', N'IUIU', N'IUIU', N'111-111-1111', 28, 2, N'11220000000', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (93, N'pero', N'como', N'kwje', N'kasjdk', N'121-212-1212', 28, 2, N'99999999999', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (94, N'', N'', N'', N'', N'-   -', 28, 2, N'', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (95, N'', N'', N'', N'', N'-   -', 3, 2, N'44444444444', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (96, N'', N'', N'', N'', N'-   -', 7, 2, N'33333333333', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (97, N'', N'', N'', N'', N'-   -', 28, 2, N'22222222222', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (99, N'', N'', N'', N'', N'-   -', 29, 2, N'66666666666', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (106, N't', N'Sarmiento', N'sjsj', N'djdjd@jfjfjf.com', N'444-444-4443', 3, 2, N'66000000000', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (107, N'cesar', N'alt', N'', N'', N'-   -', 3, 2, N'00000000333', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (109, N'Juan', N'Perez', NULL, NULL, NULL, NULL, NULL, N'789456132', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (110, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1235468796844321', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (111, N'Fabri', N'Logares', N'YPF', N'fabri@gmail.com', N'3513873218', 4, 1, N'20421064218', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (112, N'Nico', N'Mingorance', N'Movistar', N'nico@gmail.com', N'3513856128', 1, 1, N'20421068527', 0)
INSERT [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor], [nombre], [apellido], [razon_Social], [email], [telefono], [cod_Barrio], [id_Tipo], [CUIL_CUIT], [borrado]) VALUES (113, N'Neuen', N'Actis', N'Galileo', N'neuen@sistemas.frc.utn.ar', N'3541562585', 9, 1, N'20425136588', 0)
SET IDENTITY_INSERT [dbo].[Cliente_Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([cod_Empleado], [nombre], [apellido], [email], [telefono], [fecha_Alta], [cod_barrio], [calle], [numero_casa], [fecha_nacimiento], [tipo_Empleado], [contraseña], [usuario], [borrado]) VALUES (6, N'Cesar', N'Altamirano', N'cesar@gmail.com', 1122334455, CAST(N'2010-05-02' AS Date), 1, N'AV. Colon', 222, CAST(N'2000-03-22' AS Date), 1, N'Cesar001', N'CAltamir', 0)
INSERT [dbo].[Empleados] ([cod_Empleado], [nombre], [apellido], [email], [telefono], [fecha_Alta], [cod_barrio], [calle], [numero_casa], [fecha_nacimiento], [tipo_Empleado], [contraseña], [usuario], [borrado]) VALUES (7, N'Neuen', N'Actis', N'neuen@gmail.com', 22334455, CAST(N'2010-04-22' AS Date), 2, N'9 de julio', 333, CAST(N'2000-04-14' AS Date), 2, N'neuen002', N'NActis00', 0)
INSERT [dbo].[Empleados] ([cod_Empleado], [nombre], [apellido], [email], [telefono], [fecha_Alta], [cod_barrio], [calle], [numero_casa], [fecha_nacimiento], [tipo_Empleado], [contraseña], [usuario], [borrado]) VALUES (8, N'Administrador', N'Administrador', N'admin@admin', 0, CAST(N'1999-04-01' AS Date), 2, N'sd', 0, CAST(N'1999-09-09' AS Date), 1, N'admin000', N'admin000', 0)
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Localidad] ON 

INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (1, N'CordobA', 1)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (2, N'Huinca R.', 1)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (3, N'Nono', 1)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (4, N'La falda', 1)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (5, N'Alvear', 3)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (6, N'Arroyo Seco', 3)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (7, N'Athos Pampa', 1)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (8, N'Embalse', 1)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (9, N'La Cumbresita Pop', 1)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (10, N'Los Reartes', 1)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (11, N'Santa Rosa de Calamuchita', 1)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (15, N'CordoBe', 2)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (19, N'Mate', 4)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (20, N'Liniers', 2)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (23, N'Nono', 22)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (24, N'Cordoba', 22)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (27, N'Arroyo humedo', 3)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (29, N'Arroyo Seco', 4)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (30, N'Arroyito', 1)
INSERT [dbo].[Localidad] ([id_Localidad], [nombre], [id_Provincia]) VALUES (31, N'xxx', 3)
SET IDENTITY_INSERT [dbo].[Localidad] OFF
GO
SET IDENTITY_INSERT [dbo].[Provincia] ON 

INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (1, N'Cordoba')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (2, N'Buenos Aire')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (3, N'Santa Fe')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (4, N'La Pampa')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (5, N'La Rioja')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (6, N'Catamarca')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (7, N'Santiago del Estero')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (8, N'Corrinetes')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (13, N'Chaco')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (14, N'Tierra del Fuego')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (16, N'Santa Feces')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (22, N'Mendoza')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (23, N'Cata')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (25, N'Mendoza')
INSERT [dbo].[Provincia] ([id_Provincia], [nombre]) VALUES (26, N'Pung')
SET IDENTITY_INSERT [dbo].[Provincia] OFF
GO
SET IDENTITY_INSERT [dbo].[Semilla] ON 

INSERT [dbo].[Semilla] ([id_Semilla], [nombre], [stock_Minimo], [stock], [precio_Tonelada], [tipo_Semilla], [descripcion], [habilitado]) VALUES (29, N'Soja', CAST(3000.00 AS Decimal(10, 2)), CAST(2000.00 AS Decimal(10, 2)), CAST(3055.000 AS Decimal(15, 3)), NULL, N'que', N'si')
INSERT [dbo].[Semilla] ([id_Semilla], [nombre], [stock_Minimo], [stock], [precio_Tonelada], [tipo_Semilla], [descripcion], [habilitado]) VALUES (30, N'Soja', CAST(299.00 AS Decimal(10, 2)), CAST(99.00 AS Decimal(10, 2)), CAST(99.000 AS Decimal(15, 3)), NULL, N'otra', N'si')
INSERT [dbo].[Semilla] ([id_Semilla], [nombre], [stock_Minimo], [stock], [precio_Tonelada], [tipo_Semilla], [descripcion], [habilitado]) VALUES (31, N'Soja', CAST(770000.00 AS Decimal(10, 2)), CAST(33.00 AS Decimal(10, 2)), CAST(333.000 AS Decimal(15, 3)), NULL, N'55', N'SI')
INSERT [dbo].[Semilla] ([id_Semilla], [nombre], [stock_Minimo], [stock], [precio_Tonelada], [tipo_Semilla], [descripcion], [habilitado]) VALUES (32, N'Trigo', CAST(33.00 AS Decimal(10, 2)), CAST(3000.00 AS Decimal(10, 2)), CAST(44.900 AS Decimal(15, 3)), NULL, N'buena', N'si')
INSERT [dbo].[Semilla] ([id_Semilla], [nombre], [stock_Minimo], [stock], [precio_Tonelada], [tipo_Semilla], [descripcion], [habilitado]) VALUES (33, N'Trigo', CAST(2222.00 AS Decimal(10, 2)), CAST(33333.00 AS Decimal(10, 2)), CAST(34.440 AS Decimal(15, 3)), NULL, N'wwww', N'si')
INSERT [dbo].[Semilla] ([id_Semilla], [nombre], [stock_Minimo], [stock], [precio_Tonelada], [tipo_Semilla], [descripcion], [habilitado]) VALUES (34, N'Trigo', CAST(3333.00 AS Decimal(10, 2)), CAST(35555.00 AS Decimal(10, 2)), CAST(8.990 AS Decimal(15, 3)), NULL, N'33dw', N'si')
INSERT [dbo].[Semilla] ([id_Semilla], [nombre], [stock_Minimo], [stock], [precio_Tonelada], [tipo_Semilla], [descripcion], [habilitado]) VALUES (35, N'Trigo', CAST(10.00 AS Decimal(10, 2)), CAST(44.00 AS Decimal(10, 2)), CAST(9.990 AS Decimal(15, 3)), NULL, N'', N'si')
SET IDENTITY_INSERT [dbo].[Semilla] OFF
GO
INSERT [dbo].[Tipo_Cliente_Proveedor] ([id_Tipo], [nombre]) VALUES (1, N'Cliente')
INSERT [dbo].[Tipo_Cliente_Proveedor] ([id_Tipo], [nombre]) VALUES (2, N'Proveedor')
GO
INSERT [dbo].[Tipo_Empleados] ([id_tipo_Empleado], [nombre]) VALUES (1, N'SuperUsuario')
INSERT [dbo].[Tipo_Empleados] ([id_tipo_Empleado], [nombre]) VALUES (2, N'Vendedor')
GO
SET IDENTITY_INSERT [dbo].[Tipo_Semilla] ON 

INSERT [dbo].[Tipo_Semilla] ([id_Tipo_Semilla], [nombre], [habilitado]) VALUES (23, N'Importada', N'si')
INSERT [dbo].[Tipo_Semilla] ([id_Tipo_Semilla], [nombre], [habilitado]) VALUES (24, N'Nacional', N'si')
INSERT [dbo].[Tipo_Semilla] ([id_Tipo_Semilla], [nombre], [habilitado]) VALUES (25, N'Victoria', N'si')
INSERT [dbo].[Tipo_Semilla] ([id_Tipo_Semilla], [nombre], [habilitado]) VALUES (26, N'Monarca', N'si')
SET IDENTITY_INSERT [dbo].[Tipo_Semilla] OFF
GO
INSERT [dbo].[TiposXsemillas] ([id_Semilla], [id_Tipo_Semilla], [id_Calidad], [precio_sugerido]) VALUES (29, 23, 39, CAST(4000.000 AS Decimal(15, 3)))
INSERT [dbo].[TiposXsemillas] ([id_Semilla], [id_Tipo_Semilla], [id_Calidad], [precio_sugerido]) VALUES (30, 23, 40, CAST(30000.000 AS Decimal(15, 3)))
INSERT [dbo].[TiposXsemillas] ([id_Semilla], [id_Tipo_Semilla], [id_Calidad], [precio_sugerido]) VALUES (31, 25, 40, CAST(222.000 AS Decimal(15, 3)))
INSERT [dbo].[TiposXsemillas] ([id_Semilla], [id_Tipo_Semilla], [id_Calidad], [precio_sugerido]) VALUES (34, 23, 39, CAST(8.990 AS Decimal(15, 3)))
INSERT [dbo].[TiposXsemillas] ([id_Semilla], [id_Tipo_Semilla], [id_Calidad], [precio_sugerido]) VALUES (35, 26, 40, CAST(9.990 AS Decimal(15, 3)))
GO
/****** Object:  Index [IX_Calidad]    Script Date: 14/9/2020 21:38:02 ******/
ALTER TABLE [dbo].[Calidad] ADD  CONSTRAINT [IX_Calidad] UNIQUE NONCLUSTERED 
(
	[id_Calidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Semilla]    Script Date: 14/9/2020 21:38:02 ******/
CREATE NONCLUSTERED INDEX [IX_Semilla] ON [dbo].[Semilla]
(
	[id_Semilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Calidad] ADD  CONSTRAINT [DF_Calidad_habilitado]  DEFAULT ('si') FOR [habilitado]
GO
ALTER TABLE [dbo].[Cliente_Proveedor] ADD  CONSTRAINT [borrado_act]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Semilla] ADD  CONSTRAINT [DF_Semilla_habilitado]  DEFAULT ('si') FOR [habilitado]
GO
ALTER TABLE [dbo].[Tipo_Semilla] ADD  CONSTRAINT [DF_Tipo_Semilla_habilitado]  DEFAULT ('si') FOR [habilitado]
GO
ALTER TABLE [dbo].[Barrios]  WITH CHECK ADD  CONSTRAINT [FK_Barrios_Localidad] FOREIGN KEY([id_Localidad])
REFERENCES [dbo].[Localidad] ([id_Localidad])
GO
ALTER TABLE [dbo].[Barrios] CHECK CONSTRAINT [FK_Barrios_Localidad]
GO
ALTER TABLE [dbo].[Calidad]  WITH CHECK ADD  CONSTRAINT [FK_Calidad_Tipo_Semilla] FOREIGN KEY([id_Tipo_Semilla])
REFERENCES [dbo].[Tipo_Semilla] ([id_Tipo_Semilla])
GO
ALTER TABLE [dbo].[Calidad] CHECK CONSTRAINT [FK_Calidad_Tipo_Semilla]
GO
ALTER TABLE [dbo].[Cliente_Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Proveedor_Barrios] FOREIGN KEY([cod_Barrio])
REFERENCES [dbo].[Barrios] ([id_Barrio])
GO
ALTER TABLE [dbo].[Cliente_Proveedor] CHECK CONSTRAINT [FK_Cliente_Proveedor_Barrios]
GO
ALTER TABLE [dbo].[Cliente_Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Proveedor_Tipo_Cliente_Proveedor] FOREIGN KEY([id_Tipo])
REFERENCES [dbo].[Tipo_Cliente_Proveedor] ([id_Tipo])
GO
ALTER TABLE [dbo].[Cliente_Proveedor] CHECK CONSTRAINT [FK_Cliente_Proveedor_Tipo_Cliente_Proveedor]
GO
ALTER TABLE [dbo].[Detalles_de_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_de_Facturas_Facturas] FOREIGN KEY([tipo_Factura], [numero_Factura])
REFERENCES [dbo].[Facturas] ([tipo_Factura], [numero])
GO
ALTER TABLE [dbo].[Detalles_de_Facturas] CHECK CONSTRAINT [FK_Detalles_de_Facturas_Facturas]
GO
ALTER TABLE [dbo].[Detalles_de_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_de_Facturas_Semilla] FOREIGN KEY([id_Semilla])
REFERENCES [dbo].[Semilla] ([id_Semilla])
GO
ALTER TABLE [dbo].[Detalles_de_Facturas] CHECK CONSTRAINT [FK_Detalles_de_Facturas_Semilla]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Barrios] FOREIGN KEY([cod_barrio])
REFERENCES [dbo].[Barrios] ([id_Barrio])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Barrios]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Tipo_Empleados] FOREIGN KEY([tipo_Empleado])
REFERENCES [dbo].[Tipo_Empleados] ([id_tipo_Empleado])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Tipo_Empleados]
GO
ALTER TABLE [dbo].[Empresa_Transporte]  WITH CHECK ADD  CONSTRAINT [FK_Empresa_Transporte_Barrios] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_Barrio])
GO
ALTER TABLE [dbo].[Empresa_Transporte] CHECK CONSTRAINT [FK_Empresa_Transporte_Barrios]
GO
ALTER TABLE [dbo].[Envios]  WITH CHECK ADD  CONSTRAINT [FK_Envios_Barrios] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_Barrio])
GO
ALTER TABLE [dbo].[Envios] CHECK CONSTRAINT [FK_Envios_Barrios]
GO
ALTER TABLE [dbo].[Envios]  WITH CHECK ADD  CONSTRAINT [FK_Envios_Empresa_Transporte] FOREIGN KEY([id_Empresa_Transporte])
REFERENCES [dbo].[Empresa_Transporte] ([id_Empresa])
GO
ALTER TABLE [dbo].[Envios] CHECK CONSTRAINT [FK_Envios_Empresa_Transporte]
GO
ALTER TABLE [dbo].[Envios]  WITH CHECK ADD  CONSTRAINT [FK_Envios_Facturas] FOREIGN KEY([tipo_Factura], [id_Factura])
REFERENCES [dbo].[Facturas] ([tipo_Factura], [numero])
GO
ALTER TABLE [dbo].[Envios] CHECK CONSTRAINT [FK_Envios_Facturas]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Empleados1] FOREIGN KEY([cod_Empleado])
REFERENCES [dbo].[Empleados] ([cod_Empleado])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Empleados1]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Tipo_Cliente_Proveedor] FOREIGN KEY([id_cliente_Proveedor])
REFERENCES [dbo].[Cliente_Proveedor] ([id_Cliente_Proveedor])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Tipo_Cliente_Proveedor]
GO
ALTER TABLE [dbo].[Forma_PagoXfactura]  WITH CHECK ADD  CONSTRAINT [FK_Forma_PagoXfactura_Facturas] FOREIGN KEY([tipo_Factura], [numero_Factura])
REFERENCES [dbo].[Facturas] ([tipo_Factura], [numero])
GO
ALTER TABLE [dbo].[Forma_PagoXfactura] CHECK CONSTRAINT [FK_Forma_PagoXfactura_Facturas]
GO
ALTER TABLE [dbo].[Forma_PagoXfactura]  WITH CHECK ADD  CONSTRAINT [FK_Forma_PagoXfactura_Formas_Pagos] FOREIGN KEY([id_Forma_Pago])
REFERENCES [dbo].[Formas_Pagos] ([id_Pago])
GO
ALTER TABLE [dbo].[Forma_PagoXfactura] CHECK CONSTRAINT [FK_Forma_PagoXfactura_Formas_Pagos]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Localidad_Provincia] FOREIGN KEY([id_Provincia])
REFERENCES [dbo].[Provincia] ([id_Provincia])
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Localidad_Provincia]
GO
ALTER TABLE [dbo].[Semilla]  WITH CHECK ADD  CONSTRAINT [FK_Semilla_Tipo_Semilla1] FOREIGN KEY([tipo_Semilla])
REFERENCES [dbo].[Tipo_Semilla] ([id_Tipo_Semilla])
GO
ALTER TABLE [dbo].[Semilla] CHECK CONSTRAINT [FK_Semilla_Tipo_Semilla1]
GO
ALTER TABLE [dbo].[TiposXsemillas]  WITH CHECK ADD  CONSTRAINT [FK_TiposXsemillas_Calidad] FOREIGN KEY([id_Calidad])
REFERENCES [dbo].[Calidad] ([id_Calidad])
GO
ALTER TABLE [dbo].[TiposXsemillas] CHECK CONSTRAINT [FK_TiposXsemillas_Calidad]
GO
ALTER TABLE [dbo].[TiposXsemillas]  WITH CHECK ADD  CONSTRAINT [FK_TiposXsemillas_Semilla] FOREIGN KEY([id_Semilla])
REFERENCES [dbo].[Semilla] ([id_Semilla])
GO
ALTER TABLE [dbo].[TiposXsemillas] CHECK CONSTRAINT [FK_TiposXsemillas_Semilla]
GO
ALTER TABLE [dbo].[TiposXsemillas]  WITH CHECK ADD  CONSTRAINT [FK_TiposXsemillas_Tipo_Semilla] FOREIGN KEY([id_Tipo_Semilla])
REFERENCES [dbo].[Tipo_Semilla] ([id_Tipo_Semilla])
GO
ALTER TABLE [dbo].[TiposXsemillas] CHECK CONSTRAINT [FK_TiposXsemillas_Tipo_Semilla]
GO
USE [master]
GO
ALTER DATABASE [Agronegocios] SET  READ_WRITE 
GO
