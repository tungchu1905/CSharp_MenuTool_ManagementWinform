USE [master]
GO
/****** Object:  Database [ManageInformationCs]    Script Date: 6/6/2021 4:04:47 PM ******/
CREATE DATABASE [ManageInformationCs]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ManageInformationCs', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ManageInformationCs.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ManageInformationCs_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ManageInformationCs_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ManageInformationCs] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ManageInformationCs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ManageInformationCs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ManageInformationCs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ManageInformationCs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ManageInformationCs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ManageInformationCs] SET ARITHABORT OFF 
GO
ALTER DATABASE [ManageInformationCs] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ManageInformationCs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ManageInformationCs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ManageInformationCs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ManageInformationCs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ManageInformationCs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ManageInformationCs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ManageInformationCs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ManageInformationCs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ManageInformationCs] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ManageInformationCs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ManageInformationCs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ManageInformationCs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ManageInformationCs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ManageInformationCs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ManageInformationCs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ManageInformationCs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ManageInformationCs] SET RECOVERY FULL 
GO
ALTER DATABASE [ManageInformationCs] SET  MULTI_USER 
GO
ALTER DATABASE [ManageInformationCs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ManageInformationCs] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ManageInformationCs] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ManageInformationCs] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ManageInformationCs] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ManageInformationCs', N'ON'
GO
ALTER DATABASE [ManageInformationCs] SET QUERY_STORE = OFF
GO
USE [ManageInformationCs]
GO
/****** Object:  Table [dbo].[StudentFamily]    Script Date: 6/6/2021 4:04:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentFamily](
	[Pid] [int] NULL,
	[FatherName] [nvarchar](50) NULL,
	[FaAddress] [nvarchar](50) NULL,
	[FaCareer] [nvarchar](50) NULL,
	[MotherName] [nvarchar](50) NULL,
	[MoAddress] [nvarchar](50) NULL,
	[MoCareer] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentInfo]    Script Date: 6/6/2021 4:04:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentInfo](
	[Sid] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Dob] [date] NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Religion] [nvarchar](50) NULL,
	[Nation] [nvarchar](50) NULL,
	[Gender] [bit] NULL,
	[SLanguage] [nvarchar](50) NULL,
	[Images] [nvarchar](50) NULL,
 CONSTRAINT [PK_StudentInfo] PRIMARY KEY CLUSTERED 
(
	[Sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfor]    Script Date: 6/6/2021 4:04:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfor](
	[CodeID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserInfor] PRIMARY KEY CLUSTERED 
(
	[CodeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[StudentFamily]  WITH CHECK ADD  CONSTRAINT [FK_StudentFamily_StudentInfo] FOREIGN KEY([Pid])
REFERENCES [dbo].[StudentInfo] ([Sid])
GO
ALTER TABLE [dbo].[StudentFamily] CHECK CONSTRAINT [FK_StudentFamily_StudentInfo]
GO
USE [master]
GO
ALTER DATABASE [ManageInformationCs] SET  READ_WRITE 
GO
