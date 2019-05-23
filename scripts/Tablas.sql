USE [choppin-db]
GO
/****** Object:  Table [dbo].[Mesas]    Script Date: 23/5/2019 16:26:16 ******/
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
/****** Object:  Table [dbo].[Pagos]    Script Date: 23/5/2019 16:26:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[IdVenta] [int] NOT NULL,
	[IdMedioPago] [int] NOT NULL,
	[Importe] [numeric](18, 4) NOT NULL,
 CONSTRAINT [PK_Pagos] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC,
	[IdMedioPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 23/5/2019 16:26:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Precio] [numeric](18, 4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 23/5/2019 16:26:23 ******/
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
/****** Object:  Table [dbo].[VentasDetalle]    Script Date: 23/5/2019 16:26:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentasDetalle](
	[IdVentaDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [numeric](18, 4) NOT NULL,
	[Diferencia] [numeric](18, 4) NOT NULL,
	[DiferenciaIdAplica] [int] NULL,
	[DiferenciaMotivo] [nvarchar](200) NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_VentasDetalle_1] PRIMARY KEY CLUSTERED 
(
	[IdVentaDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[VentasDetalle] ADD  CONSTRAINT [DF_VentasDetalle_Fecha]  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Mesas] FOREIGN KEY([IdMesa])
REFERENCES [dbo].[Mesas] ([IdMesa])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Mesas]
GO
ALTER TABLE [dbo].[VentasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentasDetalle_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[VentasDetalle] CHECK CONSTRAINT [FK_VentasDetalle_Productos]
GO
ALTER TABLE [dbo].[VentasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentasDetalle_Ventas] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Ventas] ([IdVenta])
GO
ALTER TABLE [dbo].[VentasDetalle] CHECK CONSTRAINT [FK_VentasDetalle_Ventas]
GO
