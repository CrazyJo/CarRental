
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/20/2017 20:46:40
-- Generated from EDMX file: C:\Users\Philip\Documents\Visual Studio 2015\Projects\CarRental\CarRental.Data\CarRentalModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CarRentalDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RentRentalDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RentalDetails] DROP CONSTRAINT [FK_RentRentalDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_RolePersonRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonRoles] DROP CONSTRAINT [FK_RolePersonRole];
GO
IF OBJECT_ID(N'[dbo].[FK_CarCarDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK_CarCarDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_CarRentalDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RentalDetails] DROP CONSTRAINT [FK_CarRentalDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_CarParking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK_CarParking];
GO
IF OBJECT_ID(N'[dbo].[FK_CarPriceItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK_CarPriceItem];
GO
IF OBJECT_ID(N'[dbo].[FK_AuthInfoPersonRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonRoles] DROP CONSTRAINT [FK_AuthInfoPersonRole];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonAuthInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People] DROP CONSTRAINT [FK_PersonAuthInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonRent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rents] DROP CONSTRAINT [FK_PersonRent];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cars];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[PersonRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonRoles];
GO
IF OBJECT_ID(N'[dbo].[CarDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarDetails];
GO
IF OBJECT_ID(N'[dbo].[Parking]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parking];
GO
IF OBJECT_ID(N'[dbo].[Rents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rents];
GO
IF OBJECT_ID(N'[dbo].[RentalDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RentalDetails];
GO
IF OBJECT_ID(N'[dbo].[PriceList]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PriceList];
GO
IF OBJECT_ID(N'[dbo].[AuthInfoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuthInfoes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CarDetails_Id] int  NOT NULL,
    [ParkingItem_Id] int  NOT NULL,
    [PriceItem_Id] int  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirsName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [AuthInfo_Id] int  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] int  NOT NULL
);
GO

-- Creating table 'PersonRoles'
CREATE TABLE [dbo].[PersonRoles] (
    [RoleId] int  NOT NULL,
    [AuthInfoId] int  NOT NULL,
    [Role_Id] int  NOT NULL,
    [AuthInfo_Id] int  NOT NULL
);
GO

-- Creating table 'CarDetails'
CREATE TABLE [dbo].[CarDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Color] nvarchar(max)  NOT NULL,
    [CarId] int  NOT NULL
);
GO

-- Creating table 'Parking'
CREATE TABLE [dbo].[Parking] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TotalCars] int  NOT NULL,
    [Balance] int  NOT NULL,
    [CarId] int  NOT NULL
);
GO

-- Creating table 'Rents'
CREATE TABLE [dbo].[Rents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateRental] datetime  NOT NULL,
    [PersonId] int  NOT NULL,
    [Person_Id] int  NOT NULL
);
GO

-- Creating table 'RentalDetails'
CREATE TABLE [dbo].[RentalDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Lease] time  NOT NULL,
    [CarId] int  NOT NULL,
    [RentId] int  NOT NULL,
    [Rent_Id] int  NOT NULL,
    [Car_Id] int  NOT NULL
);
GO

-- Creating table 'PriceList'
CREATE TABLE [dbo].[PriceList] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PricePerHour] float  NOT NULL,
    [CarId] int  NOT NULL
);
GO

