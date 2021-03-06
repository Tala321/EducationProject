/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2017 (14.0.1000)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [EducationProject]    Script Date: 12/30/2018 4:59:01 PM ******/
CREATE DATABASE [EducationProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EducationProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EducationProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EducationProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EducationProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EducationProject] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EducationProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EducationProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EducationProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EducationProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EducationProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EducationProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [EducationProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EducationProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EducationProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EducationProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EducationProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EducationProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EducationProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EducationProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EducationProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EducationProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EducationProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EducationProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EducationProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EducationProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EducationProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EducationProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EducationProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EducationProject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EducationProject] SET  MULTI_USER 
GO
ALTER DATABASE [EducationProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EducationProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EducationProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EducationProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EducationProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EducationProject] SET QUERY_STORE = OFF
GO
USE [EducationProject]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [EducationProject]
GO
/****** Object:  Table [dbo].[AssignTasks]    Script Date: 12/30/2018 4:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssignTasks](
	[AssignTaskId] [int] IDENTITY(0,1) NOT NULL,
	[TaskId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[TaskPoint] [int] NULL,
	[GroupId] [int] NULL,
 CONSTRAINT [PK__AssignTa__AADB7B9D5980491A] PRIMARY KEY CLUSTERED 
(
	[AssignTaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupCategories]    Script Date: 12/30/2018 4:59:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupCategories](
	[GroupCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[GroupCategoryTypeId] [int] NOT NULL,
	[GroupCategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__GroupCat__EADFE97ABAC44B56] PRIMARY KEY CLUSTERED 
(
	[GroupCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupCategoryTypes]    Script Date: 12/30/2018 4:59:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupCategoryTypes](
	[GroupCategoryTypeId] [int] IDENTITY(1,1) NOT NULL,
	[GroupCategoryTypeName] [nvarchar](50) NOT NULL,
	[GroupCategoryTypeStartTime] [time](7) NOT NULL,
	[GroupCategoryTypeEndTime] [time](7) NOT NULL,
 CONSTRAINT [PK__GroupCat__032517D8222AF65A] PRIMARY KEY CLUSTERED 
(
	[GroupCategoryTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 12/30/2018 4:59:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[GroupId] [int] IDENTITY(1,1) NOT NULL,
	[PackageId] [int] NOT NULL,
	[TeacherId] [int] NOT NULL,
	[MentorId] [int] NOT NULL,
	[GroupCategoryId] [int] NOT NULL,
	[GroupStartDate] [date] NULL,
	[GroupName] [nvarchar](50) NULL,
	[GroupEmail] [nvarchar](50) NULL,
 CONSTRAINT [PK__Groups__149AF36A681FAB85] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Library]    Script Date: 12/30/2018 4:59:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Library](
	[LibraryId] [int] IDENTITY(0,1) NOT NULL,
	[LibraryItemName] [nvarchar](50) NOT NULL,
	[LibraryItemSource] [nvarchar](max) NOT NULL,
	[LibraryItemType] [bit] NOT NULL,
 CONSTRAINT [PK__Library__A136475FFC84177F] PRIMARY KEY CLUSTERED 
(
	[LibraryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logins]    Script Date: 12/30/2018 4:59:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[LoginId] [int] IDENTITY(0,1) NOT NULL,
	[LoginEmail] [nvarchar](50) NOT NULL,
	[LoginPassword] [nvarchar](50) NOT NULL,
	[UserTypeId] [int] NULL,
 CONSTRAINT [PK__Logins__4DDA28180F77A3B1] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mentors]    Script Date: 12/30/2018 4:59:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mentors](
	[MentorId] [int] IDENTITY(1,1) NOT NULL,
	[PackageId] [int] NOT NULL,
	[MentorName] [nvarchar](50) NOT NULL,
	[MentorSurname] [nvarchar](50) NOT NULL,
	[MentorEmail] [nvarchar](50) NOT NULL,
	[MentorPhone] [nvarchar](50) NULL,
	[MentorBio] [nvarchar](max) NULL,
	[MentorPhoto] [nvarchar](50) NULL,
 CONSTRAINT [PK__Mentors__053B7E989DBB0208] PRIMARY KEY CLUSTERED 
(
	[MentorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Mentors__21AC4B6D08E99288] UNIQUE NONCLUSTERED 
(
	[MentorEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 12/30/2018 4:59:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[MessageId] [int] IDENTITY(0,1) NOT NULL,
	[MessageFrom] [nvarchar](50) NOT NULL,
	[MessageTo] [nvarchar](50) NOT NULL,
	[MessageTitle] [nvarchar](30) NULL,
	[MessageBody] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK__Messages__C87C0C9CA7FA3B35] PRIMARY KEY CLUSTERED 
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Packages]    Script Date: 12/30/2018 4:59:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Packages](
	[PackageId] [int] IDENTITY(1,1) NOT NULL,
	[PackageName] [nvarchar](50) NOT NULL,
	[PackageDuration] [int] NULL,
 CONSTRAINT [PK__Programs__752560583AAE0DAA] PRIMARY KEY CLUSTERED 
(
	[PackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PdfSources]    Script Date: 12/30/2018 4:59:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PdfSources](
	[PdfSourceId] [int] IDENTITY(0,1) NOT NULL,
	[PdfSourceName] [nvarchar](50) NULL,
 CONSTRAINT [PK__PdfSourc__EC929AC2A1E90297] PRIMARY KEY CLUSTERED 
(
	[PdfSourceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 12/30/2018 4:59:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[GroupId] [int] NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[StudentSurname] [nvarchar](50) NOT NULL,
	[StudentBirthDate] [date] NOT NULL,
	[StudentEmail] [nvarchar](50) NOT NULL,
	[StudentPhone] [nvarchar](50) NULL,
	[StudentRegistrationDate] [date] NULL,
	[StudentPhoto] [nvarchar](50) NULL,
	[StudentBio] [nvarchar](max) NULL,
 CONSTRAINT [PK__Students__32C52B99629F3957] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Students__3569CFDB2723580A] UNIQUE NONCLUSTERED 
(
	[StudentEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskCategories]    Script Date: 12/30/2018 4:59:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskCategories](
	[TaskCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[TaskCategoryName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TaskCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 12/30/2018 4:59:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[TaskId] [int] IDENTITY(0,1) NOT NULL,
	[TaskName] [nvarchar](50) NOT NULL,
	[TaskUrl] [nvarchar](50) NOT NULL,
	[TaskStartDate] [nvarchar](50) NOT NULL,
	[TaskDuration] [int] NOT NULL,
	[TaskDetails] [nvarchar](max) NOT NULL,
	[TaskCategoryId] [int] NOT NULL,
 CONSTRAINT [PK__Tasks__7C6949B18BFE128D] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 12/30/2018 4:59:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[PackageId] [int] NOT NULL,
	[TeacherName] [nvarchar](50) NOT NULL,
	[TeacherSurname] [nvarchar](50) NOT NULL,
	[TeacherEmail] [nvarchar](50) NOT NULL,
	[TeacherPhone] [nvarchar](50) NULL,
	[TeacherBio] [nvarchar](max) NULL,
	[TeacherPhoto] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TeacherEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 12/30/2018 4:59:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[UserTypeId] [int] IDENTITY(1,1) NOT NULL,
	[UserTypeName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AssignTasks]  WITH CHECK ADD  CONSTRAINT [AssignTasks_StudentId_to_Task_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
GO
ALTER TABLE [dbo].[AssignTasks] CHECK CONSTRAINT [AssignTasks_StudentId_to_Task_StudentId]
GO
ALTER TABLE [dbo].[AssignTasks]  WITH CHECK ADD  CONSTRAINT [AssignTasks_TaskId_to_Task_TaskId] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Tasks] ([TaskId])
GO
ALTER TABLE [dbo].[AssignTasks] CHECK CONSTRAINT [AssignTasks_TaskId_to_Task_TaskId]
GO
ALTER TABLE [dbo].[GroupCategories]  WITH CHECK ADD  CONSTRAINT [GroupCategories_GroupCategoryTypeId_to_GroupCategoryTypeId] FOREIGN KEY([GroupCategoryTypeId])
REFERENCES [dbo].[GroupCategoryTypes] ([GroupCategoryTypeId])
GO
ALTER TABLE [dbo].[GroupCategories] CHECK CONSTRAINT [GroupCategories_GroupCategoryTypeId_to_GroupCategoryTypeId]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [Groups_GroupCategoryId_to_GroupCategoryId] FOREIGN KEY([GroupCategoryId])
REFERENCES [dbo].[GroupCategories] ([GroupCategoryId])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [Groups_GroupCategoryId_to_GroupCategoryId]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [Groups_MentorId_to_GroupCategoryId] FOREIGN KEY([MentorId])
REFERENCES [dbo].[Mentors] ([MentorId])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [Groups_MentorId_to_GroupCategoryId]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [Groups_programId_to_programId] FOREIGN KEY([PackageId])
REFERENCES [dbo].[Packages] ([PackageId])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [Groups_programId_to_programId]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [Groups_TeacherId_to_TeacherId] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teachers] ([TeacherId])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [Groups_TeacherId_to_TeacherId]
GO
ALTER TABLE [dbo].[Logins]  WITH CHECK ADD  CONSTRAINT [Logins_UserTypeId_to_UserTypeId] FOREIGN KEY([UserTypeId])
REFERENCES [dbo].[UserType] ([UserTypeId])
GO
ALTER TABLE [dbo].[Logins] CHECK CONSTRAINT [Logins_UserTypeId_to_UserTypeId]
GO
ALTER TABLE [dbo].[Mentors]  WITH CHECK ADD  CONSTRAINT [Mentors_programId_to_programId] FOREIGN KEY([PackageId])
REFERENCES [dbo].[Packages] ([PackageId])
GO
ALTER TABLE [dbo].[Mentors] CHECK CONSTRAINT [Mentors_programId_to_programId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [Students_GroupId_to_GroupId] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([GroupId])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [Students_GroupId_to_GroupId]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [Teachers_programId_to_programId] FOREIGN KEY([PackageId])
REFERENCES [dbo].[Packages] ([PackageId])
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [Teachers_programId_to_programId]
GO
USE [master]
GO
ALTER DATABASE [EducationProject] SET  READ_WRITE 
GO
