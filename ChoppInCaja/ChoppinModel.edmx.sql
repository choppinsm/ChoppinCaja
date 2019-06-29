
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/29/2019 12:12:13
-- Generated from EDMX file: C:\proyectos\Chopin\ChoppinCaja\ChoppInCaja\ChoppinModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [choppin-db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Ventas_Mesas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ventas] DROP CONSTRAINT [FK_Ventas_Mesas];
GO
IF OBJECT_ID(N'[dbo].[FK_VentasDetalle_Productos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VentasDetalle] DROP CONSTRAINT [FK_VentasDetalle_Productos];
GO
IF OBJECT_ID(N'[dbo].[FK_VentasDetalle_Ventas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VentasDetalle] DROP CONSTRAINT [FK_VentasDetalle_Ventas];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CajasCerradas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CajasCerradas];
GO
IF OBJECT_ID(N'[dbo].[Mesas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mesas];
GO
IF OBJECT_ID(N'[dbo].[Pagos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagos];
GO
IF OBJECT_ID(N'[dbo].[Productos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Productos];
GO
IF OBJECT_ID(N'[dbo].[Ventas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ventas];
GO
IF OBJECT_ID(N'[dbo].[VentasDetalle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VentasDetalle];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Mesas'
CREATE TABLE [dbo].[Mesas] (
    [IdMesa] int  NOT NULL,
    [Nombre] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Productos'
CREATE TABLE [dbo].[Productos] (
    [IdProducto] int  NOT NULL,
    [Nombre] nvarchar(100)  NOT NULL,
    [Precio] decimal(18,4)  NOT NULL,
    [IdCategoria] int  NOT NULL,
    [IdMarca] int  NOT NULL
);
GO

-- Creating table 'Ventas'
CREATE TABLE [dbo].[Ventas] (
    [IdVenta] int IDENTITY(1,1) NOT NULL,
    [IdMesa] int  NOT NULL,
    [Apertura] datetime  NOT NULL,
    [Cierre] datetime  NULL
);
GO

-- Creating table 'VentasDetalles'
CREATE TABLE [dbo].[VentasDetalles] (
    [IdVentaDetalle] int IDENTITY(1,1) NOT NULL,
    [IdVenta] int  NOT NULL,
    [IdProducto] int  NOT NULL,
    [Cantidad] int  NOT NULL,
    [Precio] decimal(18,4)  NOT NULL,
    [Diferencia] decimal(18,4)  NOT NULL,
    [DiferenciaIdAplica] int  NULL,
    [DiferenciaMotivo] nvarchar(200)  NULL,
    [Fecha] datetime  NOT NULL
);
GO

-- Creating table 'Pagos'
CREATE TABLE [dbo].[Pagos] (
    [IdVenta] int  NOT NULL,
    [IdMedioPago] int  NOT NULL,
    [Importe] decimal(18,4)  NOT NULL
);
GO

-- Creating table 'CajasCerradas'
CREATE TABLE [dbo].[CajasCerradas] (
    [IdVenta] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [IdCategoria] int  NOT NULL,
    [Nombre] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'Marcas'
CREATE TABLE [dbo].[Marcas] (
    [IdMarca] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdMesa] in table 'Mesas'
ALTER TABLE [dbo].[Mesas]
ADD CONSTRAINT [PK_Mesas]
    PRIMARY KEY CLUSTERED ([IdMesa] ASC);
GO

-- Creating primary key on [IdProducto] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [PK_Productos]
    PRIMARY KEY CLUSTERED ([IdProducto] ASC);
GO

-- Creating primary key on [IdVenta] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [PK_Ventas]
    PRIMARY KEY CLUSTERED ([IdVenta] ASC);
GO

-- Creating primary key on [IdVentaDetalle] in table 'VentasDetalles'
ALTER TABLE [dbo].[VentasDetalles]
ADD CONSTRAINT [PK_VentasDetalles]
    PRIMARY KEY CLUSTERED ([IdVentaDetalle] ASC);
GO

-- Creating primary key on [IdVenta], [IdMedioPago] in table 'Pagos'
ALTER TABLE [dbo].[Pagos]
ADD CONSTRAINT [PK_Pagos]
    PRIMARY KEY CLUSTERED ([IdVenta], [IdMedioPago] ASC);
GO

-- Creating primary key on [IdVenta] in table 'CajasCerradas'
ALTER TABLE [dbo].[CajasCerradas]
ADD CONSTRAINT [PK_CajasCerradas]
    PRIMARY KEY CLUSTERED ([IdVenta] ASC);
GO

-- Creating primary key on [IdCategoria] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC);
GO

-- Creating primary key on [IdMarca] in table 'Marcas'
ALTER TABLE [dbo].[Marcas]
ADD CONSTRAINT [PK_Marcas]
    PRIMARY KEY CLUSTERED ([IdMarca] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdMesa] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [FK_Ventas_Mesas]
    FOREIGN KEY ([IdMesa])
    REFERENCES [dbo].[Mesas]
        ([IdMesa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ventas_Mesas'
CREATE INDEX [IX_FK_Ventas_Mesas]
ON [dbo].[Ventas]
    ([IdMesa]);
GO

-- Creating foreign key on [IdProducto] in table 'VentasDetalles'
ALTER TABLE [dbo].[VentasDetalles]
ADD CONSTRAINT [FK_VentasDetalle_Productos]
    FOREIGN KEY ([IdProducto])
    REFERENCES [dbo].[Productos]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VentasDetalle_Productos'
CREATE INDEX [IX_FK_VentasDetalle_Productos]
ON [dbo].[VentasDetalles]
    ([IdProducto]);
GO

-- Creating foreign key on [IdVenta] in table 'VentasDetalles'
ALTER TABLE [dbo].[VentasDetalles]
ADD CONSTRAINT [FK_VentasDetalle_Ventas]
    FOREIGN KEY ([IdVenta])
    REFERENCES [dbo].[Ventas]
        ([IdVenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VentasDetalle_Ventas'
CREATE INDEX [IX_FK_VentasDetalle_Ventas]
ON [dbo].[VentasDetalles]
    ([IdVenta]);
GO

-- Creating foreign key on [IdCategoria] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [FK_CategoriasProducto]
    FOREIGN KEY ([IdCategoria])
    REFERENCES [dbo].[Categorias]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriasProducto'
CREATE INDEX [IX_FK_CategoriasProducto]
ON [dbo].[Productos]
    ([IdCategoria]);
GO

-- Creating foreign key on [IdMarca] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [FK_MarcaProducto]
    FOREIGN KEY ([IdMarca])
    REFERENCES [dbo].[Marcas]
        ([IdMarca])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MarcaProducto'
CREATE INDEX [IX_FK_MarcaProducto]
ON [dbo].[Productos]
    ([IdMarca]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------