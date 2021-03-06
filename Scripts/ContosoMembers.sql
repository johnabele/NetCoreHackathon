USE [master]
GO
/****** Object:  Database [ContosoMembers]    Script Date: 4/16/2017 2:11:48 PM ******/
CREATE DATABASE [ContosoMembers]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ContosoMembers', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ContosoMembers.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ContosoMembers_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ContosoMembers_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ContosoMembers] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ContosoMembers].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ContosoMembers] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ContosoMembers] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ContosoMembers] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ContosoMembers] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ContosoMembers] SET ARITHABORT OFF 
GO
ALTER DATABASE [ContosoMembers] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ContosoMembers] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ContosoMembers] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ContosoMembers] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ContosoMembers] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ContosoMembers] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ContosoMembers] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ContosoMembers] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ContosoMembers] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ContosoMembers] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ContosoMembers] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ContosoMembers] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ContosoMembers] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ContosoMembers] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ContosoMembers] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ContosoMembers] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ContosoMembers] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ContosoMembers] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ContosoMembers] SET  MULTI_USER 
GO
ALTER DATABASE [ContosoMembers] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ContosoMembers] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ContosoMembers] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ContosoMembers] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ContosoMembers] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ContosoMembers]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 4/16/2017 2:11:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [bigint] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[MemberType] [int] NULL,
	[TaxId] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Member] ([MemberId], [FirstName], [LastName], [MemberType], [TaxId], [CreatedDate], [UpdatedDate]) VALUES (1, N'John', N'Jay', 1, N'001-01-0001', CAST(N'2017-03-01 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Member] ([MemberId], [FirstName], [LastName], [MemberType], [TaxId], [CreatedDate], [UpdatedDate]) VALUES (2, N'William', N'Cushing', 1, N'002-02-0002', CAST(N'2017-03-01 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Member] ([MemberId], [FirstName], [LastName], [MemberType], [TaxId], [CreatedDate], [UpdatedDate]) VALUES (3, N'Thomas', N'Johnson', 1, N'003-03-0003', CAST(N'2017-03-01 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Member] ([MemberId], [FirstName], [LastName], [MemberType], [TaxId], [CreatedDate], [UpdatedDate]) VALUES (4, N'Samuel', N'Chase', 1, N'004-04-0004', CAST(N'2017-03-01 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Member] ([MemberId], [FirstName], [LastName], [MemberType], [TaxId], [CreatedDate], [UpdatedDate]) VALUES (5, N'Oliver', N'Ellsworth', 1, N'005-05-0005', CAST(N'2017-03-01 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Member] ([MemberId], [FirstName], [LastName], [MemberType], [TaxId], [CreatedDate], [UpdatedDate]) VALUES (6, N'Alfred', N'Moore', 1, N'006-06-0006', CAST(N'2017-03-01 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Member] ([MemberId], [FirstName], [LastName], [MemberType], [TaxId], [CreatedDate], [UpdatedDate]) VALUES (7, N'Henry', N'Livingston', 1, N'007-07-0007', CAST(N'2017-03-01 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Member] ([MemberId], [FirstName], [LastName], [MemberType], [TaxId], [CreatedDate], [UpdatedDate]) VALUES (8, N'Thomas', N'Todd', 1, N'008-08-0008', CAST(N'2017-03-01 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Member] ([MemberId], [FirstName], [LastName], [MemberType], [TaxId], [CreatedDate], [UpdatedDate]) VALUES (9, N'Roger', N'Taney', 1, N'009-09-0009', CAST(N'2017-03-01 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Member] ([MemberId], [FirstName], [LastName], [MemberType], [TaxId], [CreatedDate], [UpdatedDate]) VALUES (10, N'Levi', N'Woodbury', 1, N'010-10-0010', CAST(N'2017-03-01 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime))
/****** Object:  StoredProcedure [dbo].[spGetMemberById]    Script Date: 4/16/2017 2:11:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetMemberById] 
	-- Add the parameters for the stored procedure here
	@MemberId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TOP 1 * FROM Member WHERE MemberId = @MemberId
END

GO
USE [master]
GO
ALTER DATABASE [ContosoMembers] SET  READ_WRITE 
GO
