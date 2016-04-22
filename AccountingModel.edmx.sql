
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/15/2016 15:57:20
-- Generated from EDMX file: E:\Accounting\Accounting\AccountingModel.edmx
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

IF OBJECT_ID(N'[dbo].[FK_accounts_accountsgroups]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[accounts] DROP CONSTRAINT [FK_accounts_accountsgroups];
GO
IF OBJECT_ID(N'[dbo].[FK_debenturedetails_debentures1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[debenturedetails] DROP CONSTRAINT [FK_debenturedetails_debentures1];
GO
IF OBJECT_ID(N'[dbo].[FK_debenturedetails_debentures11]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[debenturedetails] DROP CONSTRAINT [FK_debenturedetails_debentures11];
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

IF OBJECT_ID(N'[dbo].[accounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[accounts];
GO
IF OBJECT_ID(N'[dbo].[accountsgroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[accountsgroups];
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
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
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
IF OBJECT_ID(N'[AccountingModelStoreContainer].[Accounts_Balance]', 'U') IS NOT NULL
    DROP TABLE [AccountingModelStoreContainer].[Accounts_Balance];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'accounts'
CREATE TABLE [dbo].[accounts] (
    [AccountID] int  NOT NULL,
    [AccountNo] varchar(50)  NOT NULL,
    [GroupID] int  NOT NULL,
    [AccountName] varchar(50)  NOT NULL,
    [StartingBalance] float  NOT NULL,
    [Notes] varchar(100)  NOT NULL,
    [Suspended] int  NOT NULL,
    [Type] int  NOT NULL,
    [Nature] int  NOT NULL,
    [Persons] int  NOT NULL
);
GO

-- Creating table 'accountsgroups'
CREATE TABLE [dbo].[accountsgroups] (
    [GroupID] int  NOT NULL,
    [GroupName] varchar(50)  NOT NULL,
    [Under] int  NOT NULL,
    [Master] int  NOT NULL,
    [Suspended] int  NOT NULL,
    [GroupNo] varchar(1)  NOT NULL,
    [HaveGroups] int  NOT NULL,
    [Balance] float  NOT NULL
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

-- Creating table 'CurrencySets'
CREATE TABLE [dbo].[CurrencySets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CurrencyName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'debenturedetails'
CREATE TABLE [dbo].[debenturedetails] (
    [DebentureID] int  NOT NULL,
    [AccountID] int  NOT NULL,
    [Amount] float  NOT NULL,
    [Notes] varchar(1)  NOT NULL,
    [ChequeID] int  NOT NULL,
    [Narration] int  NOT NULL,
    [ValueDate] datetime  NOT NULL,
    [Payed] int  NOT NULL,
    [CenterID] int  NOT NULL,
    [GridNo] int  NOT NULL,
    [BranchID] int  NOT NULL
);
GO

-- Creating table 'debentures'
CREATE TABLE [dbo].[debentures] (
    [DebentureID] int  NOT NULL,
    [DebentureNo] varchar(1)  NOT NULL,
    [DebentureDate] datetime  NOT NULL,
    [Notes] varchar(1)  NOT NULL,
    [UserID] int  NOT NULL,
    [MDate] datetime  NOT NULL,
    [Sequence] int  NOT NULL,
    [Amount] float  NOT NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
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

-- Creating table 'SupplierSets'
CREATE TABLE [dbo].[SupplierSets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SupplierId] nvarchar(max)  NOT NULL,
    [SupplierName] nvarchar(max)  NULL,
    [SupplierStartBalance] nvarchar(max)  NULL,
    [SupplierStartBlnsDate] nvarchar(max)  NULL,
    [SupplierTypeOfBalance] nvarchar(max)  NULL,
    [SupplierStatus] nvarchar(max)  NULL,
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

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Trees'
CREATE TABLE [dbo].[Trees] (
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
    [VendorStatus] nvarchar(max)  NULL,
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

-- Creating table 'Trees1'
CREATE TABLE [dbo].[Trees1] (
    [Id] int  NOT NULL,
    [Name] nchar(10)  NULL,
    [ParentID] int  NULL
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

-- Creating table 'PaymentTypes'
CREATE TABLE [dbo].[PaymentTypes] (
    [PaymentTypeID] int IDENTITY(1,1) NOT NULL,
    [PaymentTypeName] nvarchar(max)  NOT NULL
);
GO

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
    [debit] decimal(19,4)  NULL,
    [credit] decimal(19,4)  NULL,
    [balance] decimal(19,4)  NULL,
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

-- Creating table 'accountmain1'
CREATE TABLE [dbo].[accountmain1] (
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

-- Creating primary key on [AccountID] in table 'accounts'
ALTER TABLE [dbo].[accounts]
ADD CONSTRAINT [PK_accounts]
    PRIMARY KEY CLUSTERED ([AccountID] ASC);
GO

-- Creating primary key on [GroupID] in table 'accountsgroups'
ALTER TABLE [dbo].[accountsgroups]
ADD CONSTRAINT [PK_accountsgroups]
    PRIMARY KEY CLUSTERED ([GroupID] ASC);
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

-- Creating primary key on [Id] in table 'CurrencySets'
ALTER TABLE [dbo].[CurrencySets]
ADD CONSTRAINT [PK_CurrencySets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [DebentureID], [AccountID], [Amount], [Notes], [ChequeID], [Narration], [ValueDate], [Payed], [CenterID], [GridNo], [BranchID] in table 'debenturedetails'
ALTER TABLE [dbo].[debenturedetails]
ADD CONSTRAINT [PK_debenturedetails]
    PRIMARY KEY CLUSTERED ([DebentureID], [AccountID], [Amount], [Notes], [ChequeID], [Narration], [ValueDate], [Payed], [CenterID], [GridNo], [BranchID] ASC);
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

-- Creating primary key on [Id] in table 'PermissionControls'
ALTER TABLE [dbo].[PermissionControls]
ADD CONSTRAINT [PK_PermissionControls]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SupplierSets'
ALTER TABLE [dbo].[SupplierSets]
ADD CONSTRAINT [PK_SupplierSets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'Trees'
ALTER TABLE [dbo].[Trees]
ADD CONSTRAINT [PK_Trees]
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

-- Creating primary key on [Id] in table 'Trees1'
ALTER TABLE [dbo].[Trees1]
ADD CONSTRAINT [PK_Trees1]
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

-- Creating primary key on [PaymentTypeID] in table 'PaymentTypes'
ALTER TABLE [dbo].[PaymentTypes]
ADD CONSTRAINT [PK_PaymentTypes]
    PRIMARY KEY CLUSTERED ([PaymentTypeID] ASC);
GO

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

-- Creating primary key on [Id] in table 'TreeAccounts'
ALTER TABLE [dbo].[TreeAccounts]
ADD CONSTRAINT [PK_TreeAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CompanyInfoes'
ALTER TABLE [dbo].[CompanyInfoes]
ADD CONSTRAINT [PK_CompanyInfoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'accountmain1'
ALTER TABLE [dbo].[accountmain1]
ADD CONSTRAINT [PK_accountmain1]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [GroupID] in table 'accounts'
ALTER TABLE [dbo].[accounts]
ADD CONSTRAINT [FK_accounts_accountsgroups]
    FOREIGN KEY ([GroupID])
    REFERENCES [dbo].[accountsgroups]
        ([GroupID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_accounts_accountsgroups'
CREATE INDEX [IX_FK_accounts_accountsgroups]
ON [dbo].[accounts]
    ([GroupID]);
GO

-- Creating foreign key on [AccountID] in table 'debenturedetails'
ALTER TABLE [dbo].[debenturedetails]
ADD CONSTRAINT [FK_debenturedetails_debentures11]
    FOREIGN KEY ([AccountID])
    REFERENCES [dbo].[accounts]
        ([AccountID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_debenturedetails_debentures11'
CREATE INDEX [IX_FK_debenturedetails_debentures11]
ON [dbo].[debenturedetails]
    ([AccountID]);
GO

-- Creating foreign key on [DebentureID] in table 'debenturedetails'
ALTER TABLE [dbo].[debenturedetails]
ADD CONSTRAINT [FK_debenturedetails_debentures1]
    FOREIGN KEY ([DebentureID])
    REFERENCES [dbo].[debentures]
        ([DebentureID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
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



insert into TreeAccounts (Name,parentId,type,active) values('«·√’Ê·',0,1,True);
insert into TreeAccounts (Name,parentId,type,active) values('«·Œ’Ê„',0,2,True);
insert into TreeAccounts (Name,parentId,type,active) values('«·≈Ì—«œ« ',0,3,True);
insert into TreeAccounts (Name,parentId,type,active) values('«·„’›—Ê›« ',0,4,True);
-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------