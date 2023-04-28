USE [master]
GO
/****** Object:  Database [AppAcademyWSR]    Script Date: 28.04.2023 14:20:34 ******/
CREATE DATABASE [AppAcademyWSR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AppAcademyWSR', FILENAME = N'C:\StudentDatabase\AppAcademyWSR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AppAcademyWSR_log', FILENAME = N'C:\StudentDatabase\AppAcademyWSR_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AppAcademyWSR] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AppAcademyWSR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AppAcademyWSR] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET ARITHABORT OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AppAcademyWSR] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AppAcademyWSR] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AppAcademyWSR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AppAcademyWSR] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET RECOVERY FULL 
GO
ALTER DATABASE [AppAcademyWSR] SET  MULTI_USER 
GO
ALTER DATABASE [AppAcademyWSR] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AppAcademyWSR] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AppAcademyWSR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AppAcademyWSR] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AppAcademyWSR] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AppAcademyWSR] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AppAcademyWSR', N'ON'
GO
ALTER DATABASE [AppAcademyWSR] SET QUERY_STORE = OFF
GO
USE [AppAcademyWSR]
GO
/****** Object:  User [Student]    Script Date: 28.04.2023 14:20:34 ******/
CREATE USER [Student] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [osas]    Script Date: 28.04.2023 14:20:34 ******/
CREATE USER [osas] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[osas]
GO
ALTER ROLE [db_owner] ADD MEMBER [osas]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [osas]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [osas]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [osas]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [osas]
GO
ALTER ROLE [db_datareader] ADD MEMBER [osas]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [osas]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [osas]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [osas]
GO
/****** Object:  Schema [osas]    Script Date: 28.04.2023 14:20:34 ******/
CREATE SCHEMA [osas]
GO
/****** Object:  Table [dbo].[Discipline]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discipline](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Discipline] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormTime]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormTime](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_FormTime] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[id] [int] NOT NULL,
	[IdTeacher] [int] NOT NULL,
	[IdStudent] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[DateEvent] [date] NOT NULL,
	[IdUser] [int] NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Journal]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Journal](
	[id] [int] NOT NULL,
	[IdStudent] [int] NOT NULL,
	[IdDiscipline] [int] NOT NULL,
	[Evaluation] [varchar](50) NOT NULL,
	[IdNameGroup] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NameGroup]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NameGroup](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NameGroup] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Special]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Special](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Special] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IdSpecial] [int] NOT NULL,
	[IdYearAdd] [int] NOT NULL,
	[IdFormTime] [int] NOT NULL,
	[IdNameGroup] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IdDiscipline] [int] NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[IdRole] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YearAdd]    Script Date: 28.04.2023 14:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YearAdd](
	[id] [int] NOT NULL,
	[Year] [varchar](50) NOT NULL,
 CONSTRAINT [PK_YearAdd] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Discipline] ([id], [Name]) VALUES (1, N'1')
INSERT [dbo].[Discipline] ([id], [Name]) VALUES (2, N'2')
GO
INSERT [dbo].[FormTime] ([id], [Name]) VALUES (1, N'1')
INSERT [dbo].[FormTime] ([id], [Name]) VALUES (2, N'2')
GO
INSERT [dbo].[History] ([id], [IdTeacher], [IdStudent], [IdStatus], [DateEvent], [IdUser]) VALUES (1, 1, 1, 1, CAST(N'2022-06-11' AS Date), 1)
GO
INSERT [dbo].[Journal] ([id], [IdStudent], [IdDiscipline], [Evaluation], [IdNameGroup]) VALUES (1, 1, 1, N'1', 1)
GO
INSERT [dbo].[NameGroup] ([id], [Name]) VALUES (1, N'1')
INSERT [dbo].[NameGroup] ([id], [Name]) VALUES (2, N'2')
GO
INSERT [dbo].[Role] ([id], [Name]) VALUES (1, N'1')
INSERT [dbo].[Role] ([id], [Name]) VALUES (2, N'2')
GO
INSERT [dbo].[Special] ([id], [Name]) VALUES (1, N'Программист')
INSERT [dbo].[Special] ([id], [Name]) VALUES (2, N'Веб-Разработчик')
INSERT [dbo].[Special] ([id], [Name]) VALUES (3, N'Поступил по блату')
INSERT [dbo].[Special] ([id], [Name]) VALUES (4, N'Не знает как сюда попал')
INSERT [dbo].[Special] ([id], [Name]) VALUES (5, N'Просто Матрас')
INSERT [dbo].[Special] ([id], [Name]) VALUES (6, N'Поступил чтобы было с кем попарить')
GO
INSERT [dbo].[Status] ([id], [Name]) VALUES (1, N'1')
INSERT [dbo].[Status] ([id], [Name]) VALUES (2, N'2')
GO
INSERT [dbo].[Student] ([id], [Name], [IdSpecial], [IdYearAdd], [IdFormTime], [IdNameGroup]) VALUES (1, N'1', 1, 1, 1, 1)
GO
INSERT [dbo].[Teacher] ([id], [Name], [IdDiscipline]) VALUES (1, N'1', 1)
GO
INSERT [dbo].[User] ([id], [Login], [Password], [IdRole], [Name]) VALUES (1, N'1', N'1', 1, N'1')
INSERT [dbo].[User] ([id], [Login], [Password], [IdRole], [Name]) VALUES (2, N'2', N'2', 2, N'2')
GO
INSERT [dbo].[YearAdd] ([id], [Year]) VALUES (1, N'1')
INSERT [dbo].[YearAdd] ([id], [Year]) VALUES (2, N'2')
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Status] FOREIGN KEY([IdStatus])
REFERENCES [dbo].[Status] ([id])
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Status]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Student] FOREIGN KEY([IdStudent])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Student]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Teacher] FOREIGN KEY([IdTeacher])
REFERENCES [dbo].[Teacher] ([id])
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Teacher]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_User] FOREIGN KEY([IdUser])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_User]
GO
ALTER TABLE [dbo].[Journal]  WITH CHECK ADD  CONSTRAINT [FK_Journal_Discipline] FOREIGN KEY([IdDiscipline])
REFERENCES [dbo].[Discipline] ([id])
GO
ALTER TABLE [dbo].[Journal] CHECK CONSTRAINT [FK_Journal_Discipline]
GO
ALTER TABLE [dbo].[Journal]  WITH CHECK ADD  CONSTRAINT [FK_Journal_NameGroup] FOREIGN KEY([IdNameGroup])
REFERENCES [dbo].[NameGroup] ([id])
GO
ALTER TABLE [dbo].[Journal] CHECK CONSTRAINT [FK_Journal_NameGroup]
GO
ALTER TABLE [dbo].[Journal]  WITH CHECK ADD  CONSTRAINT [FK_Journal_Student] FOREIGN KEY([IdStudent])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[Journal] CHECK CONSTRAINT [FK_Journal_Student]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_FormTime] FOREIGN KEY([IdFormTime])
REFERENCES [dbo].[FormTime] ([id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_FormTime]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_NameGroup] FOREIGN KEY([IdNameGroup])
REFERENCES [dbo].[NameGroup] ([id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_NameGroup]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Special] FOREIGN KEY([IdSpecial])
REFERENCES [dbo].[Special] ([id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Special]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_YearAdd] FOREIGN KEY([IdYearAdd])
REFERENCES [dbo].[YearAdd] ([id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_YearAdd]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Discipline] FOREIGN KEY([IdDiscipline])
REFERENCES [dbo].[Discipline] ([id])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Discipline]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [AppAcademyWSR] SET  READ_WRITE 
GO
