USE [master]
GO
/****** Object:  Database [Productdb]    Script Date: 11-01-2021 16:57:50 ******/
CREATE DATABASE [Productdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Productdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Productdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Productdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Productdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Productdb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Productdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Productdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Productdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Productdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Productdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Productdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [Productdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Productdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Productdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Productdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Productdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Productdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Productdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Productdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Productdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Productdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Productdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Productdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Productdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Productdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Productdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Productdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Productdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Productdb] SET RECOVERY FULL 
GO
ALTER DATABASE [Productdb] SET  MULTI_USER 
GO
ALTER DATABASE [Productdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Productdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Productdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Productdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Productdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Productdb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Productdb', N'ON'
GO
ALTER DATABASE [Productdb] SET QUERY_STORE = OFF
GO
USE [Productdb]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 11-01-2021 16:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productslist]    Script Date: 11-01-2021 16:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productslist](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NOT NULL,
	[Price] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[ImagePath] [varchar](max) NOT NULL,
	[ShortDescription] [varchar](50) NOT NULL,
	[Detaildescription] [varchar](250) NULL,
	[Category] [int] NOT NULL,
 CONSTRAINT [PK_Productslist] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 11-01-2021 16:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](25) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (1, N'Mobile')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (2, N'Watch')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (3, N'Book')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (4, N'Spectacles')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (5, N'Laptop')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Productslist] ON 

INSERT [dbo].[Productslist] ([Id], [Name], [Price], [Quantity], [ImagePath], [ShortDescription], [Detaildescription], [Category]) VALUES (9, N'Bhagvad Geeta', 1000.0000, 1, N'~/Image/91n7e4ULsKL215833660.jpg', N'Bhagvad Geeta', N'Bhagvad Geeta', 3)
INSERT [dbo].[Productslist] ([Id], [Name], [Price], [Quantity], [ImagePath], [ShortDescription], [Detaildescription], [Category]) VALUES (2021, N'Iphone 12', 79000.0000, 5, N'~/Image/iphone213432342.jpg', N'Iphone 12', N'6.1-inch Super Retina XDR display', 1)
SET IDENTITY_INSERT [dbo].[Productslist] OFF
GO
SET IDENTITY_INSERT [dbo].[Registration] ON 

INSERT [dbo].[Registration] ([Id], [Username], [Password]) VALUES (1, N'admin', N'admin')
INSERT [dbo].[Registration] ([Id], [Username], [Password]) VALUES (2, N'admin20', N'admin@123')
INSERT [dbo].[Registration] ([Id], [Username], [Password]) VALUES (3, N'admin123', N'admin')
SET IDENTITY_INSERT [dbo].[Registration] OFF
GO
ALTER TABLE [dbo].[Productslist]  WITH CHECK ADD FOREIGN KEY([Category])
REFERENCES [dbo].[Categories] ([Id])
GO
USE [master]
GO
ALTER DATABASE [Productdb] SET  READ_WRITE 
GO
