
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/14/2017 18:56:06
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [Phone] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [AuthInfo_Id] int  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonRoles'
CREATE TABLE [dbo].[PersonRoles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Role_Id] int  NOT NULL,
    [AuthInfo_Id] int  NOT NULL
);
GO

-- Creating table 'CarDetails1'
CREATE TABLE [dbo].[CarDetails1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Color] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ParkingItems'
CREATE TABLE [dbo].[ParkingItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Qty] int  NOT NULL
);
GO

-- Creating table 'Rents'
CREATE TABLE [dbo].[Rents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerId] int  NOT NULL,
    [EmployeeId] int  NOT NULL,
    [DateRental] datetime  NOT NULL,
    [Customer_Id] int  NOT NULL,
    [Employee_Id] int  NOT NULL
);
GO

-- Creating table 'RentalDetails'
CREATE TABLE [dbo].[RentalDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Lease] time  NOT NULL,
    [LineItem] int  NOT NULL,
    [Qty] int  NOT NULL,
    [Rent_Id] int  NOT NULL,
    [Car_Id] int  NOT NULL
);
GO

-- Creating table 'PriceItems'
CREATE TABLE [dbo].[PriceItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Price] float  NOT NULL
);
GO

-- Creating table 'AuthInfoes'
CREATE TABLE [dbo].[AuthInfoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NULL,
    [PasswordHash] int  NOT NULL
);
GO

-- Creating table 'People_Customer'
CREATE TABLE [dbo].[People_Customer] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'People_Employee'
CREATE TABLE [dbo].[People_Employee] (
    [Salary] float  NULL,
    [BirthDate] nvarchar(max)  NULL,
    [Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'PersonRoles'
ALTER TABLE [dbo].[PersonRoles]
ADD CONSTRAINT [PK_PersonRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CarDetails1'
ALTER TABLE [dbo].[CarDetails1]
ADD CONSTRAINT [PK_CarDetails1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ParkingItems'
ALTER TABLE [dbo].[ParkingItems]
ADD CONSTRAINT [PK_ParkingItems]
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

-- Creating primary key on [Id] in table 'PriceItems'
ALTER TABLE [dbo].[PriceItems]
ADD CONSTRAINT [PK_PriceItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AuthInfoes'
ALTER TABLE [dbo].[AuthInfoes]
ADD CONSTRAINT [PK_AuthInfoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People_Customer'
ALTER TABLE [dbo].[People_Customer]
ADD CONSTRAINT [PK_People_Customer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People_Employee'
ALTER TABLE [dbo].[People_Employee]
ADD CONSTRAINT [PK_People_Employee]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Customer_Id] in table 'Rents'
ALTER TABLE [dbo].[Rents]
ADD CONSTRAINT [FK_CustomerRent]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[People_Customer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerRent'
CREATE INDEX [IX_FK_CustomerRent]
ON [dbo].[Rents]
    ([Customer_Id]);
GO

-- Creating foreign key on [Employee_Id] in table 'Rents'
ALTER TABLE [dbo].[Rents]
ADD CONSTRAINT [FK_EmployeeRent]
    FOREIGN KEY ([Employee_Id])
    REFERENCES [dbo].[People_Employee]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeRent'
CREATE INDEX [IX_FK_EmployeeRent]
ON [dbo].[Rents]
    ([Employee_Id]);
GO

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
    REFERENCES [dbo].[CarDetails1]
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
    REFERENCES [dbo].[ParkingItems]
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
    REFERENCES [dbo].[PriceItems]
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

-- Creating foreign key on [Id] in table 'People_Customer'
ALTER TABLE [dbo].[People_Customer]
ADD CONSTRAINT [FK_Customer_inherits_Person]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'People_Employee'
ALTER TABLE [dbo].[People_Employee]
ADD CONSTRAINT [FK_Employee_inherits_Person]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------