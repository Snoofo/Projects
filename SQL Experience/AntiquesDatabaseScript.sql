USE [master]
GO
/****** Object:  Database [Antiques]    Script Date: 31/10/2016 10:25:34 AM ******/
CREATE DATABASE [Antiques]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Antiques', FILENAME = N'D:\SQLServer2014\SQLServer\MSSQL12.SQLEXPRESS\MSSQL\DATA\Antiques.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Antiques_log', FILENAME = N'D:\SQLServer2014\SQLServer\MSSQL12.SQLEXPRESS\MSSQL\DATA\Antiques_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Antiques] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Antiques].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Antiques] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Antiques] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Antiques] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Antiques] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Antiques] SET ARITHABORT OFF 
GO
ALTER DATABASE [Antiques] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Antiques] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Antiques] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Antiques] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Antiques] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Antiques] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Antiques] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Antiques] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Antiques] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Antiques] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Antiques] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Antiques] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Antiques] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Antiques] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Antiques] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Antiques] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Antiques] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Antiques] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Antiques] SET  MULTI_USER 
GO
ALTER DATABASE [Antiques] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Antiques] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Antiques] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Antiques] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Antiques] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Antiques]
GO
/****** Object:  User [Carlotta]    Script Date: 31/10/2016 10:25:34 AM ******/
CREATE USER [Carlotta] FOR LOGIN [Carlotta] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [Admin]    Script Date: 31/10/2016 10:25:34 AM ******/
CREATE ROLE [Admin]
GO
ALTER ROLE [Admin] ADD MEMBER [Carlotta]
GO
GRANT CONNECT TO [Carlotta] AS [dbo]
GO
/****** Object:  Table [dbo].[CustomerCategories]    Script Date: 31/10/2016 10:25:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerCategories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryDescription] [varchar](100) NOT NULL,
 CONSTRAINT [PK_CustomerCategories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
GRANT DELETE ON [dbo].[CustomerCategories] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[CustomerCategories] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[CustomerCategories] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[CustomerCategories] TO [Admin] AS [dbo]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 31/10/2016 10:25:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Suburb] [varchar](100) NOT NULL,
	[State] [varchar](3) NOT NULL,
	[Postcode] [int] NOT NULL,
	[SendCatalogue] [bit] NOT NULL,
 CONSTRAINT [PK_Customers1] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
GRANT DELETE ON [dbo].[Customers] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[Customers] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[Customers] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[Customers] TO [Admin] AS [dbo]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 31/10/2016 10:25:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemTypeID] [int] NOT NULL,
	[ItemDescription] [varchar](100) NOT NULL,
	[Price] [money] NOT NULL,
	[YearMade] [int] NOT NULL,
 CONSTRAINT [PK_Items_1] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
GRANT DELETE ON [dbo].[Items] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[Items] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[Items] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[Items] TO [Admin] AS [dbo]
GO
/****** Object:  Table [dbo].[ItemTypes]    Script Date: 31/10/2016 10:25:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemTypes](
	[ItemTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ItemTypeDescription] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ItemTypes_1] PRIMARY KEY CLUSTERED 
(
	[ItemTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
GRANT DELETE ON [dbo].[ItemTypes] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[ItemTypes] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[ItemTypes] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[ItemTypes] TO [Admin] AS [dbo]
GO
/****** Object:  Table [dbo].[SaleItems]    Script Date: 31/10/2016 10:25:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleItems](
	[SaleID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
 CONSTRAINT [PK_SaleItems_1] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC,
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
GRANT DELETE ON [dbo].[SaleItems] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[SaleItems] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[SaleItems] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[SaleItems] TO [Admin] AS [dbo]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 31/10/2016 10:25:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[SaleDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Sales_1] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
GRANT DELETE ON [dbo].[Sales] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[Sales] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[Sales] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[Sales] TO [Admin] AS [dbo]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_CustomerCategories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[CustomerCategories] ([CategoryID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_CustomerCategories]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_ItemTypes] FOREIGN KEY([ItemTypeID])
REFERENCES [dbo].[ItemTypes] ([ItemTypeID])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_ItemTypes]
GO
ALTER TABLE [dbo].[SaleItems]  WITH CHECK ADD  CONSTRAINT [FK_SaleItems_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ItemID])
GO
ALTER TABLE [dbo].[SaleItems] CHECK CONSTRAINT [FK_SaleItems_Items]
GO
ALTER TABLE [dbo].[SaleItems]  WITH CHECK ADD  CONSTRAINT [FK_SaleItems_Sales] FOREIGN KEY([SaleID])
REFERENCES [dbo].[Sales] ([SaleID])
GO
ALTER TABLE [dbo].[SaleItems] CHECK CONSTRAINT [FK_SaleItems_Sales]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Customers]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Primary key and identifier for Catgeories table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CustomerCategories', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The name of the item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CustomerCategories', @level2type=N'COLUMN',@level2name=N'CategoryDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Primary key and identifier for Customers table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign key to the categories table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customers first name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'FirstName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customers last name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'LastName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customers street address' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customers suburb' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Suburb'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customers state' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customers postcode' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Postcode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Flag whether to send catalogue' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'SendCatalogue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Primary key and identifier for Items table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign key to the ItemTypes table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'ItemTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name of the item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'ItemDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The money value of the item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'Price'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Year the item was made' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'YearMade'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Primary key and identifier for ItemTypes table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ItemTypes', @level2type=N'COLUMN',@level2name=N'ItemTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Desciption of the type of item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ItemTypes', @level2type=N'COLUMN',@level2name=N'ItemTypeDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Composite primary key with ItemID and forgein key to Sales table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SaleItems', @level2type=N'COLUMN',@level2name=N'SaleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Composite primary key with SaleID and forgein key to Items table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SaleItems', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Primary key and identifier of the Sales table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sales', @level2type=N'COLUMN',@level2name=N'SaleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign key to the Customers table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sales', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date and time of sale' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sales', @level2type=N'COLUMN',@level2name=N'SaleDate'
GO
USE [master]
GO
ALTER DATABASE [Antiques] SET  READ_WRITE 
GO
