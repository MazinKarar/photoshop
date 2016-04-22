
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/22/2016 10:22:02
-- Generated from EDMX file: C:\Users\mazin awad\Source\Repos\photoshop\AccountingModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AccountingSystem];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_InvoiceDetails_dbo_Categories_CategoryId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceDetails] DROP CONSTRAINT [FK_dbo_InvoiceDetails_dbo_Categories_CategoryId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_InvoiceDetails_dbo_Invoices_InvoiceId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceDetails] DROP CONSTRAINT [FK_dbo_InvoiceDetails_dbo_Invoices_InvoiceId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_InvoiceDetails_dbo_Products_ProductId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceDetails] DROP CONSTRAINT [FK_dbo_InvoiceDetails_dbo_Products_ProductId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Invoices_dbo_Suppliers_SupplierId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Invoices] DROP CONSTRAINT [FK_dbo_Invoices_dbo_Suppliers_SupplierId];
GO
IF OBJECT_ID(N'[dbo].[FK_debenturedetails_debentures]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[debenturedetails] DROP CONSTRAINT [FK_debenturedetails_debentures];
GO
IF OBJECT_ID(N'[dbo].[FK_debenturedetails_debentures1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[debenturedetails] DROP CONSTRAINT [FK_debenturedetails_debentures1];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemGroupsItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Items] DROP CONSTRAINT [FK_ItemGroupsItems];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMeasurementUnits_Items]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMeasurementUnits] DROP CONSTRAINT [FK_ItemMeasurementUnits_Items];
GO
IF OBJECT_ID(N'[dbo].[FK_SaleInvoiceDetails_SalesInvoices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SaleInvoiceDetails] DROP CONSTRAINT [FK_SaleInvoiceDetails_SalesInvoices];
GO
IF OBJECT_ID(N'[dbo].[FK_WharehouseItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Items] DROP CONSTRAINT [FK_WharehouseItems];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[accountmains]', 'U') IS NOT NULL
    DROP TABLE [dbo].[accountmains];
GO
IF OBJECT_ID(N'[dbo].[Accounts_Balance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Accounts_Balance];
GO
IF OBJECT_ID(N'[dbo].[AreasSets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AreasSets];
GO
IF OBJECT_ID(N'[dbo].[BankBranches]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankBranches];
GO
IF OBJECT_ID(N'[dbo].[BankSets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankSets];
GO
IF OBJECT_ID(N'[dbo].[Branches]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Branches];
GO
IF OBJECT_ID(N'[dbo].[CompanyInfoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompanyInfoes];
GO
IF OBJECT_ID(N'[dbo].[CurrencySets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CurrencySets];
GO
IF OBJECT_ID(N'[dbo].[debenturedetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[debenturedetails];
GO
IF OBJECT_ID(N'[dbo].[debentures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[debentures];
GO
IF OBJECT_ID(N'[dbo].[Groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Groups];
GO
IF OBJECT_ID(N'[dbo].[InvoiceDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InvoiceDetails];
GO
IF OBJECT_ID(N'[dbo].[Invoices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Invoices];
GO
IF OBJECT_ID(N'[dbo].[ItemGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemGroups];
GO
IF OBJECT_ID(N'[dbo].[ItemMeasurementUnits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMeasurementUnits];
GO
IF OBJECT_ID(N'[dbo].[Items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items];
GO
IF OBJECT_ID(N'[dbo].[PaymentTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PaymentTypes];
GO
IF OBJECT_ID(N'[dbo].[PermissionControls]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermissionControls];
GO
IF OBJECT_ID(N'[dbo].[SaleInvoiceDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SaleInvoiceDetails];
GO
IF OBJECT_ID(N'[dbo].[SalesInvoices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SalesInvoices];
GO
IF OBJECT_ID(N'[dbo].[SupplierSets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SupplierSets];
GO
IF OBJECT_ID(N'[dbo].[TreeAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TreeAccounts];
GO
IF OBJECT_ID(N'[dbo].[Trees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Trees];
GO
IF OBJECT_ID(N'[dbo].[Trees1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Trees1];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[VendorSets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VendorSets];
GO
IF OBJECT_ID(N'[dbo].[Wharehouses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Wharehouses];
GO
IF OBJECT_ID(N'[AccountingModelStoreContainer].[accountmain]', 'U') IS NOT NULL
    DROP TABLE [AccountingModelStoreContainer].[accountmain];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'accountmains'
CREATE TABLE [dbo].[accountmains] (
    [id] decimal(18,0)  NOT NULL,
    [dt] datetime  NULL,
    [accountid] decimal(18,0)  NULL,
    [custid] decimal(18,0)  NULL,
    [debit] decimal(19,4)  NULL,
    [credit] decimal(19,4)  NULL,
    [balance] decimal(19,4)  NULL,
    [detail] nvarchar(50)  NULL,
    [dealing] nvarchar(50)  NULL,
    [renum] decimal(18,0)  NULL,
    [idunique] decimal(18,0)  NULL,
    [active] bit  NULL,
    [isdeleted] bit  NULL,
    [ship] nvarchar(350)  NULL,
    [en_dealing] nvarchar(50)  NULL,
    [deal] nvarchar(50)  NULL,
    [Myuser] nvarchar(50)  NULL,
    [IsUser] bit  NULL,
    [CloseRegnum] decimal(18,0)  NULL,
    [Cpu] decimal(18,0)  NULL,
    [currency] nvarchar(50)  NULL,
    [currencyval] float  NULL,
    [BranchID] decimal(18,0)  NULL,
    [CostID] decimal(18,0)  NULL
);
GO

-- Creating table 'Accounts_Balance'
CREATE TABLE [dbo].[Accounts_Balance] (
    [id] decimal(18,0)  NOT NULL,
    [branchid] decimal(18,0)  NULL,
    [accountid] decimal(18,0)  NULL,
    [debit] float  NULL,
    [credit] float  NULL,
    [balance] float  NULL
);
GO

-- Creating table 'AreasSets'
CREATE TABLE [dbo].[AreasSets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AreaName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BankBranches'
CREATE TABLE [dbo].[BankBranches] (
    [Id] int  NOT NULL,
    [IdBank] varchar(50)  NULL,
    [BranchName] varchar(100)  NULL
);
GO

-- Creating table 'BankSets'
CREATE TABLE [dbo].[BankSets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BankName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Branches'
CREATE TABLE [dbo].[Branches] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BId] nvarchar(max)  NOT NULL,
    [BName] nvarchar(max)  NOT NULL,
    [BStatus] nvarchar(max)  NOT NULL,
    [BPhone1] nvarchar(max)  NOT NULL,
    [BPhone2] nvarchar(max)  NOT NULL,
    [BAddress] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CompanyInfoes'
CREATE TABLE [dbo].[CompanyInfoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [phone1] nvarchar(max)  NOT NULL,
    [phone2] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [WebSite] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CurrencySets'
CREATE TABLE [dbo].[CurrencySets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CurrencyName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'debenturedetails'
CREATE TABLE [dbo].[debenturedetails] (
    [DebentureID] int  NOT NULL,
    [AccountID] int  NULL,
    [Amount] float  NULL,
    [Notes] varchar(max)  NULL,
    [ChequeID] int  NULL,
    [Narration] int  NULL,
    [ValueDate] datetime  NULL,
    [Payed] int  NULL,
    [CenterID] int  NULL,
    [GridNo] int  NULL,
    [BranchID] int  NULL,
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'debentures'
CREATE TABLE [dbo].[debentures] (
    [DebentureID] int IDENTITY(1,1) NOT NULL,
    [DebentureNo] varchar(100)  NULL,
    [DebentureDate] datetime  NULL,
    [UserID] int  NULL,
    [MDate] datetime  NULL,
    [Sequence] int  NULL,
    [Amount] float  NULL,
    [Notes] nvarchar(max)  NULL,
    [remarks] nvarchar(max)  NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InvoiceDetails'
CREATE TABLE [dbo].[InvoiceDetails] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [InvoiceId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [CategoryId] int  NOT NULL,
    [UnitPrice] float  NOT NULL,
    [UnitQuantity] bigint  NOT NULL,
    [cuid] bigint  NULL,
    [CreateTime] datetime  NULL,
    [duid] bigint  NULL,
    [DeleteTime] datetime  NULL,
    [State] int  NULL
);
GO

-- Creating table 'Invoices'
CREATE TABLE [dbo].[Invoices] (
    [InvoiceId] int IDENTITY(1,1) NOT NULL,
    [InvoiceDate] datetime  NOT NULL,
    [SupplierId] int  NOT NULL,
    [Total] float  NULL,
    [WorkflowState] bigint  NOT NULL,
    [cuid] bigint  NULL,
    [CreateTime] datetime  NULL,
    [duid] bigint  NULL,
    [DeleteTime] datetime  NULL,
    [State] int  NULL
);
GO

-- Creating table 'ItemGroups'
CREATE TABLE [dbo].[ItemGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] int  NULL
);
GO

-- Creating table 'ItemMeasurementUnits'
CREATE TABLE [dbo].[ItemMeasurementUnits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemId] int  NULL,
    [Barcode] nchar(10)  NULL,
    [NumOfPieces] int  NULL,
    [Unit] nvarchar(50)  NULL,
    [SalePrice] decimal(18,0)  NULL,
    [PurchasePrice] decimal(18,0)  NULL,
    [PurchaseDefault] bit  NULL,
    [SaleDefault] bit  NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(50)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Status] bit  NULL,
    [ExpireDate] datetime  NULL,
    [ItemGroupsId] int  NULL,
    [WharehouseId] int  NULL,
    [MinQouantity] int  NULL,
    [MonthlySale] int  NULL,
    [FreezDate] int  NULL,
    [ExpireAlarmDays] int  NULL,
    [SupplierId] int  NULL,
    [VendorId] int  NULL,
    [Discription] nvarchar(max)  NULL,
    [HasExpireDate] bit  NULL
);
GO

-- Creating table 'PaymentTypes'
CREATE TABLE [dbo].[PaymentTypes] (
    [PaymentTypeID] int IDENTITY(1,1) NOT NULL,
    [PaymentTypeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PermissionControls'
CREATE TABLE [dbo].[PermissionControls] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CGroupId] nvarchar(max)  NOT NULL,
    [CAdmin] bit  NOT NULL,
    [CSells] bit  NOT NULL,
    [CBuys] bit  NOT NULL,
    [CWarehouse] bit  NOT NULL,
    [CAccount] bit  NOT NULL,
    [CVendorSupplier] bit  NOT NULL,
    [COther] bit  NOT NULL
);
GO

-- Creating table 'SaleInvoiceDetails'
CREATE TABLE [dbo].[SaleInvoiceDetails] (
    [DetailsId] int IDENTITY(1,1) NOT NULL,
    [ItemID] int  NOT NULL,
    [Quantity] float  NOT NULL,
    [Unit] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [SalesInvoicesId] int  NOT NULL
);
GO

-- Creating table 'SalesInvoices'
CREATE TABLE [dbo].[SalesInvoices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [InoviceNo] nvarchar(max)  NOT NULL,
    [InvoiceDate] datetime  NOT NULL,
    [CustomerID] int  NOT NULL,
    [UserID] int  NOT NULL,
    [CurrencyID] int  NOT NULL,
    [Rate] float  NOT NULL,
    [PaymentType] int  NOT NULL,
    [ChequeNo] nvarchar(max)  NULL,
    [ChequeDate] datetime  NULL,
    [Paid] int  NOT NULL,
    [Tax] float  NOT NULL,
    [Discount] float  NOT NULL,
    [Notes] nvarchar(max)  NULL,
    [Canceled] int  NULL
);
GO

-- Creating table 'SupplierSets'
CREATE TABLE [dbo].[SupplierSets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SupplierId] nvarchar(max)  NOT NULL,
    [SupplierName] nvarchar(max)  NULL,
    [SupplierStartBalance] nvarchar(max)  NULL,
    [SupplierStartBlnsDate] nvarchar(max)  NULL,
    [SupplierTypeOfBalance] nvarchar(max)  NULL,
    [SupplierStatus] varchar(50)  NULL,
    [SupplierBranch] nvarchar(max)  NULL,
    [SupplierBranchCurrency] nvarchar(max)  NULL,
    [SupplierLedger] nvarchar(max)  NULL,
    [SupplierSupplementingAccount] nvarchar(max)  NULL,
    [SupplierCompanyName] nvarchar(max)  NULL,
    [SupplierResponsible] nvarchar(max)  NULL,
    [SupplierArea] nvarchar(max)  NULL,
    [SupplierAddress] nvarchar(max)  NULL,
    [SupplierPhone1] nvarchar(max)  NULL,
    [SupplierPhone2] nvarchar(max)  NULL,
    [SupplierWebsite] nvarchar(max)  NULL,
    [SupplierEmail] nvarchar(max)  NULL,
    [SupplierBankNoAccount] nvarchar(max)  NULL,
    [SupplierBankName] nvarchar(max)  NULL,
    [SupplierBankBranach] nvarchar(max)  NULL
);
GO

-- Creating table 'TreeAccounts'
CREATE TABLE [dbo].[TreeAccounts] (
    [Id] int  NOT NULL,
    [Name] nvarchar(50)  NULL,
    [levels] int  NULL,
    [parentId] int  NULL,
    [isparent] bit  NULL,
    [related] decimal(18,0)  NULL,
    [operands] nvarchar(50)  NULL,
    [type] int  NULL,
    [sign] nvarchar(50)  NULL,
    [active] bit  NULL,
    [debit] decimal(19,2)  NULL,
    [credit] decimal(19,2)  NULL,
    [balance] decimal(19,2)  NULL,
    [cmpnum] decimal(18,0)  NULL,
    [dt] datetime  NULL,
    [note] varchar(max)  NULL,
    [ismoney] bit  NULL,
    [tag] nvarchar(50)  NULL,
    [BranchID] decimal(18,0)  NULL,
    [nameEn] nvarchar(50)  NULL,
    [typeEn] nvarchar(50)  NULL,
    [parentEn] nvarchar(50)  NULL
);
GO

-- Creating table 'Trees'
CREATE TABLE [dbo].[Trees] (
    [Id] int  NOT NULL,
    [Name] nchar(10)  NULL,
    [ParentID] int  NULL
);
GO

-- Creating table 'Trees1'
CREATE TABLE [dbo].[Trees1] (
    [Id] int  NOT NULL,
    [Name] nchar(10)  NULL,
    [ParentID] int  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UCode] nvarchar(max)  NOT NULL,
    [UName] nvarchar(max)  NOT NULL,
    [UPassword] nvarchar(max)  NOT NULL,
    [UGroup] nvarchar(max)  NULL,
    [UBranch] nvarchar(max)  NULL,
    [UStatus] nvarchar(50)  NULL
);
GO

-- Creating table 'VendorSets'
CREATE TABLE [dbo].[VendorSets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VendorId] nvarchar(max)  NULL,
    [VendorName] nvarchar(max)  NULL,
    [VendorStartBalance] nvarchar(max)  NULL,
    [VendorStartBlnsDate] nvarchar(max)  NULL,
    [VendorTypeOfBalance] nvarchar(max)  NULL,
    [VendorStatus] varchar(50)  NULL,
    [VendorBranch] nvarchar(max)  NULL,
    [VendorBranchCurrency] nvarchar(max)  NULL,
    [VendorLedger] nvarchar(max)  NULL,
    [VendorSupplementingAccount] nvarchar(max)  NULL,
    [VendorCompanyName] nvarchar(max)  NULL,
    [VendorResponsible] nvarchar(max)  NULL,
    [VendorArea] nvarchar(max)  NULL,
    [VendorAddress] nvarchar(max)  NULL,
    [VendorPhone1] nvarchar(max)  NULL,
    [VendorPhone2] nvarchar(max)  NULL,
    [VendorWebsite] nvarchar(max)  NULL,
    [VendorEmail] nvarchar(max)  NULL,
    [VendorBankNoAccount] nvarchar(max)  NULL,
    [VendorBankName] nvarchar(max)  NULL,
    [VendorBankBranach] nvarchar(max)  NULL
);
GO

-- Creating table 'Wharehouses'
CREATE TABLE [dbo].[Wharehouses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StoreName] nvarchar(max)  NOT NULL,
    [BranchID] int  NULL,
    [Status] bit  NULL,
    [Area] decimal(18,0)  NULL,
    [Address] nvarchar(max)  NULL,
    [Mobile] nvarchar(max)  NULL,
    [Size] decimal(18,0)  NULL
);
GO

-- Creating table 'accountmains1'
CREATE TABLE [dbo].[accountmains1] (
    [id] decimal(18,0)  NOT NULL,
    [dt] datetime  NULL,
    [accountid] decimal(18,0)  NULL,
    [custid] decimal(18,0)  NULL,
    [debit] decimal(19,4)  NULL,
    [credit] decimal(19,4)  NULL,
    [balance] decimal(19,4)  NULL,
    [detail] nvarchar(50)  NULL,
    [dealing] nvarchar(50)  NULL,
    [renum] decimal(18,0)  NULL,
    [idunique] decimal(18,0)  NULL,
    [active] bit  NULL,
    [isdeleted] bit  NULL,
    [ship] nvarchar(350)  NULL,
    [en_dealing] nvarchar(50)  NULL,
    [deal] nvarchar(50)  NULL,
    [Myuser] nvarchar(50)  NULL,
    [IsUser] bit  NULL,
    [CloseRegnum] decimal(18,0)  NULL,
    [Cpu] decimal(18,0)  NULL,
    [currency] nvarchar(50)  NULL,
    [currencyval] float  NULL,
    [BranchID] decimal(18,0)  NULL,
    [CostID] decimal(18,0)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'accountmains'
ALTER TABLE [dbo].[accountmains]
ADD CONSTRAINT [PK_accountmains]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Accounts_Balance'
ALTER TABLE [dbo].[Accounts_Balance]
ADD CONSTRAINT [PK_Accounts_Balance]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'AreasSets'
ALTER TABLE [dbo].[AreasSets]
ADD CONSTRAINT [PK_AreasSets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BankBranches'
ALTER TABLE [dbo].[BankBranches]
ADD CONSTRAINT [PK_BankBranches]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BankSets'
ALTER TABLE [dbo].[BankSets]
ADD CONSTRAINT [PK_BankSets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Branches'
ALTER TABLE [dbo].[Branches]
ADD CONSTRAINT [PK_Branches]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CompanyInfoes'
ALTER TABLE [dbo].[CompanyInfoes]
ADD CONSTRAINT [PK_CompanyInfoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CurrencySets'
ALTER TABLE [dbo].[CurrencySets]
ADD CONSTRAINT [PK_CurrencySets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'debenturedetails'
ALTER TABLE [dbo].[debenturedetails]
ADD CONSTRAINT [PK_debenturedetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [DebentureID] in table 'debentures'
ALTER TABLE [dbo].[debentures]
ADD CONSTRAINT [PK_debentures]
    PRIMARY KEY CLUSTERED ([DebentureID] ASC);
GO

-- Creating primary key on [Id] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InvoiceDetails'
ALTER TABLE [dbo].[InvoiceDetails]
ADD CONSTRAINT [PK_InvoiceDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [InvoiceId] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [PK_Invoices]
    PRIMARY KEY CLUSTERED ([InvoiceId] ASC);
GO

-- Creating primary key on [Id] in table 'ItemGroups'
ALTER TABLE [dbo].[ItemGroups]
ADD CONSTRAINT [PK_ItemGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemMeasurementUnits'
ALTER TABLE [dbo].[ItemMeasurementUnits]
ADD CONSTRAINT [PK_ItemMeasurementUnits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [PaymentTypeID] in table 'PaymentTypes'
ALTER TABLE [dbo].[PaymentTypes]
ADD CONSTRAINT [PK_PaymentTypes]
    PRIMARY KEY CLUSTERED ([PaymentTypeID] ASC);
GO

-- Creating primary key on [Id] in table 'PermissionControls'
ALTER TABLE [dbo].[PermissionControls]
ADD CONSTRAINT [PK_PermissionControls]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [DetailsId] in table 'SaleInvoiceDetails'
ALTER TABLE [dbo].[SaleInvoiceDetails]
ADD CONSTRAINT [PK_SaleInvoiceDetails]
    PRIMARY KEY CLUSTERED ([DetailsId] ASC);
GO

-- Creating primary key on [Id] in table 'SalesInvoices'
ALTER TABLE [dbo].[SalesInvoices]
ADD CONSTRAINT [PK_SalesInvoices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SupplierSets'
ALTER TABLE [dbo].[SupplierSets]
ADD CONSTRAINT [PK_SupplierSets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TreeAccounts'
ALTER TABLE [dbo].[TreeAccounts]
ADD CONSTRAINT [PK_TreeAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Trees'
ALTER TABLE [dbo].[Trees]
ADD CONSTRAINT [PK_Trees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Trees1'
ALTER TABLE [dbo].[Trees1]
ADD CONSTRAINT [PK_Trees1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VendorSets'
ALTER TABLE [dbo].[VendorSets]
ADD CONSTRAINT [PK_VendorSets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Wharehouses'
ALTER TABLE [dbo].[Wharehouses]
ADD CONSTRAINT [PK_Wharehouses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'accountmains1'
ALTER TABLE [dbo].[accountmains1]
ADD CONSTRAINT [PK_accountmains1]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DebentureID] in table 'debenturedetails'
ALTER TABLE [dbo].[debenturedetails]
ADD CONSTRAINT [FK_debenturedetails_debentures]
    FOREIGN KEY ([DebentureID])
    REFERENCES [dbo].[debentures]
        ([DebentureID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_debenturedetails_debentures'
CREATE INDEX [IX_FK_debenturedetails_debentures]
ON [dbo].[debenturedetails]
    ([DebentureID]);
GO

-- Creating foreign key on [AccountID] in table 'debenturedetails'
ALTER TABLE [dbo].[debenturedetails]
ADD CONSTRAINT [FK_debenturedetails_debentures1]
    FOREIGN KEY ([AccountID])
    REFERENCES [dbo].[TreeAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_debenturedetails_debentures1'
CREATE INDEX [IX_FK_debenturedetails_debentures1]
ON [dbo].[debenturedetails]
    ([AccountID]);
GO

-- Creating foreign key on [CategoryId] in table 'InvoiceDetails'
ALTER TABLE [dbo].[InvoiceDetails]
ADD CONSTRAINT [FK_dbo_InvoiceDetails_dbo_Categories_CategoryId]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[ItemGroups]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_InvoiceDetails_dbo_Categories_CategoryId'
CREATE INDEX [IX_FK_dbo_InvoiceDetails_dbo_Categories_CategoryId]
ON [dbo].[InvoiceDetails]
    ([CategoryId]);
GO

-- Creating foreign key on [InvoiceId] in table 'InvoiceDetails'
ALTER TABLE [dbo].[InvoiceDetails]
ADD CONSTRAINT [FK_dbo_InvoiceDetails_dbo_Invoices_InvoiceId]
    FOREIGN KEY ([InvoiceId])
    REFERENCES [dbo].[Invoices]
        ([InvoiceId])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_InvoiceDetails_dbo_Invoices_InvoiceId'
CREATE INDEX [IX_FK_dbo_InvoiceDetails_dbo_Invoices_InvoiceId]
ON [dbo].[InvoiceDetails]
    ([InvoiceId]);
GO

-- Creating foreign key on [ProductId] in table 'InvoiceDetails'
ALTER TABLE [dbo].[InvoiceDetails]
ADD CONSTRAINT [FK_dbo_InvoiceDetails_dbo_Products_ProductId]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_InvoiceDetails_dbo_Products_ProductId'
CREATE INDEX [IX_FK_dbo_InvoiceDetails_dbo_Products_ProductId]
ON [dbo].[InvoiceDetails]
    ([ProductId]);
GO

-- Creating foreign key on [SupplierId] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [FK_dbo_Invoices_dbo_Suppliers_SupplierId]
    FOREIGN KEY ([SupplierId])
    REFERENCES [dbo].[SupplierSets]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Invoices_dbo_Suppliers_SupplierId'
CREATE INDEX [IX_FK_dbo_Invoices_dbo_Suppliers_SupplierId]
ON [dbo].[Invoices]
    ([SupplierId]);
GO

-- Creating foreign key on [ItemGroupsId] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [FK_ItemGroupsItems]
    FOREIGN KEY ([ItemGroupsId])
    REFERENCES [dbo].[ItemGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemGroupsItems'
CREATE INDEX [IX_FK_ItemGroupsItems]
ON [dbo].[Items]
    ([ItemGroupsId]);
GO

-- Creating foreign key on [ItemId] in table 'ItemMeasurementUnits'
ALTER TABLE [dbo].[ItemMeasurementUnits]
ADD CONSTRAINT [FK_ItemMeasurementUnits_Items]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMeasurementUnits_Items'
CREATE INDEX [IX_FK_ItemMeasurementUnits_Items]
ON [dbo].[ItemMeasurementUnits]
    ([ItemId]);
GO

-- Creating foreign key on [WharehouseId] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [FK_WharehouseItems]
    FOREIGN KEY ([WharehouseId])
    REFERENCES [dbo].[Wharehouses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WharehouseItems'
CREATE INDEX [IX_FK_WharehouseItems]
ON [dbo].[Items]
    ([WharehouseId]);
GO

-- Creating foreign key on [SalesInvoicesId] in table 'SaleInvoiceDetails'
ALTER TABLE [dbo].[SaleInvoiceDetails]
ADD CONSTRAINT [FK_SaleInvoiceDetails_SalesInvoices]
    FOREIGN KEY ([SalesInvoicesId])
    REFERENCES [dbo].[SalesInvoices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SaleInvoiceDetails_SalesInvoices'
CREATE INDEX [IX_FK_SaleInvoiceDetails_SalesInvoices]
ON [dbo].[SaleInvoiceDetails]
    ([SalesInvoicesId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------