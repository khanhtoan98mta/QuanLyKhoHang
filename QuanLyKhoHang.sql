USE [master]
GO
/****** Object:  Database [QuanLyKhoHang]    Script Date: 11/26/2019 2:15:45 PM ******/
CREATE DATABASE [QuanLyKhoHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhoHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyKhoHang.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyKhoHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyKhoHang_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyKhoHang] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhoHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhoHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhoHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhoHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhoHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhoHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKhoHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhoHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhoHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhoHang] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyKhoHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKhoHang] SET QUERY_STORE = OFF
GO
USE [QuanLyKhoHang]
GO
/****** Object:  UserDefinedFunction [dbo].[GetDongiaSP]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetDongiaSP]
(@soluong int,
@gia float)
returns float
as
begin
	return (@soluong * @gia)
end
GO
/****** Object:  Table [dbo].[ChitietPhieuxuat]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChitietPhieuxuat](
	[PXID] [int] NOT NULL,
	[SPID] [int] NULL,
	[Soluong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sanpham]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sanpham](
	[IDSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[NCCID] [int] NOT NULL,
	[Gia] [float] NOT NULL,
	[Soluong] [int] NOT NULL,
 CONSTRAINT [PK_Sanpham] PRIMARY KEY CLUSTERED 
(
	[IDSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAmount1]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetAmount1]
(@id int)
returns table
as
return
(
	select sum(ChitietPhieuxuat.Soluong) as amount
	from ChitietPhieuxuat,Sanpham
	where Sanpham.IDSP = ChitietPhieuxuat.SPID and ChitietPhieuxuat.PXID = @id
)
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[IDNV] [int] NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[Gioitinh] [nvarchar](20) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Dienthoai] [text] NOT NULL,
	[Email] [text] NOT NULL,
 CONSTRAINT [PK_Nhanvien_1] PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieuxuat]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieuxuat](
	[IDPX] [int] IDENTITY(1,1) NOT NULL,
	[KHID] [int] NOT NULL,
	[NVID] [int] NOT NULL,
	[Ngayxuat] [date] NOT NULL,
 CONSTRAINT [PK_Phieuxuat] PRIMARY KEY CLUSTERED 
(
	[IDPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[IDKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](300) NOT NULL,
	[Diachi] [nvarchar](300) NOT NULL,
	[Dienthoai] [text] NOT NULL,
	[Email] [text] NOT NULL,
 CONSTRAINT [PK_Khachhang_1] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Phieuxuat_view]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Phieuxuat_view]
as
select Phieuxuat.IDPX as'Mã phiếu',Khachhang.TenKH as 'Khách hàng',Nhanvien.TenNV as 'Nhân viên' ,Phieuxuat.Ngayxuat as'Ngày xuất' from Phieuxuat,Khachhang,Nhanvien
where Phieuxuat.KHID=Khachhang.IDKH and Nhanvien.IDNV=Phieuxuat.NVID
GO
/****** Object:  Table [dbo].[ChitietPhieunhap]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChitietPhieunhap](
	[PNID] [int] NOT NULL,
	[SPID] [int] NULL,
	[Soluong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAmount]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetAmount]
(@id int)
returns table
as
return
(
	select sum(ChitietPhieuNhap.Soluong) as amount
	from ChitietPhieuNhap,Sanpham
	where Sanpham.IDSP = ChitietPhieuNhap.SPID and ChitietPhieuNhap.PNID = @id
)
GO
/****** Object:  Table [dbo].[Phieunhap]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieunhap](
	[IDPN] [int] IDENTITY(1,1) NOT NULL,
	[NCCID] [int] NOT NULL,
	[NVID] [int] NOT NULL,
	[Ngaynhap] [date] NOT NULL,
 CONSTRAINT [PK_Phieunhap] PRIMARY KEY CLUSTERED 
(
	[IDPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Chitietphieunhap_view]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function	[dbo].[Chitietphieunhap_view]
(@Phieunhapid int)
returns table
as
return(
	select sp.IDSP, sp.TenSP, sp.Gia, ct.Soluong, dbo.GetDongiaSP(ct.Soluong, sp.Gia) as DG
	from Phieunhap pn
	inner join ChitietPhieuNhap ct on ct.PNID = pn.IDPN
	inner join Sanpham sp on sp.IDSP = ct.SPID
	where pn.IDPN = @Phieunhapid
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotal]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetTotal]
(@pnid int)
returns table
as
return
(
	select sum(DG) as total from Chitietphieunhap_view(@pnid)
)
GO
/****** Object:  Table [dbo].[Nhacungcap]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhacungcap](
	[IDNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](300) NOT NULL,
	[Diachi] [nvarchar](300) NOT NULL,
	[Dienthoai] [text] NOT NULL,
	[Email] [text] NOT NULL,
 CONSTRAINT [PK_Nhacungcap] PRIMARY KEY CLUSTERED 
(
	[IDNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_Phieunhap]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_Phieunhap]
AS
SELECT        ncc.TenNCC, nv.TenNV, pn.Ngaynhap, COUNT(*) AS SLSP, SUM(sp.Gia) AS tongtien
FROM            dbo.Phieunhap AS pn INNER JOIN
                         dbo.ChitietPhieuNhap AS ct ON ct.PNID = pn.PNID INNER JOIN
                         dbo.Sanpham AS sp ON sp.SPID = ct.SPID INNER JOIN
                         dbo.Nhanvien AS nv ON nv.NVID = pn.PNID INNER JOIN
                         dbo.Nhacungcap AS ncc ON ncc.NCCID = pn.NCCID
WHERE        (pn.PNID = 1)
GROUP BY ncc.TenNCC, nv.TenNV, pn.Ngaynhap
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotal1]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetTotal1]
(@pxid int)
returns table
as
return
(
	select sum(DG) as total from Chitietphieuxuat_view(@pxid)
)
GO
/****** Object:  Table [dbo].[Nguoidung]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nguoidung](
	[taikhoan] [varchar](50) NOT NULL,
	[matkhau] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, 10, 2)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, 11, 10)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (7, 10, 10)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (8, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieunhap] ([PNID], [SPID], [Soluong]) VALUES (6, NULL, NULL)
INSERT [dbo].[ChitietPhieuxuat] ([PXID], [SPID], [Soluong]) VALUES (25, NULL, NULL)
INSERT [dbo].[ChitietPhieuxuat] ([PXID], [SPID], [Soluong]) VALUES (25, 1, 2)
INSERT [dbo].[ChitietPhieuxuat] ([PXID], [SPID], [Soluong]) VALUES (26, NULL, NULL)
INSERT [dbo].[ChitietPhieuxuat] ([PXID], [SPID], [Soluong]) VALUES (26, 1, 1)
SET IDENTITY_INSERT [dbo].[Khachhang] ON 

INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (1, N'Đỗ Văn Tú', N'Hà Nội', N'0184234324', N'dovantu@gmail.com')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (2, N'Nguyễn Chí Hiếu', N'Hà Nội', N'0132546455', N'chihieu@gmail.com')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (3, N'Chu Nhật Linh', N'Hà Nội', N'01234343232', N'nhatlinh@gmail.com')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (4, N'Chử Kim Anh', N'Hà Nội', N'0989349343', N'chukimanh@gmail.com')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (8, N'Mai Khánh Huyền', N'Hà Nội', N'0231313132', N'khanhhuyen@gmail.com')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (9, N'Ngọc Anh', N'Hà Nội', N'0324323243', N'naxinh@gmail.com')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (12, N'Toan', N'Ninh binh', N'123                                                                                                 ', N'toan@gmail.com                                                                                      ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (13, N'Vũ Khánh Toàn', N'Hà Nội', N'123456789                                                                                           ', N'kt@gmail.com                                                                                        ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (14, N't', N't', N't                                                                                                   ', N't                                                                                                   ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (15, N'f', N'f', N'f                                                                                                   ', N'f                                                                                                   ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (16, N'Khánh', N'Hà đông', N'123                                                                                                 ', N'1232@gmail.com                                                                                      ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (17, N'Học', N'Ninh bình', N'123456                                                                                              ', N'12@gmail.com                                                                                        ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (18, N'7', N'7', N'7                                                                                                   ', N'7                                                                                                   ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (19, N'd', N'đ', N'd                                                                                                   ', N'd                                                                                                   ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (20, N'321', N'213', N'213                                                                                                 ', N'12                                                                                                  ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (21, N'dsa', N'dsad', N'sa                                                                                                  ', N'f                                                                                                   ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (22, N'fd', N'fd', N'fd                                                                                                  ', N'fd                                                                                                  ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (23, N'Sơn', N'Hà nội', N'112645                                                                                              ', N't@gmail.com                                                                                         ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (24, N'Hà', N'123', N'543                                                                                                 ', N'543543                                                                                              ')
INSERT [dbo].[Khachhang] ([IDKH], [TenKH], [Diachi], [Dienthoai], [Email]) VALUES (25, N'Hương', N'123', N'457                                                                                                 ', N'huong@gmail.com                                                                                     ')
SET IDENTITY_INSERT [dbo].[Khachhang] OFF
INSERT [dbo].[Nguoidung] ([taikhoan], [matkhau]) VALUES (N'admin', N'admin')
INSERT [dbo].[Nguoidung] ([taikhoan], [matkhau]) VALUES (N'kimson', N'kimson')
SET IDENTITY_INSERT [dbo].[Nhacungcap] ON 

INSERT [dbo].[Nhacungcap] ([IDNCC], [TenNCC], [Diachi], [Dienthoai], [Email]) VALUES (1, N'Hương Quỳnh', N'Hà Nội', N'0982338565', N'huongquynh@gmail.com')
INSERT [dbo].[Nhacungcap] ([IDNCC], [TenNCC], [Diachi], [Dienthoai], [Email]) VALUES (2, N'Mạnh Tuấn', N'Hà Nội', N'016580082321', N'manhtuan@gmail.com')
INSERT [dbo].[Nhacungcap] ([IDNCC], [TenNCC], [Diachi], [Dienthoai], [Email]) VALUES (3, N'Quang Hưng', N'Hà Nội', N'01236548220', N'quanghung@gmail.com')
INSERT [dbo].[Nhacungcap] ([IDNCC], [TenNCC], [Diachi], [Dienthoai], [Email]) VALUES (6, N'Khánh Huyền', N'Hà Nội', N'093463837', N'khanhhuyen@gmail.com')
INSERT [dbo].[Nhacungcap] ([IDNCC], [TenNCC], [Diachi], [Dienthoai], [Email]) VALUES (12, N'Thu Hương', N'Hà Nội', N'0982338565', N'huongquynh@gmail.com')
INSERT [dbo].[Nhacungcap] ([IDNCC], [TenNCC], [Diachi], [Dienthoai], [Email]) VALUES (13, N'Nguyễn Kim', N'Cổ Loa', N'0988888868', N'nguyenkim@gmail.com')
SET IDENTITY_INSERT [dbo].[Nhacungcap] OFF
INSERT [dbo].[Nhanvien] ([IDNV], [TenNV], [Gioitinh], [Diachi], [Dienthoai], [Email]) VALUES (1, N'Nguyễn Minh Chiến', N'Nam', N'Hà Nội', N'012232412', N'minhchien@gmail.com')
INSERT [dbo].[Nhanvien] ([IDNV], [TenNV], [Gioitinh], [Diachi], [Dienthoai], [Email]) VALUES (2, N'Nguyễn Ngọc Quân', N'Nam', N'Hà Đông', N'013243253', N'ngocquan@gmail.com')
INSERT [dbo].[Nhanvien] ([IDNV], [TenNV], [Gioitinh], [Diachi], [Dienthoai], [Email]) VALUES (3, N'Nguyễn Trí Mạnh', N'Nam', N'Hà Đông', N'010354666', N'trimanh@gmail.com')
SET IDENTITY_INSERT [dbo].[Phieunhap] ON 

INSERT [dbo].[Phieunhap] ([IDPN], [NCCID], [NVID], [Ngaynhap]) VALUES (6, 6, 1, CAST(N'2017-05-20' AS Date))
INSERT [dbo].[Phieunhap] ([IDPN], [NCCID], [NVID], [Ngaynhap]) VALUES (7, 6, 3, CAST(N'2017-05-20' AS Date))
INSERT [dbo].[Phieunhap] ([IDPN], [NCCID], [NVID], [Ngaynhap]) VALUES (8, 2, 1, CAST(N'2017-05-20' AS Date))
SET IDENTITY_INSERT [dbo].[Phieunhap] OFF
SET IDENTITY_INSERT [dbo].[Phieuxuat] ON 

INSERT [dbo].[Phieuxuat] ([IDPX], [KHID], [NVID], [Ngayxuat]) VALUES (13, 13, 1, CAST(N'2019-10-21' AS Date))
INSERT [dbo].[Phieuxuat] ([IDPX], [KHID], [NVID], [Ngayxuat]) VALUES (25, 24, 1, CAST(N'2019-10-21' AS Date))
INSERT [dbo].[Phieuxuat] ([IDPX], [KHID], [NVID], [Ngayxuat]) VALUES (26, 25, 1, CAST(N'2019-10-21' AS Date))
SET IDENTITY_INSERT [dbo].[Phieuxuat] OFF
SET IDENTITY_INSERT [dbo].[Sanpham] ON 

INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (1, N'Máy xay sinh tố', 1, 1900000, -12)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (2, N'Kệ sách 1', 3, 2000000, 0)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (3, N'Tủ lạnh', 3, 35000000, -9)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (4, N'Điều hòa', 1, 2650000, 0)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (5, N'Máy lọc nước', 2, 1900000, 0)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (6, N'Ti vi', 1, 35000000, 0)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (7, N'Kệ sách', 2, 2650000, 0)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (8, N'Máy đánh trứng', 3, 1900000, 0)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (9, N'iPhone 6', 1, 10000000, 0)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (10, N'Galaxy S8', 6, 19000000, 12)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (11, N'Điều hòa Panasonic', 6, 2650000, 8)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (12, N'Kệ sách 3', 12, 2000000, 0)
INSERT [dbo].[Sanpham] ([IDSP], [TenSP], [NCCID], [Gia], [Soluong]) VALUES (13, N'Vở ô ly', 12, 12000, 0)
SET IDENTITY_INSERT [dbo].[Sanpham] OFF
/****** Object:  Index [IX_ChitietPhieuNhap]    Script Date: 11/26/2019 2:15:45 PM ******/
CREATE NONCLUSTERED INDEX [IX_ChitietPhieuNhap] ON [dbo].[ChitietPhieunhap]
(
	[PNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ChitietPhieuNhap_1]    Script Date: 11/26/2019 2:15:45 PM ******/
CREATE NONCLUSTERED INDEX [IX_ChitietPhieuNhap_1] ON [dbo].[ChitietPhieunhap]
(
	[PNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChitietPhieunhap]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPhieuNhap_Phieunhap1] FOREIGN KEY([PNID])
REFERENCES [dbo].[Phieunhap] ([IDPN])
GO
ALTER TABLE [dbo].[ChitietPhieunhap] CHECK CONSTRAINT [FK_ChitietPhieuNhap_Phieunhap1]
GO
ALTER TABLE [dbo].[ChitietPhieunhap]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPhieuNhap_Sanpham1] FOREIGN KEY([SPID])
REFERENCES [dbo].[Sanpham] ([IDSP])
GO
ALTER TABLE [dbo].[ChitietPhieunhap] CHECK CONSTRAINT [FK_ChitietPhieuNhap_Sanpham1]
GO
ALTER TABLE [dbo].[ChitietPhieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPhieuxuat_Phieuxuat] FOREIGN KEY([PXID])
REFERENCES [dbo].[Phieuxuat] ([IDPX])
GO
ALTER TABLE [dbo].[ChitietPhieuxuat] CHECK CONSTRAINT [FK_ChitietPhieuxuat_Phieuxuat]
GO
ALTER TABLE [dbo].[ChitietPhieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPhieuxuat_Sanpham] FOREIGN KEY([SPID])
REFERENCES [dbo].[Sanpham] ([IDSP])
GO
ALTER TABLE [dbo].[ChitietPhieuxuat] CHECK CONSTRAINT [FK_ChitietPhieuxuat_Sanpham]
GO
ALTER TABLE [dbo].[Phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_Phieunhap_Nhacungcap] FOREIGN KEY([NCCID])
REFERENCES [dbo].[Nhacungcap] ([IDNCC])
GO
ALTER TABLE [dbo].[Phieunhap] CHECK CONSTRAINT [FK_Phieunhap_Nhacungcap]
GO
ALTER TABLE [dbo].[Phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_Phieunhap_Nhanvien] FOREIGN KEY([NVID])
REFERENCES [dbo].[Nhanvien] ([IDNV])
GO
ALTER TABLE [dbo].[Phieunhap] CHECK CONSTRAINT [FK_Phieunhap_Nhanvien]
GO
ALTER TABLE [dbo].[Phieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_Phieuxuat_Khachhang] FOREIGN KEY([KHID])
REFERENCES [dbo].[Khachhang] ([IDKH])
GO
ALTER TABLE [dbo].[Phieuxuat] CHECK CONSTRAINT [FK_Phieuxuat_Khachhang]
GO
ALTER TABLE [dbo].[Phieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_Phieuxuat_Nhanvien] FOREIGN KEY([NVID])
REFERENCES [dbo].[Nhanvien] ([IDNV])
GO
ALTER TABLE [dbo].[Phieuxuat] CHECK CONSTRAINT [FK_Phieuxuat_Nhanvien]
GO
/****** Object:  StoredProcedure [dbo].[Chitietphieunhap_delete]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Chitietphieunhap_delete]
@pnid int,
@spid int
as
begin
	update Sanpham 
	set Soluong -= (select Soluong from ChitietPhieuNhap where PNID = @pnid and SPID = @spid)
	where IDSP = @spid
	update ChitietPhieuNhap set SPID = null, Soluong = null
	where PNID = @pnid and SPID = @spid
	--delete ChitietPhieuNhap where PNID = @pnid and SPID = null and Soluong = null
end
GO
/****** Object:  StoredProcedure [dbo].[Chitietphieunhap_insert_update]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Chitietphieunhap_insert_update]
@pnid int,
@spid int,
@soluong int
as
begin
	if exists (select * from ChitietPhieuNhap where PNID = @pnid and SPID = @spid)
		begin
			update ChitietPhieuNhap set Soluong += @soluong
			where PNID = @pnid and SPID = @spid
		end
	else
		begin
			insert into ChitietPhieuNhap(PNID,SPID,Soluong) values(@pnid,@spid,@soluong)
		end
	update Sanpham set Soluong += @soluong
	where IDSP = @spid
end
GO
/****** Object:  StoredProcedure [dbo].[Chitietphieunhap_update]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Chitietphieunhap_update]
@pnid int,
@spid int,
@soluong int
as
begin
	declare @slc int
	select @slc =  Soluong from ChitietPhieuNhap where PNID = @pnid and SPID = @spid
	update ChitietPhieuNhap set Soluong = @soluong
	where PNID = @pnid and SPID = @spid
	update Sanpham set Soluong += @soluong - @slc
	where IDSP = @spid
end
GO
/****** Object:  StoredProcedure [dbo].[Chitietphieuxuat_delete]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Chitietphieuxuat_delete]
@PXid int,
@spid int
as
begin
	update Sanpham 
	set Soluong += (select Soluong from ChitietPhieuxuat where PXID = @PXid and SPID = @spid)
	where IDSP = @spid
	update ChitietPhieuxuat set SPID = null, Soluong = null
	where PXID = @PXid and SPID = @spid
	--delete ChitietPhieuxuat where PXID = @PXid and SPID = null and Soluong = null
end
GO
/****** Object:  StoredProcedure [dbo].[Chitietphieuxuat_insert_update]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Chitietphieuxuat_insert_update]
@pxid int,
@spid int,
@soluong int
as
begin
	
	insert into ChitietPhieuxuat(PXID,SPID,Soluong) values(@pxid,@spid,@soluong)
	
end
GO
/****** Object:  StoredProcedure [dbo].[Chitietphieuxuat_update]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Chitietphieuxuat_update]
@pxid int,
@spid int,
@soluong int
as
begin
	declare @slc int
	select @slc =  Soluong from Chitietphieuxuat where PXID = @pxid and SPID = @spid
	update Chitietphieuxuat set Soluong = @soluong
	where PXID = @pxid and SPID = @spid
	update Sanpham set Soluong += @slc - @soluong
	where IDSP = @spid
end
GO
/****** Object:  StoredProcedure [dbo].[Chitietphieuxuat_view]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Chitietphieuxuat_view] (@Id int)
as
	select SPID as 'Mã sản phẩm',TenSP as 'Sản phẩm',Gia as 'Giá', ChitietPhieuxuat.Soluong  as 'Số lượng' from ChitietPhieuxuat,Sanpham
	where ChitietPhieuxuat.SPID=Sanpham.IDSP
	and ChitietPhieuxuat.PXID=@Id
GO
/****** Object:  StoredProcedure [dbo].[Dangnhap_check]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Dangnhap_check]
@tk varchar(50),
@mk varchar(50)
as
begin
	if not exists(select Nguoidung.taikhoan from Nguoidung where taikhoan = @tk)
		select 1
	esle if not exists(select Nguoidung.matkhau from Nguoidung where matkhau = @mk)
		select 2
	else
		select 0
end
GO
/****** Object:  StoredProcedure [dbo].[Khachhang_delete]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Khachhang_delete]
@khid int
as
begin
	if exists (select * from Phieuxuat where KHID = @khid)
		select 1
	else
		begin
			delete Khachhang where IDKH =@khid
			select 0
		end
	
end
GO
/****** Object:  StoredProcedure [dbo].[Khachhang_insert]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Khachhang_insert]
@ten nvarchar(50),
@diachi nvarchar(50),
@dienthoai nchar(100),
@email nchar(100)
as
begin
	if not exists (select *from Khachhang where TenKH=@ten)
	begin
		insert into Khachhang(TenKH,Diachi,Dienthoai,Email)
		values(@ten,@diachi,@dienthoai,@email)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[Khachhang_update]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Khachhang_update]
@khid int,
@ten nvarchar(300),
@diachi nvarchar(300),
@dienthoai text,
@email text
as
begin
	update Khachhang
	set TenKH = @ten, Diachi = @diachi, Dienthoai = @dienthoai, Email=@email
	where IDKH = @khid
end
GO
/****** Object:  StoredProcedure [dbo].[Nhacungcap_delete]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Nhacungcap_delete]
@id int
as
begin
	if exists (select NCCID from Phieunhap where NCCID = @id)
		select 1
	else
		begin
			delete Sanpham where NCCID = @id
			delete Nhacungcap where IDNCC=@id
			select 0
		end
end

GO
/****** Object:  StoredProcedure [dbo].[Nhacungcap_insert]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Nhacungcap_insert]
@ten nvarchar(300),
@diachi nvarchar(300),
@dienthoai text,
@email text
as
begin
	insert into Nhacungcap(TenNCC,Diachi,Dienthoai,Email) values(@ten,@diachi,@dienthoai,@email)
end
GO
/****** Object:  StoredProcedure [dbo].[Nhacungcap_update]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Nhacungcap_update]
@id int,
@ten nvarchar(300),
@diachi nvarchar(300),
@dienthoai text,
@email text
as
begin
	update Nhacungcap
	set TenNCC = @ten, Diachi = @diachi, Dienthoai = @dienthoai, Email=@email
	where IDNCC = @id
end
GO
/****** Object:  StoredProcedure [dbo].[Phieunhap_delete]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Phieunhap_delete]
@id int
as
begin
	if (select * from GetAmount(@id))>0
		select 1
	else
		begin
			delete ChitietPhieuNhap
			where PNID = @id
			delete Phieunhap
			where IDPN = @id
			select 0
		end
end
GO
/****** Object:  StoredProcedure [dbo].[Phieunhap_insert]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Phieunhap_insert]
@nccid int,
@nvid int,
@ngaynhap date
as
begin
	insert into Phieunhap(NCCID,NVID,Ngaynhap) values (@nccid,@nvid,@ngaynhap)
	insert into ChitietPhieuNhap(PNID) values(SCOPE_IDENTITY())
end
GO
/****** Object:  StoredProcedure [dbo].[Phieunhap_update]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Phieunhap_update]
@id int,
@nccid int,
@nvid int,
@ngaynhap date
as
begin
	update Phieunhap set NCCID = @nccid, NVID = @nvid, Ngaynhap = @ngaynhap
	where IDPN = @id
end
GO
/****** Object:  StoredProcedure [dbo].[Phieunhap_view]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Phieunhap_view]
as
begin
	select pn.IDPN, ncc.TenNCC, nv.TenNV, pn.Ngaynhap, ncc.IDNCC, nv.IDNV
	from Phieunhap pn
	inner join Nhacungcap ncc on ncc.IDNCC = pn.NCCID
	inner join Nhanvien nv on nv.IDNV = pn.NVID
end
GO
/****** Object:  StoredProcedure [dbo].[Phieuxuat_delete]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Phieuxuat_delete]
@id int
as
begin
	if (select * from GetAmount(@id))>0
		select 1
	else
		begin
			delete ChitietPhieuxuat
			where PXID = @id
			delete Phieuxuat
			where IDPX = @id
			select 0
		end
end
GO
/****** Object:  StoredProcedure [dbo].[Phieuxuat_insert]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Phieuxuat_insert]
@tenkh nvarchar(100),
@nvid int,
@ngayxuat date
as
begin
	
	insert into Phieuxuat(KHID,NVID,Ngayxuat) values ((select IDKH from Khachhang where TenKH=@tenkh),@nvid,@ngayxuat)
	insert into ChitietPhieuxuat(PXID) values(SCOPE_IDENTITY())
	
end
GO
/****** Object:  StoredProcedure [dbo].[Phieuxuat_update]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Phieuxuat_update]
@id int,
@khid int,
@nvid int,
@ngayxuat date
as
begin
	update Phieuxuat set KHID = @khid, NVID = @nvid, Ngayxuat = @ngayxuat
	where IDPX = @id
end
GO
/****** Object:  StoredProcedure [dbo].[Sanpham_delete]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sanpham_delete]
@spid int
as
begin
	if exists(select * from Chitietphieunhap where SPID = @spid)
		select 1
	else if exists (select * from Chitietphieuxuat where SPID = @spid)
		select 2
	else 
		begin
			delete Sanpham where IDSP = @spid
			select 0
		end
end
GO
/****** Object:  StoredProcedure [dbo].[Sanpham_insert]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sanpham_insert]
@ten nvarchar(300),
@nccid int,
@gia float,
@soluong int
as
begin
	insert into Sanpham(TenSP,NCCID,Gia,Soluong) values(@ten,@nccid,@gia,@soluong)
end
GO
/****** Object:  StoredProcedure [dbo].[Sanpham_update]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sanpham_update]
@id int,
@ten nvarchar(300),
@nccid int,
@gia float
as
begin
	update Sanpham
	set TenSP = @ten,
		NCCID = @nccid,
		Gia = @gia
	where IDSP = @id
end
GO
/****** Object:  StoredProcedure [dbo].[Sanpham_view]    Script Date: 11/26/2019 2:15:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sanpham_view]
as
begin
select sp.IDSP, sp.TenSP, ncc.TenNCC, sp.Gia, sp.Soluong, sp.NCCID
from Sanpham sp
inner join Nhacungcap ncc on ncc.IDNCC = sp.NCCID
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[82] 4[6] 2[6] 3) )"
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
         Begin Table = "sp"
            Begin Extent = 
               Top = 148
               Left = 818
               Bottom = 278
               Right = 1004
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ncc"
            Begin Extent = 
               Top = 260
               Left = 438
               Bottom = 390
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pn"
            Begin Extent = 
               Top = 21
               Left = 221
               Bottom = 151
               Right = 407
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct"
            Begin Extent = 
               Top = 22
               Left = 603
               Bottom = 135
               Right = 789
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "nv"
            Begin Extent = 
               Top = 214
               Left = 6
               Bottom = 344
               Right = 192
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
      Begin ColumnWidths = 12
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
E' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Phieunhap'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'nd
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Phieunhap'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Phieunhap'
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhoHang] SET  READ_WRITE 
GO
