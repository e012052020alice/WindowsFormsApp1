USE [master]
GO
/****** Object:  Database [mydb]    Script Date: 2024/6/20 下午 12:10:39 ******/
CREATE DATABASE [mydb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mydb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVERBEAR\MSSQL\DATA\mydb.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mydb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVERBEAR\MSSQL\DATA\mydb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [mydb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mydb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mydb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mydb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mydb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mydb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mydb] SET ARITHABORT OFF 
GO
ALTER DATABASE [mydb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mydb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mydb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mydb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mydb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mydb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mydb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mydb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mydb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mydb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mydb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mydb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mydb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mydb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mydb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mydb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mydb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mydb] SET RECOVERY FULL 
GO
ALTER DATABASE [mydb] SET  MULTI_USER 
GO
ALTER DATABASE [mydb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mydb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mydb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mydb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mydb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [mydb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'mydb', N'ON'
GO
ALTER DATABASE [mydb] SET QUERY_STORE = ON
GO
ALTER DATABASE [mydb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [mydb]
GO
/****** Object:  Table [dbo].[attendance]    Script Date: 2024/6/20 下午 12:10:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[attendance](
	[AttendanceID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[PunchTime] [datetime] NULL,
	[PunchType] [nvarchar](50) NULL,
 CONSTRAINT [PK_attendance] PRIMARY KEY CLUSTERED 
(
	[AttendanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 2024/6/20 下午 12:10:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[customerID] [int] IDENTITY(1,1) NOT NULL,
	[姓名] [nvarchar](50) NOT NULL,
	[電話] [nvarchar](50) NULL,
	[地址] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[密碼] [nvarchar](50) NOT NULL,
	[生日] [date] NULL,
	[婚姻狀態] [bit] NULL,
	[點數] [int] NULL,
	[權限] [int] NOT NULL,
	[使用狀態] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_persons2] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 2024/6/20 下午 12:10:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[eName] [nvarchar](50) NULL,
	[ePosition] [int] NULL,
	[HireDate] [date] NULL,
	[eSalary] [int] NULL,
	[eContactInfo] [nvarchar](50) NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 2024/6/20 下午 12:10:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[OrdersId] [int] IDENTITY(1,1) NOT NULL,
	[Ordernumbers] [bigint] NULL,
	[customerId] [int] NULL,
	[bookId] [int] NULL,
	[shoppincartId] [int] NULL,
	[ProcessingStatus] [nvarchar](50) NULL,
	[price] [int] NULL,
	[Amount] [int] NULL,
	[Time] [datetime] NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[OrdersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persons]    Script Date: 2024/6/20 下午 12:10:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[姓名] [nvarchar](50) NULL,
	[電話] [nvarchar](50) NULL,
	[地址] [nvarchar](100) NOT NULL,
	[email] [nvarchar](50) NULL,
	[生日] [date] NULL,
	[婚姻狀態] [bit] NULL,
	[點數] [int] NULL,
 CONSTRAINT [PK_persons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productBook]    Script Date: 2024/6/20 下午 12:10:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productBook](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [nvarchar](100) NOT NULL,
	[BookPrice] [int] NULL,
	[BookWriter] [nvarchar](50) NULL,
	[BookClassification] [nvarchar](50) NULL,
	[BookImage] [nvarchar](200) NULL,
	[BookDesc] [nvarchar](max) NULL,
	[ProductStatus] [nvarchar](50) NULL,
	[inventory] [int] NULL,
 CONSTRAINT [PK_produckBook] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 2024/6/20 下午 12:10:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pname] [nvarchar](100) NULL,
	[price] [int] NULL,
	[pdesc] [nvarchar](500) NULL,
	[pimage] [nvarchar](100) NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shoppingCart]    Script Date: 2024/6/20 下午 12:10:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shoppingCart](
	[shoppingCartID] [int] IDENTITY(1,1) NOT NULL,
	[customerID] [int] NOT NULL,
	[BookID] [int] NOT NULL,
	[bookAmount] [int] NULL,
	[price] [int] NULL,
 CONSTRAINT [PK_shoppingCart] PRIMARY KEY CLUSTERED 
(
	[shoppingCartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[systemMaintance]    Script Date: 2024/6/20 下午 12:10:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[systemMaintance](
	[startTime] [datetime] NULL,
	[endTime] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[attendance] ON 

INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (1, 1, CAST(N'2024-02-06T09:00:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (2, 1, CAST(N'2024-02-06T18:00:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (3, 2, CAST(N'2024-02-06T08:45:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (8, 1, CAST(N'2024-02-06T08:30:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (9, 2, CAST(N'2024-02-06T08:15:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (10, 5, CAST(N'2024-02-06T08:45:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (11, 8, CAST(N'2024-02-06T08:00:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (12, 9, CAST(N'2024-02-06T09:00:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (13, 13, CAST(N'2024-02-06T08:30:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (14, 16, CAST(N'2024-02-06T08:00:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (15, 21, CAST(N'2024-02-06T08:45:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (16, 23, CAST(N'2024-02-06T08:00:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (17, 24, CAST(N'2024-02-06T08:30:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (18, 28, CAST(N'2024-02-06T08:00:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (19, 29, CAST(N'2024-02-06T08:45:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (20, 37, CAST(N'2024-02-06T09:05:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (21, 1, CAST(N'2024-02-06T17:20:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (22, 2, CAST(N'2024-02-06T17:10:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (23, 5, CAST(N'2024-02-06T17:30:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (24, 8, CAST(N'2024-02-06T17:33:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (25, 9, CAST(N'2024-02-06T17:22:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (26, 13, CAST(N'2024-02-06T17:40:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (27, 16, CAST(N'2024-02-06T17:08:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (28, 21, CAST(N'2024-02-06T17:12:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (29, 23, CAST(N'2024-02-06T17:36:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (30, 24, CAST(N'2024-02-06T17:30:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (31, 28, CAST(N'2024-02-06T17:57:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (32, 29, CAST(N'2024-02-06T17:38:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (33, 37, CAST(N'2024-02-06T17:46:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (34, 1, CAST(N'2023-01-01T09:05:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (35, 1, CAST(N'2023-01-01T17:00:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (36, 1, CAST(N'2023-01-02T08:55:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (37, 1, CAST(N'2023-01-02T17:10:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (38, 1, CAST(N'2023-01-03T09:03:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (39, 1, CAST(N'2023-01-03T16:58:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (40, 1, CAST(N'2023-01-04T09:15:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (41, 1, CAST(N'2023-01-04T17:05:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (42, 2, CAST(N'2023-12-15T08:50:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (43, 2, CAST(N'2023-12-15T17:10:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (44, 2, CAST(N'2023-12-16T08:45:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (45, 2, CAST(N'2023-12-16T16:55:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (46, 2, CAST(N'2023-12-17T09:00:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (47, 2, CAST(N'2023-12-17T17:15:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (48, 2, CAST(N'2023-12-18T08:58:00.000' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (49, 2, CAST(N'2023-12-18T17:03:00.000' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (53, 16, CAST(N'2024-02-14T20:25:40.373' AS DateTime), N'下班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (54, 1, CAST(N'2024-02-15T23:47:53.277' AS DateTime), N'上班')
INSERT [dbo].[attendance] ([AttendanceID], [EmployeeID], [PunchTime], [PunchType]) VALUES (55, 1, CAST(N'2024-02-16T00:00:34.923' AS DateTime), N'下班')
SET IDENTITY_INSERT [dbo].[attendance] OFF
GO
SET IDENTITY_INSERT [dbo].[customers] ON 

INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (1, N'陳大貓', N'0912-234-567', N'高雄市前金區', N'mm@hh.com.tw', N'bbbbbbbb', CAST(N'1985-05-05' AS Date), 1, 1000, 10, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (2, N'黃小貓', N'0966-333-666', N'高雄市鳥松區', N'pp@nn.com', N'aaaaaaaa', CAST(N'1988-06-03' AS Date), 1, 1500, 100, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (3, N'張大書', N'0977-666-999', N'高雄市鼓山區', N'zz@dd.com.tw', N'cccccccc', CAST(N'1978-11-09' AS Date), 1, 2000, 1000, N'停權')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (4, N'黃中書', N'0988-222-777', N'台南市東區', N'rr@tt.com', N'dddddddd', CAST(N'1979-01-05' AS Date), 0, 1500, 1000, N'審核')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (5, N'王小明', N'0955-111-898', N'台南市西屯區', N'uuw@ww.com.tw', N'eeeeeeee', CAST(N'1922-08-20' AS Date), 1, 300, 100, N'審核')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (6, N'黃大名', N'0944-357-456', N'高雄市左營區', N'aa@bb.com', N'ffffffff', CAST(N'1988-09-01' AS Date), 0, 400, 1000, N'停權')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (8, N'陳小狗', N'0933-358-789', N'高雄市鼓山區', N'QQ@aa.com.tw', N'gggggggg', CAST(N'1985-03-12' AS Date), 1, 250, 10, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (9, N'陳大虎', N'0977-852-963', N'台南市西區', N'uu@qq.com', N'hhhhhhhh', CAST(N'1952-03-25' AS Date), 0, 700, 100, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (10, N'周星星', N'0945-356-123', N'台北市信義區', N'cc@nn.com.tw', N'iiiiiiii', CAST(N'1946-07-30' AS Date), 0, 350, 1000, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (11, N'張泰泰', N'0978-542-652', N'台北市內湖區', N'bb@ac.com', N'jjjjjjjj', CAST(N'1978-06-27' AS Date), 0, 450, 1000, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (12, N'王大豐', N'0945-852-146', N'高雄市楠梓區', N'ee@ma.com', N'kkkkkkkk', CAST(N'1995-07-09' AS Date), 1, 750, 1000, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (13, N'林雨來', N'0912-583-741', N'高雄市三民區', N'tt@nss.com.tw', N'mmmmmmmm', CAST(N'1985-09-12' AS Date), 0, 800, 100, N'停權')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (15, N'吳宇瞭', N'0972-524-235', N'台北市信義區', N'vv@jj.com', N'nnnnnnnn', CAST(N'1975-04-25' AS Date), 1, 900, 1000, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (16, N'張中貓', N'0933-789-321', N'高雄市前金區', N'rr@ka.com', N'oooooooo', CAST(N'1971-03-25' AS Date), 0, 850, 10, N'審核')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (17, N'邱比特', N'09766-258-147', N'台北市內湖區', N'ap@ple.com', N'pppppppp', CAST(N'1992-11-01' AS Date), 1, 1100, 1000, N'審核')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (19, N'周大山', N'0964-102-257', N'台南市北區', N'ba@nna.com.tw', N'qqqqqqqq', CAST(N'1963-12-15' AS Date), 0, 1250, 1000, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (21, N'吳曉梅', N'0963-456-825', N'高雄市楠梓區', N'gg@hh.com', N'rrrrrrrr', CAST(N'1964-10-25' AS Date), 0, 350, 3, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (23, N'劉小山', N'0912-345-678', N'台南市西區', N'ee@kk.com', N'ssssssss', CAST(N'1963-08-27' AS Date), 1, 1200, 100, N'停權')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (24, N'黃大海', N'0974-129-856', N'台南市永康區', N'oo@ll.com.tw', N'ttttttttt', CAST(N'1981-12-11' AS Date), 1, 650, 100, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (25, N'陳大樹', N'0933-250-745', N'高雄市旗山區', N'yy@zz.com', N'uuuuuuuu', CAST(N'1999-11-16' AS Date), 0, 1400, 1000, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (28, N'林小玉', N'0922-789-146', N'高雄市小港區', N'aaa@sss.com.tw', N'vvvvvvvv', CAST(N'1978-09-27' AS Date), 1, 800, 1, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (29, N'John Cheng', N'0966-777-888', N'高雄市鳥松區', N'yyy@nnn.com', N'wwwwwwww', CAST(N'1979-06-04' AS Date), 0, 1200, 2, N'審核')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (32, N'Joyce Cheng', N'0912-666-777', N'新北市', N'JJ@mmm.com.tw', N'xxxxxxxx', CAST(N'1982-03-15' AS Date), 0, 1000, 1000, N'停權')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (37, N'Mary Wang', N'0955-999-222', N'屏東市', N'ttt@bbb.com.tw', N'yyyyyyyy', CAST(N'1975-07-07' AS Date), 0, 1200, 100, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (46, N'甄世建', N'0955-345-888', N'台北市萬華區', N'yy@xx.com.tw', N'azsxdcfv', CAST(N'1969-07-25' AS Date), 1, 0, 1000, N'審核')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (47, N'張東熙', N'0945-778-632', N'台北市北投區', N'bnm@mm.com', N'dcfvgb', CAST(N'1980-07-04' AS Date), 0, 0, 100, N'審核')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (48, N'翔穗保', N'0978-965-545', N'台北市大安區', N'sleep@com.tw', N'wanttosleep', CAST(N'1997-11-17' AS Date), 0, 0, 1000, N'正常使用')
INSERT [dbo].[customers] ([customerID], [姓名], [電話], [地址], [Email], [密碼], [生日], [婚姻狀態], [點數], [權限], [使用狀態]) VALUES (49, N'aaa', N'123456', N'台北市內湖區', N'aaa@gmail.com', N'a123456', CAST(N'1965-07-16' AS Date), 1, 0, 1000, N'正常使用')
SET IDENTITY_INSERT [dbo].[customers] OFF
GO
SET IDENTITY_INSERT [dbo].[employees] ON 

INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (1, N'張三', 100, CAST(N'2023-01-01' AS Date), 30000, N'0912345678')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (2, N'李四', 100, CAST(N'2022-12-15' AS Date), 50000, N'0987654321')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (3, N'王五', 100, CAST(N'2023-02-10' AS Date), 28000, N'0922334455')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (4, N'陳六', 101, CAST(N'2023-04-20' AS Date), 32000, N'0934876123')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (5, N'劉七', 102, CAST(N'2023-05-05' AS Date), 35000, N'0978234567')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (6, N'林八', 101, CAST(N'2023-06-10' AS Date), 31000, N'0956781234')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (7, N'趙九', 100, CAST(N'2023-07-15' AS Date), 33000, N'0923456789')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (8, N'孫十', 102, CAST(N'2023-08-20' AS Date), 37000, N'0987612345')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (9, N'周十一', 100, CAST(N'2023-09-25' AS Date), 29000, N'0912345678')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (10, N'吳十二', 101, CAST(N'2023-10-30' AS Date), 34000, N'0978654321')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (11, N'郭十三', 100, CAST(N'2023-11-05' AS Date), 30000, N'0922334455')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (12, N'張十四', 102, CAST(N'2023-12-10' AS Date), 36000, N'0945678901')
INSERT [dbo].[employees] ([EmployeeID], [eName], [ePosition], [HireDate], [eSalary], [eContactInfo]) VALUES (13, N'王十五', 101, CAST(N'2023-01-15' AS Date), 31000, N'0987654321')
SET IDENTITY_INSERT [dbo].[employees] OFF
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (16, 240208150122419, 2, 7, 10, N'已結單', 1350, 3, CAST(N'2024-02-08T15:01:22.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (17, 240208152355677, 2, 1, 28, N'已出貨', 640, 2, CAST(N'2024-02-08T15:23:55.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (18, 240208152726896, 2, 7, 29, N'取消訂單', 1080, 3, CAST(N'2024-02-08T15:27:26.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (19, 240208152935292, 2, 10, 31, N'取消訂單', 1350, 3, CAST(N'2024-02-08T15:29:35.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (20, 240208153054509, 2, 8, 32, N'延遲出貨', 320, 1, CAST(N'2024-02-08T15:30:54.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (21, 240208153202811, 2, 11, 13, N'已出貨', 1350, 3, CAST(N'2024-02-08T15:32:02.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (22, 240208153202811, 2, 12, 15, N'已出貨', 1350, 3, CAST(N'2024-02-08T15:32:02.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (23, 240208153647502, 2, 1, 33, N'已審核，出貨處理中', 640, 2, CAST(N'2024-02-08T15:36:47.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (24, 240208153939111, 2, 10, 34, N'延遲出貨', 900, 2, CAST(N'2024-02-08T15:39:39.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (28, 240213174633123, 2, 11, 38, N'取消訂單', 900, 2, CAST(N'2024-02-13T17:46:33.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (29, 240213194213798, 2, 14, 41, N'已結單', 900, 2, CAST(N'2024-02-13T19:42:13.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (30, 240214130518311, 46, 12, 43, N'已結單', 450, 1, CAST(N'2024-02-14T13:05:18.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (31, 240215135215248, 1, 9, 9, N'已出貨', 1080, 3, CAST(N'2024-02-15T13:52:15.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (32, 240215135300790, 3, 9, 12, N'取消訂單', 1080, 3, CAST(N'2024-02-15T13:53:00.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (33, 240215164257813, 10, 37, 44, N'已出貨', 840, 2, CAST(N'2024-02-15T16:42:57.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (34, 240215164257813, 10, 34, 45, N'已出貨', 400, 1, CAST(N'2024-02-15T16:42:57.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (35, 240215165346739, 10, 26, 43, N'已出貨', 600, 2, CAST(N'2024-02-15T16:53:46.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (36, 240215165627926, 10, 31, 47, N'取消訂單', 800, 2, CAST(N'2024-02-15T16:56:27.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (37, 240215171221845, 10, 31, 48, N'取消訂單', 400, 1, CAST(N'2024-02-15T17:12:21.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (38, 240215171221845, 10, 32, 49, N'取消訂單', 840, 2, CAST(N'2024-02-15T17:12:21.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (39, 240215210941584, 10, 18, 49, N'已出貨', 450, 1, CAST(N'2024-02-15T21:09:41.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (40, 240215211349162, 10, 17, 51, N'已出貨', 450, 1, CAST(N'2024-02-15T21:13:49.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (41, 240215211830543, 10, 30, 44, N'已結單', 460, 1, CAST(N'2024-02-15T21:18:30.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (42, 240215211830543, 10, 28, 48, N'已結單', 630, 1, CAST(N'2024-02-15T21:18:30.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (43, 240215212314786, 10, 29, 45, N'已結單', 1080, 2, CAST(N'2024-02-15T21:23:14.000' AS DateTime))
INSERT [dbo].[orders] ([OrdersId], [Ordernumbers], [customerId], [bookId], [shoppincartId], [ProcessingStatus], [price], [Amount], [Time]) VALUES (44, 240215212314786, 10, 28, 53, N'已結單', 630, 1, CAST(N'2024-02-15T21:23:14.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[persons] ON 

INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (1, N'陳大貓', N'0912-234-567', N'高雄市前金區', N'mm@hh.com.tw', CAST(N'1985-05-05' AS Date), 0, 1000)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (2, N'黃小貓', N'0966-333-666', N'高雄市三民區', N'pp@nn.com', CAST(N'1988-06-03' AS Date), 1, 500)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (3, N'張大書', N'0977-666-999', N'高雄市鼓山區', N'zz@dd.com.tw', CAST(N'1978-11-09' AS Date), 1, 2000)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (4, N'黃中書', N'0988-222-777', N'台南市東區', N'rr@tt.com', CAST(N'1979-01-05' AS Date), 0, 1500)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (5, N'王小明', N'0955-111-898', N'台南市西屯區', N'waw@ww.com.tw', CAST(N'1922-08-20' AS Date), 1, 300)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (6, N'黃大名', N'0944-357-456', N'高雄市左營區', N'aa@bb.com', CAST(N'1988-09-01' AS Date), 0, 400)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (8, N'陳小狗', N'0933-358-789', N'高雄市鼓山區', N'qq@aa.com.tw', CAST(N'1985-03-12' AS Date), 1, 250)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (9, N'陳大虎', N'0977-852-963', N'台南市西區', N'uu@qq.com', CAST(N'1952-03-25' AS Date), 0, 700)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (10, N'周星星', N'0945-356-123', N'台北市信義區', N'cc@nn.com.tw', CAST(N'1946-07-30' AS Date), 0, 350)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (11, N'張泰泰', N'0978-542-652', N'台北市內湖區', N'bb@ac.com', CAST(N'1978-06-27' AS Date), 0, 450)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (12, N'王大豐', N'0945-852-146', N'高雄市楠梓區', N'ee@ma.com', CAST(N'1995-07-09' AS Date), 1, 750)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (13, N'林雨來', N'0912-583-741', N'高雄市三民區', N'tt@nss.com.tw', CAST(N'1985-09-12' AS Date), 0, 800)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (15, N'吳宇瞭', N'0972-524-235', N'台北市信義區', N'vv@jj.com', CAST(N'1975-04-25' AS Date), 1, 900)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (16, N'張中貓', N'0933-789-321', N'高雄市前金區', N'rr@ka.com', CAST(N'1971-03-25' AS Date), 0, 850)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (17, N'邱比特', N'09766-258-147', N'台北市內湖區', N'ap@ple.com', CAST(N'1992-11-01' AS Date), 1, 1100)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (19, N'周大山', N'0964-102-257', N'台南市北區', N'ba@nna.com.tw', CAST(N'1963-12-15' AS Date), 0, 1250)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (21, N'吳曉梅', N'0963-456-825', N'高雄市楠梓區', N'gg@hh.com', CAST(N'1964-10-25' AS Date), 0, 350)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (23, N'劉小山', N'0912-345-678', N'台南市西區', N'ee@kk.com', CAST(N'1963-08-27' AS Date), 1, 1200)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (24, N'黃大海', N'0974-129-856', N'台南市永康區', N'oo@ll.com.tw', CAST(N'1981-12-11' AS Date), 1, 650)
INSERT [dbo].[persons] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (25, N'陳大樹', N'0933-250-745', N'高雄市旗山區', N'yy@zz.com', CAST(N'1999-11-16' AS Date), 0, 1400)
SET IDENTITY_INSERT [dbo].[persons] OFF
GO
SET IDENTITY_INSERT [dbo].[productBook] ON 

INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (1, N'刻意練習：原創者全面解析，比天賦更關鍵的學習法', 320, N'安德斯‧艾瑞克森, 羅伯特‧普爾', N'心理勵志', N'刻意練習：原創者全面解析，比天賦更關鍵的學習法.png', N'國際媒體、全球暢銷書、頂尖教練爭相引用的「刻意練習法」！
這可能是人類第一次擁有關於如何練成天才的統一理論！

　　找到天賦，不如找對方法！
　　天才與庸才之間的差別不在基因、不在天分，在「刻意練習」！

　　原創者親授，首度完整揭露「刻意練習」的科學實證與應用。
　　帶你揮別道聽塗說的不完整資訊，
　　正確學會這足以讓你精通所有技能的全新學習法，
　　顛覆你長久以來對潛能、對天賦、對智商的觀念！                                                                                                                                                                                                                                                                                                   ', N'正常', 4)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (7, N'30歲之後，才是你大腦的全盛期：成年人其實比學生更適合讀書？日本首席腦科學名醫親授，打造終生持續進化的最強大腦！', 360, N'加藤俊德', N'心理勵志', N'30歲之後，才是你大腦的全盛期：成年人其實比學生更適合讀書？.png', N'成年人的大腦狀態，其實比學生時代更好！

長踞排行榜一年，熱銷10萬冊！AMAZON熱門暢銷書！
成年進修、考取證照、職場學習必讀的學習聖經！

　　．就算年齡增長，記憶力也不會退化？
　　．只要改變通勤路線，理解力就能大幅提升？
　　．大腦能全力專注的時間，只有二十分鐘？
　　．把喜歡的東西放在身邊，學習速度會提升四倍？
　　．比起視覺接收，「用聽的」更有助於記憶？                                                                                                                                                                                                                                                                                                                  ', N'正常', 8)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (8, N'面對無禮之人，就要比他更無禮：35個人際關係斷捨離，奪回內心的舒服與安定', 320, N'鄭宰熏', N'心理勵志', N'面對無禮之人，就要比他更無禮：35個人際關係斷捨離，奪回內心的舒服與安定.png', N'身上帶點刺，才能在這世界站得穩！
 
斬斷有毒關係、撕下「好欺負」標籤，迎接全新的自己！
 
「看完這本書，有如醍醐灌頂！」
韓國網路書店「YES24」讀者9.6分超高評價！
 
　　他人可以無禮，
　　但不代表你就該被冒犯。
　　面對粗魯的言行，就用無禮相待吧，
　　你很珍貴，絕不能容許被隨意踐踏。
 
　　無禮之人：「喂！你只賺這一點點錢，可以用在哪裡啊？」
　　正確回應：「總比你雖然有錢，但沒人願意陪你一起花更好吧。」
 
　　無禮之人：「你胖了好多！都可以在地上滾來滾去了！」
　　正確回應：「是啊，但是至少不像你，臉像被砸爛一樣。」
　　
　　無禮之人：「你最近看起來容光煥發，該不會是去整形了吧？」
　　正確回應：「喔？看來你對這件事非常了解，所以你去整了哪裡呢？」
 
　　這個世界上，「無禮之人」無所不在。你是否也曾被他人惹火，對方卻不以為意，反而怪你「玻璃心」？是時候該給這些　　人一點教訓了。
 
　　想對抗無禮之人，就要比他「更無禮」！若是遇事一味容忍，對他人的挑釁不斷退讓，最後的結果只會讓你徹底失去自我。果斷地「以牙還牙」，他們才不敢在你面前繼續放肆，擾亂你的生活！
 
　　本書藉由9大人際關係類型、35則心理分析，教你如何精準辨識「無禮之人」、捨棄不健康的人我相處，建立良好的人際關係。人生只有一次，想活得更開心、更幸福嗎？就從去除身邊那些無禮之人開始吧！', N'正常', 7)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (9, N'長途旅客', 390, N'豆苗先生', N'心理勵志', N'長途旅客.png', N'　★獻給所有曾經受傷的靈魂！暖心圖文溫柔陪伴深陷情緒症困擾的人們。
　　★出道15年真情力作，40萬人引頸期待！跨界創作人感動推薦。

　　人生就像旅途，我們是長途旅客，
　　旅程從起點到終點，關係從開始到離別，
　　你能否接受所有的結局？
　　所有的情緒、否定、新生、惆悵又是什麼模樣？

　　生命就是這樣，我們互相打擾，但也互相依賴。
　　光是與你在一起，就足以成為我生命的意義。
　　十三歲開始創作的豆苗先生，坦承自己也有情緒症狀。
　　他說，長大好痛苦，除了哭跟裝沒事以外，不知道還能用什麼方式處理，沒辦法像以前一樣挪出大量的時間替自己療傷，只能不斷地消磨自己的靈魂。
　　因此，他要將第一本書獻給所有曾受傷的靈魂。
　　書中除了分享觸動人心的故事，也透過單格、多格、長篇等不同創作形式的插畫，將人生各個階段進入關係後產生的困惑、焦慮、溫柔、悲傷等，一一用細膩的筆觸呈現。

　　這世界上還有好多好多，我們都還想不透的事情，我用一年記錄下來，再讓我用一生去思考這些問題的答案吧。也希望有一天，你們在人生這趟旅程，不再需要用這本書找到歸屬感，而是有個人，能夠真正的擁抱你。
漫漫長途，你我都是旅客。', N'正常', 7)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (10, N'多巴胺國度：在縱慾年代找到身心平衡
DOPAMINE NATION: Finding Balance in the Age of Indulgence', 450, N'安娜‧蘭布克醫師（Dr. Anna Lembke）', N'心理勵志', N'多巴胺國度：在縱慾年代找到身心平衡.png', N' 美國暢銷20萬本

成功戒癮的經典之作

 

揭露人們在慾望國度中的瘋狂歷險、
所付出的代價，以及，如何平安歸來。

 

滑手機、瘋購物、狂自慰，

我們身處誘惑太多的時代，早已成癮卻無法自拔。

 

這本書要談成癮的爽、戒癮的痛，

以及爽痛之間如何取得平衡。

 

　　滑手機、熬夜追劇、大吃大喝、瘋狂消費，成為辛苦一天之後必備的自我慰勞；然而，我們已經網路成癮、購物成癮，或是酒癮、性成癮上身，卻不自知。

　　這不是我們的錯，而是多巴胺（dopamine）的問題。

　　多巴胺是一種神經傳導物質，又稱為「腦內啡」，要讓大腦釋放多巴胺很簡單，只要你做一件事情能讓自己開心就行了，像是上網、吃喝玩樂、盡情購物。不過，多巴胺會逐漸減少，需要更多的慾望、更強的刺激才行，也因此讓人愈來愈痛苦。

　　如果我們發現自己上網時間愈來愈長、暴飲暴食的次數愈來愈多、喝下肚的酒愈來愈烈、購物次數愈來愈頻繁，很有可能已經成癮。

　　安娜‧蘭布克醫師（Dr. Anna Lembke）是史丹佛大學醫學院精神科暨成癮醫學教授，也是史丹佛戒癮診所的主任，她以協助成癮者戒癮的多年經驗，在徵得病患同意之下，將她協助酒癮者、毒癮者、性成癮者如何戒癮的案例納入本書，詮釋慾望的來源、成癮的問題和戒癮的過程。

　　蘭布克醫師指出，在我們的腦中，爽快和痛苦如同翹翹板的兩端，當一端受到過度刺激，另一端就會翹起，多巴胺分泌的多寡影響爽與痛的平衡，一旦打亂，就會導致爽痛失衡。

　　她坦言，自己曾經有一段時間沉迷於閱讀網路言情小說，這個經驗讓她更了解，多巴胺導致我們在成癮的爽快與戒癮的痛苦之間擺盪。她發現，如果「痛」是為了「爽」而必須付出的代價，「爽」就是「痛」過之後兌換到的獎勵。

　　蘭布克醫師在書中整理出一套方法協助成癮者有效戒癮，這八個步驟的英文首字剛好對應多巴胺 DOPAMINE，包括：資料（Data）、目的（Objectives）、問題（Problems）、禁慾（Abstinence）、正念（Mindfulness）、洞見（Insight）、下一步（Next steps）和實驗（Experiment）。

　　身處充滿各種刺激的環境之中，究竟我們要如何不受到多巴胺過度控制，在成癮的爽快和戒癮的痛苦之間取得平衡？答案就在這本書。', N'正常', 3)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (11, N'全知讀者視角01', 450, N'싱숑', N'輕小說', N'全知讀者視角01.png', N'十年來只有我一個人在追的小說，
　　居然變成了現實？
　　我是一個平凡的上班族，
　　唯一的嗜好是看網路小說《在滅亡的世界中存活的三種方法》。
　　但在我看完最終話時，小說中的場景倏然成真！
　　彷彿人間煉獄的地鐵車廂，踐踏著城市的巨大怪物，
　　以及憑空出現在眼前的訊息：
　　[您收到了主線任務！]

　　熟悉的小說角色紛紛登場，
　　有人成為我的伙伴，有人恨不得殺我而後快。
　　而那個強大無比、牽動著整個世界命運的「小說主角」，
　　充滿殺意的冷冽刀鋒更直指我而來──
　　「你，究竟是誰？」

　　一個世界已然毀滅，全新的世界正在誕生。

　　至於我，則是知曉這個世界結局的

　　唯一讀者。', N'正常', 4)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (12, N'全知讀者視角02', 450, N'싱숑', N'輕小說', N'全知讀者視角02.png', N'一個世界已然毀滅，全新的世界正在誕生，
至於我，則是知曉這個世界結局的唯一讀者──
 
　　由地鐵發端的殊死任務，逐步擴展至整個首都。
　　為了將這個世界導引到我想要的方向，
　　我不得不冒用那個混帳主角的身分。
　　這時，一群自稱得到未來啟示的使徒趁隙介入，
　　帶來的卻是極端混亂和重重疑竇！
 
　　隨著第四個主線任務來到尾聲，
　　以絕對的權力王座為誘餌，各方勢力展開了激烈的諸王之爭，
　　我也必須再次與劉衆赫為敵。
　　然而，除了我這個讀者以外無人知曉，
　　導致首爾覆滅的「災禍」，
　　即將在這個任務落幕時降臨──
 
　　對我而言，不存在下一次「回歸」。
　　在這個世界，我必將抵達故事的終章。', N'正常', 2)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (14, N'全知讀者視角03', 450, N'싱숑', N'輕小說', N'全知讀者視角03.png', N'　一個世界已然毀滅，全新的世界正在誕生，
　　至於我，則是知曉這個世界結局的唯一讀者──
　　--
　　為了應對即將到來的第五個主線任務，
　　我正式成為申流承的背後星，
　　與我理念不合的韓秀英，也就此分道揚鑣。
　　孰料，來自第四十一次回歸時間線的災禍申流承轉眼孵化，
　　以壓倒性的力量橫掃整個首爾！
　　城市化為煉獄，她的眼中卻浮現了深沉的哀傷。
　　只有作為讀者的我明白，
　　這個在世界線迷宮漂流千年的孤寂靈魂，
　　不只能毀滅一切，亦將毀滅自己。

　　正因深愛著《滅活法》，
　　我比任何人都希望這個故事裡的人物，能擺脫既定的悲哀結局。
　　為此，我前往冥界尋求奧林帕斯神的幫助，
　　作為交換，冥界女王提出了為祂「殺死目標」的要求。
　　而在任務指引之地，竟出現了韓秀英的身影──', N'正常', 8)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (15, N'全知讀者視角04', 450, N'싱숑', N'輕小說', N'全知讀者視角04.png', N'          一個世界已然毀滅，全新的世界正在誕生，
　　至於我，則是知曉這個世界結局的唯一讀者──

　　隨著劉衆赫與涅巴納的決戰劃下句點，
　　肆虐首爾全境的獸潮，終以最強化身的犧牲落下帷幕。
　　就在此時，我收到了星座盛宴的邀請通知，
　　憑藉過往累積的傳說，
　　我在眾星的見證下，正式躋身星座之列。

　　成為星座，不代表能逃離星星直播的桎梏，
　　我跟隨眾人投入下一個任務，
　　這個惡魔遍地的副本內，
　　卻出現了號稱能徹底擺脫任務的神祕樂園！
　　疑惑之際，消失多時的劉尚雅意外現身，
　　伙伴們還未及感受重聚的喜悅，
　　奧林帕斯神殘酷的命運預言，已宣告了我們未來的離別──', N'正常', 10)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (16, N'全知讀者視角05', 450, N'싱숑', N'輕小說', N'全知讀者視角05.png', N'　　一個世界已然毀滅，全新的世界正在誕生，
　　至於我，則是知曉這個世界結局的唯一讀者──

　　在大型星雲縝密的謀劃下，我陷入了進退維谷的死局。
　　正因明白想要保護一切，就必須失去一切，
　　我帶著微笑，讓珍愛的人們將我放逐到任務之外。
　　肉體崩潰分解，傳說流逝四散，
　　一無所有的虛空之中，唯有撕裂靈魂的痛楚無窮無盡。
　　然而，當我的意識即將完全湮滅，
　　地平線的惡魔悄然現身，露出了狡猾的笑容。

　　以自身累積的傳說為代價，
　　我來到了任務流放者的聚集地──第七十三號魔界。
　　為了找出活下去的契機，
　　我必須在這個星座不屑一顧的世界，掀起革命的浪潮！', N'正常', 10)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (17, N'全知讀者視角06', 450, N'싱숑', N'輕小說', N'全知讀者視角06.png', N'        一個世界已然毀滅，全新的世界正在誕生，
　　至於我，則是知曉這個世界結局的唯一讀者──
　　--
　　魔王選拔戰迫在眉睫，
　　我在冥界女王的介紹下，前往美食協會找尋可能的盟友。
　　面對見識過無數傳說的高等星座，
　　初窺星座之徑的我，擁有的歷史太過單薄，
　　能夠利用的，只有祂們對美味故事的貪婪欲望。

　　然而計畫趕不上變化，當選拔戰的號角吹響，
　　敵對星座的強大仍舊超乎想像。
　　幾近粉碎神智的攻擊侵蝕了我的意識，
　　等我再度睜開雙眼，
　　卻見象徵「回歸」的光芒，正自劉衆赫體內緩緩綻放……', N'正常', 9)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (18, N'全知讀者視角07', 450, N'싱숑', N'輕小說', N'全知讀者視角07.png', N'　一個世界已然毀滅，全新的世界正在誕生，
　　至於我，則是知曉這個世界結局的唯一讀者──

　　與隱密的謀略家簽訂異界盟約，
　　我穿越到了第一千八百六十三次回歸的時間線。
　　在這個已然化作焦土的世界，
　　本該身為救世主的劉衆赫，卻成了一切絕望的源頭，
　　率領眾人與之對抗的，
　　竟是一道與我穿著相同大衣的身影。

　　不願屬於我的世界亦走向破滅，
　　我匆匆回到原本的時間線，
　　孰料迎來的不是伙伴們的熱情擁抱，而是數不清的刀光劍影。
　　在逐漸模糊的視野中，
　　最後的畫面，是鄭熙媛冰冷漠然的面孔……', N'正常', 9)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (19, N'全知讀者視角08', 450, N'싱숑', N'輕小說', N'全知讀者視角08.png', N'　　一個世界已然毀滅，全新的世界正在誕生，
　　至於我，則是知曉這個世界結局的唯一讀者──

　　獲得巨神的強力奧援，
　　我趕在最後一刻加入了巨人族戰役。
　　然而巨型星雲的底蘊太過深厚，
　　我們還未清算與奧林帕斯的新仇舊恨，
　　神話級星座波塞頓竟無視概然性，悍然出手！
　　為此，我不得不成為冥界的繼承人，以換取冥王協助。

　　既定的未來越漸脫離掌控，
　　一則意外的神啟，更打亂了我所有計畫。
　　當《滅活法》的情報不再是祕密，
　　那充滿殺意的冷冽刀鋒，再度直指我的咽喉——
　　「你，為何騙我。」', N'正常', 10)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (20, N'全知讀者視角09', 450, N'싱숑', N'輕小說', N'全知讀者視角09.png', N'　　一個世界已然毀滅，全新的世界正在誕生，
　　至於我，則是知曉這個世界結局的唯一讀者──

　　懷著絕不放棄任何伙伴的信念，
　　我踏上了擁有拯救劉尚雅方法的轉生者之島，
　　同時，我也將在此完成我的「唯一神話」的轉之篇章。
　　然而當傳送到任務地區的我再次睜眼，
　　整個世界，已然面目全非。

　　克服了一個又一個星星直播的惡意考驗，
　　我與伙伴終於抵達神魔大戰的戰場，
　　非善非惡的金獨子集團，
　　卻立刻成了雙方陣營競相剷除的首要目標。
　　眼見無法調和的善惡矛盾越演越烈，
　　沉睡在地獄最深處的絕望，悄悄伸出了獠牙……', N'缺貨中', 0)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (21, N'全知讀者視角10', 450, N'싱숑', N'輕小說', N'全知讀者視角10.png', N'　　一個世界已然毀滅，全新的世界正在誕生，
　　至於我，則是知曉這個世界結局的唯一讀者──

　　呼喚異界神格的代價，便是星星的墜亡。
　　被不可名狀之渺遠吞噬的我原已接受命運，
　　誰知隱密的謀略家意外出現的身影，為一切帶來了全新的轉機。
　　當我自幽深的黑暗中緩緩甦醒，
　　映入眼簾的，竟是異界神格不可言說的祕密。

　　得知了世界線的殘酷真相，
　　我更加確信毀滅星星直播勢在必行。
　　與此同時，鬼怪亦捎來了「最後的任務」開啟的消息。
　　這個充滿苦難的漫長故事，
　　終於響起了邁向最終篇章的倒數計時──', N'缺貨中', 0)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (22, N'我可能錯了：森林智者的最後一堂人生課', 450, N'比約恩．納提科．林德布勞, 卡洛琳．班克勒, 納維德．莫迪里', N'心理勵志', N'我可能錯了：森林智者的最後一堂人生課.png', N'　　達賴喇嘛：這本書能使所有人受益
　
　　瑞典最暢銷心靈書，連續三年獲獎不斷！
　　隱居山林的經濟學家，最動人的生命體悟
　　17年的森林寺院修行、返鄉後的憂鬱巨浪、與漸凍症並肩走向死亡的日子，
　　這句話，成了他一生的金言，
　　也將帶你擺脫焦慮風暴、生命備受鼓舞！

　　※心能量管理中心執行長 許瑞云醫師、主持人 曾寶儀、阿迪亞香提──專文推薦
　　身心靈導師 賴佩霞博士──好評推薦
　　※封面圖《崇敬》（Adoración），是當今古巴重量級且身價最高的藝術家托馬斯．桑切斯所繪，諾貝爾文學獎得主馬奎斯也是托馬斯的忠實粉絲。

　　瑞典每30個人就有1個人看過這本書！
　　一句簡單又神奇的箴言，
　　為你在困頓中找到撫慰與前進的勇氣！

　　2022年1月，經濟學家比約恩．納提科．林德布勞的辭世，讓全瑞典人落淚哀悼。《我可能錯了》是比約恩人生的最後一本書，在2020年一出版就造成轟動，成為暢銷書冠軍。

　　26歲事業有成的比約恩，在即將成為跨國大企業最年輕的財務長時，選擇拋下一切到泰國森林展開17年的出家生活。在森林寺院中，他被授予了稱號Natthiko──意思是「在智慧中成長的人」。

　　「我可能錯了」這句話，正是比約恩在寺院中汲取到最有智慧的工具，幫他挺過17年後再回瑞典時的憂鬱風暴，以及罹患漸凍症逐漸走向死亡的日子。

　　在這本讀者給予「一輩子的床頭書」「每一頁都會畫重點的書」等好評如潮的書中，並不是關於宗教，也不是要告訴你如何過生活，更不是要你接受一套新的信仰。它是要幫助你活得更愉快、更自由，而且以清晰明智的方式與自己的思想和情感連結。

　　★2020年，榮獲瑞典Adlibris書店年度最佳非文學著作、Storytel大獎年度最佳非文學著作
　　★2021年，有聲書榮獲瑞典「年度之聲」大獎
　　★2022年，榮獲瑞典Nextory電子書獎
　　★售出英、西、法、德、韓等29國版權', N'正常', 10)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (23, N'別對每件事都有反應：淡泊一點也無妨， 活出快意人生的99個禪練習！', 330, N'枡野俊明', N'心理勵志', N'別對每件事都有反應：淡泊一點也無妨， 活出快意人生的99個禪練習！.png', N'入選「世界最值得尊敬的100名日本人」之
百萬暢銷作家──枡野俊明，
突破20萬冊超強新作！
以禪學教會我們「舒適地度過人生」！

　　該放下，就放下，也放過自己，
　　工作也好，人際關係也罷，沒有什麼不能捨棄。

　　世界變遷快速，環境動盪不安，
　　網路資訊、社群言論等，令人喜憂參半，
　　找不回心靈的平靜，也擺不平情緒的波動，
　　人與人之間物理及心理的距離，也變得更加難以捉摸。

　　禪語「放下著」，意指捨去一切的執著。

　　這世上有許多事情，光靠自己的力量是無法控制的，
　　正因為人與人之間不可能完全相互理解，
　　以及再怎麼努力，也不可能看透未來、改寫過去，
　　不如把這些都放下吧，別再浪費心力和能量，
　　集中在「此刻正在進行的事」、「現在能做的事」。

　　本書透過「人際關係」、「擺脫負面情緒」、「停止磨耗心靈」、「不自討苦吃」、「活出快意人生」五大分類，介紹能讓你的心重獲自由的99個準則。

　　當疲憊於生活上各種事物，以及與他人的關係時，
　　閱讀本書，必定能讓你成為———

　　不受人際關係擺佈的人。
　　對工作態度積極的人。
　　每天都過得愉快的人。', N'缺貨中', 0)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (24, N'蛤蟆先生去看心理師', 400, N'羅伯．狄保德', N'心理勵志', N'蛤蟆先生去看心理師.png', N'心理諮商創舉
取材自英國童話《柳林中的風聲》完美結合心理學的經典之作
授權10個語言版本，自1997年起長銷20多年
 
────────  只要我們的情緒真正獲得理解，就能有成長的機會  ────────

　　藉由蛤蟆先生和心理師的10次諮商，演繹心理諮商全過程，見證療癒與改變的發生。
 
　　讓我們與蛤蟆先生一起走趟心靈成長的旅程，探索憂鬱與自卑、軟弱、愛炫耀的個性究竟來源於何處，反思童年經歷的深刻影響，以及如何才能在心理上真正長大成人，獨立、自信、充滿希望地生活。
 
　　「每個人生下來都是王子，卻被父母變成青蛙。心理治療的目的，就是讓青蛙再變回王子。」——溝通分析創始人艾瑞克．伯恩（Eric Berne）
　　閱讀本書，將可深刻領略此句名言之妙，和蛤蟆先生一同經歷心理探險、重拾自我的洗禮。

　　【內容簡介】
　　這本老少咸宜、令人愉悅的作品，角色取材自英國經典童話《柳林中的風聲》，作者將心理治療過程運用在動物主角們身上：主角蛤蟆先生因為憂鬱症而離群索居，好友河鼠、鼴鼠和老獾擔憂他可能會做傻事，大力慫恿他去找心理諮商師蒼鷺。蒼鷺運用溝通分析（Transactional Analysis）協助蛤蟆先生面對內在小孩和成人，學會分析自己的感覺，發展情緒智商。到了書末，他恢復了以前的開朗，展開全新的旅程。
 
　　故事中涵蓋憤怒、潛意識、自我審判、兒童的自我狀態、父母的自我狀態、成人的自我狀態，適應性兒童、挑剔型父母、共謀、情商等心理學理論。將心理知識巧妙融入故事情節，解析20多個心理學專業名詞、可說是展現心理諮商療程的標準範本。
 
　　【《蛤蟆先生勇氣藏書卡》組】
　　尺寸：6.5×9cm
　　紙張：凝雪映畫美術紙 240g
　　數量：一組共三張
　　印刷：特別色
 
國外暢銷佳績/得獎紀錄

　　英國亞馬遜網路書店心理諮商類暢銷   第1名
　　當當網心理學類暢銷榜   第1名', N'正常', 12)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (25, N'從苦瓜熬成哈密瓜：歡迎收聽紫砂歐娜【限量簽名版＋紫砂戰隊過好年紅包袋】', 390, N'歐娜', N'心理勵志', N'從苦瓜熬成哈密瓜：歡迎收聽紫砂歐娜.png', N'一起把苦瓜人生活得精彩！
曾經受過的傷或許無法完全癒合，卻讓人更勇敢而堅強對抗世界的黑暗，
最無私的分享，帶領你朝著光亮的地方，遇見更美好的每一個自我。
 
【限量附贈】「紫砂戰隊過好年紅包袋」
採獨家手繪插圖（共兩款），送禮自用兩相宜
 
【紫砂戰隊過好年紅包袋】
內容物：一組兩入（苦瓜款與哈密瓜款各一）
尺寸：寬9×高20公分
印刷：彩色印刷
 
　　歐娜到底是誰？
　　她是在工作崗位上戰戰兢兢的電視圈幕後企劃，
　　也是減重超過五十公斤的毅力女神，
　　更是用幽默化解挫折的人氣Podcaster，
　　這次她從原點與你分享，她的故事。
 
　　從《康熙來了》的幕後策劃到走向台前自信分享生活的Podcaster，
　　歐娜的聲音陪伴無數的人度過通勤長路、漫漫夜晚以及每一個脆弱的時刻，
　　她話不落地成為最貼近你耳邊的朋友，
　　而這次她將用文字向你訴說她的故事，她的秘密。
 
　　這是一本關於一個女孩勇敢追夢的紀錄，
　　也是她在反覆流血結痂的傷口中找到自己的故事，
　　一個比一般人更會說故事的平凡女子，
　　帶你一起從苦瓜熬成哈密瓜，從嘴角下垂到嘴角上揚！
 
　　＃關於職場歐娜這樣說
　　電視圈究竟是什麼地獄呢？我想是加班地獄
　　上班第一週就在廁所過夜，加班是常態，加班到大半夜更是習以為常，然而她也因此重拾駕照，成為現在暢行無阻的資深駕駛！
 
　　＃關於生活歐娜這樣說
　　找房子不難，找到好房子才困難！
　　回憶起到北京工作的日子，飲食文化的衝擊下，與你最貼近的是你的馬桶，連使用洗衣機都必須推出室外安裝，北京生活讓你哭笑不得！
 
　　＃關於自我歐娜這樣說
　　這次我要為自己而減。
　　你曾因為他人異樣的眼光而感到不自在嗎？這個社會雖嚷嚷著多元，有時卻只用單一審美。歐娜將訴說她一路的成長歷程，「肥胖」、「胖子」、「109」等綽號迴盪在她心中，都是她受過的傷痕，這次她將剖開這些瘡疤，與讀者一起療傷。
 
　　＃關於情感歐娜這樣說
　　當聽眾成了男友
　　他認真地寫了封情書，在歐娜面前大聲朗讀。母胎單身二十多年，就這樣遇到了一個很棒的人，告別了單身。粉絲、聽眾變成另一半這種事，感覺是很多戲劇電影的題材，卻奇蹟似地發生了，果然還是要相信愛情啊。
 
　　「我的過去不算最苦，畢竟很多人的生活更水深火熱，我的現在也不是最甜，還有很多美中不足。我就跟一開始預料的一樣，是個超普通的人，講著瑣碎的故事，分享經歷這些事情後的喜悅，希望每位閱讀這本書的人，都可以從中得到一點點力量。」── 歐娜', N'下架停賣', 0)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (26, N'被討厭的勇氣：自我啟發之父「阿德勒」的教導', 300, N'岸見一郎, 古賀史健', N'心理勵志', N'被討厭的勇氣：自我啟發之父「阿德勒」的教導.png', N'★讓人生為之一變的全新經典，終於誕生！
★日本亞馬遜年度冠軍書，連續300天長踞暢銷榜，街頭巷尾人手一冊！
★榮獲日本2014年商業書大賞第三名，作者古賀史健榮獲評審特別獎！
★獲選《經理人》雜誌2014年4月商管選書。
★戴爾．卡內基：「阿德勒是畢生研究人類及其潛力的偉大心理學家！」
★與佛洛依德、榮格齊名，並稱「心理學三巨頭」。阿德勒除了是心理學發展承先啟後之人，更堪稱自我啟發之父！

　　所謂的自由，就是被別人討厭。
　　有人討厭你，正是你行使自由、依照自己的生活方針過日子的標記。

　　為什麼人們一直無法改變？
　　為什麼自卑感總是揮之不去？
　　為什麼我們總是活在別人的期待之下？
　　為什麼現在無法真實感受到幸福？
　　或許是因為，我們缺少了被別人討厭的勇氣！

　　一名憤世嫉俗的年輕人來到哲學家的小屋。
　　當他聽聞哲學家主張「世界無比單純，人人都能幸福」，便決心前來推翻這種謬論。
　　這個世界明明複雜混亂，哪裡單純了？
　　如果幸福真的這麼容易，為什麼他還會過得這麼痛苦？

　　他們開始了你來我往的思考與論辯。
　　年輕人原以為哲學家不過是昧於現實的昏庸老頭，
　　但是一夜又一夜過去後，年輕人反而陷入沉思：這世界到底是什麼樣子？
　　「所謂的自由，就是被別人討厭。」哲學家說。
　　怎麼會這樣？怎麼會有人想被別人討厭？
　　想得到真正的自由，又為什麼非得被別人討厭不可呢？
　　這個世界，究竟是單純，還是複雜？人，到底能不能得到幸福？……

　　問題不在於「世界」是什麼樣子，而在於「你」是什麼樣子。

　　阿爾弗雷德．阿德勒（Alfred Adler，1870-1937）

　　出生於維也納，是一位醫師、心理學家、兒童教育家，也是「個體心理學」的創始人，與佛洛伊德、榮格同為心理學三巨頭之一。他相信人的一切行為都有目的，並認為每個人都是不同的個體，研究過程也應該以個人的特殊心理經驗為對象。阿德勒的學說讓心理學從「生物性」轉向「社會性」，對心理學發展具有相當重要的意義，許多治療學派也都引用他的學說，他更被奉為家族治療的鼻祖。', N'正常', 13)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (27, N'3分鐘未來日記【369天實踐版】：萬人見證的書寫奇蹟', 540, N'山田弘美, 濱田真由美', N'心理勵志', N'3分鐘未來日記【369天實踐版】：萬人見證的書寫奇蹟.png', N'　    如果寫在日記裡的一切都會成真，
　　如果只要仔細描摹文字，願望就會實現，
　　而且一天只要花3分鐘，你願意試試看嗎？

　　369天的描摹日記，讓好運吸引力跟你站在同一陣線！

　　★FB兩萬人社團一起寫日記創下奇蹟
　　★年度百大最強日記書
　　★上萬人親身實證，這個方法真的有效！
　　寫過的都推薦！

　　只要描摹就能心想事成，沒辦法更簡單了！

　　一推出就暢銷的《3分鐘未來日記》幫助許多人實現了夢想。
　　原本是一本書＋49天份的描摹日記，
　　但讀者不斷詢問：「我已經寫到第N輪了，有沒有更進一步的版本可以寫？」
　　來了！比一年還多的369天實踐版，做你一整年的靠山！

　　《3分鐘未來日記》上萬名讀者實作體驗：
　　☉從沒中過雲端發票獎，有天寫：「終於中雲端發票了！」結果真的中獎了！
　　☉開始寫第二輪3分鐘日記，我感受到3分鐘日記的威力，連自己都沒想到的好事，一件一件都降臨到我身邊。
　　☉因為生活中發生意外事件，導致需要在短時間內找到合適的房子。寫進日記沒多久，朋友就介紹了非常適合的房子，還談到好價錢，順利簽約搬入了。
　　☉一年內被加薪兩次！
　　☉遇到很照顧我又貼心的對象，並且準備結婚了！
　　☉又一張訂單實現，達成了百萬經紀人的願望。寫了幾個月的3分鐘未來日記，完成了好多目標。
　　☉對完發票那天寫下：「今天對發票中了1000元，可以幫助更多人了！」隔兩天收電子郵件時，發現一封境外消費的中獎通知，金額剛好就是1000元！感謝3分鐘未來日記。
　　☉發現年初寫下的願望居然不到半年就做到了，真的非常驚喜。原來這個日記對拖延症也有一點效果。
　　☉我是做網路拍賣的賣家，賣的東西是較小金額的文具類，所以就寫了希望單筆訂單金額能夠大一點，比較好包貨。這幾天都有達標！

　　這麼多人的分享與見證讓我們知道──
　　寫下的願望真的一直在實現！

　　之前沒讀過、寫過《3分鐘未來日記》？
　　完全沒問題！本書有詳細說明做法，新讀者也能一秒上手，
　　天天練習進入心想事成的頻率！

　　◎提升未來日記實現機率的重點：
　　1 日記最後加上表達情緒及感謝的句子，感受願望實現的心情。
　　2 實在想不到要寫什麼，只是描摹也OK。無法每天寫也無須介意。
　　3 不要每天回頭讀之前寫過的內容。
　　4 選一枝好握、自己最喜歡的筆來寫。
　　5 與人分享願望成真的部分。

　　開始寫未來日記之後，
　　你會知道「心想事成是真的」「事情會變成你想的那樣」！', N'正常', 16)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (28, N'繁花（全新修訂布面精裝典藏版）', 630, N'金宇澄', N'文學小說', N'繁花（全新修訂布面精裝典藏版）.png', N'「小說可以大聲疾呼，也該允許我一聲不響。」

　　2018年台北國際書展書展大獎首獎得主金宇澄震撼文壇之作

　　中國小說學會2012年度 中國小說排行榜榜首
　　2012年華語文學傳媒大獎之「年度小說家」獎
　　魯迅文化獎
　　施耐庵文學獎
　　茅盾文學獎
　　…

　　胡晴舫、柯裕棻、張惠菁、馬家輝、傅月庵、黃麗群、黃崇凱、駱以軍推薦
　　王家衛即將改編電影，為繼《花樣年華》、《2046》後的第三部曲
　　2019全新修訂，極致典藏布面精裝本
　　收錄金宇澄繁體版新序，柯裕棻專訪，全新精彩人物關係圖
　　金宇澄親繪插畫二十幅

　　一座城，兩個男人，三段童年，四個十年，還有說不盡的市井故事。

　　九○年代，生意人的上海。律師滬生與妻子白萍有名無實，兩人結婚後白萍便想盡辦法轉往國外，不願再回家來。法律夜校同學梅瑞先是與滬生交往，後來勾搭上他的好友「寶總」阿寶，但阿寶心裡始終有一個女孩的影子。

　　商場上，精明的女人盯著成功的男人，特別是寂寞的男人。而寂寞的男人背後，都有過一個特別的女人。他們的故事──關於一座城的故事──要遠從滬生、阿寶與小毛三人結識的童年，六○年代的上海說起，那其中充滿各種美麗的、迷人的、身不由己的、充滿慾望的女人，女人的身體，渴望女人的男人與渴望男人的女人；街坊、八卦、流言、背叛、傳說、英雄事蹟、失望與希望、眼淚，與一場改變所有人的革命。

　　「繁花就像星星點點生命力特強的一朵朵小花，好比樹上閃爍小燈，這個亮起那個暗下，是這種味道。」──金宇澄

　　「這是一本非常可敬的小說，對我內在的衝擊，可能像幾年前在香港讀到的《太后與我》，或二讀三讀張愛玲的《雷峰塔》，那不是一本小說選擇的觀看世界方式，而是透過一本小說的『這一次』對你置身的世界幻覺的搏擊。」──駱以軍

　　「上海的文學和關於上海的文學，從張愛玲以來都是陰性的，而在金宇澄的《繁花》裡充滿了荷爾蒙性感，不是粗獷，是上海男人的性感。」──王家衛

　　《繁花》緣起於向一座偉大的城市致敬，金宇澄想寫下兩代人的上海故事，包括可說的與「不響」的；敘事時間涵跨了上海的二十世紀六○年代至九○年代，敘事路線一從六○年至文化大革命結束，另一條則自一九八○年到二十一世紀初，以三名童年好友的際遇，勾勒出上海市井生活的真實樣貌，如流水席般如實描摹個中悲歡。文字密緻，細節精巧，說故事技巧卓越的《繁花》被譽為繼承了張愛玲與王安憶的上海敘事，不僅重現了專屬上海的當代清明上河圖，更像是集上海男男女女命運的當代《紅樓夢》。', N'正常', 18)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (29, N'也好吃', 420, N'馬世芳', N'文學小說', N'也好吃.png', N'                           懂音樂的他，你認識已久
                    懂吃、懂下廚的馬世芳，正式報到

　　馬世芳能將過去的顏色寫得新，將當代的氣息寫得深，至於滋味嘛，吃過這些菜的我願毫不誇大地保證：真是也好吃。――黃麗群

　　不論是想學能成為家的味道的料理，想共情自己生命中與家的聯繫，或是想領略一篇篇對菜餚背後心意的讀者，這本書都值得陪伴我們慢慢品味自家與他家。
　　這是一本沒有憂傷也沒有炫耀，對於料理與飲食只是充滿了尋常日子和被愛過的成長時光分別的孺慕，安然的漫步之書。我是如此地羨慕……也以我的羨慕祝福著作家與每位讀者。 ――安溥

　　一個饞人的自白，引你穿過時間，品嚐念想食物的幸福
　　家傳百頁包肉、爸爸的酸梅湯、姑奶奶的茄餅、人生第一杯卡布其諾……
　　21篇散文，追溯21個食物背後的故事、充滿滋味的記憶畫面

　　一朝洗手做羹湯，領你進入廚房，體會創造美味的滿足
　　一碗麵、一鍋飯、蚵仔雙味、大肉三鍋、小排四帖、家常六則……
　　72道家常料理親手演繹，娓娓道來程序與訣竅，少的是小心翼翼的緊張，多的是從容頑皮的樂趣

　　本書通關密語：很好看•很餓•不要晚上看
　　好（ㄏㄠˋ）吃的胃口，好（ㄏㄠˇ）吃的心法，一次蒐羅

　　自稱饞人的馬世芳，從疫情期間煮一碗麵開始，結合曾經的美食記憶，揉成他的廚房道理。廚房裡，他像個好奇孩子，興致勃勃尋找著好吃、好玩、好掌握的做菜樂趣。他鑽研，可書裡不寫他的鑽研；他講究，反而不那麼講究也好吃的招數書中經常可見。

　　他做菜有一種彈性。不只是食材替換的彈性，做法上的彈性、難度上的彈性、心情上的彈性，加上絕好的文筆，構成他寫吃喝做菜時的獨特魅力。主持音樂節目時專業又精準的馬世芳，在廚房裡展露出自在寫意。

　　吃，從來就不只是味覺的饗宴，細火慢燉的還有心靈的溫度。

　　這是一本談吃之念想與重現的生活散文，不走食譜規格，保證引人入勝。部分菜色搭配照片，都來自馬世芳的飯桌。', N'正常', 9)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (30, N'詭畫連篇', 460, N'傑森・雷庫拉克', N'文學小說', N'詭畫連篇.png', N'　　這個家真的很不對勁，不要隨便問……
 
　　▲《后翼棄兵》金獎編劇：打破類型小說天花板，餘韻強勁！
　　▲恐怖大師史蒂芬．金：這本我愛到不行！
 
　　1個隱形朋友x 70多幅童稚塗鴉x毛骨悚然的大宅=
　　那孩子真的看得到……
 
　　★暢榜話題小說 ★Netflix搶下改編權 ★亞馬遜書店最佳驚悚懸疑書
　　★Goodreads書評網恐怖小說票選冠軍 ★版權售出30國
 
　　年度最大膽的多重逆轉小說！
　　從5歲孩子的70多幅塗鴉，帶出劇情翻轉線索，寫出驚悚小說新高度！
 
　　孩子是個禮物，
　　但有時跟著禮物一起來的，卻是……
 
　　瑪洛莉藥物成癮了好久，辛苦戒毒後，透過輔導員介紹，來到中產郊區應徵保母，試圖重新站穩人生的腳步。雇主是一對恩愛夫妻，他們的五歲獨子泰迪乖巧可愛，像天使一般。
 
　　工作的環境很好。白天瑪洛莉就陪小泰迪玩耍，晚上她回到後院獨立小屋休息，有時還會去夜跑。她已經超過半年沒碰藥，正一點一滴贏回自主權。
　　
　　小泰迪什麼都好，就是老愛提「想像朋友」安雅，甚至拿安雅當藉口抗拒一些事。明明泰迪也知道安雅不是真的，而且更惱人的是，泰迪的畫竟然從起初充滿童稚的塗鴉，逐漸多出一個長髮飄飄、面貌猙獰的女人，甚至一些不可思議、貌似凶案的場景。
 
　　瑪洛莉覺得事有蹊蹺，也感受到泰迪爸媽抗拒面對，然而當她展開調查，卻只見泰迪的塗鴉「越演越烈」。
　　
　　某日鄰居老婦在閒聊中，透露了這屋子的過去：一名神祕的女人、一樁奇特凶案……
　　但是讓瑪洛莉更驚慌的是，泰迪的「寫實風格」圖畫與那個案件，越來越接近……
 
　　※榮登今日美國、亞馬遜書店、美國獨立書商、出版人週刊、蘋果iBooks電子書等各大暢銷榜
　　※Netflix搶下改編權，Goodreads書評網恐怖小說票選冠軍！
　　※亞馬遜書店最佳驚悚懸疑選書，全球版權售出30國', N'正常', 17)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (31, N'不便利的便利店', 400, N'金浩然', N'文學小說', N'不便利的便利店.png', N'人生就是會有很多不便利、不舒服，
這間有點慘澹的便利店，卻為我們撐起了閃閃發光的空間……

艱難時刻的光亮之書
一間便利店，接通了我們的幸福人生

　　★韓國年度最受歡迎小說
　　★銷售破70萬冊，25個都市特選年度之書
　　★Yes24年度之書，韓國各大書店排行榜總冠軍，口碑直追《歡迎光臨夢境百貨》  
　　★電子書平台「米莉的書齋」年度圖書第二名
　　★韓國中央圖書館館員推薦之書
　　★售出泰、日、簡中、台灣、越南、印尼等多國版權
　　★影視改編熱烈進行中

　　◎全球獨家收錄：作者手寫給台灣讀者的問候箋

　　這間有點不便利，卻讓人想一再前往的便利店，
　　藏著能在艱難生活中給你安慰的各樣物品。

　　買一送一的喜悅、三角飯糰模樣的悲傷，
　　以及一萬元所帶來的四次歡笑，
　　充滿特別的故事與奇妙商品組合的便利店，時時歡迎您！

　　廉女士搭火車途中，驚覺錢包不見了，此時一通電話來告知，說在車站撿到了包包，還嚅囁詢問能否借用點錢買便當吃。廉女士答應了。

　　果然如她所想，對方是一名流浪漢。廉女士在拿回包包時，告知對方，歡迎他來自己經營的便利店吃便當。

　　這間便利店生意不太好，店員更是各種邊緣人的組合：上了年紀還為子女操碎了心的婦人；準備公務員考試多年的年輕女孩；五十多歲靠微薄薪水養家的一家之主。而廉女士為了如同家人般的員工，努力把店鋪撐了下來。

　　然而，大夜班店員突然辭職，讓她苦惱不已。就在這時，常來吃報廢便當的流浪漢竟陰錯陽差接下這份工作……

　　只差一點點就陷落於孤立和衝突的人生，
　　如何在這個小小的空間裡悄悄獲得喘息？
　　一間不夠便利的便利店，又如何接通大家的幸福人生？

　　◎便利店「幫人生加值」小語
　　※我問，支持妳的力量究竟是什麼？
　　她說，人生本來就是不斷解決問題，既然都要解決問題，那就努力選還可以的問題來解。

　　※便利店是個人們來來去去的空間，無論店員還是客人，都只是短暫停留的過客。便利店就像間加油站，讓人們用物品或金錢為自己加值。

　　※為什麼開心？因為炸雞？因為爸爸的陪伴？其實無論是什麼都沒關係，因為能一起吃雞的就是家人。

　　※人生就是關係，關係的根本就是溝通。我發現只要我們能跟身旁的人交心，幸福其實離我們不遠。

　　※巴布狄倫的外婆曾經告訴他，幸福不是在通往目標路途上的某樣東西，而是那條路本身就是幸福。你所遇見的每個人，都在苦苦掙扎著與什麼對抗，所以你必須親切待人。', N'正常', 15)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (32, N'心很小 裝喜歡的事就好', 420, N'黃山料', N'文學小說', N'心很小 裝喜歡的事就好.png', N'請你不要傷害我的心，
因為心裡面住的是你。
 
――誠品年度暢銷 總冠軍 黃山料――
描寫家庭關係．心靈救贖小說
 
那些讓我失望的人，也許還能給我愛？
 
　　★蟬連三年 誠品「年度暢銷冠軍」
　　★總銷量破30萬本 華文暢銷作家
 
　　「對不起，我不該這樣……」 
 
　　她緊緊擁抱我，這已是制式的腳本，但不管上演幾次，老套的模組，卻每一次都能奏效。因為我們在乎彼此，所以沒有什麼是一個擁抱不能解決的，如果有，那就再抱一次……
 
　　∞∞∞∞∞∞∞∞∞∞∞ 
　　壓抑自己，討好別人， 
　　這是很吃虧的， 
　　因為你若討好不成， 
　　你沒有別人，也沒有自己。 
　 
　　做自己，永遠是最划算的， 
　　因為就算你被討厭了， 
　　你至少也還有自己。 
　　∞∞∞∞∞∞∞∞∞∞∞
 
　　黃山料寫過愛情、寫過青春，這次面向家庭，挖掘世代共有的家庭故事———背負著有毒的關係，還能奔向美好生活？最珍惜的人，為何往往最破碎？越用力渴望的關係，為何越得不到？
 
　　∞∞∞∞∞∞∞∞∞∞∞  
　　不再聯繫，不是不愛，而是我們明白， 
　　不再相見，沒有傷害，已是最好的愛。
　　∞∞∞∞∞∞∞∞∞∞∞
 
　　【改編自真實故事】
　　隨著書中女主角小恩，看見親情勒索、手足裂痕，層層堆疊的痛苦，她決意離家出走，成了北漂青年。奮力生存的日子裡，接連出現她身邊的善意與惡意，催促著成長、也扼殺了最後一吋的溫柔。 
 
　　然而，在被城市的慾望吞噬之前，小恩終於揭開瘡疤，看見腐爛傷口下的祕密……
 
　　∞∞∞∞∞∞∞∞∞∞∞ 
　　痛苦不該被比較， 
　　因為你永遠不知道，
　　你的雲淡風輕， 
　　也許已是他的深淵谷底。 
　　∞∞∞∞∞∞∞∞∞∞∞
 
　　不是每個家都有一盞溫暖燈光，那些欠缺的陪伴、經年累月的誤解、說不出口的真心話，從失望積攢成絕望，我們還能期待些什麼？
 
　　作者寫下：「不必對每件事情有感覺，不必對每個情緒有反應，你的時間不多、溫柔有限，留一分，給必要的人，其餘九分，留給自己。」
 
　　∞∞∞∞∞∞∞∞∞∞∞
　　生活最好的狀態是，
　　在一個人的生活，自得其樂；
　　在別人的世界裡，順其自然。
　　心之所向，便是陽光。
　　∞∞∞∞∞∞∞∞∞∞∞
 
　　黃山料再次帶來療癒人心的救贖，
　　描繪人最重要的能力，
　　是悲傷時不忘快樂、
　　是在谷底裡望向天空。
　　 
　　要相信，
　　壞事會慢慢過去，好事會慢慢靠近，
 
　　心很小，裝喜歡的事就好，
　　帶著願望與念想，
　　你一定會奔向更好的生活。', N'正常', 21)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (33, N'原子習慣：細微改變帶來巨大成就的實證法則', 330, N'詹姆斯‧克利爾', N'商業理財', N'原子習慣：細微改變帶來巨大成就的實證法則.png', N'　　每天都進步1%，一年後，你會進步37倍；
　　每天都退步1%，一年後，你會弱化到趨近於0！
　　你的一點小改變、一個好習慣，將會產生複利效應，
　　如滾雪球般，為你帶來豐碩的人生成果！

　　一出版立刻風行全球，
　　企業界、運動界、教育界、瘦身界都在用的習慣養成實作指南！

　　★Amazon、《紐約時報》《華爾街日報》《今日美國報》《出版人週刊》暢銷書！
　　★商業雜誌《Fast Company》評為2018年7本最佳商業書之一！
　　★《商業內幕》（Business Insider）網站選為2018年最佳自我成長書籍！
　　★職涯網站The Muse推薦：最能幫助你增進工作效率的書！

　　善用「複利」效應，讓小小的原子習慣利滾利，滾出生命的大不同！
　　天天細微改變，會累積成巨大差異，這就是原子習慣的驚人力量！

　　本書作者詹姆斯‧克利爾在高二的一場棒球賽中意外被球棒擊中臉，嚴重受傷，甚至被實施人工昏迷。經過好幾個月的治療，雖然痊癒出院，可以重新踏上球場，後來也進入大學棒球隊，卻只能坐在板凳席，幾乎沒有上場機會。

　　然而，在頭部嚴重受傷之後的第六年，他被選為他所就讀大學的最佳男性運動員，並且入選ESPN的全美明星陣容——整個美國僅有33人獲得這項殊榮。

　　從運動生涯幾乎結束，到入選全美明星陣容，甚至在畢業時獲得學業方面的總統獎章，他是怎麼做到的？一切只因他認識且善用了「原子習慣」的力量！

　　◎有效建立永久良好習慣的系統化「行為改變四法則」
　　雖然知道習慣很重要，但你經常為了自己的壞習慣苦惱，想要戒除卻力不從心？或者，你想養成好習慣，卻老是半途而廢？其實，問題不在你身上，而是你遵循的行為改變系統出了問題！

　　作者從生物學、心理學及神經科學中擷取菁華，結合自己親身實踐的經驗，創造出簡單易懂、容易執行的「行為改變四法則」。這套法則可運用於學業、工作、家庭、健康、財富、人際關係等人生各個面向，有效幫助你打造好習慣、戒除壞習慣。

　　◎風行各界的習慣養成指南
　　本書作者是世界知名的習慣養成專家，經常受邀到各界演講，例如NFL、NBA、MLB的球隊，以及美國運通、麥肯錫、美林證券、奇異公司、本田汽車、思科系統、IKEA等知名企業。

　　本書提供的系統性方法不只適用於個人，還能運用在……
　　‧商業：讓顧客養成購買你的產品或服務的習慣
　　‧親子教養：讓孩子養成良好的生活習慣
　　‧教育：讓學生建立良好的讀書習慣

　　◎你可以在這本書中學到的10件事：
　　‧建立一套每天進步1%的系統
　　‧戒除壞習慣，保持好習慣
　　‧避免多數人在改變習慣時常犯的錯
　　‧克服「缺乏動機和意志力」的問題
　　‧建立更強大的身分認同與信心
　　‧騰出時間建立新習慣（即使你忙瘋了）
　　‧設計讓你更容易成功的環境
　　‧做出可以造就巨大成果的微小改變
　　‧在養成好習慣的路上走偏時回到正軌
　　‧將本書中提到的概念運用在實際生活中', N'正常', 17)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (34, N'底層邏輯：看清這個世界的底牌', 400, N'劉潤', N'商業理財', N'底層邏輯：看清這個世界的底牌.png', N'         你真的相信眼睛所看到的一切嗎？
 
　　事實是最不容易產生爭議的客觀存在嗎？
　　或許，我們對事實的瞭解，還不夠全面。
　　或許，我們是被表象或經驗欺騙、迷惑，導致看不透事情的本質。
 
　　唯有透過「底層邏輯+環境變數」，
　　才能讓你在千變萬化的世界中，認清所有真相！
 
　　當一個人持有的不是觀點而是立場時，你應該做的事情，是對他說「It’s good for you」（這對你有益）。
　　反過來，我們也要時刻反省自己：我說的話、我的表述，是事實，是觀點，是立場，還是信仰？
 
　　請運用以下幾點：
　　一.拋棄經驗，不要輕易下結論，懷著空杯心態去看問題。
　　二.運用「假設—驗證—結論—調整」，大膽假設，小心求證，得出結論，做出調整。
　　三.不要被利益、立場左右，就事論事。
 
　　能做到以上三點，再複雜、繁瑣的事，你也能抽絲剝繭、洞察本質。
 
　　為什麼我們要懂「底層邏輯」？
 
　　如果你是學生，透過底層邏輯能學會：思考問題的邏輯
　　˙懂得辯證真理
　　˙獲取解決問題的方法
　　˙洞察事情的本質
 
　　如果你是職場新鮮人，透過底層邏輯能學會：個人進化的方法
　　˙做好時間管理
　　˙讓事情產生最大效益，創造十倍價值
　　˙培養良好人脈
 
　　如果你是創業者或企業管理者，透過底層邏輯能學會：公司營運的順暢
　　˙獲取正確的戰略
　　˙掌控利潤
　　˙留住優秀員工
 
　　本書可以幫忙你思考：
　　˙找工作時，正確思考想學習與得到什麼？
　　˙和朋友交往時，如何拉長時間觀察，不因小事而漸行漸遠？
　　˙獲取人脈時，要如何互相幫忙達到雙贏的局面？
　
專文審定
 
　　商業思維學院院長 游舒帆   
　　「這不是我第一次閱讀劉潤的書，他的每本書的思路都很獨特，觀點也很有趣，同時充滿洞見。如果你想知道他是怎麼思考，怎麼理解問題，怎麼產生洞見的，我相信這本《底層邏輯》應該可以讓你一窺一二。」', N'正常', 9)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (35, N'一如既往【附贈美金1元限量版】：不變的人性法則與致富心態', 450, N'摩根．豪瑟', N'商業理財', N'一如既往【附贈美金1元限量版】：不變的人性法則與致富心態.png', N'　　關於金錢、歷史與人性不變的23件事

　　全球暢銷書《致富心態》作者全新力作
　　迎接難以預測的未來與種種人生挑戰最有效的新工具

　　綠角、雷浩斯、陳鳳馨、財女Jenny 好評推薦
　　☆ Amazon 4.5星好評
　　☆ 出版即登紐約時報暢銷榜
　　☆ 誠品、博客來、金石堂一致推薦選書

　　人們在設立投資計畫時，都講求精確的數據、對未來的預測，以及合乎常理的邏輯。但是，我們很常看到的狀況是：結果不如預期、受到情緒影響而更動計畫、預測完全失準，或是被突如其來的事件給打擊。

　　本書作者摩根‧豪瑟指出，與其拚命預測不確定的事件，我們應該花更多時間去理解恆常的行為。不論是投資或人生，都應該反其道而行：回頭看，而且視野要廣闊，並且專注在不曾改變的事物。

　　本書延續前作，作者以各式各樣極具說服力的案例，交織絕佳的故事編排手法，用最平實的敘述，帶讀者了解關於風險、機會、數據、誘因、情緒與人性的真實面。你可以從中學到：

　　＊要根據人的行為方式做預測，而不是根據特定事件做預測。
　　＊想要活得幸福快樂，管理期望非常重要。
　　＊股價是今天的數字乘以明天的故事。
　　＊無法測量與預測的事，在商業與投資領域是最強大的力量。
　　＊要知道股價高點在哪裡，唯一的辦法就是讓市場漲過頭。
　　＊最好的財務規畫是像悲觀主義者一樣儲蓄，並且像樂觀主義者一樣投資。
　　＊一項完美的能力，是以犧牲另一項攸關存亡的能力為代價。

　　每個人都想看到未來的商業、經濟、政治到社會趨勢，但我們都不擅於預測未來發生的事情，唯有當你不再執著於預測未知，專注在恆久不變的事，才能在人生與投資路上獲得最大的滿足與成就。', N'下架停賣', 0)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (36, N'持續買進：資料科學家的投資終極解答，存錢及致富的實證方法', 400, N'尼克．馬朱利', N'商業理財', N'持續買進：資料科學家的投資終極解答，存錢及致富的實證方法.png', N'★聽說「逢低買進」是投資穩賺策略？
錯！最強資料科學家告訴你：
千萬別為了抄底，浪費時間在市場外觀望，
「持續買進」才是致富不敗法則！
★《原子習慣》、《致富心態》作者一致強推，
出版即登亞馬遜投資類暢銷冠軍、
BookAuthority評選2022年最佳財經書
 
　　●當資料科學家研究起股市……
　　「等待抄底好時機」、「不要把雞蛋放在同一個籃子裡」、「低買高賣」……投資世界充滿了豐富的詞彙、睿智的專家，提出各種穩賺策略。你是不是深感認同，全盤接受？
 
　　 然而，身兼資料科學家和財富管理專家的尼克．馬朱利表示，這時候，你需要依賴數據與證據，而不是盲信與猜測。因為各種長久存在的看法並不總是對的，不適用於每個人或每種情況。
 
　　馬朱利出身普通家庭，上大學前連股票是什麼都不知道，每天擔心錢不夠用，因此對金錢產生嚴重焦慮感，讀過許許多多投資書及文章，並忠實遵循了作法，然而他對未來的恐懼絲毫沒有消失。為了解開金錢的迷團，他拿出身為數據科學家的專業分析股票市場，創辦「金錢與數據部落格」（OfDollarsAndData.com），持續發表以數據分析為基礎的投資理財文章，將看來枯燥的數據化為生動又人人能懂的故事，成為財經界最有特色的部落格。
 
　　●持續買進的力量，就像原子習慣一樣強大
　　他分析了近百年股市數據後，得出的終極答案是——最安全可靠的賺錢方式是「持續買進」，就是這麼簡單！不需要分析公司價值，也不需要判斷是牛市還是熊市。 就像原子習慣一樣，最重要的是「持續做」。 這也就是「成本平均法 」（DCA），即使是上帝也無法擊敗成本平均法的報酬率！
 
　　馬朱利以嚴格的數據和證據挑戰已深入人心（但似是而非）的投資假設，結論常與我們的直覺相悖，讓人大感意外，例如：
 
　　‧你不該手握現金等逢低買進：你一心等待的低點可能遲遲未來，結果市場持續上揚，錯失了多月（或更久）的複利成長，績效遠遠落後於「盡快買，經常買、持續買」。
 
　　‧不買個股，買ETF：根據1926年至 2016 年美國股市的研究，只有4% 的個股表現優於國債（埃克森美孚、蘋果、微軟、奇異和 IBM）。你有信心選到的是 4% ，而不是96%嗎？除非你是選股高手，否則追蹤大盤指數的ETF才適合你。
 
　　‧大幅修正是買進的好機會：你不必害怕在牛市裡一買進就下跌。數據指出，投資1920年至2020年間跌幅超過五成的時期，未來年報酬率超過25%！
 
　　‧買房是好投資嗎？：在1972 年至2001 年間，把每月繳房貸的錢拿來投資S&P 500指數，並把股息再投資，將能賺到四倍報酬，還不包括買房的稅金、修繕等成本。如果你買房不是為了自住，租房就好。
 
　　‧FIRE（財務獨立、早早退休）是辦得到的，但是你不一定要FIRE：沒錯！4% 法則（退休的儲蓄是退休後第一年的預期支出的25 倍）就可以退休，而且研究指出你每年會越花越少，但是你最該想清楚的，不工作，生活裡能找得到哪些意義、維持哪些關係。
 
　　《持續買進》針對根深柢固的投資迷思一一破解，包含股票、債券、房地產、儲蓄、卡債、退休帳戶……，立論嚴謹、有理有據，難能可貴地把實證資料講得新鮮有趣、引人入勝，更重要的是提供每個人都務實可行的建議。不論是投資新鮮人或老手，都能從馬朱利的投資概念與方法獲益。
 
本書特色
 
　　1.資料科學家／投資專家二刀流！用數據破解似是而非的投資觀念謬誤
　　投資不能靠直覺，更不能道聽途說！資料科學家用數據說話，以機智風趣的文章挑戰根深柢固的投資假設（包括要存錢、抄底、買／租房等迷思），引導讀者客觀思考、一改舊思維，建立正確投資心態和習慣。
 
　　2. 資料科學家的投資終極解答——無論牛市、熊市，「持續買進」才能穩紮穩打累積財富！
　　用數據探索投資的終極答案，跟我們想的不一樣！如果你擁有神一般的預測牛市、熊市能力，似乎應該「逢低買進」，很遺憾，數據告訴我們，逢低買進的績效不如「立刻買、持續買」，因為即早投資、參與股市，複利會發揮想像不到的力量。普通人的致富之路，本來就是這麼簡單。
 
　　3.新鮮角度＋完整架構，充滿洞見與智慧
　　本書完整帶出投資觀念與工具，且給予各種財務狀況建議，指出累積財富立即可行的道路，每位投資人都能獲得啟發。', N'正常', 19)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (37, N'逆思維：華頓商學院最具影響力的教授，突破人生盲點的全局思考【博客來獨家書封版】', 420, N'亞當．格蘭特', N'商業理財', N'逆思維：華頓商學院最具影響力的教授，突破人生盲點的全局思考【博客來獨家書封版】.png', N'想法轉個彎，人生路更寬！

2023年博客來Q1暢銷總榜NO.1熱銷書！
2023年博客來上半年暢銷榜「商業職場類」NO.1熱銷書！
博客來「BOOKS POWER大賞」讀者票選最愛非文學書！
 
《給予：華頓商學院最啟發人心的一堂課》暢銷作家、
「正向心理學」權威亞當．格蘭特 重量級代表作！
 
如果正門進不去，就尋找側門，
假使計畫行不通，就改變作法。
翻轉危局的解答並不一定在前方，
而在你的每一個「想不到」裡。
 
　　● 面對無法撲滅的森林大火，最好的逃生方式竟然是「放火」？
　　● 一旦水溫變熱，青蛙就會受不了跳出去，所以「溫水煮青蛙」永遠不可能發生？
　　● 為什麼皮克斯不延續《玩具總動員》的成功經驗，反而希望團隊「唱反調」？
　　● 沒有任何證據顯示星座影響性格，但為何我們還是對星座分析著迷不已？
　　● 五年內從全美一半的市占率暴跌到1 %，黑莓機到底做錯了什麼？
 
　　每個人都習慣以最舒適的方式思考，不願懷疑或挑戰自我，因為「質疑」會讓世界變得難以預期，甚至威脅到自我認同，於是，我們的成見不斷延續，聰明成為盲點，害怕改變的「順思維」讓我們選擇劃地自限。
 
　　若想要突破自我限制，就必須建立「科學家」的「逆思維」，打破成規，大膽反思。不同於信仰堅定的「牧師」，或是巧舌如簧的「政客」，「科學家」不會讓自己的想法成為意識形態，也不會妄下定論，而是會讓問題帶領我們前進，關鍵不在於誰對誰錯，而是明白自己的欠缺與不足。
 
　　從自己到他人，從他人到群體，從群體到社會。「逆思維」幫助我們用開放的心態，提升心智的彈性，建立良性的衝突，在瞬息萬變的世界中找到平衡點。真正的「知道」，就是承認自己的「不知道」。只要謹慎思考，凡事再想一下，就能掙脫成見枷鎖，突破認知盲點，掌握永不被淘汰的核心競爭力！', N'正常', 10)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (38, N'ChatGPT 4 + API創新體驗AI世界邁向開發機器人程式王者歸來（全彩印刷）', 780, N'洪錦魁', N'電腦資訊', N'ChatGPT 4 + API創新體驗AI世界邁向開發機器人程式王者歸來（全彩印刷）.png', N'ChatGPT-4 與API
創新體驗 AI 世界邁向開發機器人程式
王者歸來（全彩印刷）

★★★★★【AI體驗邁向開發設計】★★★★★
★★★★★【深度解析ChatGPT、Bing AI、API】★★★★★
★★★★★【文字】【繪圖】【音樂】【動畫】【影片】★★★★★
★★★★★【設計實例最多/應用最廣的聊天機器人】★★★★★
★★★★★【獨家設計會聽會說的電話客服機器人程式】★★★★★
★★★★★【網頁、Line、Excel平台設計機器人程式】★★★★★

　　這本書基本上是先前著作「ChatGPT-4 Bing Chat創新體驗文字/繪圖/音樂/動畫/影片的AI世界」內容的擴充。「第一篇：創新體驗 ChatGPT 與 Bing 的 AI 世界」，重點是如何應用目前已有的AI產品。「第二篇：開發 AI 機器人程式設計」，重點是開發與設計AI機器人。研讀本書，讀者可以獲得下列多方面的知識：

　　【深度認識ChatGPT】
　　★ GPT-3.5與GPT-4的差異
　　☆ 了解Vision GPT-4和No Vision GPT-4的區別
　　★ 說明為何用繁體中文對話，可是ChatGPT回應是簡體中文
　　☆ 客製化個人特色的ChatGPT
　　★ 使用個人名字或是匿名分享對話記錄
　　☆ 備份或用PDF儲存對話紀錄
　　★ 認識與使用ChatGPT App
　　☆ 徹底認識Prompt

　　【生活應用】
　　★ 建立圖文並茂的對話
　　☆ 建立圖文並茂的簡報
　　★ 旅遊知識與行程規劃
　　☆ 建立英文學習機與英文翻譯機
　　★ 口說與英文聽力練習
　　☆ 創作短、中或長篇小說
　　★ 詩詞創作
　　☆ 代寫含莎士比亞或詩詞的邀約信件
　　★ 你忠實的交友顧問

　　【股市應用】
　　★ 獲得單一股票訊息
　　☆ 股票技術分析

　　【教育應用】
　　★ ChatGPT是你的活字典
　　☆ 協助摘要、心得、報告、專題撰寫
　　★ 依據程度學習體驗
　　☆ 教師講義、問卷、考試題目

　　【企業應用】
　　★ IG貼文格式、銷售建議
　　☆ 行銷文案與活動
　　★ 拍攝行銷活動的腳本設計
　　☆ 面試者與面試官
　　★ 企業公告
　　☆ 加薪與企業談判議題
　　★ 提升Excel的工作效率到輔助工作分析

　　【Chrome商店ChatGPT-3.5/4.0的插件擴展應用】
　　★ ChatGPT for Google – 回應網頁搜尋
　　☆ WebChatGPT – 網頁搜尋
　　★ Voice Control for ChatGPT – 口說與聽力
　　☆ ChatGPT Writer – 回覆訊息與代寫電子郵件

　　【GPT-4官方認證的插件軟體】
　　★ Wikipedia – 知識百科
　　☆ Earth – 地圖大師
　　★ Prompt Perfect – 完美提示
　　☆ Show Me Diagram – 圖表生成
　　★ Speaker – AI語音導師
　　☆ Speechki – 文字轉語音
　　★ VoxScript – 網頁/影片摘要神器
　　☆ WebPilot – 瀏覽或搜尋網頁資料
　　★ ChatWithPDF – 閱讀與整理PDF
　　☆ Wolfram – 科學計算與精選知識
　　★ Noteable – 數據視覺化分析與探索
　　☆ Expedia – 旅遊網站

　　【深度解析Bing Chat】
　　★ 認識平衡/創意/精確交談模式
　　☆ 體驗文字/語音/圖片的多模態輸入
　　★ Bing Chat的圖片搜尋
　　☆ Bing Chat側邊欄的加值
　　★ Bing Image Creator, AI繪圖
　　★ Bing App

　　【AI創意時代】
　　★ AI繪圖使用Midjourney
　　☆ 打造AI影片D-ID
　　★ 打造你的AI代言人
　　☆ AI音樂Soundraw
　　★ Google未公開的音樂神器musicLM
　　☆ 讓你的照片動起來Leiapix

　　【學習Python程式設計】
　　★ ChatGPT 輔助學習 Python 語法與繪製流程圖
　　☆ 重構與重寫你的程式
　　★ 擔任直譯器角色
　　☆ 多程式語言能力- 協助不同程式語言的轉換

　　【設計股票程式】
　　★ 全球股市查詢，計算均線
　　☆ 尋找股票買賣時機- 台積電股票

　　【最全面的機器人程式設計】
　　★ 客服、健康諮詢、翻譯、語法修正與含 Emoji 的聊天機器人
　　☆ 設計英語發音與聽力學習機器人
　　★ 會聽會說的「電話客服機器人」

　　【網頁版的機器人】
　　★ 網頁版機器人的特色
　　☆ AI 聊天機器人網頁分享

　　【Line Bot 機器人】
　　★ ChatGPT 智慧移入 Line Bot 機器人

　　【Excel 平台開發聊天機器人】
　　★ 基礎聊天機器人
　　☆ 情感分析機器人', N'正常', 1)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (39, N'Excel x ChatGPT入門到完整學習邁向最強職場應用王者歸來(全彩印刷)', 760, N'洪錦魁', N'電腦資訊', N'Excel x ChatGPT入門到完整學習邁向最強職場應用王者歸來(全彩印刷).png', N'Excel x ChatGPT
入門到完整學習x邁向最強職場應用
王者歸來
(全彩印刷)第3版
 
★★★★★【內容最廣】【技巧最全面】★★★★★
★★★★★【33個主題】【832頁內容】【608個實例】★★★★★
★★★★★【2600張Excel說明畫面】【170個圖表】★★★★★
 
　　這是目前市面上內容最完整的Excel書籍，全書有33個主題，使用約608個實例，相較於第2版增加與修訂了超過60處，主要是增加下列資料：
 
　　★ 多了約50個實例解說更完整的Excel知識
　　☆ ChatGPT輔助學習Excel、函數與Excel VBA
　　★ 認識網路版的Excel
　　☆ 用選單輸入資料
　　★ 2D區域地圖
　　☆ 3D地圖
　　★ 加值你的Excel – 增益集
　　☆ 整合ChatGPT功能，在Excel內建立聊天機器人
 
　　這是一本適用零基礎的人開始解說的Excel書籍，整本書從Excel視窗說起、儲存格輸入資料、建立表單與圖表、一步一步引導讀者建立淺顯易懂、美觀、設計感、專業資料呈現的表單與圖表，最後成為令人尊重的專業職場達人。本書除了說明各功能用法，更強調解說Excel功能的內涵與精神
 
　　★ 全書約2600張Excel說明畫面
　　☆ 約608個Excel檔案實例
　　★ 全書約170個圖表
　　☆ 講解基本Excel功能，同時專業化報表與圖表。
　　★ ChatGPT輔助解說
　　☆ 完整解說人事、財會、業務、管理、分析
　　★ 解說註解與附註的用法與原始精神
　　☆ 為特定儲存格的進行資料驗證
　　★ 建立、編輯、美化工作表 
　　☆ 充分發揮公式、函數功能，高效率使用工作表
　　★ 建立與編輯專業的圖表，同時解析適用時機
　　☆ 建立清單統計資料
　　★ 建立專業的樞紐分析表
　　☆ 用Excel執行規劃與求解，執行業績預測分析
　　★ 認識分析藍本管理員
　　☆ Excel圖表嵌入PowerPoint簡報檔案
　　★ Excel與Word合併列印文件
　　☆ 處理大型Excel工作表，可以使用分頁預覽
　　★ 巨集與巨集病毒解說
　　☆ Excel VBA基礎
　　★ 資料剖析
　　☆ 保護儲存格區間、工作表、活頁簿
　　★ 不同語言的翻譯與轉換
　　☆ 圖片、圖案、圖示與3D模型
　　★ SmartArt圖形的應用
　　☆ 將圖片嵌入儲存格
　　★ Excel的浮水印
　　☆ Excel與Word、PowerPoint軟體協同作業
　　★ Excel與文字檔、CSV檔
　　☆ Bar Code條碼設計
　　★ 2D與3D地圖
　　☆ Excel增益集
　　★ 整合ChatGPT建立聊天機器人', N'正常', 13)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (40, N'Power BI x Copilot x ChatGPT 商業報表設計入門：資料清理、資料模型、資料視覺化到報表共享建立全局觀念', 630, N'戴士寶', N'電腦資訊', N'Power BI x Copilot x ChatGPT 商業報表設計入門：資料清理、資料模型、資料視覺化到報表共享建立全局觀念.png', N'　　在這個以數據為核心的時代，企業的數據轉型不再是選擇，而是必然。《PowerBI x Copilot x ChatGPT 商業報表設計入門：資料清理、資料模型、資料視覺化到共享報表建立全局觀念》是一本為這一轉型需求而生的專業書籍。作者戴士寶 Stark，憑藉在 Power BI 領域的豐富經驗，為讀者提供全面而深入的學習途徑。
　　
　　本書從「資料流」的視角切入，全面介紹 Power BI 的各個方面，從資料清理、資料模型建構，到資料視覺化和雲端分享報表等。對於初學者而言，這本書從第一頁到最後一頁是一個完整的學習路徑，可以逐步掌握 Power BI 的各項工具和技能。對於已經有一定經驗的 Power BI 使用者，本書提供了新的視野和啟發，在現有基礎上進一步提升。
 
　　在書中亦引入了 Copilot 和 ChatGPT 等 AI 工具，使讀者在學習過程中能夠更高效地解決問題。此外，書中豐富的實戰案例和 Stark 的「無私分享」和「無私小撇步」，不僅豐富了讀者的操作技巧，更深化了對 Power BI 應用場景的理解。
 
　　尤其值得一提的是，書中對資料視覺化的深入探討和實作指導，透過詳細講解 Power BI Desktop 的強大功能，如欄位參數、深度鑽研分析和客製化工具提示等，使讀者更能夠充分發揮 Power BI 的潛力。
 
　　本書是一本既適合初學者又能滿足有經驗使用者需求的實用工具書。它不僅提供了全面的技術知識，更是一個實戰平台，讓讀者能夠將學到的知識直接應用於實際工作，有效推動個人和企業的數據轉型進程。
 
本書特色
 
　　本書以其獨特的視角和實用性，為讀者提供了一個全面學習 Power BI 的絕佳機會。特色包括：
 
　　●資料流導向學習：這是業界唯一從「資料流」的角度出發，全面深入地介紹 Power BI 的書籍。內容覆蓋從資料清理、資料模型構建，到資料視覺化及雲端分享報表等各階段的重要工具和技巧。
 
　　●結合 AI 工具：書中巧妙融合了 Copilot 與 ChatGPT 這兩項先進的 AI 工具，協助讀者有效解決問題，提升學習和應用的效率。
 
　　●實戰案例分析：每章都配有大量貼近實際工作場景的案例，幫助讀者將所學知識迅速應用於工作之中，從理論到實踐一氣呵成。
 
　　●Stark 的經驗分享：書中包含「Stark 無私分享」及「Stark 無私小撇步」單元，Stark 將自己多年來的經驗和心得毫無保留地傳授給讀者，讓操作細節更加精準有效。
 
　　●資料視覺化專案實作：書中以實際專案為例，指導讀者掌握 Power BI 的強大功能，如欄位參數、鑽研分析和客製化工具提示等，讓讀者能夠充分發揮 Power BI 的潛力。
 
　　●持續學習的支援：Stark 在他的 Instagram、部落格、電子報等媒體持續提供學習文章以及新功能分享。
 
　　●全彩印刷：詳細的操作與視覺化過程，用彩色呈現更能所見即所得。', N'正常', 17)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (41, N'ChatGPT 4 Turbo 萬用手冊 2024 春季號：提示工程、超強外掛、My GPTs、OpenAI API、Midjourney、Copilot、Bard、Claude 2', 680, N'蔡宜坦, 施威銘研究室', N'電腦資訊', N'ChatGPT 4 Turbo 萬用手冊 2024 春季號：提示工程、超強外掛、My GPTs.png', N'\ 懂得運用 AI 就不怕被淘汰 //

ChatGPT 問世滿一年, 威力和能耐仍持續激增,
不斷讓人驚呼：「沒想到這樣也可以」！
不只是好玩, 經過一年摸索,
ChatGPT 已融入大家的工作日常之中,
是的, AI 生產力的時代真的來了！

▌全球第一的 ChatGPT 專書 ▌
▌題材最新、最完整、最豐富 ▌

　　ChatGPT 是真正稱得上殺手級應用的 AI 產品, 除了擁有接近人類語言的對話能力, 讓一般使用者為之驚艷外, 更重要的是, OpenAI 開創了一條全新的康莊大道, 拋開技術的束縛, 讓任何人用口語化的自然語言就可以輕鬆跟 AI 溝通, 甚至客製化自己專屬的機器人, 毫無開發的門檻, 也迅速帶動後續許多 AI 應用和產業鏈的發展。

　　跟著我們的腳步, 你會學到讓 ChatGPT 好好說話、三思而後行的提示原則, 還有上百個可直接套用的現成範本, 像是：模擬面試、撰寫社群貼文、草擬存證信函、英文寫作批改、不菜市場的命名、問卷設計、生成投影片、高點擊率文案…等基本應用, 也會有貼心小天使幫你生成程式碼, 還可以幫忙除錯、註解、寫說明文件、轉換語法、資料分析等, 還有編輯嚴選的各種外掛、第三方 GPT 機器人、AI 繪圖工具、自動化流程、免費的 AI 替代服務等應用, 更棒的是會帶你客製化 ChatGPT, 用自然語言打造各種不同應用的機器人, 內容豐富、成就感滿滿。

　　無論您是最熱血的行銷、企劃、人資、行政、秘書、助理等基層人員, 還是最有才的資料分析師、專案經理、自媒體創作者、直銷團隊、教職人員、線上講師等專業人士, 本書都能帶領你一起探索 ChatGPT 的世界。

本書特色

　　【要學 ChatGPT, 就要選最新、最即時、最完整的！】
　　本書配合 ChatGPT 大更新, 融入最新的多模態模型和 My GPTs 客製化功能, 搭配功能升級的網路瀏覽和外掛功能, 全面更新 ChatGPT 的操作技巧, 並以當前最新的 GPT-4 Turbo 模型為核心, 同時也兼顧 GPT-3.5 模型。

　　除了 ChatGPT 官方功能, 也會介紹好用的第三方外掛和 GPT 機器人, 還有 Copilot (Bing AI)、Bard、Claude 2 這些盟友同場競技, 也結合超熱門的 Midjourney、DALL-E 3、Leonardo.Ai、Playground AI 等生成式 AI 服務。

　　想要參透 ChatGPT 有多強？
　　想要知道 ChatGPT 又有哪些新應用？
　　現在就跟著 AI 一起動起來, 翻轉新世代的競爭力！

　　【打造無極限的最強 ChatGPT 機器人】
　　★ 用自然語言設計你專屬的 ChatGPT
　　★ 多模態模型聰明切換, 看得見、說得出、做得到
　　★ 善用瀏覽外掛找資料, 突破任何時間限制
　　★ 直接摘要精華片段, 不用花大把時間看影片
　　★ 論文、資料讀不完, 讓 ChatGPT 幫你畫重點
　　★ 沒錢升級？免費 Claude 2、Bard、Copilot 也很好用

　　【跟 AI 溝通必學的提示工程，現成範本即學即用】
　　★ 融合吳恩達大神的提問建議, 一試見效！
　　★ 跟 ChatGPT 玩角色扮演, 專家說法有模有樣
　　★ 階段式、多回合問法, 幫寫文章還能自己審稿
　　★ 讓 ChatGPT 動動腦, 多想一下不出錯
　　★ 讓你的 Siri 更聰明！用手機跟 ChatGPT 對話

　　【小天使幫寫 Code！你也是 AI 工程師】
　　★ 零門檻客製化 GPT 機器人, 還有免費現成的可以用
　　★ 讓 ChatGPT 幫你寫程式, 用 Python 處理大小事
　　★ 用說的就能做資料分析, 補缺值、視覺化還能幫建模
　　★ 用 Power Automate 打造本地/雲端 Chatbot

　　【智慧化的 AI 辦公室, 大幅提升工作效率】
　　★ 雜亂無章的原始資料, 一秒井然有序變表格
　　★ 讓 ChatGPT 幫你設計問卷、做文書處理
　　★ ChatGPT 幫你生成函數公式、還能圖表分析
　　★ 自動生成大綱, 再快速轉成簡報檔

　　【讓 ChatGPT 帶你活用 AI 神繪師】
　　★ 快速上手最強的 Midjourney 繪圖
　　★ Leonardo.Ai - CP 值最高的 AI 繪圖神器
　　★ 超好用的 Canva 加上 AI 外掛, 怎能不愛上它
　　★ 新手友善的 Playground AI, 生圖、修圖全搞定
　　★ 功力大增又看得懂中文的 DALL-E 3

　　全書蒐羅數百個不同領域、各行各業的 ChatGPT 提示範本和實用技巧，將各種官方、非官方的密技, 統統挖出來讓你知道, 絕對是你所能找到, 最完整的 ChatGPT 應用大全。', N'正常', 14)
INSERT [dbo].[productBook] ([BookID], [BookName], [BookPrice], [BookWriter], [BookClassification], [BookImage], [BookDesc], [ProductStatus], [inventory]) VALUES (42, N'從零開始學 Visual C# 2022 程式設計(暢銷回饋版)', 690, N'李馨', N'電腦資訊', N'從零開始學 Visual C# 2022 程式設計(暢銷回饋版).png', N'           本書佳評如潮，暢銷回饋再版中！
 
　　這是一本針對初學者認識程式語言的入門書，是以著墨於程式語言特色和語法的形式，導引學習Visual C#程式語言，以.NET提供的類別庫為範本，配合Visual Studio 2022整合式開發環境，加上愈來愈有智慧的AI輔助IntelliSense功能，可以依據使用者撰寫程式的習慣，讓所編寫的程式保有一致性，避免不必要的錯誤。無論是使用哪一種語言，皆能在共通語言執行環境下，發展出跨平台的應用程式。對於Visual C#語言有興趣，又想要對.NET類別庫有更多認識的讀者，可透過本書獲得通盤性的瞭解。本書以最嚴謹的態度，輔以最精要的表達方式，期許能降低閱讀壓力，筆者深信本書能讓初學者經過Visual C#的學習之旅，繼而開啟編寫程式語言的更多樂趣。
 
　　／全書重要主題如下／
　　程式基礎篇
　　․ Visual Studio 2022快速入門
　　․ Visual C#與.NET
　　․ 資料與變數
　　․ 流程控制
　　․ 陣列和字串。
 
　　物件導向篇
　　․ 學習物件導向
　　․ 方法和傳遞機制
　　․ 繼承、多型和介面
　　․ 泛型、集合和例外處理
 
　　視窗工作篇
　　․ 視窗表單的運作
　　․ 通用控制項
　　․ 提供交談的對話方塊
　　․ 選單控制項和功能表
 
　　資料處理篇
　　․ 滑鼠、鍵盤、多重文件
　　․ I/O與資料處理
　　․ ADO.NET元件
　　․ 語言整合查詢-LINQ', N'正常', 2)
SET IDENTITY_INSERT [dbo].[productBook] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (1, N'蘋果', 50, N'超好吃的青森蘋果', N'1.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (2, N'橘子', 30, N'吃了有福氣的橘子', N'2.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (3, N'櫻桃', 150, N'飄洋過海的美國櫻桃', N'3.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (4, N'葡萄', 130, N'又大又甜的葡萄', N'4.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (5, N'西瓜', 40, N'不甜免錢的花蓮大西瓜', N'5.png')
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[shoppingCart] ON 

INSERT [dbo].[shoppingCart] ([shoppingCartID], [customerID], [BookID], [bookAmount], [price]) VALUES (5, 1, 1, 2, 1080)
INSERT [dbo].[shoppingCart] ([shoppingCartID], [customerID], [BookID], [bookAmount], [price]) VALUES (8, 1, 7, 2, 1080)
INSERT [dbo].[shoppingCart] ([shoppingCartID], [customerID], [BookID], [bookAmount], [price]) VALUES (9, 1, 9, 2, 1080)
INSERT [dbo].[shoppingCart] ([shoppingCartID], [customerID], [BookID], [bookAmount], [price]) VALUES (12, 3, 9, 2, 1080)
INSERT [dbo].[shoppingCart] ([shoppingCartID], [customerID], [BookID], [bookAmount], [price]) VALUES (35, 2, 7, 2, 1080)
INSERT [dbo].[shoppingCart] ([shoppingCartID], [customerID], [BookID], [bookAmount], [price]) VALUES (39, 2, 8, 2, 1080)
INSERT [dbo].[shoppingCart] ([shoppingCartID], [customerID], [BookID], [bookAmount], [price]) VALUES (40, 2, 9, 2, 1080)
INSERT [dbo].[shoppingCart] ([shoppingCartID], [customerID], [BookID], [bookAmount], [price]) VALUES (42, 2, 15, 2, 1080)
INSERT [dbo].[shoppingCart] ([shoppingCartID], [customerID], [BookID], [bookAmount], [price]) VALUES (55, 10, 27, 2, 1080)
SET IDENTITY_INSERT [dbo].[shoppingCart] OFF
GO
INSERT [dbo].[systemMaintance] ([startTime], [endTime]) VALUES (CAST(N'2023-12-18T08:58:00.000' AS DateTime), CAST(N'2023-12-18T17:03:00.000' AS DateTime))
INSERT [dbo].[systemMaintance] ([startTime], [endTime]) VALUES (CAST(N'2024-02-14T15:00:00.000' AS DateTime), CAST(N'2024-02-14T23:00:00.000' AS DateTime))
INSERT [dbo].[systemMaintance] ([startTime], [endTime]) VALUES (CAST(N'2024-02-16T00:15:00.000' AS DateTime), CAST(N'2024-02-16T00:18:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[attendance]  WITH CHECK ADD  CONSTRAINT [FK_attendance_persons2] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[customers] ([customerID])
GO
ALTER TABLE [dbo].[attendance] CHECK CONSTRAINT [FK_attendance_persons2]
GO
ALTER TABLE [dbo].[customers]  WITH CHECK ADD  CONSTRAINT [FK_persons2_persons2] FOREIGN KEY([customerID])
REFERENCES [dbo].[customers] ([customerID])
GO
ALTER TABLE [dbo].[customers] CHECK CONSTRAINT [FK_persons2_persons2]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_persons2] FOREIGN KEY([customerId])
REFERENCES [dbo].[customers] ([customerID])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_persons2]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_productBook] FOREIGN KEY([bookId])
REFERENCES [dbo].[productBook] ([BookID])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_productBook]
GO
ALTER TABLE [dbo].[shoppingCart]  WITH CHECK ADD  CONSTRAINT [FK_shoppingCart_persons2] FOREIGN KEY([customerID])
REFERENCES [dbo].[customers] ([customerID])
GO
ALTER TABLE [dbo].[shoppingCart] CHECK CONSTRAINT [FK_shoppingCart_persons2]
GO
ALTER TABLE [dbo].[shoppingCart]  WITH CHECK ADD  CONSTRAINT [FK_shoppingCart_productBook] FOREIGN KEY([BookID])
REFERENCES [dbo].[productBook] ([BookID])
GO
ALTER TABLE [dbo].[shoppingCart] CHECK CONSTRAINT [FK_shoppingCart_productBook]
GO
USE [master]
GO
ALTER DATABASE [mydb] SET  READ_WRITE 
GO
