USE [master]
GO
/****** Object:  Database [compliant]    Script Date: 02/22/2021 01:02:13 ******/
CREATE DATABASE [compliant] ON  PRIMARY 
( NAME = N'compliant', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\compliant.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'compliant_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\compliant_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [compliant] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [compliant].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [compliant] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [compliant] SET ANSI_NULLS OFF
GO
ALTER DATABASE [compliant] SET ANSI_PADDING OFF
GO
ALTER DATABASE [compliant] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [compliant] SET ARITHABORT OFF
GO
ALTER DATABASE [compliant] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [compliant] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [compliant] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [compliant] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [compliant] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [compliant] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [compliant] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [compliant] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [compliant] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [compliant] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [compliant] SET  DISABLE_BROKER
GO
ALTER DATABASE [compliant] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [compliant] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [compliant] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [compliant] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [compliant] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [compliant] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [compliant] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [compliant] SET  READ_WRITE
GO
ALTER DATABASE [compliant] SET RECOVERY SIMPLE
GO
ALTER DATABASE [compliant] SET  MULTI_USER
GO
ALTER DATABASE [compliant] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [compliant] SET DB_CHAINING OFF
GO
USE [compliant]
GO
/****** Object:  Table [dbo].[users]    Script Date: 02/22/2021 01:02:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[name] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[contact] [nvarchar](max) NULL,
	[country] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[solvegraph]    Script Date: 02/22/2021 01:02:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[solvegraph](
	[solvecat] [nvarchar](max) NULL,
	[pin] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[solve]    Script Date: 02/22/2021 01:02:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[solve](
	[complaint_id] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[contact] [nvarchar](max) NULL,
	[cnic] [nvarchar](max) NULL,
	[city] [nvarchar](max) NULL,
	[area] [nvarchar](max) NULL,
	[complaint] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[graph]    Script Date: 02/22/2021 01:02:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[graph](
	[dept] [nvarchar](max) NULL,
	[pin] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comp]    Script Date: 02/22/2021 01:02:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comp](
	[complaint_id] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[contact] [nvarchar](max) NULL,
	[cnic] [nvarchar](max) NULL,
	[city] [nvarchar](max) NULL,
	[area] [nvarchar](max) NULL,
	[complaint] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