-- Creating table 'AuthInfoes'
CREATE TABLE [dbo].[AuthInfoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [PersonId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [RoleId], [AuthInfoId] in table 'PersonRoles'
ALTER TABLE [dbo].[PersonRoles]
ADD CONSTRAINT [PK_PersonRoles]
    PRIMARY KEY CLUSTERED ([RoleId], [AuthInfoId] ASC);
GO

-- Creating primary key on [Id] in table 'CarDetails'
ALTER TABLE [dbo].[CarDetails]
ADD CONSTRAINT [PK_CarDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Parking'
ALTER TABLE [dbo].[Parking]
ADD CONSTRAINT [PK_Parking]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rents'
ALTER TABLE [dbo].[Rents]
ADD CONSTRAINT [PK_Rents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RentalDetails'
ALTER TABLE [dbo].[RentalDetails]
ADD CONSTRAINT [PK_RentalDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PriceList'
ALTER TABLE [dbo].[PriceList]
ADD CONSTRAINT [PK_PriceList]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AuthInfoes'
ALTER TABLE [dbo].[AuthInfoes]
ADD CONSTRAINT [PK_AuthInfoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Rent_Id] in table 'RentalDetails'
ALTER TABLE [dbo].[RentalDetails]
ADD CONSTRAINT [FK_RentRentalDetails]
    FOREIGN KEY ([Rent_Id])
    REFERENCES [dbo].[Rents]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RentRentalDetails'
CREATE INDEX [IX_FK_RentRentalDetails]
ON [dbo].[RentalDetails]
    ([Rent_Id]);
GO

-- Creating foreign key on [Role_Id] in table 'PersonRoles'
ALTER TABLE [dbo].[PersonRoles]
ADD CONSTRAINT [FK_RolePersonRole]
    FOREIGN KEY ([Role_Id])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolePersonRole'
CREATE INDEX [IX_FK_RolePersonRole]
ON [dbo].[PersonRoles]
    ([Role_Id]);
GO

-- Creating foreign key on [CarDetails_Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_CarCarDetails]
    FOREIGN KEY ([CarDetails_Id])
    REFERENCES [dbo].[CarDetails]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarCarDetails'
CREATE INDEX [IX_FK_CarCarDetails]
ON [dbo].[Cars]
    ([CarDetails_Id]);
GO

-- Creating foreign key on [Car_Id] in table 'RentalDetails'
ALTER TABLE [dbo].[RentalDetails]
ADD CONSTRAINT [FK_CarRentalDetails]
    FOREIGN KEY ([Car_Id])
    REFERENCES [dbo].[Cars]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarRentalDetails'
CREATE INDEX [IX_FK_CarRentalDetails]
ON [dbo].[RentalDetails]
    ([Car_Id]);
GO

-- Creating foreign key on [ParkingItem_Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_CarParking]
    FOREIGN KEY ([ParkingItem_Id])
    REFERENCES [dbo].[Parking]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarParking'
CREATE INDEX [IX_FK_CarParking]
ON [dbo].[Cars]
    ([ParkingItem_Id]);
GO

-- Creating foreign key on [PriceItem_Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_CarPriceItem]
    FOREIGN KEY ([PriceItem_Id])
    REFERENCES [dbo].[PriceList]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarPriceItem'
CREATE INDEX [IX_FK_CarPriceItem]
ON [dbo].[Cars]
    ([PriceItem_Id]);
GO

-- Creating foreign key on [AuthInfo_Id] in table 'PersonRoles'
ALTER TABLE [dbo].[PersonRoles]
ADD CONSTRAINT [FK_AuthInfoPersonRole]
    FOREIGN KEY ([AuthInfo_Id])
    REFERENCES [dbo].[AuthInfoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AuthInfoPersonRole'
CREATE INDEX [IX_FK_AuthInfoPersonRole]
ON [dbo].[PersonRoles]
    ([AuthInfo_Id]);
GO

-- Creating foreign key on [AuthInfo_Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_PersonAuthInfo]
    FOREIGN KEY ([AuthInfo_Id])
    REFERENCES [dbo].[AuthInfoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonAuthInfo'
CREATE INDEX [IX_FK_PersonAuthInfo]
ON [dbo].[People]
    ([AuthInfo_Id]);
GO

-- Creating foreign key on [Person_Id] in table 'Rents'
ALTER TABLE [dbo].[Rents]
ADD CONSTRAINT [FK_PersonRent]
    FOREIGN KEY ([Person_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonRent'
CREATE INDEX [IX_FK_PersonRent]
ON [dbo].[Rents]
    ([Person_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------