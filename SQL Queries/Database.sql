USE [master]
GO
/****** Object:  Database [W3LinkApiDB]    Script Date: 11.06.2022 07:40:20 ******/
CREATE DATABASE [W3LinkApiDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'W3LinkApiDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\W3LinkApiDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'W3LinkApiDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\W3LinkApiDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [W3LinkApiDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [W3LinkApiDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [W3LinkApiDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [W3LinkApiDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [W3LinkApiDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [W3LinkApiDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [W3LinkApiDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [W3LinkApiDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET RECOVERY FULL 
GO
ALTER DATABASE [W3LinkApiDB] SET  MULTI_USER 
GO
ALTER DATABASE [W3LinkApiDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [W3LinkApiDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [W3LinkApiDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [W3LinkApiDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [W3LinkApiDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [W3LinkApiDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'W3LinkApiDB', N'ON'
GO
ALTER DATABASE [W3LinkApiDB] SET QUERY_STORE = OFF
GO
USE [W3LinkApiDB]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_price_calculate]    Script Date: 11.06.2022 07:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_price_calculate] (@kur decimal, @id int)

RETURNS decimal
AS
BEGIN
 
  DECLARE @price decimal, @area int

  select @area = width*height from ProductFeatures

  Set @price = @area * @kur

  RETURN @price

END
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11.06.2022 07:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 11.06.2022 07:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductFeatures]    Script Date: 11.06.2022 07:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductFeatures](
	[Id] [int] NOT NULL,
	[Width] [int] NOT NULL,
	[Height] [int] NOT NULL,
 CONSTRAINT [PK_ProductFeatures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11.06.2022 07:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[Stock] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 11.06.2022 07:40:20 ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProductFeatures]  WITH CHECK ADD  CONSTRAINT [FK_ProductFeatures_Products_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductFeatures] CHECK CONSTRAINT [FK_ProductFeatures_Products_Id]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
USE [master]
GO
ALTER DATABASE [W3LinkApiDB] SET  READ_WRITE 
GO
