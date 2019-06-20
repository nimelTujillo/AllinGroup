CREATE DATABASE BDOperaciones
GO
USE [BDOperaciones]
GO
/****** Object:  Table [dbo].[bus]    Script Date: 19/06/2019 12:59:04 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bus](
	[id_bus] [INT] IDENTITY(1,1) NOT NULL,
	[nu_placa] [VARCHAR](20) NULL,
	[tx_clase] [VARCHAR](50) NULL,
	[tx_marca] [VARCHAR](50) NULL,
	[tx_modelo] [VARCHAR](50) NULL,
	[tx_color] [VARCHAR](50) NULL,
	[nu_motor] [INT] NULL,
	[nu_asientos] [INT] NULL,
	[nu_puertas] [INT] NULL,
	[fecha_inscripcion] [DATETIME] NULL,
	[año_fabricacion] [VARCHAR](20) NULL,
	[tx_estado] [VARCHAR](20) NULL,
 CONSTRAINT [PK__bus__D507E4318E745028] PRIMARY KEY CLUSTERED 
(
	[id_bus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[conductor]    Script Date: 19/06/2019 12:59:05 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[conductor](
	[dni] [INT] NOT NULL,
	[nombre] [VARCHAR](50) NULL,
	[apellido] [VARCHAR](50) NULL,
	[fecha_ingreso] [DATETIME] NULL,
	[cat_licencia] [VARCHAR](20) NULL,
	[nu_licencia] [VARCHAR](20) NULL,
	[tx_direccion] [VARCHAR](20) NULL,
	[tx_estado] [VARCHAR](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produccion]    Script Date: 19/06/2019 12:59:05 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produccion](
	[id_produccion] [INT] IDENTITY(1,1) NOT NULL,
	[dni_conductor] [INT] NULL,
	[id_bus] [INT] NULL,
	[can_ingreso] [DECIMAL](10, 2) NULL,
	[fecha] [DATETIME] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_produccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 19/06/2019 12:59:05 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[dni_usuario] [INT] NOT NULL,
	[nombre] [VARCHAR](30) NULL,
	[apellido] [VARCHAR](40) NULL,
	[email] [VARCHAR](50) NULL,
	[usu_login] [VARCHAR](50) NULL,
	[pass_login] [VARCHAR](50) NULL,
	[tx_estado] [VARCHAR](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[dni_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bus] ON 

INSERT [dbo].[bus] ([id_bus], [nu_placa], [tx_clase], [tx_marca], [tx_modelo], [tx_color], [nu_motor], [nu_asientos], [nu_puertas], [fecha_inscripcion], [año_fabricacion], [tx_estado]) VALUES (2, N'PL-1589', N'BUS', N'TOYOTA', N'BS-008', N'ROJO', 158, 0, 8, CAST(N'2019-06-17T16:12:00.000' AS DATETIME), N'2019', N'ACTIVO')
INSERT [dbo].[bus] ([id_bus], [nu_placa], [tx_clase], [tx_marca], [tx_modelo], [tx_color], [nu_motor], [nu_asientos], [nu_puertas], [fecha_inscripcion], [año_fabricacion], [tx_estado]) VALUES (3, N'EPE-2013', N'OMNIBUS', N'VOLVO', N'OP-256', N'ROJO', 4523, 25, 2, CAST(N'2019-02-25T00:00:00.000' AS DATETIME), N'2019', N'Activo')
INSERT [dbo].[bus] ([id_bus], [nu_placa], [tx_clase], [tx_marca], [tx_modelo], [tx_color], [nu_motor], [nu_asientos], [nu_puertas], [fecha_inscripcion], [año_fabricacion], [tx_estado]) VALUES (4, N'PL-125', N'BUS', N'TOYOTA', N'YARIS', N'NEGRO', 2000, 100, 4, CAST(N'2000-01-01T00:00:00.000' AS DATETIME), N'2009', N'Activo')
INSERT [dbo].[bus] ([id_bus], [nu_placa], [tx_clase], [tx_marca], [tx_modelo], [tx_color], [nu_motor], [nu_asientos], [nu_puertas], [fecha_inscripcion], [año_fabricacion], [tx_estado]) VALUES (5, N'PLA-5896', N'BUS', N'TOYOTA', N'BUUUUU', N'NEGRO', 2013, 100, 4, CAST(N'2015-02-01T00:00:00.000' AS DATETIME), N'2014', N'ACTIVO')
INSERT [dbo].[bus] ([id_bus], [nu_placa], [tx_clase], [tx_marca], [tx_modelo], [tx_color], [nu_motor], [nu_asientos], [nu_puertas], [fecha_inscripcion], [año_fabricacion], [tx_estado]) VALUES (6, N'PLA-5896', N'BUS', N'TOYOTA', N'BUUUUU', N'NEGRO', 2013, 100, 4, CAST(N'2015-02-01T00:00:00.000' AS DATETIME), N'2014', N'ACTIVO')
INSERT [dbo].[bus] ([id_bus], [nu_placa], [tx_clase], [tx_marca], [tx_modelo], [tx_color], [nu_motor], [nu_asientos], [nu_puertas], [fecha_inscripcion], [año_fabricacion], [tx_estado]) VALUES (7, N'PL-1477', N'BUS', N'TOYOTA', N'BUS1000', N'BLANCO', 2000, 100, 4, CAST(N'2015-02-01T00:00:00.000' AS DATETIME), N'2014', N'ACTIVO')
INSERT [dbo].[bus] ([id_bus], [nu_placa], [tx_clase], [tx_marca], [tx_modelo], [tx_color], [nu_motor], [nu_asientos], [nu_puertas], [fecha_inscripcion], [año_fabricacion], [tx_estado]) VALUES (8, N'PL-1478', N'BUS', N'TOYOTA', N'BUS1000', N'BLANCO', 2000, 100, 4, CAST(N'2015-02-01T00:00:00.000' AS DATETIME), N'2014', N'ACTIVO')
SET IDENTITY_INSERT [dbo].[bus] OFF
INSERT [dbo].[conductor] ([dni], [nombre], [apellido], [fecha_ingreso], [cat_licencia], [nu_licencia], [tx_direccion], [tx_estado]) VALUES (12345678, N'Carlos', N'Sanchez Huaman', CAST(N'2019-05-02T00:00:00.000' AS DATETIME), N'A5', N'20135', N'Mz A5 Lote 52, SJM', N'Activo')
INSERT [dbo].[usuario] ([dni_usuario], [nombre], [apellido], [email], [usu_login], [pass_login], [tx_estado]) VALUES (44112233, N'NIMEL', N'TRUJILLO', N'ntrujillo@gmail.com', N'ntrujillo', N'12345', N'Activo')
