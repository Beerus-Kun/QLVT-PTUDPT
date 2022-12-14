USE [master]
GO
/****** Object:  Database [QLVT]    Script Date: 14/12/2022 10:27:35 AM ******/
CREATE DATABASE [QLVT]
GO
ALTER DATABASE [QLVT] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLVT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLVT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLVT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLVT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLVT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLVT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLVT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLVT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLVT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLVT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLVT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLVT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLVT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLVT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLVT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLVT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLVT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLVT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLVT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLVT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLVT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLVT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLVT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLVT] SET RECOVERY FULL 
GO
ALTER DATABASE [QLVT] SET  MULTI_USER 
GO
ALTER DATABASE [QLVT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLVT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLVT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLVT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLVT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLVT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLVT', N'ON'
GO
ALTER DATABASE [QLVT] SET QUERY_STORE = OFF
GO
ALTER DATABASE [QLVT] SET  READ_WRITE 
GO
USE [QLVT]
GO
/****** Object:  Table [dbo].[CHINHANH]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHINHANH](
	[MACN] [nchar](6) NOT NULL,
	[TEN] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHINHANH] ([MACN], [TEN]) VALUES (N'CN1   ', N'Chi nhánh 1')
INSERT [dbo].[CHINHANH] ([MACN], [TEN]) VALUES (N'CN2   ', N'Chi nhánh 2')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__CHINHANH__C456F6BBA875F1BF]    Script Date: 14/12/2022 10:27:37 AM ******/
ALTER TABLE [dbo].[CHINHANH] ADD UNIQUE NONCLUSTERED 
(
	[TEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
GO
/****** Object:  Table [dbo].[KHO]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO](
	[MAKHO] [nchar](20) NOT NULL,
	[TEN] [nvarchar](20) NOT NULL,
	[MACN] [nchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KHO] ([MAKHO], [TEN], [MACN]) VALUES (N'KHO1                ', N'Kho Cầu Giấy', N'CN1   ')
INSERT [dbo].[KHO] ([MAKHO], [TEN], [MACN]) VALUES (N'KHO2                ', N'Kho Long Biên', N'CN1   ')
INSERT [dbo].[KHO] ([MAKHO], [TEN], [MACN]) VALUES (N'KHO3                ', N'Kho Hà Đông', N'CN1   ')
INSERT [dbo].[KHO] ([MAKHO], [TEN], [MACN]) VALUES (N'KHO4                ', N'Kho Đống Đa', N'CN1   ')
INSERT [dbo].[KHO] ([MAKHO], [TEN], [MACN]) VALUES (N'KHO5                ', N'Kho Thủ Đức', N'CN2   ')
INSERT [dbo].[KHO] ([MAKHO], [TEN], [MACN]) VALUES (N'KHO6                ', N'Kho Gò Vấp', N'CN2   ')
INSERT [dbo].[KHO] ([MAKHO], [TEN], [MACN]) VALUES (N'KHO7                ', N'Kho Tân Bình', N'CN2   ')
INSERT [dbo].[KHO] ([MAKHO], [TEN], [MACN]) VALUES (N'KHO8                ', N'Kho Củ Chi', N'CN2   ')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KHO__C456F6BB54241E99]    Script Date: 14/12/2022 10:27:37 AM ******/
ALTER TABLE [dbo].[KHO] ADD UNIQUE NONCLUSTERED 
(
	[TEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KHO]  WITH CHECK ADD  CONSTRAINT [FK__KHO__MACN__30F848ED] FOREIGN KEY([MACN])
REFERENCES [dbo].[CHINHANH] ([MACN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KHO] CHECK CONSTRAINT [FK__KHO__MACN__30F848ED]
GO
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [nchar](20) NOT NULL,
	[TEN] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SDT] [nchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TEN], [DIACHI], [SDT]) VALUES (N'NCC1                ', N'Bến Tre', N'Bến Tre', N'0689746523     ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TEN], [DIACHI], [SDT]) VALUES (N'NCC2                ', N'Hải Phòng', N'Hải Phòng', N'0687946532     ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TEN], [DIACHI], [SDT]) VALUES (N'NCC3                ', N'Bình Định', N'Bình Định', N'0125497423     ')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NHACUNGC__C456F6BBA926EC06]    Script Date: 14/12/2022 10:27:37 AM ******/
ALTER TABLE [dbo].[NHACUNGCAP] ADD UNIQUE NONCLUSTERED 
(
	[TEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NHACUNGC__CA1930A5E431D726]    Script Date: 14/12/2022 10:27:37 AM ******/
ALTER TABLE [dbo].[NHACUNGCAP] ADD UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NHACUNGC__F1A22D413C52648F]    Script Date: 14/12/2022 10:27:37 AM ******/
ALTER TABLE [dbo].[NHACUNGCAP] ADD UNIQUE NONCLUSTERED 
(
	[DIACHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NHACUNGCAP]  WITH CHECK ADD CHECK  ((len([SDT])>(6) AND len([SDT])<(12)))
GO
GO
/****** Object:  Table [dbo].[LOAIHANGHOA]    Script Date: 14/12/2022 10:27:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHANGHOA](
	[MALHH] [nchar](20) NOT NULL,
	[TEN] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MALHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LOAIHANGHOA] ([MALHH], [TEN]) VALUES (N'DGD                 ', N'Đồ gia dụng')
INSERT [dbo].[LOAIHANGHOA] ([MALHH], [TEN]) VALUES (N'TP                  ', N'Thực phẩm')
INSERT [dbo].[LOAIHANGHOA] ([MALHH], [TEN]) VALUES (N'VLXD                ', N'Vật liệu xây dựng')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__LOAIHANG__C456F6BBEB766CCC]    Script Date: 14/12/2022 10:27:37 AM ******/
ALTER TABLE [dbo].[LOAIHANGHOA] ADD UNIQUE NONCLUSTERED 
(
	[TEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MAHH] [nchar](20) NOT NULL,
	[TEN] [nvarchar](20) NULL,
	[MALHH] [nchar](20) NOT NULL,
	[DONVI] [nvarchar](6) NOT NULL,
	[DONGIA] [int] NOT NULL,
 CONSTRAINT [PK__HANGHOA__603F20C207226CCB] PRIMARY KEY CLUSTERED 
(
	[MAHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'DGD-BU              ', N'Bàn ủi', N'DGD                 ', N'cái', 1500000)
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'DGD-D               ', N'Dao', N'DGD                 ', N'cái', 50000)
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'DGD-K               ', N'Kéo', N'DGD                 ', N'cái', 20000)
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'DGD-ME              ', N'Máy ép', N'DGD                 ', N'cái', 400000)
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'DGD-NC              ', N'Nồi cơm', N'DGD                 ', N'cái', 500000)
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'TP-B                ', N'Bánh snack', N'TP                  ', N'bịch', 8000)
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'TP-G                ', N'Gạo', N'TP                  ', N'kg', 20000)
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'TP-S                ', N'Sữa', N'TP                  ', N'hộp', 15000)
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'VLXD-CBT            ', N'Cát bê tông', N'VLXD                ', N'm3', 300000)
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'VLXD-GL             ', N'Gạch lỗ', N'VLXD                ', N'viên', 980)
INSERT [dbo].[HANGHOA] ([MAHH], [TEN], [MALHH], [DONVI], [DONGIA]) VALUES (N'VLXD-XMT            ', N'Xi măng trắng', N'VLXD                ', N'bao', 140000)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__HANGHOA__C456F6BB4371D4FF]    Script Date: 14/12/2022 10:27:37 AM ******/
ALTER TABLE [dbo].[HANGHOA] ADD  CONSTRAINT [UQ__HANGHOA__C456F6BB4371D4FF] UNIQUE NONCLUSTERED 
(
	[TEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_TENHH]    Script Date: 14/12/2022 10:27:37 AM ******/
CREATE NONCLUSTERED INDEX [IDX_TENHH] ON [dbo].[HANGHOA]
(
	[TEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK__HANGHOA__MALHH__37A5467C] FOREIGN KEY([MALHH])
REFERENCES [dbo].[LOAIHANGHOA] ([MALHH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK__HANGHOA__MALHH__37A5467C]
GO
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[IDKH] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](50) NOT NULL,
	[NGAYSINH] [date] NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SDT] [nchar](15) NOT NULL,
	[MACN] [nchar](6) NOT NULL,
 CONSTRAINT [PK__KHACHHAN__B87DC1A7FC155E99] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (1, N'Nguyễn Thị Kiều An', CAST(N'2001-06-08' AS Date), N'97 Man Thiện', N'0865842364     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (2, N'Nguyễn Tuyết Ánh', CAST(N'1999-02-20' AS Date), N'97 Man Thiện', N'0125489657     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (3, N'Trần Thế Bảo', CAST(N'1980-03-07' AS Date), N'97 Man Thiện', N'0689547615     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (4, N'Nguyễn Thị Kiều Dung', CAST(N'2000-09-04' AS Date), N'97 Man Thiện', N'0784531685     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (5, N'Trần Văn Đồng', CAST(N'1988-12-06' AS Date), N'97 Man Thiện', N'0916842654     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (31, N'Nguyễn Thị Thùy Linh', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0739577785     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (32, N'Nguyễn Thị My', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0267026263     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (33, N'Hà Yến Nhi', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0869296467     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (34, N'Lê Thị Huỳnh  Như', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0327119463     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (35, N'Lê Văn Phim', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0068694128     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (36, N'Nguyễn Thanh Phúc', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0873860434     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (37, N'Nguyễn Thị Như Phương', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0502741219     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (38, N'Nguyễn Tấn Quang', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0907336291     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (39, N'Nguyễn Thị Vân Quỳnh', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0606517752     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (40, N'Huỳnh Văn Tấn', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0017976695     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (41, N'Trần Xuân Thanh', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0928094407     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (42, N'Đỗ Tiến Thành', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0879670171     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (43, N'Huỳnh Ngọc Thanh', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0714875815     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (44, N'Dương Minh Thịnh', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0648083154     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (45, N'Đào Phương Thuỳ', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0634888768     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (46, N'Nguyễn Ngọc Tiên', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0448572557     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (47, N'Đặng Thị Thùy Trang', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0389326508     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (48, N'Vũ Thị Trúc', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0104676145     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (49, N'Lê Văn Trung', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0048030937     ', N'CN1   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (50, N'Phạm Quang Vinh', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0816397613     ', N'CN2   ')
INSERT [dbo].[KHACHHANG] ([IDKH], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN]) VALUES (51, N'Phan Tường Vy', CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0214612519     ', N'CN1   ')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KHACHHAN__1C1AC12695B1EA32]    Script Date: 14/12/2022 10:27:37 AM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [UQ__KHACHHAN__1C1AC12695B1EA32] UNIQUE NONCLUSTERED 
(
	[SDT] ASC,
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_CHINHANH] FOREIGN KEY([MACN])
REFERENCES [dbo].[CHINHANH] ([MACN])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_CHINHANH]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [CK__KHACHHANG__SDT__2D27B809] CHECK  ((len([SDT])>(6) AND len([SDT])<(12)))
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [CK__KHACHHANG__SDT__2D27B809]
GO
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [nchar](20) NOT NULL,
	[HO] [nvarchar](40) NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[PHAI] [bit] NOT NULL,
	[NGAYSINH] [date] NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SDT] [nchar](15) NOT NULL,
	[MACN] [nchar](6) NOT NULL,
	[DANHDAUDAXOA] [bit] NOT NULL,
 CONSTRAINT [PK__NHANVIEN__603F5114DEC71322] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV1                 ', N'Trần Văn', N'Đồng', 1, CAST(N'1993-10-29' AS Date), N'97 Man Thiện', N'0179465328     ', N'CN1   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV10                ', N'Nguyễn Thế', N'Bân', 0, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN2   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV11                ', N'Nguyễn Vũ Lan', N'Chi', 1, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN1   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV12                ', N'Hồ Thị Mỹ', N'Dung', 0, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN2   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV13                ', N'Nguyễn Thị', N'Dung', 1, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN1   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV14                ', N'Lê Minh', N'Dương', 0, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN2   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV15                ', N'Phạm Bảo', N'Đại', 0, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN1   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV16                ', N'Thái Thị Thúy', N'Đào', 0, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN2   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV17                ', N'Mai Công', N'Hậu', 0, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN1   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV18                ', N'Nguyễn Thanh', N'Hiệp', 1, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN2   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV19                ', N'Trương Thị Mỹ', N'Hoàng', 0, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN1   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV2                 ', N'Trần Phương', N'Dương', 0, CAST(N'1994-06-01' AS Date), N'97 Man Thiện', N'0657954624     ', N'CN2   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV20                ', N'Nguyễn Hoàng', N'Hy', 0, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0454596528     ', N'CN2   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV3                 ', N'Lê Thị', N'Hòa', 0, CAST(N'1997-03-17' AS Date), N'97 Man Thiện', N'0974169544     ', N'CN1   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV4                 ', N'Nguyễn Việt', N'Hoàng', 1, CAST(N'1999-06-08' AS Date), N'97 Man Thiện', N'0416846532     ', N'CN2   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV5                 ', N'Trương Tấn', N'Thịnh', 1, CAST(N'2000-03-31' AS Date), N'97 Man Thiện', N'0648972642     ', N'CN1   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV6                 ', N'Trần Quốc', N'Bảo', 1, CAST(N'1995-06-09' AS Date), N'97 Man Thiện', N'098049417      ', N'CN2   ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [NGAYSINH], [DIACHI], [SDT], [MACN], [DANHDAUDAXOA]) VALUES (N'NV8                 ', N'Nguyễn Phương', N'Anh', 1, CAST(N'2000-06-08' AS Date), N'97 Man Thiện', N'0870026945     ', N'CN1   ', 0)
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [DF__NHANVIEN__DANHDA__276EDEB3]  DEFAULT ((0)) FOR [DANHDAUDAXOA]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK__NHANVIEN__MACN__286302EC] FOREIGN KEY([MACN])
REFERENCES [dbo].[CHINHANH] ([MACN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK__NHANVIEN__MACN__286302EC]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [CK__NHANVIEN__SDT__29572725] CHECK  ((len([SDT])>(6) AND len([SDT])<(12)))
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [CK__NHANVIEN__SDT__29572725]
GO
GO
/****** Object:  Table [dbo].[DONDAT]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONDAT](
	[MADD] [nchar](20) NOT NULL,
	[MANCC] [nchar](20) NOT NULL,
	[THOIGIAN] [datetime] NOT NULL,
	[MANV] [nchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MADD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD1                 ', N'NCC2                ', CAST(N'2022-11-30T21:39:59.363' AS DateTime), N'NV2                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD10                ', N'NCC2                ', CAST(N'2022-06-05T00:00:00.000' AS DateTime), N'NV16                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD11                ', N'NCC1                ', CAST(N'2022-06-26T00:00:00.000' AS DateTime), N'NV16                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD12                ', N'NCC1                ', CAST(N'2022-08-04T00:00:00.000' AS DateTime), N'NV14                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD13                ', N'NCC3                ', CAST(N'2022-07-17T00:00:00.000' AS DateTime), N'NV8                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD14                ', N'NCC3                ', CAST(N'2022-06-06T00:00:00.000' AS DateTime), N'NV14                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD15                ', N'NCC1                ', CAST(N'2022-06-21T00:00:00.000' AS DateTime), N'NV5                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD16                ', N'NCC3                ', CAST(N'2022-09-05T00:00:00.000' AS DateTime), N'NV14                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD17                ', N'NCC2                ', CAST(N'2022-10-10T00:00:00.000' AS DateTime), N'NV4                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD18                ', N'NCC3                ', CAST(N'2022-06-21T00:00:00.000' AS DateTime), N'NV17                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD19                ', N'NCC2                ', CAST(N'2022-06-14T00:00:00.000' AS DateTime), N'NV19                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD2                 ', N'NCC1                ', CAST(N'2022-12-01T20:46:48.187' AS DateTime), N'NV2                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD20                ', N'NCC1                ', CAST(N'2022-08-10T00:00:00.000' AS DateTime), N'NV19                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD21                ', N'NCC1                ', CAST(N'2022-07-01T00:00:00.000' AS DateTime), N'NV3                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD22                ', N'NCC1                ', CAST(N'2022-06-04T00:00:00.000' AS DateTime), N'NV14                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD23                ', N'NCC3                ', CAST(N'2022-10-20T00:00:00.000' AS DateTime), N'NV2                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD24                ', N'NCC3                ', CAST(N'2022-06-27T00:00:00.000' AS DateTime), N'NV10                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD25                ', N'NCC2                ', CAST(N'2022-08-10T00:00:00.000' AS DateTime), N'NV14                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD26                ', N'NCC1                ', CAST(N'2022-10-22T00:00:00.000' AS DateTime), N'NV6                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD27                ', N'NCC1                ', CAST(N'2022-06-10T00:00:00.000' AS DateTime), N'NV3                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD28                ', N'NCC2                ', CAST(N'2022-08-10T00:00:00.000' AS DateTime), N'NV4                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD29                ', N'NCC3                ', CAST(N'2022-10-03T00:00:00.000' AS DateTime), N'NV16                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD3                 ', N'NCC2                ', CAST(N'2022-07-24T00:00:00.000' AS DateTime), N'NV12                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD30                ', N'NCC3                ', CAST(N'2022-08-25T00:00:00.000' AS DateTime), N'NV6                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD31                ', N'NCC2                ', CAST(N'2022-06-23T00:00:00.000' AS DateTime), N'NV16                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD32                ', N'NCC1                ', CAST(N'2022-10-16T00:00:00.000' AS DateTime), N'NV17                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD33                ', N'NCC1                ', CAST(N'2022-10-07T00:00:00.000' AS DateTime), N'NV13                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD34                ', N'NCC2                ', CAST(N'2022-09-27T00:00:00.000' AS DateTime), N'NV13                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD35                ', N'NCC2                ', CAST(N'2022-08-25T00:00:00.000' AS DateTime), N'NV19                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD36                ', N'NCC2                ', CAST(N'2022-07-16T00:00:00.000' AS DateTime), N'NV17                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD37                ', N'NCC1                ', CAST(N'2022-10-20T00:00:00.000' AS DateTime), N'NV19                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD38                ', N'NCC2                ', CAST(N'2022-09-23T00:00:00.000' AS DateTime), N'NV12                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD39                ', N'NCC2                ', CAST(N'2022-08-06T00:00:00.000' AS DateTime), N'NV19                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD4                 ', N'NCC1                ', CAST(N'2022-06-06T00:00:00.000' AS DateTime), N'NV13                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD40                ', N'NCC3                ', CAST(N'2022-09-28T00:00:00.000' AS DateTime), N'NV15                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD41                ', N'NCC3                ', CAST(N'2022-10-07T00:00:00.000' AS DateTime), N'NV12                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD42                ', N'NCC3                ', CAST(N'2022-10-24T00:00:00.000' AS DateTime), N'NV1                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD43                ', N'NCC2                ', CAST(N'2022-06-22T00:00:00.000' AS DateTime), N'NV6                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD44                ', N'NCC3                ', CAST(N'2022-09-23T00:00:00.000' AS DateTime), N'NV4                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD45                ', N'NCC1                ', CAST(N'2022-10-10T00:00:00.000' AS DateTime), N'NV10                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD46                ', N'NCC1                ', CAST(N'2022-08-03T00:00:00.000' AS DateTime), N'NV17                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD47                ', N'NCC1                ', CAST(N'2022-08-05T00:00:00.000' AS DateTime), N'NV14                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD48                ', N'NCC1                ', CAST(N'2022-09-09T00:00:00.000' AS DateTime), N'NV17                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD49                ', N'NCC2                ', CAST(N'2022-08-16T00:00:00.000' AS DateTime), N'NV13                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD5                 ', N'NCC2                ', CAST(N'2022-06-18T00:00:00.000' AS DateTime), N'NV17                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD50                ', N'NCC1                ', CAST(N'2022-06-28T00:00:00.000' AS DateTime), N'NV1                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD51                ', N'NCC1                ', CAST(N'2022-10-23T00:00:00.000' AS DateTime), N'NV3                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD52                ', N'NCC3                ', CAST(N'2022-07-17T00:00:00.000' AS DateTime), N'NV6                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD53                ', N'NCC3                ', CAST(N'2022-08-18T00:00:00.000' AS DateTime), N'NV11                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD54                ', N'NCC1                ', CAST(N'2022-06-17T00:00:00.000' AS DateTime), N'NV12                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD55                ', N'NCC2                ', CAST(N'2022-07-20T00:00:00.000' AS DateTime), N'NV3                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD56                ', N'NCC3                ', CAST(N'2022-09-11T00:00:00.000' AS DateTime), N'NV15                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD57                ', N'NCC1                ', CAST(N'2022-08-01T00:00:00.000' AS DateTime), N'NV15                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD58                ', N'NCC2                ', CAST(N'2022-06-06T00:00:00.000' AS DateTime), N'NV16                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD6                 ', N'NCC1                ', CAST(N'2022-10-11T00:00:00.000' AS DateTime), N'NV12                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD7                 ', N'NCC1                ', CAST(N'2022-09-08T00:00:00.000' AS DateTime), N'NV3                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD70                ', N'NCC1                ', CAST(N'2022-08-20T00:00:00.000' AS DateTime), N'NV6                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD71                ', N'NCC2                ', CAST(N'2022-06-05T00:00:00.000' AS DateTime), N'NV4                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD72                ', N'NCC2                ', CAST(N'2022-07-19T00:00:00.000' AS DateTime), N'NV4                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD73                ', N'NCC3                ', CAST(N'2022-10-21T00:00:00.000' AS DateTime), N'NV20                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD74                ', N'NCC2                ', CAST(N'2022-07-15T00:00:00.000' AS DateTime), N'NV16                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD75                ', N'NCC3                ', CAST(N'2022-07-10T00:00:00.000' AS DateTime), N'NV12                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD76                ', N'NCC1                ', CAST(N'2022-07-09T00:00:00.000' AS DateTime), N'NV6                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD77                ', N'NCC3                ', CAST(N'2022-08-17T00:00:00.000' AS DateTime), N'NV11                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD78                ', N'NCC1                ', CAST(N'2022-09-21T00:00:00.000' AS DateTime), N'NV17                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD79                ', N'NCC3                ', CAST(N'2022-08-24T00:00:00.000' AS DateTime), N'NV19                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD8                 ', N'NCC1                ', CAST(N'2022-09-10T00:00:00.000' AS DateTime), N'NV8                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD80                ', N'NCC3                ', CAST(N'2022-07-22T00:00:00.000' AS DateTime), N'NV4                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD81                ', N'NCC1                ', CAST(N'2022-06-11T00:00:00.000' AS DateTime), N'NV15                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD82                ', N'NCC2                ', CAST(N'2022-06-07T00:00:00.000' AS DateTime), N'NV18                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD83                ', N'NCC3                ', CAST(N'2022-10-14T00:00:00.000' AS DateTime), N'NV2                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD84                ', N'NCC1                ', CAST(N'2022-06-02T00:00:00.000' AS DateTime), N'NV1                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD85                ', N'NCC1                ', CAST(N'2022-08-17T00:00:00.000' AS DateTime), N'NV8                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD86                ', N'NCC3                ', CAST(N'2022-07-02T00:00:00.000' AS DateTime), N'NV11                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD87                ', N'NCC2                ', CAST(N'2022-06-04T00:00:00.000' AS DateTime), N'NV1                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD88                ', N'NCC2                ', CAST(N'2022-06-16T00:00:00.000' AS DateTime), N'NV11                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD89                ', N'NCC1                ', CAST(N'2022-06-28T00:00:00.000' AS DateTime), N'NV5                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD9                 ', N'NCC3                ', CAST(N'2022-06-26T00:00:00.000' AS DateTime), N'NV6                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD90                ', N'NCC2                ', CAST(N'2022-09-06T00:00:00.000' AS DateTime), N'NV6                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD91                ', N'NCC3                ', CAST(N'2022-07-22T00:00:00.000' AS DateTime), N'NV11                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD92                ', N'NCC1                ', CAST(N'2022-09-05T00:00:00.000' AS DateTime), N'NV20                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD93                ', N'NCC1                ', CAST(N'2022-09-19T00:00:00.000' AS DateTime), N'NV11                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD94                ', N'NCC3                ', CAST(N'2022-06-27T00:00:00.000' AS DateTime), N'NV20                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD95                ', N'NCC2                ', CAST(N'2022-08-17T00:00:00.000' AS DateTime), N'NV13                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD96                ', N'NCC2                ', CAST(N'2022-10-15T00:00:00.000' AS DateTime), N'NV6                 ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD97                ', N'NCC1                ', CAST(N'2022-06-13T00:00:00.000' AS DateTime), N'NV11                ')
INSERT [dbo].[DONDAT] ([MADD], [MANCC], [THOIGIAN], [MANV]) VALUES (N'DD98                ', N'NCC1                ', CAST(N'2022-06-14T00:00:00.000' AS DateTime), N'NV10                ')
GO
ALTER TABLE [dbo].[DONDAT] ADD  DEFAULT (getdate()) FOR [THOIGIAN]
GO
ALTER TABLE [dbo].[DONDAT]  WITH CHECK ADD  CONSTRAINT [FK__DONDAT__MANCC__4222D4EF] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DONDAT] CHECK CONSTRAINT [FK__DONDAT__MANCC__4222D4EF]
GO
ALTER TABLE [dbo].[DONDAT]  WITH CHECK ADD  CONSTRAINT [FK__DONDAT__MANV__4316F928] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DONDAT] CHECK CONSTRAINT [FK__DONDAT__MANV__4316F928]
GO
GO
/****** Object:  Table [dbo].[CTDD]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDD](
	[MADD] [nchar](20) NOT NULL,
	[MAHH] [nchar](20) NOT NULL,
	[SL] [int] NOT NULL,
	[DONGIA] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MADD] ASC,
	[MAHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD1                 ', N'DGD-NC              ', 5, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD1                 ', N'TP-B                ', 5, 3000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD1                 ', N'TP-S                ', 50000, 50000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD10                ', N'DGD-D               ', 48, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD10                ', N'DGD-ME              ', 93, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD10                ', N'DGD-NC              ', 70, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD10                ', N'TP-G                ', 100, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD11                ', N'DGD-D               ', 94, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD11                ', N'TP-B                ', 61, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD11                ', N'VLXD-CBT            ', 49, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD12                ', N'DGD-D               ', 84, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD12                ', N'DGD-K               ', 54, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD12                ', N'VLXD-CBT            ', 95, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD13                ', N'TP-B                ', 57, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD13                ', N'TP-G                ', 96, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD13                ', N'VLXD-GL             ', 71, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD14                ', N'DGD-K               ', 39, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD14                ', N'TP-G                ', 63, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD14                ', N'VLXD-GL             ', 93, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD15                ', N'DGD-BU              ', 78, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD15                ', N'DGD-ME              ', 84, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD15                ', N'TP-B                ', 45, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD15                ', N'TP-G                ', 54, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD15                ', N'TP-S                ', 73, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD15                ', N'VLXD-GL             ', 43, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD16                ', N'DGD-K               ', 93, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD16                ', N'DGD-ME              ', 99, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD16                ', N'TP-B                ', 31, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD16                ', N'TP-S                ', 58, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD16                ', N'VLXD-GL             ', 73, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD16                ', N'VLXD-XMT            ', 26, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD17                ', N'DGD-D               ', 36, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD17                ', N'DGD-ME              ', 24, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD17                ', N'DGD-NC              ', 93, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD18                ', N'DGD-K               ', 27, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD18                ', N'DGD-NC              ', 40, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD18                ', N'VLXD-XMT            ', 27, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD19                ', N'DGD-BU              ', 28, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD19                ', N'DGD-ME              ', 35, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD19                ', N'DGD-NC              ', 80, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD19                ', N'VLXD-CBT            ', 78, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD19                ', N'VLXD-GL             ', 80, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD19                ', N'VLXD-XMT            ', 29, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD2                 ', N'DGD-NC              ', 18, 50000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD20                ', N'DGD-BU              ', 62, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD20                ', N'DGD-D               ', 48, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD20                ', N'DGD-K               ', 66, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD20                ', N'TP-B                ', 90, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD20                ', N'VLXD-GL             ', 37, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD21                ', N'DGD-K               ', 98, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD21                ', N'DGD-NC              ', 31, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD21                ', N'TP-G                ', 98, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD21                ', N'VLXD-CBT            ', 54, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD22                ', N'DGD-BU              ', 52, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD22                ', N'DGD-NC              ', 67, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD22                ', N'TP-B                ', 100, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD22                ', N'TP-G                ', 40, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD22                ', N'TP-S                ', 35, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD22                ', N'VLXD-CBT            ', 59, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD23                ', N'DGD-BU              ', 42, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD23                ', N'DGD-D               ', 31, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD23                ', N'DGD-ME              ', 96, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD23                ', N'TP-B                ', 54, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD23                ', N'VLXD-CBT            ', 51, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD23                ', N'VLXD-XMT            ', 29, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD24                ', N'DGD-BU              ', 82, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD24                ', N'DGD-D               ', 94, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD24                ', N'DGD-NC              ', 36, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD24                ', N'TP-S                ', 71, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD24                ', N'VLXD-CBT            ', 42, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD24                ', N'VLXD-XMT            ', 56, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD25                ', N'DGD-D               ', 82, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD25                ', N'DGD-K               ', 36, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD25                ', N'DGD-NC              ', 78, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD25                ', N'TP-B                ', 81, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD25                ', N'TP-S                ', 100, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD25                ', N'VLXD-XMT            ', 75, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD26                ', N'DGD-D               ', 55, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD26                ', N'DGD-K               ', 63, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD26                ', N'TP-G                ', 87, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD26                ', N'TP-S                ', 64, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD26                ', N'VLXD-XMT            ', 41, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD27                ', N'DGD-D               ', 84, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD27                ', N'DGD-K               ', 97, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD27                ', N'DGD-ME              ', 83, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD27                ', N'DGD-NC              ', 82, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD27                ', N'TP-G                ', 41, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD28                ', N'DGD-D               ', 90, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD28                ', N'DGD-K               ', 53, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD28                ', N'TP-G                ', 67, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD28                ', N'TP-S                ', 86, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD28                ', N'VLXD-CBT            ', 86, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD28                ', N'VLXD-XMT            ', 34, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD29                ', N'DGD-ME              ', 76, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD29                ', N'TP-S                ', 96, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD29                ', N'VLXD-CBT            ', 32, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD29                ', N'VLXD-XMT            ', 31, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD3                 ', N'DGD-D               ', 68, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD3                 ', N'TP-B                ', 76, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD30                ', N'DGD-BU              ', 46, 1050000)
GO
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD30                ', N'DGD-D               ', 77, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD30                ', N'DGD-NC              ', 65, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD30                ', N'TP-B                ', 56, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD30                ', N'VLXD-XMT            ', 32, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD31                ', N'DGD-BU              ', 30, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD31                ', N'DGD-ME              ', 53, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD31                ', N'TP-G                ', 51, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD31                ', N'TP-S                ', 39, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD31                ', N'VLXD-XMT            ', 58, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD32                ', N'DGD-K               ', 67, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD32                ', N'DGD-NC              ', 41, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD32                ', N'TP-G                ', 42, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD32                ', N'TP-S                ', 85, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD32                ', N'VLXD-CBT            ', 97, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD33                ', N'DGD-ME              ', 40, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD33                ', N'DGD-NC              ', 49, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD33                ', N'TP-G                ', 92, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD33                ', N'VLXD-GL             ', 98, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD33                ', N'VLXD-XMT            ', 59, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD34                ', N'DGD-BU              ', 33, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD34                ', N'DGD-D               ', 24, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD34                ', N'DGD-NC              ', 70, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD34                ', N'TP-G                ', 54, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD34                ', N'TP-S                ', 27, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD34                ', N'VLXD-CBT            ', 31, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD34                ', N'VLXD-GL             ', 46, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD34                ', N'VLXD-XMT            ', 62, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD35                ', N'DGD-BU              ', 29, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD35                ', N'DGD-D               ', 43, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD35                ', N'TP-B                ', 71, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD35                ', N'TP-S                ', 25, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD36                ', N'DGD-BU              ', 80, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD36                ', N'DGD-ME              ', 42, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD36                ', N'DGD-NC              ', 45, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD36                ', N'TP-G                ', 45, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD36                ', N'TP-S                ', 45, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD37                ', N'DGD-BU              ', 95, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD37                ', N'DGD-NC              ', 95, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD37                ', N'TP-B                ', 32, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD37                ', N'TP-G                ', 80, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD38                ', N'DGD-BU              ', 30, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD38                ', N'DGD-NC              ', 53, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD38                ', N'TP-B                ', 84, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD38                ', N'TP-S                ', 93, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD38                ', N'VLXD-GL             ', 39, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD38                ', N'VLXD-XMT            ', 55, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD39                ', N'TP-B                ', 81, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD39                ', N'TP-S                ', 67, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD39                ', N'VLXD-GL             ', 61, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD4                 ', N'TP-B                ', 27, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD4                 ', N'TP-G                ', 98, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD40                ', N'DGD-K               ', 33, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD40                ', N'DGD-ME              ', 57, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD40                ', N'TP-G                ', 84, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD40                ', N'VLXD-CBT            ', 87, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD40                ', N'VLXD-GL             ', 87, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD40                ', N'VLXD-XMT            ', 49, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD41                ', N'DGD-NC              ', 35, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD41                ', N'TP-G                ', 61, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD41                ', N'TP-S                ', 97, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD42                ', N'DGD-BU              ', 69, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD42                ', N'DGD-NC              ', 74, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD42                ', N'TP-S                ', 95, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD42                ', N'VLXD-CBT            ', 37, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD42                ', N'VLXD-GL             ', 98, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD43                ', N'DGD-NC              ', 34, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD43                ', N'TP-B                ', 48, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD43                ', N'VLXD-CBT            ', 48, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD44                ', N'DGD-BU              ', 93, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD44                ', N'DGD-K               ', 23, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD44                ', N'DGD-NC              ', 75, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD45                ', N'DGD-D               ', 45, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD45                ', N'DGD-K               ', 85, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD46                ', N'TP-B                ', 68, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD46                ', N'VLXD-CBT            ', 97, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD46                ', N'VLXD-GL             ', 94, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD47                ', N'DGD-BU              ', 29, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD47                ', N'DGD-D               ', 41, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD47                ', N'TP-G                ', 33, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD48                ', N'DGD-NC              ', 65, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD48                ', N'TP-B                ', 26, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD48                ', N'VLXD-CBT            ', 56, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD49                ', N'DGD-D               ', 35, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD49                ', N'TP-S                ', 88, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD5                 ', N'DGD-D               ', 60, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD5                 ', N'DGD-ME              ', 23, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD5                 ', N'VLXD-GL             ', 95, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD50                ', N'DGD-BU              ', 62, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD50                ', N'TP-S                ', 98, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD51                ', N'TP-B                ', 44, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD51                ', N'VLXD-GL             ', 76, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD51                ', N'VLXD-XMT            ', 28, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD52                ', N'DGD-ME              ', 48, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD52                ', N'TP-S                ', 66, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD52                ', N'VLXD-GL             ', 91, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD53                ', N'DGD-NC              ', 40, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD53                ', N'TP-B                ', 93, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD54                ', N'DGD-NC              ', 92, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD54                ', N'TP-G                ', 89, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD54                ', N'TP-S                ', 91, 10500)
GO
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD54                ', N'VLXD-GL             ', 96, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD55                ', N'TP-B                ', 38, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD55                ', N'VLXD-CBT            ', 62, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD55                ', N'VLXD-GL             ', 25, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD56                ', N'TP-B                ', 39, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD56                ', N'TP-G                ', 61, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD57                ', N'DGD-ME              ', 96, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD57                ', N'DGD-NC              ', 80, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD57                ', N'VLXD-CBT            ', 31, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD58                ', N'DGD-D               ', 68, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD58                ', N'DGD-K               ', 92, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD58                ', N'TP-S                ', 64, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD58                ', N'VLXD-GL             ', 62, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD6                 ', N'DGD-BU              ', 88, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD6                 ', N'DGD-D               ', 75, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD6                 ', N'VLXD-CBT            ', 49, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD6                 ', N'VLXD-XMT            ', 47, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD7                 ', N'DGD-ME              ', 92, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD7                 ', N'TP-S                ', 45, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD7                 ', N'VLXD-XMT            ', 23, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD70                ', N'DGD-ME              ', 35, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD70                ', N'VLXD-GL             ', 42, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD71                ', N'DGD-D               ', 80, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD71                ', N'VLXD-XMT            ', 33, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD72                ', N'DGD-D               ', 94, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD72                ', N'DGD-K               ', 81, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD72                ', N'VLXD-GL             ', 73, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD73                ', N'DGD-BU              ', 68, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD73                ', N'TP-B                ', 85, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD74                ', N'DGD-D               ', 82, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD74                ', N'DGD-ME              ', 75, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD75                ', N'DGD-BU              ', 50, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD75                ', N'DGD-ME              ', 89, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD75                ', N'VLXD-XMT            ', 41, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD76                ', N'TP-B                ', 78, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD76                ', N'TP-S                ', 99, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD76                ', N'VLXD-GL             ', 95, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD77                ', N'VLXD-GL             ', 29, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD77                ', N'VLXD-XMT            ', 34, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD78                ', N'DGD-BU              ', 87, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD78                ', N'DGD-ME              ', 27, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD79                ', N'DGD-ME              ', 38, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD79                ', N'TP-S                ', 42, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD79                ', N'VLXD-CBT            ', 32, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD8                 ', N'DGD-D               ', 79, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD8                 ', N'DGD-NC              ', 73, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD8                 ', N'VLXD-CBT            ', 73, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD80                ', N'DGD-ME              ', 66, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD80                ', N'TP-S                ', 27, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD81                ', N'DGD-D               ', 91, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD81                ', N'TP-G                ', 67, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD81                ', N'VLXD-CBT            ', 75, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD82                ', N'DGD-BU              ', 37, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD82                ', N'TP-B                ', 85, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD82                ', N'VLXD-CBT            ', 52, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD83                ', N'DGD-D               ', 38, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD83                ', N'VLXD-XMT            ', 72, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD84                ', N'TP-G                ', 46, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD84                ', N'VLXD-GL             ', 53, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD84                ', N'VLXD-XMT            ', 36, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD85                ', N'VLXD-CBT            ', 98, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD85                ', N'VLXD-GL             ', 31, 686)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD86                ', N'DGD-D               ', 86, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD86                ', N'TP-S                ', 45, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD86                ', N'VLXD-CBT            ', 56, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD87                ', N'DGD-BU              ', 100, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD87                ', N'DGD-D               ', 36, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD87                ', N'TP-B                ', 64, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD87                ', N'VLXD-XMT            ', 68, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD88                ', N'DGD-BU              ', 95, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD88                ', N'DGD-D               ', 23, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD88                ', N'DGD-K               ', 24, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD88                ', N'VLXD-XMT            ', 45, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD89                ', N'TP-G                ', 52, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD9                 ', N'DGD-K               ', 47, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD9                 ', N'TP-G                ', 30, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD90                ', N'TP-B                ', 45, 5600)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD90                ', N'VLXD-CBT            ', 84, 210000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD91                ', N'DGD-ME              ', 25, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD91                ', N'TP-G                ', 53, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD91                ', N'TP-S                ', 37, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD91                ', N'VLXD-XMT            ', 31, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD92                ', N'DGD-BU              ', 66, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD92                ', N'TP-S                ', 97, 10500)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD93                ', N'DGD-NC              ', 48, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD93                ', N'VLXD-XMT            ', 77, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD94                ', N'DGD-BU              ', 90, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD94                ', N'DGD-NC              ', 63, 350000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD94                ', N'VLXD-XMT            ', 93, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD95                ', N'DGD-D               ', 25, 35000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD95                ', N'VLXD-XMT            ', 30, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD96                ', N'DGD-K               ', 36, 14000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD96                ', N'VLXD-XMT            ', 100, 98000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD97                ', N'DGD-BU              ', 45, 1050000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD97                ', N'DGD-ME              ', 57, 280000)
INSERT [dbo].[CTDD] ([MADD], [MAHH], [SL], [DONGIA]) VALUES (N'DD97                ', N'VLXD-GL             ', 68, 686)
GO
ALTER TABLE [dbo].[CTDD]  WITH CHECK ADD  CONSTRAINT [FK__CTDD__MADD__45F365D3] FOREIGN KEY([MADD])
REFERENCES [dbo].[DONDAT] ([MADD])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTDD] CHECK CONSTRAINT [FK__CTDD__MADD__45F365D3]
GO
ALTER TABLE [dbo].[CTDD]  WITH CHECK ADD  CONSTRAINT [FK__CTDD__MAHH__46E78A0C] FOREIGN KEY([MAHH])
REFERENCES [dbo].[HANGHOA] ([MAHH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTDD] CHECK CONSTRAINT [FK__CTDD__MAHH__46E78A0C]
GO
ALTER TABLE [dbo].[CTDD]  WITH CHECK ADD CHECK  (([SL]>(0)))
GO
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [nchar](20) NOT NULL,
	[NGAYLAP] [datetime] NOT NULL,
	[MADD] [nchar](20) NOT NULL,
	[MANV] [nchar](20) NOT NULL,
	[MAKHO] [nchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN1                 ', CAST(N'2022-12-02T11:41:05.010' AS DateTime), N'DD1                 ', N'NV2                 ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN10                ', CAST(N'2022-07-05T00:00:00.000' AS DateTime), N'DD10                ', N'NV16                ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN11                ', CAST(N'2022-07-26T00:00:00.000' AS DateTime), N'DD11                ', N'NV16                ', N'KHO8                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN12                ', CAST(N'2022-09-04T00:00:00.000' AS DateTime), N'DD12                ', N'NV14                ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN13                ', CAST(N'2022-08-17T00:00:00.000' AS DateTime), N'DD13                ', N'NV8                 ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN14                ', CAST(N'2022-07-06T00:00:00.000' AS DateTime), N'DD14                ', N'NV14                ', N'KHO7                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN15                ', CAST(N'2022-07-21T00:00:00.000' AS DateTime), N'DD15                ', N'NV5                 ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN16                ', CAST(N'2022-10-05T00:00:00.000' AS DateTime), N'DD16                ', N'NV14                ', N'KHO7                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN17                ', CAST(N'2022-07-06T00:00:00.000' AS DateTime), N'DD17                ', N'NV13                ', N'KHO4                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN18                ', CAST(N'2022-07-21T00:00:00.000' AS DateTime), N'DD18                ', N'NV17                ', N'KHO3                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN19                ', CAST(N'2022-07-14T00:00:00.000' AS DateTime), N'DD19                ', N'NV19                ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN2                 ', CAST(N'2022-12-03T22:06:41.473' AS DateTime), N'DD1                 ', N'NV2                 ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN20                ', CAST(N'2022-09-10T00:00:00.000' AS DateTime), N'DD20                ', N'NV19                ', N'KHO3                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN21                ', CAST(N'2022-08-01T00:00:00.000' AS DateTime), N'DD21                ', N'NV3                 ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN22                ', CAST(N'2022-07-04T00:00:00.000' AS DateTime), N'DD22                ', N'NV14                ', N'KHO8                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN23                ', CAST(N'2022-11-20T00:00:00.000' AS DateTime), N'DD23                ', N'NV2                 ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN24                ', CAST(N'2022-07-27T00:00:00.000' AS DateTime), N'DD24                ', N'NV10                ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN25                ', CAST(N'2022-09-10T00:00:00.000' AS DateTime), N'DD25                ', N'NV14                ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN26                ', CAST(N'2022-11-22T00:00:00.000' AS DateTime), N'DD26                ', N'NV6                 ', N'KHO7                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN27                ', CAST(N'2022-07-10T00:00:00.000' AS DateTime), N'DD27                ', N'NV3                 ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN28                ', CAST(N'2022-09-10T00:00:00.000' AS DateTime), N'DD28                ', N'NV4                 ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN29                ', CAST(N'2022-11-03T00:00:00.000' AS DateTime), N'DD29                ', N'NV16                ', N'KHO8                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN3                 ', CAST(N'2022-08-24T00:00:00.000' AS DateTime), N'DD3                 ', N'NV12                ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN30                ', CAST(N'2022-09-25T00:00:00.000' AS DateTime), N'DD30                ', N'NV6                 ', N'KHO7                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN31                ', CAST(N'2022-07-23T00:00:00.000' AS DateTime), N'DD31                ', N'NV16                ', N'KHO8                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN32                ', CAST(N'2022-11-16T00:00:00.000' AS DateTime), N'DD32                ', N'NV17                ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN33                ', CAST(N'2022-11-07T00:00:00.000' AS DateTime), N'DD33                ', N'NV13                ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN34                ', CAST(N'2022-10-27T00:00:00.000' AS DateTime), N'DD34                ', N'NV13                ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN35                ', CAST(N'2022-09-25T00:00:00.000' AS DateTime), N'DD35                ', N'NV19                ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN36                ', CAST(N'2022-08-16T00:00:00.000' AS DateTime), N'DD36                ', N'NV17                ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN37                ', CAST(N'2022-11-20T00:00:00.000' AS DateTime), N'DD37                ', N'NV19                ', N'KHO4                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN38                ', CAST(N'2022-10-23T00:00:00.000' AS DateTime), N'DD38                ', N'NV12                ', N'KHO7                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN39                ', CAST(N'2022-09-06T00:00:00.000' AS DateTime), N'DD39                ', N'NV19                ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN4                 ', CAST(N'2022-07-06T00:00:00.000' AS DateTime), N'DD4                 ', N'NV13                ', N'KHO4                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN40                ', CAST(N'2022-10-28T00:00:00.000' AS DateTime), N'DD40                ', N'NV15                ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN41                ', CAST(N'2022-11-07T00:00:00.000' AS DateTime), N'DD41                ', N'NV12                ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN42                ', CAST(N'2022-11-24T00:00:00.000' AS DateTime), N'DD42                ', N'NV1                 ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN43                ', CAST(N'2022-07-22T00:00:00.000' AS DateTime), N'DD43                ', N'NV6                 ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN44                ', CAST(N'2022-10-23T00:00:00.000' AS DateTime), N'DD44                ', N'NV4                 ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN45                ', CAST(N'2022-11-10T00:00:00.000' AS DateTime), N'DD45                ', N'NV10                ', N'KHO8                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN46                ', CAST(N'2022-09-03T00:00:00.000' AS DateTime), N'DD46                ', N'NV17                ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN47                ', CAST(N'2022-09-05T00:00:00.000' AS DateTime), N'DD47                ', N'NV14                ', N'KHO8                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN48                ', CAST(N'2022-10-09T00:00:00.000' AS DateTime), N'DD48                ', N'NV17                ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN49                ', CAST(N'2022-09-16T00:00:00.000' AS DateTime), N'DD49                ', N'NV13                ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN5                 ', CAST(N'2022-07-18T00:00:00.000' AS DateTime), N'DD5                 ', N'NV17                ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN50                ', CAST(N'2022-07-28T00:00:00.000' AS DateTime), N'DD50                ', N'NV1                 ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN51                ', CAST(N'2022-11-23T00:00:00.000' AS DateTime), N'DD51                ', N'NV3                 ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN52                ', CAST(N'2022-08-17T00:00:00.000' AS DateTime), N'DD52                ', N'NV6                 ', N'KHO7                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN53                ', CAST(N'2022-09-18T00:00:00.000' AS DateTime), N'DD53                ', N'NV11                ', N'KHO4                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN54                ', CAST(N'2022-07-17T00:00:00.000' AS DateTime), N'DD54                ', N'NV12                ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN55                ', CAST(N'2022-08-20T00:00:00.000' AS DateTime), N'DD55                ', N'NV3                 ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN56                ', CAST(N'2022-10-11T00:00:00.000' AS DateTime), N'DD56                ', N'NV15                ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN57                ', CAST(N'2022-09-01T00:00:00.000' AS DateTime), N'DD57                ', N'NV15                ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN58                ', CAST(N'2022-07-06T00:00:00.000' AS DateTime), N'DD58                ', N'NV16                ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN6                 ', CAST(N'2022-11-11T00:00:00.000' AS DateTime), N'DD6                 ', N'NV12                ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN7                 ', CAST(N'2022-10-08T00:00:00.000' AS DateTime), N'DD7                 ', N'NV3                 ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN70                ', CAST(N'2022-09-20T00:00:00.000' AS DateTime), N'DD70                ', N'NV6                 ', N'KHO8                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN71                ', CAST(N'2022-07-05T00:00:00.000' AS DateTime), N'DD71                ', N'NV4                 ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN72                ', CAST(N'2022-08-19T00:00:00.000' AS DateTime), N'DD72                ', N'NV4                 ', N'KHO8                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN73                ', CAST(N'2022-11-21T00:00:00.000' AS DateTime), N'DD73                ', N'NV20                ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN74                ', CAST(N'2022-08-15T00:00:00.000' AS DateTime), N'DD74                ', N'NV16                ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN75                ', CAST(N'2022-08-10T00:00:00.000' AS DateTime), N'DD75                ', N'NV12                ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN76                ', CAST(N'2022-08-09T00:00:00.000' AS DateTime), N'DD76                ', N'NV6                 ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN77                ', CAST(N'2022-09-17T00:00:00.000' AS DateTime), N'DD77                ', N'NV11                ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN78                ', CAST(N'2022-10-21T00:00:00.000' AS DateTime), N'DD78                ', N'NV17                ', N'KHO4                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN79                ', CAST(N'2022-09-24T00:00:00.000' AS DateTime), N'DD79                ', N'NV19                ', N'KHO3                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN8                 ', CAST(N'2022-10-10T00:00:00.000' AS DateTime), N'DD8                 ', N'NV8                 ', N'KHO4                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN80                ', CAST(N'2022-08-22T00:00:00.000' AS DateTime), N'DD80                ', N'NV4                 ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN81                ', CAST(N'2022-07-11T00:00:00.000' AS DateTime), N'DD81                ', N'NV15                ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN82                ', CAST(N'2022-07-07T00:00:00.000' AS DateTime), N'DD82                ', N'NV18                ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN83                ', CAST(N'2022-11-14T00:00:00.000' AS DateTime), N'DD83                ', N'NV2                 ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN84                ', CAST(N'2022-07-02T00:00:00.000' AS DateTime), N'DD84                ', N'NV1                 ', N'KHO3                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN85                ', CAST(N'2022-09-17T00:00:00.000' AS DateTime), N'DD85                ', N'NV8                 ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN86                ', CAST(N'2022-08-02T00:00:00.000' AS DateTime), N'DD86                ', N'NV11                ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN87                ', CAST(N'2022-07-04T00:00:00.000' AS DateTime), N'DD87                ', N'NV1                 ', N'KHO1                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN88                ', CAST(N'2022-07-16T00:00:00.000' AS DateTime), N'DD88                ', N'NV11                ', N'KHO2                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN89                ', CAST(N'2022-07-28T00:00:00.000' AS DateTime), N'DD89                ', N'NV5                 ', N'KHO3                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN9                 ', CAST(N'2022-07-26T00:00:00.000' AS DateTime), N'DD9                 ', N'NV6                 ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN90                ', CAST(N'2022-10-06T00:00:00.000' AS DateTime), N'DD90                ', N'NV6                 ', N'KHO7                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN91                ', CAST(N'2022-08-22T00:00:00.000' AS DateTime), N'DD91                ', N'NV11                ', N'KHO4                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN92                ', CAST(N'2022-10-05T00:00:00.000' AS DateTime), N'DD92                ', N'NV20                ', N'KHO5                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN93                ', CAST(N'2022-10-19T00:00:00.000' AS DateTime), N'DD93                ', N'NV11                ', N'KHO3                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN94                ', CAST(N'2022-07-27T00:00:00.000' AS DateTime), N'DD94                ', N'NV20                ', N'KHO8                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN95                ', CAST(N'2022-09-17T00:00:00.000' AS DateTime), N'DD95                ', N'NV13                ', N'KHO3                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN96                ', CAST(N'2022-11-15T00:00:00.000' AS DateTime), N'DD96                ', N'NV6                 ', N'KHO6                ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MADD], [MANV], [MAKHO]) VALUES (N'PN97                ', CAST(N'2022-07-13T00:00:00.000' AS DateTime), N'DD97                ', N'NV11                ', N'KHO1                ')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PHIEUNHA__C16397CA060568C9]    Script Date: 14/12/2022 10:27:37 AM ******/
ALTER TABLE [dbo].[PHIEUNHAP] ADD UNIQUE NONCLUSTERED 
(
	[NGAYLAP] ASC,
	[MADD] ASC,
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PHIEUNHAP] ADD  DEFAULT (getdate()) FOR [NGAYLAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_DONDAT] FOREIGN KEY([MADD])
REFERENCES [dbo].[DONDAT] ([MADD])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_DONDAT]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_KHO] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[KHO] ([MAKHO])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_KHO]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
GO
/****** Object:  Table [dbo].[CTPN]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPN](
	[MAPN] [nchar](20) NOT NULL,
	[MAHH] [nchar](20) NOT NULL,
	[SL] [int] NOT NULL,
	[DONGIA] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MAHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN1                 ', N'DGD-NC              ', 1, 500000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN1                 ', N'TP-B                ', 5, 6000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN1                 ', N'TP-S                ', 8, 3000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN10                ', N'DGD-D               ', 48, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN10                ', N'DGD-ME              ', 93, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN10                ', N'DGD-NC              ', 70, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN10                ', N'TP-G                ', 49, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN11                ', N'DGD-D               ', 94, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN11                ', N'TP-B                ', 61, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN11                ', N'VLXD-CBT            ', 49, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN12                ', N'DGD-D               ', 84, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN12                ', N'DGD-K               ', 54, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN12                ', N'VLXD-CBT            ', 95, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN13                ', N'TP-B                ', 57, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN13                ', N'TP-G                ', 96, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN13                ', N'VLXD-GL             ', 71, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN14                ', N'DGD-K               ', 39, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN14                ', N'TP-G                ', 63, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN14                ', N'VLXD-GL             ', 93, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN15                ', N'DGD-BU              ', 78, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN15                ', N'DGD-ME              ', 84, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN15                ', N'TP-B                ', 45, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN15                ', N'TP-G                ', 54, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN15                ', N'TP-S                ', 73, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN15                ', N'VLXD-GL             ', 43, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN16                ', N'DGD-K               ', 93, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN16                ', N'DGD-ME              ', 99, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN16                ', N'TP-B                ', 31, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN16                ', N'TP-S                ', 58, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN16                ', N'VLXD-GL             ', 73, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN16                ', N'VLXD-XMT            ', 26, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN17                ', N'DGD-D               ', 90, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN17                ', N'DGD-ME              ', 24, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN17                ', N'DGD-NC              ', 86, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN18                ', N'DGD-K               ', 27, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN18                ', N'DGD-NC              ', 40, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN18                ', N'VLXD-XMT            ', 27, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN19                ', N'DGD-BU              ', 28, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN19                ', N'DGD-ME              ', 35, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN19                ', N'DGD-NC              ', 80, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN19                ', N'VLXD-CBT            ', 78, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN19                ', N'VLXD-GL             ', 80, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN19                ', N'VLXD-XMT            ', 29, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN2                 ', N'TP-S                ', 8, 600000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN20                ', N'DGD-BU              ', 62, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN20                ', N'DGD-D               ', 48, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN20                ', N'DGD-K               ', 66, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN20                ', N'TP-B                ', 90, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN20                ', N'VLXD-GL             ', 37, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN21                ', N'DGD-K               ', 98, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN21                ', N'DGD-NC              ', 31, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN21                ', N'TP-G                ', 98, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN21                ', N'VLXD-CBT            ', 54, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN22                ', N'DGD-NC              ', 67, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN22                ', N'TP-G                ', 40, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN22                ', N'TP-S                ', 35, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN22                ', N'VLXD-CBT            ', 59, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN23                ', N'DGD-BU              ', 42, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN23                ', N'DGD-D               ', 31, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN23                ', N'TP-B                ', 54, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN23                ', N'VLXD-CBT            ', 51, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN24                ', N'DGD-BU              ', 82, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN24                ', N'DGD-D               ', 94, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN24                ', N'DGD-NC              ', 36, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN24                ', N'TP-S                ', 71, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN24                ', N'VLXD-CBT            ', 42, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN24                ', N'VLXD-XMT            ', 56, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN25                ', N'DGD-D               ', 82, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN25                ', N'DGD-K               ', 36, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN25                ', N'DGD-NC              ', 78, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN25                ', N'TP-B                ', 81, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN25                ', N'TP-S                ', 100, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN25                ', N'VLXD-XMT            ', 75, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN26                ', N'DGD-D               ', 55, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN26                ', N'DGD-K               ', 63, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN26                ', N'TP-G                ', 87, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN26                ', N'TP-S                ', 64, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN26                ', N'VLXD-XMT            ', 41, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN27                ', N'DGD-D               ', 84, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN27                ', N'DGD-K               ', 97, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN27                ', N'DGD-ME              ', 83, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN27                ', N'DGD-NC              ', 82, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN27                ', N'TP-G                ', 41, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN28                ', N'DGD-D               ', 90, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN28                ', N'DGD-K               ', 53, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN28                ', N'TP-G                ', 67, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN28                ', N'TP-S                ', 86, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN28                ', N'VLXD-CBT            ', 86, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN28                ', N'VLXD-XMT            ', 34, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN29                ', N'DGD-ME              ', 76, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN29                ', N'TP-S                ', 96, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN29                ', N'VLXD-CBT            ', 32, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN29                ', N'VLXD-XMT            ', 31, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN3                 ', N'DGD-D               ', 68, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN3                 ', N'TP-B                ', 76, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN30                ', N'DGD-BU              ', 46, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN30                ', N'DGD-D               ', 77, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN30                ', N'DGD-NC              ', 65, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN30                ', N'TP-B                ', 56, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN30                ', N'VLXD-XMT            ', 32, 112000)
GO
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN31                ', N'DGD-BU              ', 30, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN31                ', N'DGD-ME              ', 53, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN31                ', N'TP-G                ', 51, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN31                ', N'TP-S                ', 39, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN31                ', N'VLXD-XMT            ', 58, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN32                ', N'DGD-K               ', 67, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN32                ', N'DGD-NC              ', 41, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN32                ', N'TP-G                ', 42, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN32                ', N'TP-S                ', 85, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN32                ', N'VLXD-CBT            ', 97, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN33                ', N'DGD-ME              ', 40, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN33                ', N'DGD-NC              ', 49, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN33                ', N'TP-G                ', 92, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN33                ', N'VLXD-GL             ', 98, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN33                ', N'VLXD-XMT            ', 59, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN34                ', N'DGD-BU              ', 33, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN34                ', N'DGD-D               ', 24, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN34                ', N'DGD-NC              ', 70, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN34                ', N'TP-G                ', 54, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN34                ', N'TP-S                ', 27, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN34                ', N'VLXD-CBT            ', 31, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN34                ', N'VLXD-GL             ', 46, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN34                ', N'VLXD-XMT            ', 62, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN35                ', N'DGD-BU              ', 29, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN35                ', N'DGD-D               ', 43, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN35                ', N'TP-B                ', 71, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN35                ', N'TP-S                ', 25, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN36                ', N'DGD-BU              ', 80, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN36                ', N'DGD-ME              ', 42, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN36                ', N'DGD-NC              ', 45, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN36                ', N'TP-G                ', 45, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN36                ', N'TP-S                ', 45, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN37                ', N'DGD-BU              ', 95, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN37                ', N'DGD-NC              ', 95, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN37                ', N'TP-B                ', 32, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN37                ', N'TP-G                ', 80, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN38                ', N'DGD-BU              ', 30, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN38                ', N'DGD-NC              ', 53, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN38                ', N'TP-B                ', 84, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN38                ', N'TP-S                ', 93, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN38                ', N'VLXD-GL             ', 39, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN38                ', N'VLXD-XMT            ', 55, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN39                ', N'TP-B                ', 81, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN39                ', N'TP-S                ', 67, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN39                ', N'VLXD-GL             ', 61, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN4                 ', N'TP-B                ', 27, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN4                 ', N'TP-G                ', 98, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN40                ', N'DGD-K               ', 33, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN40                ', N'DGD-ME              ', 57, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN40                ', N'TP-G                ', 84, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN40                ', N'VLXD-CBT            ', 87, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN40                ', N'VLXD-GL             ', 87, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN40                ', N'VLXD-XMT            ', 49, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN41                ', N'DGD-NC              ', 35, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN41                ', N'TP-G                ', 61, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN41                ', N'TP-S                ', 97, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN42                ', N'DGD-BU              ', 69, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN42                ', N'DGD-NC              ', 74, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN42                ', N'TP-S                ', 95, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN42                ', N'VLXD-CBT            ', 37, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN42                ', N'VLXD-GL             ', 98, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN43                ', N'DGD-NC              ', 34, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN43                ', N'TP-B                ', 48, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN43                ', N'VLXD-CBT            ', 48, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN44                ', N'DGD-BU              ', 93, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN44                ', N'DGD-K               ', 23, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN44                ', N'DGD-NC              ', 75, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN45                ', N'DGD-D               ', 45, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN45                ', N'DGD-K               ', 85, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN46                ', N'TP-B                ', 68, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN46                ', N'VLXD-CBT            ', 97, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN46                ', N'VLXD-GL             ', 94, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN47                ', N'DGD-BU              ', 29, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN47                ', N'DGD-D               ', 41, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN47                ', N'TP-G                ', 33, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN48                ', N'DGD-NC              ', 65, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN48                ', N'TP-B                ', 26, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN48                ', N'VLXD-CBT            ', 56, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN49                ', N'DGD-D               ', 35, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN49                ', N'TP-S                ', 88, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN5                 ', N'DGD-D               ', 60, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN5                 ', N'DGD-ME              ', 23, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN5                 ', N'VLXD-GL             ', 95, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN50                ', N'DGD-BU              ', 62, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN50                ', N'TP-S                ', 98, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN51                ', N'TP-B                ', 44, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN51                ', N'VLXD-GL             ', 76, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN51                ', N'VLXD-XMT            ', 28, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN52                ', N'DGD-ME              ', 48, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN52                ', N'TP-S                ', 66, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN52                ', N'VLXD-GL             ', 91, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN53                ', N'DGD-NC              ', 40, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN53                ', N'TP-B                ', 93, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN54                ', N'DGD-NC              ', 92, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN54                ', N'TP-G                ', 89, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN54                ', N'TP-S                ', 91, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN54                ', N'VLXD-GL             ', 96, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN55                ', N'TP-B                ', 38, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN55                ', N'VLXD-CBT            ', 62, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN55                ', N'VLXD-GL             ', 25, 784)
GO
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN56                ', N'TP-B                ', 39, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN56                ', N'TP-G                ', 61, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN57                ', N'DGD-ME              ', 96, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN57                ', N'DGD-NC              ', 80, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN57                ', N'VLXD-CBT            ', 31, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN58                ', N'DGD-D               ', 68, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN58                ', N'DGD-K               ', 92, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN58                ', N'TP-S                ', 64, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN58                ', N'VLXD-GL             ', 62, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN6                 ', N'DGD-BU              ', 88, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN6                 ', N'DGD-D               ', 75, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN6                 ', N'VLXD-CBT            ', 49, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN6                 ', N'VLXD-XMT            ', 47, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN7                 ', N'DGD-ME              ', 92, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN7                 ', N'TP-S                ', 45, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN7                 ', N'VLXD-XMT            ', 23, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN70                ', N'DGD-ME              ', 35, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN70                ', N'VLXD-GL             ', 42, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN71                ', N'DGD-D               ', 80, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN71                ', N'VLXD-XMT            ', 33, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN72                ', N'DGD-D               ', 94, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN72                ', N'DGD-K               ', 81, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN72                ', N'VLXD-GL             ', 73, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN73                ', N'DGD-BU              ', 68, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN73                ', N'TP-B                ', 85, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN74                ', N'DGD-D               ', 82, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN74                ', N'DGD-ME              ', 75, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN75                ', N'DGD-BU              ', 50, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN75                ', N'DGD-ME              ', 89, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN75                ', N'VLXD-XMT            ', 41, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN76                ', N'TP-B                ', 78, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN76                ', N'TP-S                ', 99, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN76                ', N'VLXD-GL             ', 95, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN77                ', N'VLXD-GL             ', 29, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN77                ', N'VLXD-XMT            ', 34, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN78                ', N'DGD-BU              ', 87, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN78                ', N'DGD-ME              ', 27, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN79                ', N'DGD-ME              ', 38, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN79                ', N'TP-S                ', 42, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN79                ', N'VLXD-CBT            ', 32, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN8                 ', N'DGD-NC              ', 73, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN8                 ', N'VLXD-CBT            ', 73, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN80                ', N'DGD-ME              ', 66, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN80                ', N'TP-S                ', 27, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN81                ', N'DGD-D               ', 91, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN81                ', N'TP-G                ', 67, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN81                ', N'VLXD-CBT            ', 75, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN82                ', N'DGD-BU              ', 37, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN82                ', N'TP-B                ', 85, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN82                ', N'VLXD-CBT            ', 52, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN83                ', N'DGD-D               ', 38, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN83                ', N'VLXD-XMT            ', 72, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN84                ', N'TP-G                ', 46, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN84                ', N'VLXD-GL             ', 53, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN84                ', N'VLXD-XMT            ', 36, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN85                ', N'VLXD-CBT            ', 98, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN85                ', N'VLXD-GL             ', 31, 784)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN86                ', N'DGD-D               ', 86, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN86                ', N'TP-S                ', 45, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN86                ', N'VLXD-CBT            ', 56, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN87                ', N'DGD-BU              ', 100, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN87                ', N'DGD-D               ', 36, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN87                ', N'TP-B                ', 64, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN87                ', N'VLXD-XMT            ', 68, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN88                ', N'DGD-BU              ', 95, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN88                ', N'DGD-D               ', 23, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN88                ', N'DGD-K               ', 24, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN88                ', N'VLXD-XMT            ', 45, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN89                ', N'TP-G                ', 52, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN9                 ', N'DGD-K               ', 47, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN9                 ', N'TP-G                ', 30, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN90                ', N'TP-B                ', 45, 6400)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN90                ', N'VLXD-CBT            ', 84, 240000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN91                ', N'DGD-ME              ', 25, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN91                ', N'TP-G                ', 53, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN91                ', N'TP-S                ', 37, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN91                ', N'VLXD-XMT            ', 31, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN92                ', N'DGD-BU              ', 66, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN92                ', N'TP-S                ', 97, 12000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN93                ', N'DGD-NC              ', 48, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN93                ', N'VLXD-XMT            ', 77, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN94                ', N'DGD-BU              ', 90, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN94                ', N'DGD-NC              ', 63, 400000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN94                ', N'VLXD-XMT            ', 93, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN95                ', N'DGD-D               ', 25, 40000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN95                ', N'VLXD-XMT            ', 30, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN96                ', N'DGD-K               ', 36, 16000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN96                ', N'VLXD-XMT            ', 100, 112000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN97                ', N'DGD-BU              ', 45, 1200000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN97                ', N'DGD-ME              ', 57, 320000)
INSERT [dbo].[CTPN] ([MAPN], [MAHH], [SL], [DONGIA]) VALUES (N'PN97                ', N'VLXD-GL             ', 68, 784)
GO
ALTER TABLE [dbo].[CTPN]  WITH CHECK ADD  CONSTRAINT [FK__CTPN__MAPN__5165187F] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PHIEUNHAP] ([MAPN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK__CTPN__MAPN__5165187F]
GO
ALTER TABLE [dbo].[CTPN]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_HANGHOA] FOREIGN KEY([MAHH])
REFERENCES [dbo].[HANGHOA] ([MAHH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_HANGHOA]
GO
ALTER TABLE [dbo].[CTPN]  WITH CHECK ADD CHECK  (([SL]>(0)))
GO
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [nchar](20) NOT NULL,
	[NGAYLAP] [datetime] NOT NULL,
	[MANV] [nchar](20) NOT NULL,
	[MAKHO] [nchar](20) NOT NULL,
	[IDKH] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD1                 ', CAST(N'2022-12-08T21:34:23.173' AS DateTime), N'NV2                 ', N'KHO5                ', 4)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD100               ', CAST(N'2022-12-13T09:13:03.740' AS DateTime), N'NV2                 ', N'KHO5                ', 44)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD11                ', CAST(N'2022-07-05T00:00:00.000' AS DateTime), N'NV16                ', N'KHO6                ', 4)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD12                ', CAST(N'2022-07-26T00:00:00.000' AS DateTime), N'NV16                ', N'KHO8                ', 46)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD13                ', CAST(N'2022-09-04T00:00:00.000' AS DateTime), N'NV14                ', N'KHO6                ', 50)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD15                ', CAST(N'2022-07-06T00:00:00.000' AS DateTime), N'NV14                ', N'KHO7                ', 44)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD16                ', CAST(N'2022-07-21T00:00:00.000' AS DateTime), N'NV5                 ', N'KHO1                ', 41)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD17                ', CAST(N'2022-10-05T00:00:00.000' AS DateTime), N'NV14                ', N'KHO7                ', 32)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD18                ', CAST(N'2022-07-06T00:00:00.000' AS DateTime), N'NV13                ', N'KHO4                ', 51)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD19                ', CAST(N'2022-11-06T00:00:00.000' AS DateTime), N'NV10                ', N'KHO7                ', 50)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD2                 ', CAST(N'2022-12-08T00:00:00.000' AS DateTime), N'NV2                 ', N'KHO5                ', 4)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD20                ', CAST(N'2022-07-14T00:00:00.000' AS DateTime), N'NV19                ', N'KHO1                ', 37)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD21                ', CAST(N'2022-09-10T00:00:00.000' AS DateTime), N'NV19                ', N'KHO3                ', 51)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD22                ', CAST(N'2022-08-01T00:00:00.000' AS DateTime), N'NV3                 ', N'KHO2                ', 5)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD23                ', CAST(N'2022-07-04T00:00:00.000' AS DateTime), N'NV14                ', N'KHO8                ', 4)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD24                ', CAST(N'2022-11-20T00:00:00.000' AS DateTime), N'NV2                 ', N'KHO6                ', 38)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD25                ', CAST(N'2022-07-27T00:00:00.000' AS DateTime), N'NV10                ', N'KHO6                ', 42)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD26                ', CAST(N'2022-09-10T00:00:00.000' AS DateTime), N'NV14                ', N'KHO6                ', 34)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD27                ', CAST(N'2022-11-22T00:00:00.000' AS DateTime), N'NV6                 ', N'KHO7                ', 44)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD28                ', CAST(N'2022-07-10T00:00:00.000' AS DateTime), N'NV3                 ', N'KHO2                ', 1)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD29                ', CAST(N'2022-09-10T00:00:00.000' AS DateTime), N'NV4                 ', N'KHO5                ', 50)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD30                ', CAST(N'2022-08-01T00:00:00.000' AS DateTime), N'NV5                 ', N'KHO4                ', 51)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD31                ', CAST(N'2022-09-25T00:00:00.000' AS DateTime), N'NV6                 ', N'KHO7                ', 50)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD32                ', CAST(N'2022-07-23T00:00:00.000' AS DateTime), N'NV16                ', N'KHO8                ', 34)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD33                ', CAST(N'2022-10-21T00:00:00.000' AS DateTime), N'NV8                 ', N'KHO2                ', 47)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD34                ', CAST(N'2022-11-07T00:00:00.000' AS DateTime), N'NV13                ', N'KHO2                ', 35)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD35                ', CAST(N'2022-10-27T00:00:00.000' AS DateTime), N'NV13                ', N'KHO2                ', 1)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD36                ', CAST(N'2022-09-25T00:00:00.000' AS DateTime), N'NV19                ', N'KHO2                ', 31)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD37                ', CAST(N'2022-08-16T00:00:00.000' AS DateTime), N'NV17                ', N'KHO2                ', 43)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD38                ', CAST(N'2022-11-20T00:00:00.000' AS DateTime), N'NV19                ', N'KHO4                ', 47)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD39                ', CAST(N'2022-10-23T00:00:00.000' AS DateTime), N'NV12                ', N'KHO7                ', 38)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD40                ', CAST(N'2022-09-06T00:00:00.000' AS DateTime), N'NV19                ', N'KHO1                ', 33)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD41                ', CAST(N'2022-10-28T00:00:00.000' AS DateTime), N'NV15                ', N'KHO1                ', 37)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD42                ', CAST(N'2022-11-07T00:00:00.000' AS DateTime), N'NV12                ', N'KHO5                ', 42)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD43                ', CAST(N'2022-11-24T00:00:00.000' AS DateTime), N'NV1                 ', N'KHO1                ', 35)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD45                ', CAST(N'2022-10-23T00:00:00.000' AS DateTime), N'NV4                 ', N'KHO6                ', 2)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD47                ', CAST(N'2022-09-03T00:00:00.000' AS DateTime), N'NV17                ', N'KHO2                ', 51)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD48                ', CAST(N'2022-09-05T00:00:00.000' AS DateTime), N'NV14                ', N'KHO8                ', 36)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD49                ', CAST(N'2022-10-09T00:00:00.000' AS DateTime), N'NV17                ', N'KHO2                ', 33)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD5                 ', CAST(N'2022-07-06T00:00:00.000' AS DateTime), N'NV13                ', N'KHO4                ', 35)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD51                ', CAST(N'2022-07-28T00:00:00.000' AS DateTime), N'NV1                 ', N'KHO1                ', 1)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD53                ', CAST(N'2022-08-17T00:00:00.000' AS DateTime), N'NV6                 ', N'KHO7                ', 2)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD54                ', CAST(N'2022-09-18T00:00:00.000' AS DateTime), N'NV11                ', N'KHO4                ', 41)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD55                ', CAST(N'2022-07-17T00:00:00.000' AS DateTime), N'NV12                ', N'KHO5                ', 4)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD56                ', CAST(N'2022-08-20T00:00:00.000' AS DateTime), N'NV3                 ', N'KHO1                ', 49)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD57                ', CAST(N'2022-10-11T00:00:00.000' AS DateTime), N'NV15                ', N'KHO1                ', 39)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD58                ', CAST(N'2022-09-01T00:00:00.000' AS DateTime), N'NV15                ', N'KHO2                ', 33)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD59                ', CAST(N'2022-07-06T00:00:00.000' AS DateTime), N'NV16                ', N'KHO5                ', 38)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD7                 ', CAST(N'2022-11-11T00:00:00.000' AS DateTime), N'NV12                ', N'KHO6                ', 44)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD71                ', CAST(N'2022-09-20T00:00:00.000' AS DateTime), N'NV6                 ', N'KHO8                ', 34)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD72                ', CAST(N'2022-07-05T00:00:00.000' AS DateTime), N'NV4                 ', N'KHO6                ', 42)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD73                ', CAST(N'2022-08-19T00:00:00.000' AS DateTime), N'NV4                 ', N'KHO8                ', 32)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD74                ', CAST(N'2022-11-21T00:00:00.000' AS DateTime), N'NV20                ', N'KHO5                ', 36)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD75                ', CAST(N'2022-08-15T00:00:00.000' AS DateTime), N'NV16                ', N'KHO5                ', 2)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD76                ', CAST(N'2022-08-10T00:00:00.000' AS DateTime), N'NV12                ', N'KHO6                ', 4)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD77                ', CAST(N'2022-08-09T00:00:00.000' AS DateTime), N'NV6                 ', N'KHO6                ', 42)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD78                ', CAST(N'2022-09-17T00:00:00.000' AS DateTime), N'NV11                ', N'KHO1                ', 43)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD79                ', CAST(N'2022-10-21T00:00:00.000' AS DateTime), N'NV17                ', N'KHO4                ', 5)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD8                 ', CAST(N'2022-10-08T00:00:00.000' AS DateTime), N'NV3                 ', N'KHO1                ', 41)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD80                ', CAST(N'2022-09-24T00:00:00.000' AS DateTime), N'NV19                ', N'KHO3                ', 1)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD82                ', CAST(N'2022-07-11T00:00:00.000' AS DateTime), N'NV15                ', N'KHO1                ', 43)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD83                ', CAST(N'2022-07-07T00:00:00.000' AS DateTime), N'NV18                ', N'KHO5                ', 44)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD84                ', CAST(N'2022-11-14T00:00:00.000' AS DateTime), N'NV2                 ', N'KHO6                ', 32)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD85                ', CAST(N'2022-07-02T00:00:00.000' AS DateTime), N'NV1                 ', N'KHO3                ', 35)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD86                ', CAST(N'2022-09-17T00:00:00.000' AS DateTime), N'NV8                 ', N'KHO2                ', 51)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD88                ', CAST(N'2022-07-04T00:00:00.000' AS DateTime), N'NV1                 ', N'KHO1                ', 31)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD89                ', CAST(N'2022-07-16T00:00:00.000' AS DateTime), N'NV11                ', N'KHO2                ', 5)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD90                ', CAST(N'2022-07-28T00:00:00.000' AS DateTime), N'NV5                 ', N'KHO3                ', 49)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD91                ', CAST(N'2022-10-06T00:00:00.000' AS DateTime), N'NV6                 ', N'KHO7                ', 36)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD92                ', CAST(N'2022-08-22T00:00:00.000' AS DateTime), N'NV11                ', N'KHO4                ', 35)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD95                ', CAST(N'2022-07-27T00:00:00.000' AS DateTime), N'NV20                ', N'KHO8                ', 40)
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [IDKH]) VALUES (N'HD96                ', CAST(N'2022-09-17T00:00:00.000' AS DateTime), N'NV13                ', N'KHO3                ', 35)
GO
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT (getdate()) FOR [NGAYLAP]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__IDKH__59063A47] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KHACHHANG] ([IDKH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__IDKH__59063A47]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MAHD] [nchar](20) NOT NULL,
	[MAHH] [nchar](20) NOT NULL,
	[SL] [int] NOT NULL,
	[DONGIA] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC,
	[MAHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD1                 ', N'TP-B                ', 5, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD11                ', N'DGD-NC              ', 9, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD12                ', N'VLXD-CBT            ', 1, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD13                ', N'DGD-D               ', 27, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD15                ', N'TP-G                ', 28, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD16                ', N'DGD-BU              ', 1, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD16                ', N'DGD-ME              ', 29, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD16                ', N'TP-B                ', 15, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD16                ', N'TP-G                ', 3, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD16                ', N'TP-S                ', 37, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD16                ', N'VLXD-GL             ', 3, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD17                ', N'TP-B                ', 2, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD17                ', N'VLXD-XMT            ', 14, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD18                ', N'DGD-D               ', 13, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD19                ', N'DGD-K               ', 10, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD19                ', N'DGD-NC              ', 18, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD2                 ', N'TP-S                ', 6, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD20                ', N'DGD-BU              ', 6, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD20                ', N'DGD-ME              ', 10, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD20                ', N'DGD-NC              ', 27, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD20                ', N'VLXD-XMT            ', 7, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD21                ', N'TP-B                ', 23, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD22                ', N'DGD-K               ', 2, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD22                ', N'VLXD-CBT            ', 6, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD23                ', N'TP-B                ', 4, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD23                ', N'TP-G                ', 12, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD23                ', N'TP-S                ', 1, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD24                ', N'DGD-BU              ', 16, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD24                ', N'DGD-ME              ', 21, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD24                ', N'TP-B                ', 1, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD24                ', N'VLXD-CBT            ', 23, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD24                ', N'VLXD-XMT            ', 2, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD25                ', N'DGD-BU              ', 9, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD25                ', N'DGD-D               ', 13, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD26                ', N'DGD-D               ', 38, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD26                ', N'DGD-NC              ', 40, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD26                ', N'VLXD-XMT            ', 14, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD27                ', N'DGD-D               ', 9, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD27                ', N'TP-S                ', 25, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD27                ', N'VLXD-XMT            ', 20, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD28                ', N'DGD-D               ', 36, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD28                ', N'DGD-ME              ', 11, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD29                ', N'DGD-D               ', 7, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD29                ', N'DGD-K               ', 21, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD29                ', N'TP-G                ', 19, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD29                ', N'TP-S                ', 14, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD29                ', N'VLXD-CBT            ', 36, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD29                ', N'VLXD-XMT            ', 1, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD30                ', N'VLXD-CBT            ', 10, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD31                ', N'DGD-NC              ', 14, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD31                ', N'TP-B                ', 4, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD32                ', N'DGD-BU              ', 14, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD32                ', N'DGD-ME              ', 7, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD32                ', N'TP-G                ', 2, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD32                ', N'TP-S                ', 11, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD32                ', N'VLXD-XMT            ', 24, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD33                ', N'TP-G                ', 13, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD33                ', N'TP-S                ', 14, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD33                ', N'VLXD-CBT            ', 40, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD34                ', N'DGD-ME              ', 21, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD34                ', N'DGD-NC              ', 3, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD34                ', N'VLXD-GL             ', 22, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD35                ', N'DGD-BU              ', 2, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD35                ', N'DGD-D               ', 2, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD35                ', N'DGD-NC              ', 21, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD35                ', N'TP-G                ', 15, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD35                ', N'TP-S                ', 2, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD35                ', N'VLXD-GL             ', 1, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD35                ', N'VLXD-XMT            ', 28, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD36                ', N'TP-S                ', 9, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD37                ', N'DGD-BU              ', 36, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD37                ', N'DGD-ME              ', 9, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD37                ', N'DGD-NC              ', 23, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD38                ', N'DGD-NC              ', 6, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD38                ', N'TP-G                ', 14, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD39                ', N'DGD-BU              ', 8, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD39                ', N'DGD-NC              ', 23, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD39                ', N'TP-B                ', 15, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD39                ', N'TP-S                ', 1, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD40                ', N'TP-B                ', 19, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD40                ', N'TP-S                ', 2, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD40                ', N'VLXD-GL             ', 22, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD41                ', N'DGD-K               ', 3, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD42                ', N'DGD-NC              ', 8, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD42                ', N'TP-G                ', 27, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD42                ', N'TP-S                ', 49, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD43                ', N'VLXD-CBT            ', 3, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD43                ', N'VLXD-GL             ', 15, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD45                ', N'DGD-NC              ', 10, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD47                ', N'VLXD-CBT            ', 47, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD48                ', N'DGD-BU              ', 4, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD49                ', N'TP-B                ', 5, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD5                 ', N'TP-B                ', 4, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD51                ', N'DGD-BU              ', 32, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD53                ', N'TP-S                ', 20, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD53                ', N'VLXD-GL             ', 33, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD54                ', N'DGD-NC              ', 10, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD55                ', N'DGD-NC              ', 26, 500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD55                ', N'TP-G                ', 35, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD55                ', N'TP-S                ', 30, 15000)
GO
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD55                ', N'VLXD-GL             ', 16, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD56                ', N'TP-B                ', 14, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD56                ', N'VLXD-CBT            ', 21, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD57                ', N'TP-G                ', 7, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD58                ', N'DGD-ME              ', 11, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD58                ', N'VLXD-CBT            ', 5, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD59                ', N'DGD-D               ', 30, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD59                ', N'DGD-K               ', 41, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD59                ', N'VLXD-GL             ', 13, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD7                 ', N'DGD-BU              ', 62, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD71                ', N'DGD-ME              ', 16, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD72                ', N'DGD-D               ', 10, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD73                ', N'DGD-K               ', 18, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD73                ', N'VLXD-GL             ', 6, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD74                ', N'DGD-BU              ', 25, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD75                ', N'DGD-ME              ', 31, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD76                ', N'DGD-BU              ', 15, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD77                ', N'TP-S                ', 25, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD78                ', N'VLXD-XMT            ', 5, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD79                ', N'DGD-BU              ', 12, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD8                 ', N'TP-S                ', 25, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD80                ', N'DGD-ME              ', 5, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD80                ', N'TP-S                ', 10, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD80                ', N'VLXD-CBT            ', 10, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD82                ', N'VLXD-CBT            ', 6, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD83                ', N'TP-B                ', 26, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD84                ', N'DGD-D               ', 1, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD84                ', N'VLXD-XMT            ', 34, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD85                ', N'TP-G                ', 13, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD85                ', N'VLXD-GL             ', 10, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD85                ', N'VLXD-XMT            ', 4, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD86                ', N'VLXD-GL             ', 31, 980)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD88                ', N'TP-B                ', 11, 8000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD88                ', N'VLXD-XMT            ', 31, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD89                ', N'DGD-BU              ', 18, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD89                ', N'DGD-D               ', 4, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD89                ', N'VLXD-XMT            ', 21, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD90                ', N'TP-G                ', 3, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD91                ', N'VLXD-CBT            ', 35, 300000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD92                ', N'DGD-ME              ', 4, 400000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD92                ', N'TP-G                ', 2, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD92                ', N'TP-S                ', 19, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD95                ', N'DGD-BU              ', 17, 1500000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD95                ', N'VLXD-XMT            ', 24, 140000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD96                ', N'DGD-D               ', 3, 50000)
INSERT [dbo].[CTHD] ([MAHD], [MAHH], [SL], [DONGIA]) VALUES (N'HD96                ', N'VLXD-XMT            ', 9, 140000)
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK__CTHD__MAHD__5BE2A6F2] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK__CTHD__MAHD__5BE2A6F2]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HANGHOA] FOREIGN KEY([MAHH])
REFERENCES [dbo].[HANGHOA] ([MAHH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HANGHOA]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD CHECK  (([SL]>(0)))
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_BaoCaoNhapXuat]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_BaoCaoNhapXuat] 
@DATEFROM DATETIME,
@DATETO DATETIME
as

WITH NHAP AS(
	--select NGAY = CONVERT(VARCHAR(10),P.NGAYLAP,103), TIENNHAP = SUM(C.DONGIA * C.SL)
	select P.NGAYLAP, C.DONGIA, C.SL
	from (
		SELECT *
		FROM PHIEUNHAP
		WHERE NGAYLAP BETWEEN @DATEFROM AND @DATETO
	) P, CTPN C
	WHERE P.MAPN = C.MAPN
	--GROUP BY CONVERT(VARCHAR(10),P.NGAYLAP,103)
), XUAT AS(
	select P.NGAYLAP, C.DONGIA, C.SL
	from (
		SELECT *
		FROM HOADON
		WHERE NGAYLAP BETWEEN @DATEFROM AND @DATETO
	) P, CTHD C
	WHERE P.MAHD = C.MAHD
	--GROUP BY CONVERT(VARCHAR(10),P.NGAYLAP,103)
)

SELECT NGAY = CONVERT(VARCHAR(10),CONVERT(DATE,N.NGAYLAP,103), 103), TIENNHAP = SUM(N.DONGIA * N.SL), TIENXUAT = SUM(X.DONGIA * X.SL)
FROM NHAP N, XUAT X
WHERE CONVERT(DATE,N.NGAYLAP,103) = CONVERT(DATE,X.NGAYLAP,103)
GROUP BY CONVERT(DATE,N.NGAYLAP,103)
ORDER BY CONVERT(DATE,N.NGAYLAP,103)
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_ChuyenChiNhanh]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChuyenChiNhanh] 
	@MANV nchar(20), 
	@MACN nchar(6),
	@MANVMOI nchar(20) 
AS
DECLARE @LGNAME VARCHAR(50)
DECLARE @USERNAME VARCHAR(50)
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN
	BEGIN DISTRIBUTED TRAN
		DECLARE @HO NVARCHAR(40)
		DECLARE @TEN NVARCHAR(10)
		DECLARE @DIACHI NVARCHAR(100)
		DECLARE @NGAYSINH DATE
		DECLARE @PHAI BIT
		DECLARE @SDT NCHAR(15)

		-- Nếu mã nhân viên mới có rồi nghĩa là: đang ở chế độ hoàn tác
		IF EXISTS(
			SELECT * 
			FROM LINK0.QLVT.DBO.NHANVIEN
			WHERE MANV = @MANVMOI
		)
		BEGIN
		-- Kiểm tra xem nhân viên đó đã thực hiện j chưa
		-- Nếu rồi thì return
			-- Có ở đơn đặt
			IF EXISTS(
			SELECT * 
			FROM LINK0.QLVT.DBO.DONDAT
			WHERE MANV = @MANV
			)
			RAISERROR(N'Không thể hoàn tác (chuyển chi nhánh). Nhân viên đã tạo đơn đặt ở chi nhánh mới.',16,1); 

			-- Có ở phiếu nhập
			IF EXISTS(
			SELECT * 
			FROM LINK0.QLVT.DBO.PHIEUNHAP
			WHERE MANV = @MANV
			)
			RAISERROR(N'Không thể hoàn tác (chuyển chi nhánh). Nhân viên đã tạo phiếu nhập ở chi nhánh mới.',16,1);
			 

			-- Có ở hóa đơn
			IF EXISTS(
			SELECT * 
			FROM LINK0.QLVT.DBO.HOADON
			WHERE MANV = @MANV
			)
			RAISERROR(N'Không thể hoàn tác (chuyển chi nhánh). Nhân viên đã tạo hóa đơn ở chi nhánh mới.',16,1); 
			
			BEGIN TRY
				-- Nếu không có thì thực hiện xóa nhân viên trong bảng
				DELETE FROM LINK0.QLVT.DBO.NHANVIEN
				WHERE MANV = @MANV

				UPDATE LINK0.QLVT.DBO.NHANVIEN
				SET DANHDAUDAXOA = 0
				WHERE MANV = @MANVMOI
			END TRY

			BEGIN CATCH
			END CATCH
		END

		ELSE
		BEGIN
			SELECT @HO = HO, @TEN = TEN, @DIACHI = DIACHI, @NGAYSINH = NGAYSINH, @PHAI = PHAI, @SDT = SDT 
			FROM NhanVien 
			WHERE MANV = @MANV

			-- Không có nhân viên mới, tức là trong chế độ chuyển nhân viên

			SELECT @HO = HO, @TEN = TEN, @DIACHI = DIACHI, @NGAYSINH = NGAYSINH, @PHAI = PHAI, @SDT = SDT 
			FROM NhanVien 
			WHERE MANV = @MANV

			UPDATE NhanVien
			SET DANHDAUDAXOA = 1
			WHERE MANV = @MANV

			INSERT INTO LINK0.QLVT.DBO.NHANVIEN(MANV, HO, TEN, PHAI, NGAYSINH, DIACHI, SDT, MACN, DANHDAUDAXOA) 
			VALUES (@MANVMOI, @HO, @TEN, @PHAI, @NGAYSINH, @DIACHI, @SDT, @MACN, 0)
		END

		
	
	COMMIT TRAN;

	-- sp_droplogin và sp_dropuser không thể được thực thi trong một giao tác do người dùng định nghĩa
	-- Kiểm tra xem Nhân viên đã có login chưa. Có thì xóa
	IF EXISTS(SELECT SUSER_SNAME(sid) FROM sys.sysusers WHERE name = CAST(@MANV AS NVARCHAR))
	BEGIN
		SET @LGNAME = CAST((SELECT SUSER_SNAME(sid) FROM sys.sysusers WHERE name = CAST(@MANV AS NVARCHAR)) AS VARCHAR(50))
		SET @USERNAME = CAST(@MANV AS VARCHAR(50))
		EXEC SP_DROPUSER @USERNAME;
		EXEC SP_DROPLOGIN @LGNAME;
	END	

	RETURN 0
	
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_DangNhap]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DangNhap]
	@TENLOGIN NVARCHAR( 100)
AS
	DECLARE @UID INT
	DECLARE @MANV NVARCHAR(100)
	DECLARE @HOTEN NVARCHAR(100)
	SELECT @UID= uid , @MANV= NAME FROM sys.sysusers 
  	WHERE sid = SUSER_SID(@TENLOGIN)

	SELECT @HOTEN = HO+ ' '+TEN FROM dbo.NHANVIEN WHERE MANV=@MANV;

	
	IF ISNULL(@HOTEN, '0') = '0'
		SELECT @HOTEN = HO+ ' '+TEN FROM LINK0.QLVT.dbo.NHANVIEN WHERE MANV=@MANV;

	SELECT  MANV= @MANV, 
       		HOTEN = @HOTEN, 
       		TENNHOM=NAME
  	FROM sys.sysusers
    	WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachNhanVien]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DanhSachNhanVien]
as

select MANV, HO + ' ' + TEN, PHAI, DIACHI, SDT, DANHDAUDAXOA 
from NHANVIEN
order by TEN, HO
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachVatTu]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachVatTu] as

SELECT H.MAHH, H.TEN, L.TEN, H.DONVI, H.DONGIA
FROM HANGHOA H, LOAIHANGHOA L
WHERE H.MALHH = L.MALHH
ORDER BY H.TEN
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_DonHangKhongPhieuNhap]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DonHangKhongPhieuNhap] as

WITH TKPN AS ( 
	SELECT P.MADD, C.MAHH, C.SL
	FROM PHIEUNHAP P, CTPN C
	WHERE P.MAPN = C.MAPN
), TKDD AS (
	SELECT P.MADD, P.THOIGIAN, P.MANCC,P.MANV, C.MAHH, C.SL, C.DONGIA
	FROM DONDAT P, CTDD C
	WHERE P.MADD = C.MADD
), TONGHOP AS(
	SELECT D.MADD, NGAYLAP = CONVERT(VARCHAR(10),D.THOIGIAN,103), D.MANCC, D.MANV, D.SL, D.DONGIA
	FROM TKDD D
	LEFT JOIN  TKPN N 
	ON N.MADD = D.MADD
	AND N.MAHH = D.MAHH
	WHERE ISNULL(N.SL ,-1) =-1
	-- ORDER BY D.MADD
), TENNCC AS (
	SELECT D.MADD, D.NGAYLAP, N.TEN, D.MANV, D.SL, D.DONGIA
	FROM TONGHOP D, NHACUNGCAP N
	WHERE D.MANCC = N.MANCC
), TENNV AS (
	SELECT D.MADD, D.NGAYLAP, NHACUNGCAP = D.TEN, NHANVIEN = N.HO + ' ' + N.TEN, D.SL, D.DONGIA
	FROM TENNCC D, NHANVIEN N
	WHERE D.MANV = N.MANV
)

	SELECT * FROM TENNV
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_HoatDongNhanVien]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_HoatDongNhanVien]
@MANV NCHAR(20),
@DATEFROM DATETIME,
@DATETO DATETIME
AS

WITH TONGHOP AS (
SELECT THANGNAM = FORMAT(P.NGAYLAP,'MM/yyyy'), NGAYLAP = FORMAT(P.NGAYLAP,'dd/MM/yyyy'), MA = P.MAPN, C.MAHH, P.MAKHO, C.SL, C.DONGIA, THANHTIEN = SL * DONGIA
	FROM (
		SELECT *
		FROM PHIEUNHAP
		WHERE MANV = @MANV AND NGAYLAP BETWEEN @DATEFROM AND @DATETO) P,
		CTPN C
	WHERE C.MAPN = P.MAPN
UNION ALL
	SELECT THANGNAM = FORMAT(P.NGAYLAP,'MM/yyyy'), NGAYLAP = FORMAT(P.NGAYLAP,'dd/MM/yyyy'), MA = P.MAHD, C.MAHH, P.MAKHO, C.SL, C.DONGIA, THANHTIEN = SL * DONGIA
	FROM (
		SELECT *
		FROM HOADON
		WHERE MANV = @MANV AND NGAYLAP BETWEEN @DATEFROM AND @DATETO) P,
		CTHD C
	WHERE C.MAHD = P.MAHD

--ORDER BY NGAYLAP 
),THEMTENKHO AS(
	SELECT T.*,TENKHO = K.TEN
	FROM TONGHOP T, KHO K
	WHERE T.MAKHO = K.MAKHO
)

SELECT T.THANGNAM, T.NGAYLAP, T.MA,TENHANG = H.TEN, T.TENKHO, T.SL, T.DONGIA, T.THANHTIEN
FROM THEMTENKHO T, HANGHOA H
WHERE T.MAHH = H.MAHH
ORDER BY T.NGAYLAP
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraHopLeHangNhap]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraHopLeHangNhap]
	@MAPN NCHAR(20), 
	@MAHH NCHAR(20), 
	@SL INT
AS
BEGIN
	DECLARE @MAKHO NCHAR(20), @SLHIENTAI INT, @TONGHANGNHAP INT, @TONGHANGBAN INT

	SELECT P.MAPN, MAKHO, SL, MAHH
	INTO #DSPN
	FROM PHIEUNHAP P 
	LEFT JOIN CTPN C
	ON P.MAPN = C.MAPN


	SELECT @SLHIENTAI = SL, @MAKHO = MAKHO
	FROM #DSPN
	WHERE MAPN = @MAPN AND MAHH = @MAHH

	SELECT @TONGHANGNHAP = ISNULL(SUM(SL),0)
	FROM #DSPN
	WHERE MAKHO = @MAKHO AND MAHH = @MAHH

	SELECT @TONGHANGBAN = ISNULL(SUM(SL),0)
	FROM HOADON H
	LEFT JOIN CTHD C
	ON H.MAHD = C.MAHD
	WHERE C.MAHH = @MAHH

	DROP TABLE #DSPN

	RETURN (@TONGHANGNHAP - @SLHIENTAI + @SL - @TONGHANGBAN)
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraLogin]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraLogin]
	@LGNAME VARCHAR(50)
AS
	IF EXISTS (
		SELECT * 
		FROM sys.syslogins 
		WHERE loginname = @LGNAME
	)
	RETURN 0

	RETURN 1
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaChiTietDonDat]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaChiTietDonDat]
	@MADD nchar(20),
	@MAHH nchar(20)
AS
BEGIN
	IF ( EXISTS( SELECT * FROM CTDD WHERE MADD = @MADD AND MAHH = @MAHH ) )
		RETURN 1;
	RETURN 0;-- id nhap vao khong ton tai
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaChiTietHoaDon]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaChiTietHoaDon]
	@MAKHO nchar(20),
	@MAHH nchar(20),
	@MAHD nchar(20),
	@SL int
AS
BEGIN
	DECLARE @MAKHO2 NCHAR(20), @SLHIENTAI INT

	IF ( EXISTS( SELECT * FROM CTHD WHERE MAHD = @MAHD AND MAHH = @MAHH ) )
		RETURN 1; -- TRUNG HH 

	SELECT @MAKHO2 = MAKHO, @SLHIENTAI = SL FROM view_ChonChiTietHoaDon WHERE MAKHO = @MAKHO AND MAHH = @MAHH

	IF(ISNULL(@MAKHO2,'0') = '0') 
		RETURN 2; -- KO CO SP

	IF(@SLHIENTAI >= @SL)
		RETURN 3; -- HOP LE

	RETURN @SLHIENTAI * -1;-- SL NH HON
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaChiTietPhieuNhap]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaChiTietPhieuNhap]
	@MAPN nchar(20),
	@MAHH nchar(20)
AS
BEGIN
	DECLARE @MADD NCHAR(20)

	SELECT @MADD = MADD
	FROM PHIEUNHAP
	WHERE MAPN = @MAPN

	IF ( EXISTS( SELECT * FROM CTPN WHERE MAPN = @MAPN AND MAHH = @MAHH ) )
		RETURN 1;

	IF (EXISTS (SELECT * FROM CTDD WHERE MADD = @MADD AND MAHH = @MAHH))
		RETURN 2;
	RETURN 0;-- id nhap vao khong ton tai
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaDonDatHang]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaDonDatHang]
	@id nchar(20)
AS
BEGIN
	IF ( EXISTS( SELECT * FROM LINK0.QLVT.DBO.DONDAT WHERE MADD = @id ) )
		RETURN 1;
	RETURN 0;-- id nhap vao khong ton tai
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaHoaDon]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaHoaDon]
	@id nchar(20)
AS
BEGIN
	IF ( EXISTS( SELECT * FROM LINK0.QLVT.DBO.HOADON WHERE MAHD = @id ) )
		RETURN 1;
	RETURN 0;-- id nhap vao khong ton tai
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaPhieuNhap]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_KiemTraMaPhieuNhap]
	@id nchar(20)
AS
BEGIN
	IF ( EXISTS( SELECT * FROM LINK0.QLVT.DBO.PHIEUNHAP WHERE MAPN = @id ) )
		RETURN 1;
	RETURN 0;-- id nhap vao khong ton tai
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaVatTu]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraMaVatTu]
@MAVT nchar(20)
AS
BEGIN
	-- lấy chỉ cột mã vật tư mà thôi
	-- kiểm tra mẫ vật tư ở phân mảnh hiện tại
	IF EXISTS(SELECT *
			  FROM HANGHOA VT  
			  WHERE VT.MAHH = @MAVT)
			RETURN 1; -- Mã Vattu đang dùng ở phân mảnh hiện tại
	-- -- kiểm tra mẫ vật tư ở phân mảnh khác
	ELSE IF EXISTS(SELECT *
				   FROM LINK0.QLVT.DBO.HANGHOA VT  
				   WHERE VT.MAHH = @MAVT)
			RETURN 1; -- Mã Vattu đang dùng ở phân mảnh khác
	RETURN 0; -- Chưa tồn tại
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaVatTuChiNhanhConLai]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaVatTuChiNhanhConLai]
	@MAHH NCHAR(20)
AS
BEGIN
	IF EXISTS( SELECT 1 FROM LINK0.QLVT.DBO.HANGHOA as V
				WHERE V.MAHH = @MAHH
				AND				
				(EXISTS(SELECT 1 FROM LINK0.QLVT.DBO.CTPN WHERE CTPN.MAHH = @MAHH))
				OR (EXISTS(SELECT 1 FROM LINK0.QLVT.DBO.CTDD WHERE CTDD.MAHH = @MAHH)) )
		RETURN 1;
	RETURN 0;
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraUser]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraUser]
	@USERNAME VARCHAR(50)
AS
	IF EXISTS (
		SELECT * 
		FROM sys.sysusers
		WHERE name = @USERNAME
	)
	RETURN 0

	RETURN 1
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_TaoTaiKhoan]
    @LGNAME VARCHAR(50),  @PASS VARCHAR(50),
    @USERNAME VARCHAR(50),  @ROLE VARCHAR(50)
AS
	EXEC SP_ADDLOGIN @LGNAME, @PASS, 'QLVT'

  	EXEC SP_GRANTDBACCESS @LGNAME, @USERNAME

	EXEC sp_addrolemember @ROLE, @USERNAME
  	IF @ROLE = 'CONGTY' OR @ROLE = 'CHINHANH'

  	BEGIN
      	EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
      	EXEC sp_addsrvrolemember @LGNAME, 'DBCREATOR'
	  	EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  	END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_ThayDoiChiTietHoaDon]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ThayDoiChiTietHoaDon]
	@MAKHO nchar(20),
	@MAHH nchar(20),
	@MAHD nchar(20),
	@SL int
AS
BEGIN
	DECLARE @MAKHO2 NCHAR(20), @SLHIENTAI INT, @SLDADAT INT

	SELECT @SLDADAT = SL FROM CTHD WHERE MAHD = @MAHD AND MAHH = @MAHH

	IF(ISNULL(@SLDADAT, -1) = -1)
	RETURN 1;

	SELECT @MAKHO2 = MAKHO, @SLHIENTAI = ISNULL(SL,0) FROM view_ChonChiTietHoaDon WHERE MAKHO = @MAKHO AND MAHH = @MAHH

	IF(@SLHIENTAI + @SLDADAT >= @SL)
		RETURN 3; -- HOP LE

	RETURN (@SLHIENTAI + @SLDADAT) * -1;-- SL NH HON
END
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_TongHopNhapXuat]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC [sp_TongHopNhapXuat] 6,2022,12,2022,'N','CODSF'
CREATE PROCEDURE [dbo].[sp_TongHopNhapXuat] @THANGBD INT,
@NAMBD INT,
@THANGKT INT,
@NAMKT INT,
@NX NCHAR(1),
@VITRI NCHAR(10)
as 

IF @VITRI <> 'CONGTY'
BEGIN 
	IF @NX = 'N'
	BEGIN
		SELECT T.THANGNAM, H.TEN, T.SL, T.DONGIA
		FROM(
		select MAHH = c.MAHH, SL = sum(c.sl) ,DONGIA = sum(c.dongia * c.sl), THANGNAM = cast(MONTH(d.NGAYLAP) as nchar(2)) +'/' + cast(YEAR(d.NGAYLAP)as nchar)
		from PHIEUNHAP d, CTPN c
		where d.MAPN = c.MAPN AND 
			YEAR(d.NGAYLAP) >= @NAMBD AND 
			YEAR(d.NGAYLAP) <= @NAMKT AND 
			MONTH(d.NGAYLAP) >= @THANGBD AND 
			MONTH(d.NGAYLAP) <= @THANGKT 
		group by MONTH(d.NGAYLAP), YEAR(d.NGAYLAP), c.MAHH) T , HANGHOA H
		WHERE T.MAHH = H.MAHH
		ORDER BY CONVERT(datetime,'1/' +THANGNAM  ,103)

		--DROP TABLE #THPN1
	END
	ELSE 
	BEGIN
		SELECT T.THANGNAM, H.TEN, T.SL, T.DONGIA
		FROM (
			select MAHH = c.MAHH, SL = sum(c.sl) ,DONGIA = sum(c.dongia * c.sl), THANGNAM = cast(MONTH(d.NGAYLAP) as nchar(2)) +'/' + cast(YEAR(d.NGAYLAP)as nchar)
		
		from HOADON d, CTHD c
		where d.MAHD = c.MAHD AND 
			YEAR(d.NGAYLAP) >= @NAMBD AND 
			YEAR(d.NGAYLAP) <= @NAMKT AND 
			MONTH(d.NGAYLAP) >= @THANGBD AND 
			MONTH(d.NGAYLAP) <= @THANGKT 
		group by MONTH(d.NGAYLAP), YEAR(d.NGAYLAP), c.MAHH
		) T, HANGHOA H
		WHERE T.MAHH = H.MAHH
		ORDER BY CONVERT(datetime,'1/' +THANGNAM  ,103)

		

		--DROP TABLE #THPX1
	END
END

ELSE
BEGIN 
	IF @NX <> 'X'
	BEGIN
		SELECT T.THANGNAM, H.TEN, T.SL, T.DONGIA
		FROM (
			select MAHH = c.MAHH, SL = sum(c.sl) ,DONGIA = sum(c.dongia * c.sl), THANGNAM = cast(MONTH(d.NGAYLAP) as nchar(2)) +'/' + cast(YEAR(d.NGAYLAP)as nchar)
		
		from LINK0.QLVT.DBO.PHIEUNHAP d, LINK0.QLVT.DBO.CTPN c
		where d.MAPN = c.MAPN AND 
			YEAR(d.NGAYLAP) >= @NAMBD AND 
			YEAR(d.NGAYLAP) <= @NAMKT AND 
			MONTH(d.NGAYLAP) >= @THANGBD AND 
			MONTH(d.NGAYLAP) <= @THANGKT 
		group by MONTH(d.NGAYLAP), YEAR(d.NGAYLAP), c.MAHH
		) T, HANGHOA H
		WHERE T.MAHH = H.MAHH
		ORDER BY CONVERT(datetime,'1/' +THANGNAM  ,103)

		--DROP TABLE #THPN2
	END
	ELSE 
	BEGIN
		
		SELECT T.THANGNAM, H.TEN, T.SL, T.DONGIA
		FROM (
		select MAHH = c.MAHH, SL = sum(c.sl) ,DONGIA = sum(c.dongia * c.sl), THANGNAM = cast(MONTH(d.NGAYLAP) as nchar(2)) +'/' + cast(YEAR(d.NGAYLAP)as nchar)
	
		from LINK0.QLVT.DBO.HOADON d, LINK0.QLVT.DBO.CTHD c
		where d.MAHD = c.MAHD AND 
			YEAR(d.NGAYLAP) >= @NAMBD AND 
			YEAR(d.NGAYLAP) <= @NAMKT AND 
			MONTH(d.NGAYLAP) >= @THANGBD AND 
			MONTH(d.NGAYLAP) <= @THANGKT 
		group by MONTH(d.NGAYLAP), YEAR(d.NGAYLAP), c.MAHH
		) T, HANGHOA H
		WHERE T.MAHH = H.MAHH
		ORDER BY CONVERT(datetime,'1/' +THANGNAM  ,103)

		--DROP TABLE #THPX2
	END
END

GO
GO
/****** Object:  StoredProcedure [dbo].[sp_TraCuu_KiemTraMaKho]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraCuu_KiemTraMaKho]
	@MAKHO nchar(20)
as
begin
	if( exists( select 1 
				from LINK0.QLVT.DBO.KHO as K 
				where K.MAKHO = @MAKHO ) )
		return 1; -- ton tai
	return 0;-- khong ton tai
end
GO
GO
/****** Object:  StoredProcedure [dbo].[sp_TraCuu_KiemTraMaNhanVien]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_TraCuu_KiemTraMaNhanVien]
	@MANHANVIEN nchar(20)
as
begin
	if exists( select * from LINK0.QLVT.DBO.NHANVIEN as NV where NV.MANV = @MANHANVIEN)
		return 1; -- ma nhan vien ton tai
	return 0; -- ma nhan vien khong ton tai
end
GO
GO
/****** Object:  View [dbo].[view_ChonChiTietDonDat]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_ChonChiTietDonDat]
AS
WITH donNhap AS (SELECT        SUM(c.SL) AS SL, c.MAHH, p.MADD
                                          FROM            dbo.PHIEUNHAP AS p LEFT OUTER JOIN
                                                                   dbo.CTPN AS c ON c.MAPN = p.MAPN
                                          GROUP BY c.MAHH, p.MADD)
    SELECT        K.MADD, K.MAHH, K.SLDAT, K.SLNHAP, H.TEN
     FROM            (SELECT        c.MADD, c.MAHH, c.SL AS SLDAT, ISNULL(d.SL, 0) AS SLNHAP
                               FROM            dbo.CTDD AS c LEFT OUTER JOIN
                                                         donNhap AS d ON c.MAHH = d.MAHH AND c.MADD = d.MADD) AS K INNER JOIN
                              dbo.HANGHOA AS H ON K.MAHH = H.MAHH
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "H"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "K"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_ChonChiTietDonDat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_ChonChiTietDonDat'
GO
GO
/****** Object:  View [dbo].[view_ChonChiTietHoaDon]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_ChonChiTietHoaDon]
AS
WITH DANHAP AS (SELECT        P.MAKHO, C.MAHH, SUM(C.SL) AS SL
                                         FROM            dbo.CTPN AS C INNER JOIN
                                                                  dbo.PHIEUNHAP AS P ON C.MAPN = P.MAPN
                                         GROUP BY P.MAKHO, C.MAHH), DABAN AS
    (SELECT        P.MAKHO, C.MAHH, SUM(C.SL) AS SL
      FROM            dbo.CTHD AS C INNER JOIN
                                dbo.HOADON AS P ON C.MAHD = P.MAHD
      GROUP BY P.MAKHO, C.MAHH), TONGHOP AS
    (SELECT        N.MAKHO, N.MAHH, N.SL - ISNULL(B.SL, 0) AS SL
      FROM            DABAN AS B RIGHT OUTER JOIN
                                DANHAP AS N ON B.MAHH = N.MAHH)
    SELECT        T.MAKHO, T.MAHH, T.SL, H.TEN AS TENHH, K.TEN AS TENKHO, H.DONGIA
     FROM            TONGHOP AS T INNER JOIN
                              dbo.HANGHOA AS H ON T.MAHH = H.MAHH INNER JOIN
                              dbo.KHO AS K ON T.MAKHO = K.MAKHO
     WHERE        (T.SL > 0)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[14] 2[27] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "H"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "K"
            Begin Extent = 
               Top = 120
               Left = 38
               Bottom = 250
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_ChonChiTietHoaDon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_ChonChiTietHoaDon'
GO
GO
/****** Object:  View [dbo].[view_DanhSachPhanManh]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_DanhSachPhanManh]
AS
	SELECT TENCN=PUBS.description, TENSERVER=subscriber_server
	 FROM sysmergepublications  PUBS, sysmergesubscriptions SUBS
 	WHERE PUBS.pubid = SUBS.pubid AND  publisher <> subscriber_server
GO
GO
/****** Object:  View [dbo].[view_DanhSachLoaiHangHoa]    Script Date: 14/12/2022 10:27:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_DanhSachLoaiHangHoa]
AS
	SELECT MA=MALHH, TEN FROM LOAIHANGHOA
GO
