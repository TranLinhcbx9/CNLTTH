USE [master]
GO
/****** Object:  Database [BanLinhKienMayTinh]    Script Date: 12/26/2020 2:56:18 PM ******/
CREATE DATABASE [BanLinhKienMayTinh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BanLinhKienMayTinh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BanLinhKienMayTinh.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BanLinhKienMayTinh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BanLinhKienMayTinh_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BanLinhKienMayTinh] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BanLinhKienMayTinh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BanLinhKienMayTinh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET ARITHABORT OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET  MULTI_USER 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BanLinhKienMayTinh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BanLinhKienMayTinh] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BanLinhKienMayTinh]
GO
/****** Object:  Table [dbo].[Anh]    Script Date: 12/26/2020 2:56:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Anh](
	[img] [nvarchar](50) NULL,
	[maAnh] [int] NOT NULL,
	[maLinhKien] [int] NOT NULL,
 CONSTRAINT [PK_Anh_1] PRIMARY KEY CLUSTERED 
(
	[maAnh] ASC,
	[maLinhKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 12/26/2020 2:56:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[maDonHang] [int] NOT NULL,
	[maLinhKien] [int] NOT NULL,
	[soLuong] [int] NULL,
	[donGia] [float] NULL,
	[ngayThang] [date] NULL,
	[donVi] [nvarchar](50) NULL,
	[tongTien] [float] NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[maDonHang] ASC,
	[maLinhKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 12/26/2020 2:56:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[maPhieuNhap] [int] NOT NULL,
	[maLinhKien] [int] NOT NULL,
	[soLuong] [int] NULL,
	[donGia] [float] NULL,
	[ngayThang] [date] NULL,
	[donVi] [nvarchar](50) NULL,
	[tongTien] [float] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC,
	[maLinhKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 12/26/2020 2:56:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[maPhieuXuat] [int] NOT NULL,
	[maLinhKien] [int] NOT NULL,
	[soLuong] [int] NULL,
	[donGia] [float] NULL,
	[donVi] [float] NULL,
	[ngayThang] [date] NULL,
	[tongTien] [float] NULL,
 CONSTRAINT [PK_ChiTietPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[maPhieuXuat] ASC,
	[maLinhKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 12/26/2020 2:56:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[maDonHang] [int] NOT NULL,
	[trangThai] [nvarchar](50) NULL,
	[maGioHang] [int] NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[maDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 12/26/2020 2:56:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[thongtin] [nvarchar](50) NULL CONSTRAINT [DF_GioHang_thongtin]  DEFAULT (getdate()),
	[maGioHang] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NULL,
 CONSTRAINT [PK_GioHang_1] PRIMARY KEY CLUSTERED 
(
	[maGioHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LinhKien]    Script Date: 12/26/2020 2:56:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LinhKien](
	[maLinhKien] [int] IDENTITY(1,1) NOT NULL,
	[maLoaiLinhKien] [int] NULL,
	[maNhaCungCap] [int] NULL,
	[maLoaiMay] [int] NULL,
	[tenLinhKien] [nvarchar](50) NULL,
	[thongSoKiThuat] [nvarchar](500) NULL,
	[moTa] [nvarchar](500) NULL,
	[giaBan] [float] NULL,
	[thoiGianBaoHanh] [nvarchar](50) NULL,
 CONSTRAINT [PK_LinhKien] PRIMARY KEY CLUSTERED 
(
	[maLinhKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiLinhKien]    Script Date: 12/26/2020 2:56:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiLinhKien](
	[maLoaiLinhKien] [int] IDENTITY(1,1) NOT NULL,
	[tenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiLinhKien] PRIMARY KEY CLUSTERED 
(
	[maLoaiLinhKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiMay]    Script Date: 12/26/2020 2:56:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMay](
	[maLoaiMay] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiMay] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiMay] PRIMARY KEY CLUSTERED 
(
	[maLoaiMay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCC]    Script Date: 12/26/2020 2:56:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[maNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[tenNhaCungCap] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCC] PRIMARY KEY CLUSTERED 
(
	[maNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/26/2020 2:56:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[maPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[tongTien] [float] NULL,
	[ngayThang] [date] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 12/26/2020 2:56:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[maPhieuXuat] [int] IDENTITY(1,1) NOT NULL,
	[tongTien] [float] NULL,
	[ngayThang] [date] NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[maPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/26/2020 2:56:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userName] [nvarchar](50) NOT NULL,
	[passWord] [nvarchar](50) NOT NULL,
	[chucNang] [nvarchar](50) NULL,
	[trangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users_1] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Anh] ([img], [maAnh], [maLinhKien]) VALUES (N'anh1', 1, 1)
INSERT [dbo].[Anh] ([img], [maAnh], [maLinhKien]) VALUES (N'anh2', 2, 1)
INSERT [dbo].[Anh] ([img], [maAnh], [maLinhKien]) VALUES (N'anh3', 3, 2)
INSERT [dbo].[DonHang] ([maDonHang], [trangThai], [maGioHang]) VALUES (1, N'được mua hàng', 4)
SET IDENTITY_INSERT [dbo].[GioHang] ON 

INSERT [dbo].[GioHang] ([thongtin], [maGioHang], [userName]) VALUES (N'gán xong tài khoản', 4, N'admin')
SET IDENTITY_INSERT [dbo].[GioHang] OFF
SET IDENTITY_INSERT [dbo].[LinhKien] ON 

INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (1, 1, 2, 1, N'bộ vi xử lý i5 9400f', N'Tốc độ xử lý  2.9 - 4.1 GHz9999999999999999999', N'Hàng chính hãng', 1500, N'36 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (2, 1, 2, 1, N'bộ vi xử lý i3 9100f ', N'Tốc độ xử lý  2.9 - 4.1 GHz', N'Hàng mới fullbox', 1500, N'36 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (3, 1, 2, 1, N'main h110', N'socket 1151v1', N'Hàng mới full box', 16500, N'36 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (4, 1, 2, 1, N'main b450', N'Hỗ trợ cho AMD Ryzen ™ thế hệ thứ 2 / Ryzen', N'hàng mới fullbox', 1500, N'36 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (5, 2, 1, 1, N'ram', N'4gb buss 2400', N'Hàng cũ', 1500, N'36 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (6, 2, 1, 2, N'ram', N'4gb buss 24444', N'Hàng cũ', NULL, N'6 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (7, 1, 2, 1, N'SSD', N'read 450mb/s write 500mb/s', N'hàng mới', 1500, N'36 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (8, 1, 1, 1, N'hdd', N'4gb buss 2400', N'Hàng mới', NULL, N'36 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (9, 1, 2, 1, N'Nguồn power 450', N'450W', N'Hàng mới bảo hành 3 năm', 1500, N'36 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (10, 1, 1, 1, N'Vỏ case', N'', N'Hàng mới', 1500, N'6 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (11, 1, 2, 1, N'rx570 8gb', N'8bg', N'Hnagf mới ', NULL, N'36 tháng')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (12, 1, 1, 1, N'1234', N'1', N'1', 1, N'1')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (13, 1, 1, 1, N'fgdfd', N'ghfgf', N'bjgjh', 54, N'vhh')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (14, 3, 1, 1, N'232', N'erwe', N'erer', 32, N'erw')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (15, 1, 1, 1, N'1', N'1', N'1', 1, N'1')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (16, 2, 2, 1, N'2', N'2', N'2', 2, N'2')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (17, 1, 1, 1, N'5', N'5', N'5', 5, N'5')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (1013, 1, 1, 1, N'1', N'9', N'9', 9, N'9')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (1014, 1, 1, 1, N'1', N'10', N'10', 10, N'10')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (1015, 3, 3, 3, N'3', N'3', N'33', 33, N'3')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (1016, NULL, NULL, NULL, N'3', N'3', N'3', 3, N'3')
INSERT [dbo].[LinhKien] ([maLinhKien], [maLoaiLinhKien], [maNhaCungCap], [maLoaiMay], [tenLinhKien], [thongSoKiThuat], [moTa], [giaBan], [thoiGianBaoHanh]) VALUES (1018, NULL, NULL, NULL, N'RAM kingmax', N'8G', N'mới nguyên seal', 100000, N'12 tháng')
SET IDENTITY_INSERT [dbo].[LinhKien] OFF
SET IDENTITY_INSERT [dbo].[LoaiLinhKien] ON 

INSERT [dbo].[LoaiLinhKien] ([maLoaiLinhKien], [tenLoai]) VALUES (1, N'RAM')
INSERT [dbo].[LoaiLinhKien] ([maLoaiLinhKien], [tenLoai]) VALUES (2, N'SSD')
INSERT [dbo].[LoaiLinhKien] ([maLoaiLinhKien], [tenLoai]) VALUES (3, N'Màn hình')
INSERT [dbo].[LoaiLinhKien] ([maLoaiLinhKien], [tenLoai]) VALUES (4, N'Chuột')
INSERT [dbo].[LoaiLinhKien] ([maLoaiLinhKien], [tenLoai]) VALUES (5, N'Bàn phím')
INSERT [dbo].[LoaiLinhKien] ([maLoaiLinhKien], [tenLoai]) VALUES (6, N'USB')
INSERT [dbo].[LoaiLinhKien] ([maLoaiLinhKien], [tenLoai]) VALUES (7, N'Loa')
INSERT [dbo].[LoaiLinhKien] ([maLoaiLinhKien], [tenLoai]) VALUES (8, N'Other')
INSERT [dbo].[LoaiLinhKien] ([maLoaiLinhKien], [tenLoai]) VALUES (9, N'Lót chuột')
SET IDENTITY_INSERT [dbo].[LoaiLinhKien] OFF
SET IDENTITY_INSERT [dbo].[LoaiMay] ON 

INSERT [dbo].[LoaiMay] ([maLoaiMay], [tenLoaiMay]) VALUES (1, N'Asus')
INSERT [dbo].[LoaiMay] ([maLoaiMay], [tenLoaiMay]) VALUES (2, N'Dell')
INSERT [dbo].[LoaiMay] ([maLoaiMay], [tenLoaiMay]) VALUES (3, N'Macbook')
INSERT [dbo].[LoaiMay] ([maLoaiMay], [tenLoaiMay]) VALUES (4, N'Case')
INSERT [dbo].[LoaiMay] ([maLoaiMay], [tenLoaiMay]) VALUES (5, N'Other')
INSERT [dbo].[LoaiMay] ([maLoaiMay], [tenLoaiMay]) VALUES (6, N'Lenovo')
INSERT [dbo].[LoaiMay] ([maLoaiMay], [tenLoaiMay]) VALUES (7, N'Surface')
SET IDENTITY_INSERT [dbo].[LoaiMay] OFF
SET IDENTITY_INSERT [dbo].[NhaCC] ON 

INSERT [dbo].[NhaCC] ([maNhaCungCap], [tenNhaCungCap]) VALUES (1, N'Phong Vũ')
INSERT [dbo].[NhaCC] ([maNhaCungCap], [tenNhaCungCap]) VALUES (2, N'Laptop24h')
INSERT [dbo].[NhaCC] ([maNhaCungCap], [tenNhaCungCap]) VALUES (3, N'Điện máy xanh')
SET IDENTITY_INSERT [dbo].[NhaCC] OFF
ALTER TABLE [dbo].[ChiTietDonHang] ADD  CONSTRAINT [DF_ChiTietDonHang_donGia]  DEFAULT ((0)) FOR [donGia]
GO
ALTER TABLE [dbo].[ChiTietDonHang] ADD  CONSTRAINT [DF_ChiTietDonHang_ngayThang]  DEFAULT (getdate()) FOR [ngayThang]
GO
ALTER TABLE [dbo].[ChiTietDonHang] ADD  CONSTRAINT [DF_ChiTietDonHang_donVi]  DEFAULT (N'vnd') FOR [donVi]
GO
ALTER TABLE [dbo].[ChiTietDonHang] ADD  CONSTRAINT [DF_ChiTietDonHang_tongTien]  DEFAULT ((0)) FOR [tongTien]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [DF_PhieuNhap_ngayThang]  DEFAULT (getdate()) FOR [ngayThang]
GO
ALTER TABLE [dbo].[PhieuXuat] ADD  CONSTRAINT [DF_PhieuXuat_ngayThang]  DEFAULT (getdate()) FOR [ngayThang]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_userName]  DEFAULT (N'userName.GetHashCode()+passWord.GetHashCode()') FOR [userName]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_chucNang]  DEFAULT (N'khachMua') FOR [chucNang]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_trangThai]  DEFAULT (N'off') FOR [trangThai]
GO
ALTER TABLE [dbo].[Anh]  WITH CHECK ADD  CONSTRAINT [FK_Anh_LinhKien] FOREIGN KEY([maLinhKien])
REFERENCES [dbo].[LinhKien] ([maLinhKien])
GO
ALTER TABLE [dbo].[Anh] CHECK CONSTRAINT [FK_Anh_LinhKien]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_DonHang] FOREIGN KEY([maDonHang])
REFERENCES [dbo].[DonHang] ([maDonHang])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DonHang]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_LinhKien] FOREIGN KEY([maLinhKien])
REFERENCES [dbo].[LinhKien] ([maLinhKien])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_LinhKien]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_LinhKien] FOREIGN KEY([maLinhKien])
REFERENCES [dbo].[LinhKien] ([maLinhKien])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_LinhKien]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([maPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([maPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_LinhKien] FOREIGN KEY([maLinhKien])
REFERENCES [dbo].[LinhKien] ([maLinhKien])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_LinhKien]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat] FOREIGN KEY([maPhieuXuat])
REFERENCES [dbo].[PhieuXuat] ([maPhieuXuat])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_GioHang] FOREIGN KEY([maGioHang])
REFERENCES [dbo].[GioHang] ([maGioHang])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_GioHang]
GO
USE [master]
GO
ALTER DATABASE [BanLinhKienMayTinh] SET  READ_WRITE 
GO
