USE [choppin-db]
GO
/****** Object:  Table [dbo].[CajasCerradas]    Script Date: 3/7/2019 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CajasCerradas](
	[IdVenta] [int] NOT NULL,
 CONSTRAINT [PK_CajasCerradas] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 3/7/2019 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[IdCategoria] [int] NOT NULL,
	[Nombre] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 3/7/2019 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[IdMarca] [int] NOT NULL,
	[Nombre] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesas]    Script Date: 3/7/2019 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesas](
	[IdMesa] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Mesas] PRIMARY KEY CLUSTERED 
(
	[IdMesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 3/7/2019 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[IdVenta] [int] NOT NULL,
	[IdMedioPago] [int] NOT NULL,
	[Importe] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_Pagos] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC,
	[IdMedioPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 3/7/2019 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Precio] [decimal](18, 4) NOT NULL,
	[IdCategoria] [int] NULL,
	[IdMarca] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 3/7/2019 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdMesa] [int] NOT NULL,
	[Apertura] [datetime] NOT NULL,
	[Cierre] [datetime] NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentasDetalles]    Script Date: 3/7/2019 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentasDetalles](
	[IdVentaDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [decimal](18, 4) NOT NULL,
	[Diferencia] [decimal](18, 4) NOT NULL,
	[DiferenciaIdAplica] [int] NULL,
	[DiferenciaMotivo] [nvarchar](200) NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_VentasDetalles] PRIMARY KEY CLUSTERED 
(
	[IdVentaDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre]) VALUES (0, N'')
GO
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre]) VALUES (1, N'Tirada')
GO
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre]) VALUES (2, N'Porron')
GO
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre]) VALUES (3, N'Frituras')
GO
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre]) VALUES (4, N'Hambuguesa')
GO
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre]) VALUES (5, N'Pizza')
GO
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre]) VALUES (6, N'Picada')
GO
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre]) VALUES (7, N'Trago')
GO
INSERT [dbo].[Categorias] ([IdCategoria], [Nombre]) VALUES (8, N'Bebidas')
GO
INSERT [dbo].[Marcas] ([IdMarca], [Nombre]) VALUES (0, N'')
GO
INSERT [dbo].[Marcas] ([IdMarca], [Nombre]) VALUES (1, N'Equum')
GO
INSERT [dbo].[Marcas] ([IdMarca], [Nombre]) VALUES (2, N'Heineken')
GO
INSERT [dbo].[Marcas] ([IdMarca], [Nombre]) VALUES (3, N'Imperial')
GO
INSERT [dbo].[Marcas] ([IdMarca], [Nombre]) VALUES (4, N'Isembeck')
GO
INSERT [dbo].[Marcas] ([IdMarca], [Nombre]) VALUES (5, N'Schneider')
GO
INSERT [dbo].[Marcas] ([IdMarca], [Nombre]) VALUES (6, N'Coca Cola')
GO
INSERT [dbo].[Marcas] ([IdMarca], [Nombre]) VALUES (7, N'Speed')
GO
INSERT [dbo].[Mesas] ([IdMesa], [Nombre]) VALUES (0, N'Barra')
GO
INSERT [dbo].[Mesas] ([IdMesa], [Nombre]) VALUES (1, N'Mesa 1')
GO
INSERT [dbo].[Mesas] ([IdMesa], [Nombre]) VALUES (2, N'Mesa 2')
GO
INSERT [dbo].[Mesas] ([IdMesa], [Nombre]) VALUES (3, N'Mesa 3')
GO
INSERT [dbo].[Mesas] ([IdMesa], [Nombre]) VALUES (4, N'Mesa 4')
GO
INSERT [dbo].[Mesas] ([IdMesa], [Nombre]) VALUES (5, N'Mesa 5')
GO
INSERT [dbo].[Mesas] ([IdMesa], [Nombre]) VALUES (6, N'Mesa 6')
GO
INSERT [dbo].[Mesas] ([IdMesa], [Nombre]) VALUES (7, N'Mesa 7')
GO
INSERT [dbo].[Mesas] ([IdMesa], [Nombre]) VALUES (8, N'Mesa 8')
GO
INSERT [dbo].[Mesas] ([IdMesa], [Nombre]) VALUES (9, N'Mesa 9')
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (101, N'IPA', CAST(120.0000 AS Decimal(18, 4)), 1, 1)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (102, N'HONEY', CAST(120.0000 AS Decimal(18, 4)), 1, 1)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (103, N'SCOTTISH', CAST(120.0000 AS Decimal(18, 4)), 1, 1)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (104, N'GOLDEN', CAST(120.0000 AS Decimal(18, 4)), 1, 1)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (105, N'IPA', CAST(120.0000 AS Decimal(18, 4)), 1, 1)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (201, N'IPA', CAST(120.0000 AS Decimal(18, 4)), 2, 3)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (202, N'STOUT', CAST(120.0000 AS Decimal(18, 4)), 2, 3)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (203, N'LAGER', CAST(120.0000 AS Decimal(18, 4)), 2, 3)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (204, N'WEISS', CAST(120.0000 AS Decimal(18, 4)), 2, 3)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (205, N'APA', CAST(120.0000 AS Decimal(18, 4)), 2, 1)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (301, N'Papas Fritas', CAST(100.0000 AS Decimal(18, 4)), 3, 0)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (401, N'Simple', CAST(-1000.0000 AS Decimal(18, 4)), 4, 0)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (402, N'Completa', CAST(-1000.0000 AS Decimal(18, 4)), 4, 0)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (403, N'Super', CAST(-1000.0000 AS Decimal(18, 4)), 4, 0)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (404, N'Cebolla', CAST(-1000.0000 AS Decimal(18, 4)), 4, 0)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (405, N'Choppin', CAST(-1000.0000 AS Decimal(18, 4)), 4, 0)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (701, N'Champagne', CAST(200.0000 AS Decimal(18, 4)), 7, 0)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (801, N'Agua chica', CAST(80.0000 AS Decimal(18, 4)), 8, 0)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (802, N'MiniLata', CAST(80.0000 AS Decimal(18, 4)), 8, 6)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (803, N'Botella', CAST(180.0000 AS Decimal(18, 4)), 8, 6)
GO
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Precio], [IdCategoria], [IdMarca]) VALUES (804, N'Lata', CAST(80.0000 AS Decimal(18, 4)), 8, 7)
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Marcas_Categorias] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marcas] ([IdMarca])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Marcas_Categorias]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categorias] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([IdCategoria])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categorias]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Mesas] FOREIGN KEY([IdMesa])
REFERENCES [dbo].[Mesas] ([IdMesa])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Mesas]
GO
ALTER TABLE [dbo].[VentasDetalles]  WITH CHECK ADD  CONSTRAINT [FK_VentasDetalle_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[VentasDetalles] CHECK CONSTRAINT [FK_VentasDetalle_Productos]
GO
ALTER TABLE [dbo].[VentasDetalles]  WITH CHECK ADD  CONSTRAINT [FK_VentasDetalle_Ventas] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Ventas] ([IdVenta])
GO
ALTER TABLE [dbo].[VentasDetalles] CHECK CONSTRAINT [FK_VentasDetalle_Ventas]
GO
