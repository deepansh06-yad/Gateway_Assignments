USE [master]
GO
/****** Object:  Database [logindb]    Script Date: 21-12-2020 12:05:39 ******/
CREATE DATABASE [logindb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'logindb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\logindb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'logindb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\logindb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [logindb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [logindb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [logindb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [logindb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [logindb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [logindb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [logindb] SET ARITHABORT OFF 
GO
ALTER DATABASE [logindb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [logindb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [logindb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [logindb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [logindb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [logindb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [logindb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [logindb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [logindb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [logindb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [logindb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [logindb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [logindb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [logindb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [logindb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [logindb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [logindb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [logindb] SET RECOVERY FULL 
GO
ALTER DATABASE [logindb] SET  MULTI_USER 
GO
ALTER DATABASE [logindb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [logindb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [logindb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [logindb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [logindb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [logindb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'logindb', N'ON'
GO
ALTER DATABASE [logindb] SET QUERY_STORE = OFF
GO
USE [logindb]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 21-12-2020 12:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](14) NOT NULL,
	[Password] [varchar](14) NOT NULL,
	[ConfirmPassword] [varchar](14) NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userregistration]    Script Date: 21-12-2020 12:05:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userregistration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Emailid] [varchar](25) NOT NULL,
	[Designation] [varchar](20) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Phone] [int] NOT NULL,
 CONSTRAINT [PK_userregistration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Registration] ON 

INSERT [dbo].[Registration] ([id], [UserName], [Password], [ConfirmPassword]) VALUES (1, N'admin', N'admin', NULL)
INSERT [dbo].[Registration] ([id], [UserName], [Password], [ConfirmPassword]) VALUES (2, N'admin2', N'admin123', N'admin123')
SET IDENTITY_INSERT [dbo].[Registration] OFF
GO
SET IDENTITY_INSERT [dbo].[userregistration] ON 

INSERT [dbo].[userregistration] ([id], [Name], [Emailid], [Designation], [Address], [Age], [Phone]) VALUES (3, N'deepansh', N'deepanshyadav06@gmail.com', N'project trainee', N'govardhan', 22, 123)
INSERT [dbo].[userregistration] ([id], [Name], [Emailid], [Designation], [Address], [Age], [Phone]) VALUES (4, N'Deepansh', N'ab@gmail.com', N'soft', N'vfshd', 20, 544)
SET IDENTITY_INSERT [dbo].[userregistration] OFF
GO
USE [master]
GO
ALTER DATABASE [logindb] SET  READ_WRITE 
GO
