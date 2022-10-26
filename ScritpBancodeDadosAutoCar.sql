USE [master]
GO
/****** Object:  Database [AutoCar]    Script Date: 25/10/2022 19:57:34 ******/
CREATE DATABASE [AutoCar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AutoCar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXP2016\MSSQL\DATA\AutoCar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AutoCar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXP2016\MSSQL\DATA\AutoCar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AutoCar] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AutoCar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AutoCar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AutoCar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AutoCar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AutoCar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AutoCar] SET ARITHABORT OFF 
GO
ALTER DATABASE [AutoCar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AutoCar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AutoCar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AutoCar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AutoCar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AutoCar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AutoCar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AutoCar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AutoCar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AutoCar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AutoCar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AutoCar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AutoCar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AutoCar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AutoCar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AutoCar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AutoCar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AutoCar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AutoCar] SET  MULTI_USER 
GO
ALTER DATABASE [AutoCar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AutoCar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AutoCar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AutoCar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AutoCar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AutoCar] SET QUERY_STORE = OFF
GO
USE [AutoCar]
GO
/****** Object:  Table [dbo].[TbAcessorios]    Script Date: 25/10/2022 19:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbAcessorios](
	[IdAcessorios] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
 CONSTRAINT [PK_TbAcessorios] PRIMARY KEY CLUSTERED 
(
	[IdAcessorios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbCarro]    Script Date: 25/10/2022 19:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbCarro](
	[IdCarro] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TbCarro] PRIMARY KEY CLUSTERED 
(
	[IdCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbCarrosAcessorios]    Script Date: 25/10/2022 19:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbCarrosAcessorios](
	[IdCarrosAcessorios] [int] IDENTITY(1,1) NOT NULL,
	[IdCarro] [int] NOT NULL,
	[IdAcessorios] [int] NOT NULL,
 CONSTRAINT [PK_TbCarrosAcessorios] PRIMARY KEY CLUSTERED 
(
	[IdCarrosAcessorios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TbAcessorios] ON 
GO
INSERT [dbo].[TbAcessorios] ([IdAcessorios], [Nome]) VALUES (2, N'farol luminoso')
GO
INSERT [dbo].[TbAcessorios] ([IdAcessorios], [Nome]) VALUES (3, N'RODA ARO 25')
GO
INSERT [dbo].[TbAcessorios] ([IdAcessorios], [Nome]) VALUES (4, N'lanterna')
GO
SET IDENTITY_INSERT [dbo].[TbAcessorios] OFF
GO
SET IDENTITY_INSERT [dbo].[TbCarro] ON 
GO
INSERT [dbo].[TbCarro] ([IdCarro], [Nome]) VALUES (10, N'CORSA SEDAN')
GO
INSERT [dbo].[TbCarro] ([IdCarro], [Nome]) VALUES (11, N'ASTRA 2022')
GO
INSERT [dbo].[TbCarro] ([IdCarro], [Nome]) VALUES (12, N'gol')
GO
SET IDENTITY_INSERT [dbo].[TbCarro] OFF
GO
SET IDENTITY_INSERT [dbo].[TbCarrosAcessorios] ON 
GO
INSERT [dbo].[TbCarrosAcessorios] ([IdCarrosAcessorios], [IdCarro], [IdAcessorios]) VALUES (1, 10, 2)
GO
INSERT [dbo].[TbCarrosAcessorios] ([IdCarrosAcessorios], [IdCarro], [IdAcessorios]) VALUES (2, 10, 3)
GO
INSERT [dbo].[TbCarrosAcessorios] ([IdCarrosAcessorios], [IdCarro], [IdAcessorios]) VALUES (3, 11, 4)
GO
INSERT [dbo].[TbCarrosAcessorios] ([IdCarrosAcessorios], [IdCarro], [IdAcessorios]) VALUES (4, 11, 2)
GO
INSERT [dbo].[TbCarrosAcessorios] ([IdCarrosAcessorios], [IdCarro], [IdAcessorios]) VALUES (5, 12, 2)
GO
INSERT [dbo].[TbCarrosAcessorios] ([IdCarrosAcessorios], [IdCarro], [IdAcessorios]) VALUES (6, 12, 3)
GO
INSERT [dbo].[TbCarrosAcessorios] ([IdCarrosAcessorios], [IdCarro], [IdAcessorios]) VALUES (7, 12, 4)
GO
SET IDENTITY_INSERT [dbo].[TbCarrosAcessorios] OFF
GO
ALTER TABLE [dbo].[TbCarrosAcessorios]  WITH CHECK ADD  CONSTRAINT [FK_TbCarrosAcessorios_TbAcessorios] FOREIGN KEY([IdAcessorios])
REFERENCES [dbo].[TbAcessorios] ([IdAcessorios])
GO
ALTER TABLE [dbo].[TbCarrosAcessorios] CHECK CONSTRAINT [FK_TbCarrosAcessorios_TbAcessorios]
GO
ALTER TABLE [dbo].[TbCarrosAcessorios]  WITH CHECK ADD  CONSTRAINT [FK_TbCarrosAcessorios_TbCarro] FOREIGN KEY([IdCarro])
REFERENCES [dbo].[TbCarro] ([IdCarro])
GO
ALTER TABLE [dbo].[TbCarrosAcessorios] CHECK CONSTRAINT [FK_TbCarrosAcessorios_TbCarro]
GO
USE [master]
GO
ALTER DATABASE [AutoCar] SET  READ_WRITE 
GO
