USE [master]
GO
/****** Object:  Database [hotel_management_db]    Script Date: 08/02/2022 7:22:52 pm ******/
CREATE DATABASE [hotel_management_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hotel_management_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\hotel_management_db.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'hotel_management_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\hotel_management_db_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [hotel_management_db] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hotel_management_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hotel_management_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hotel_management_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hotel_management_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hotel_management_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hotel_management_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [hotel_management_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [hotel_management_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hotel_management_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hotel_management_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hotel_management_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hotel_management_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hotel_management_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hotel_management_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hotel_management_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hotel_management_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [hotel_management_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hotel_management_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hotel_management_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hotel_management_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hotel_management_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hotel_management_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hotel_management_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hotel_management_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [hotel_management_db] SET  MULTI_USER 
GO
ALTER DATABASE [hotel_management_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hotel_management_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hotel_management_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hotel_management_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [hotel_management_db]
GO
/****** Object:  Table [dbo].[accounts]    Script Date: 08/02/2022 7:22:52 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accounts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](255) NOT NULL,
	[middle_name] [varchar](255) NOT NULL,
	[last_name] [varchar](255) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[username] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 08/02/2022 7:22:52 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[lastname] [varchar](255) NOT NULL,
	[firstname] [varchar](255) NOT NULL,
	[middlename] [varchar](255) NOT NULL,
	[contact_no] [varchar](255) NOT NULL,
	[address] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservations]    Script Date: 08/02/2022 7:22:52 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[room] [varchar](255) NOT NULL,
	[date_reservation] [date] NOT NULL,
	[customer_name] [varchar](255) NOT NULL,
	[status] [varchar](255) NOT NULL,
	[check_in] [datetime] NULL,
	[check_out] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rooms]    Script Date: 08/02/2022 7:22:52 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rooms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[room_no] [varchar](255) NOT NULL,
	[room_type] [varchar](255) NOT NULL,
	[description] [text] NOT NULL,
	[price] [int] NOT NULL,
	[max_person] [int] NOT NULL,
	[is_available] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[rooms] ADD  DEFAULT ((1)) FOR [is_available]
GO
USE [master]
GO
ALTER DATABASE [hotel_management_db] SET  READ_WRITE 
GO
