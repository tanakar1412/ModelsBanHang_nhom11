﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class db0121 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatLieus",
                columns: table => new
                {
                    ChatLieuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChatLieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieus", x => x.ChatLieuId);
                });

            migrationBuilder.CreateTable(
                name: "ChucVus",
                columns: table => new
                {
                    ChucVuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MotaChucVu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVus", x => x.ChucVuId);
                });

            migrationBuilder.CreateTable(
                name: "DeGiays",
                columns: table => new
                {
                    DeGiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDeGiay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeGiays", x => x.DeGiayId);
                });

            migrationBuilder.CreateTable(
                name: "GiamGias",
                columns: table => new
                {
                    GiamGiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenGiamGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SanPhamKhuyenMai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhanTramKhuyenMai = table.Column<float>(type: "real", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiamGias", x => x.GiamGiaId);
                });

            migrationBuilder.CreateTable(
                name: "hinhThucThanhToans",
                columns: table => new
                {
                    HinhThucThanhToanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHinhThuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hinhThucThanhToans", x => x.HinhThucThanhToanId);
                });

            migrationBuilder.CreateTable(
                name: "KichCos",
                columns: table => new
                {
                    KichCoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKichCo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    size = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichCos", x => x.KichCoId);
                });

            migrationBuilder.CreateTable(
                name: "KieuDangs",
                columns: table => new
                {
                    KieuDangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKieuDang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuDangs", x => x.KieuDangId);
                });

            migrationBuilder.CreateTable(
                name: "MauSacs",
                columns: table => new
                {
                    MauSacId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSacs", x => x.MauSacId);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    TaikhoanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaytaotaikhoan = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.TaikhoanId);
                });

            migrationBuilder.CreateTable(
                name: "TheLoaiGiays",
                columns: table => new
                {
                    TheLoaiGiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoaiGiays", x => x.TheLoaiGiayId);
                });

            migrationBuilder.CreateTable(
                name: "ThongBaos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DaXem = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBaos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieus",
                columns: table => new
                {
                    ThuongHieuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenThuongHieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieus", x => x.ThuongHieuId);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhatCuoiCung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaiKhoanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.KhachHangId);
                    table.ForeignKey(
                        name: "FK_KhachHangs_TaiKhoans_TaiKhoanId",
                        column: x => x.TaiKhoanId,
                        principalTable: "TaiKhoans",
                        principalColumn: "TaikhoanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    ChucVuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaikhoanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayCapNhatCuoiCung = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.NhanVienId);
                    table.ForeignKey(
                        name: "FK_NhanViens_ChucVus_ChucVuId",
                        column: x => x.ChucVuId,
                        principalTable: "ChucVus",
                        principalColumn: "ChucVuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanViens_TaiKhoans_TaikhoanId",
                        column: x => x.TaikhoanId,
                        principalTable: "TaiKhoans",
                        principalColumn: "TaikhoanId");
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    VoucherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenVoucher = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhanTram = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    IdTaiKhoan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaikhoanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.VoucherId);
                    table.ForeignKey(
                        name: "FK_Vouchers_TaiKhoans_TaikhoanId",
                        column: x => x.TaikhoanId,
                        principalTable: "TaiKhoans",
                        principalColumn: "TaikhoanId");
                });

            migrationBuilder.CreateTable(
                name: "Giays",
                columns: table => new
                {
                    GiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatLieuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThuongHieuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KieuDangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TheLoaiGiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeGiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenGiay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giays", x => x.GiayId);
                    table.ForeignKey(
                        name: "FK_Giays_ChatLieus_ChatLieuId",
                        column: x => x.ChatLieuId,
                        principalTable: "ChatLieus",
                        principalColumn: "ChatLieuId");
                    table.ForeignKey(
                        name: "FK_Giays_DeGiays_DeGiayId",
                        column: x => x.DeGiayId,
                        principalTable: "DeGiays",
                        principalColumn: "DeGiayId");
                    table.ForeignKey(
                        name: "FK_Giays_KieuDangs_KieuDangId",
                        column: x => x.KieuDangId,
                        principalTable: "KieuDangs",
                        principalColumn: "KieuDangId");
                    table.ForeignKey(
                        name: "FK_Giays_TheLoaiGiays_TheLoaiGiayId",
                        column: x => x.TheLoaiGiayId,
                        principalTable: "TheLoaiGiays",
                        principalColumn: "TheLoaiGiayId");
                    table.ForeignKey(
                        name: "FK_Giays_ThuongHieus_ThuongHieuId",
                        column: x => x.ThuongHieuId,
                        principalTable: "ThuongHieus",
                        principalColumn: "ThuongHieuId");
                });

            migrationBuilder.CreateTable(
                name: "diaChiKhachHangs",
                columns: table => new
                {
                    DiaChiKhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDiaChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    khachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diaChiKhachHangs", x => x.DiaChiKhachHangId);
                    table.ForeignKey(
                        name: "FK_diaChiKhachHangs_KhachHangs_khachHangId",
                        column: x => x.khachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "KhachHangId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    GioHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTaoGioHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhatCuoiCung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.GioHangId);
                    table.ForeignKey(
                        name: "FK_GioHangs_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "KhachHangId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaiKhoanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HinhThucThanhToanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoucherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenCuaKhachHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SDTCuaKhachHang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmailCuaKhachHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayNhanHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTienSauKhiGiam = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.HoaDonId);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "KhachHangId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_TaiKhoans_TaiKhoanId",
                        column: x => x.TaiKhoanId,
                        principalTable: "TaiKhoans",
                        principalColumn: "TaikhoanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_Vouchers_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Vouchers",
                        principalColumn: "VoucherId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_HoaDons_hinhThucThanhToans_HinhThucThanhToanId",
                        column: x => x.HinhThucThanhToanId,
                        principalTable: "hinhThucThanhToans",
                        principalColumn: "HinhThucThanhToanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiayChiTiets",
                columns: table => new
                {
                    GiayChiTietId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KichCoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MauSacId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuongCon = table.Column<int>(type: "int", nullable: false),
                    AnhGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gia = table.Column<float>(type: "real", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiayChiTiets", x => x.GiayChiTietId);
                    table.ForeignKey(
                        name: "FK_GiayChiTiets_Giays_GiayId",
                        column: x => x.GiayId,
                        principalTable: "Giays",
                        principalColumn: "GiayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiayChiTiets_KichCos_KichCoId",
                        column: x => x.KichCoId,
                        principalTable: "KichCos",
                        principalColumn: "KichCoId");
                    table.ForeignKey(
                        name: "FK_GiayChiTiets_MauSacs_MauSacId",
                        column: x => x.MauSacId,
                        principalTable: "MauSacs",
                        principalColumn: "MauSacId");
                });

            migrationBuilder.CreateTable(
                name: "GiayDotGiamGias",
                columns: table => new
                {
                    GiayDotGiamGiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiamGiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiayDotGiamGias", x => x.GiayDotGiamGiaId);
                    table.ForeignKey(
                        name: "FK_GiayDotGiamGias_GiamGias_GiamGiaId",
                        column: x => x.GiamGiaId,
                        principalTable: "GiamGias",
                        principalColumn: "GiamGiaId");
                    table.ForeignKey(
                        name: "FK_GiayDotGiamGias_Giays_GiayId",
                        column: x => x.GiayId,
                        principalTable: "Giays",
                        principalColumn: "GiayId");
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiets",
                columns: table => new
                {
                    GioHangChiTietId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GioHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuongSanPham = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiets", x => x.GioHangChiTietId);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiets_Giays_GiayId",
                        column: x => x.GiayId,
                        principalTable: "Giays",
                        principalColumn: "GiayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiets_GioHangs_GioHangId",
                        column: x => x.GioHangId,
                        principalTable: "GioHangs",
                        principalColumn: "GioHangId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiets",
                columns: table => new
                {
                    HoaDonChiTietId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuongSanPham = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NgayTraHang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThaiChiTiet = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiets", x => x.HoaDonChiTietId);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_Giays_GiayId",
                        column: x => x.GiayId,
                        principalTable: "Giays",
                        principalColumn: "GiayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_HoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDons",
                        principalColumn: "HoaDonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anhs",
                columns: table => new
                {
                    AnhId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiayChiTietId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DuongDan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anhs", x => x.AnhId);
                    table.ForeignKey(
                        name: "FK_Anhs_GiayChiTiets_GiayChiTietId",
                        column: x => x.GiayChiTietId,
                        principalTable: "GiayChiTiets",
                        principalColumn: "GiayChiTietId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ChucVus",
                columns: new[] { "ChucVuId", "MotaChucVu", "TenChucVu", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Quản trị hệ thống", "Admin", 1 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Nhân viên bán hàng", "NhanVien", 1 }
                });

            migrationBuilder.InsertData(
                table: "KichCos",
                columns: new[] { "KichCoId", "MoTa", "TenKichCo", "TrangThai", "size" },
                values: new object[,]
                {
                    { new Guid("0e0818d8-8336-41c3-be55-2704c104fd7f"), "Cỡ giày 42", "Size 42", true, 42 },
                    { new Guid("19d0e7d7-0424-433f-a27e-5813a92db3e4"), "Cỡ giày 47", "Size 47", true, 47 },
                    { new Guid("1dfeed12-bf38-48f1-a32c-746eda203e04"), "Cỡ giày 43", "Size 43", true, 43 },
                    { new Guid("31ef77d6-43ab-41d1-a67f-a86e2870bccd"), "Cỡ giày 49", "Size 49", true, 49 },
                    { new Guid("3691ccb3-f06f-43d4-966f-70332d7bbfcf"), "Cỡ giày 45", "Size 45", true, 45 },
                    { new Guid("50a764b1-877c-4d43-8062-f48f85be9951"), "Cỡ giày 36", "Size 36", true, 36 },
                    { new Guid("6e6eecba-44d6-40d4-bc86-690f8dab8a37"), "Cỡ giày 37", "Size 37", true, 37 },
                    { new Guid("8a296580-906c-4075-aee0-fdbfcdfaa9ec"), "Cỡ giày 39", "Size 39", true, 39 },
                    { new Guid("a41a70d1-1c6d-41f2-9988-77c4c1caad2d"), "Cỡ giày 35", "Size 35", true, 35 },
                    { new Guid("a8f0a819-d686-4b15-a5a1-b0544d0dc31c"), "Cỡ giày 38", "Size 38", true, 38 },
                    { new Guid("ab3ab209-4464-4c2a-af38-df437add7951"), "Cỡ giày 44", "Size 44", true, 44 },
                    { new Guid("b4021533-e730-4bff-bcc2-a5199f147087"), "Cỡ giày 48", "Size 48", true, 48 },
                    { new Guid("d67c2153-b5f3-4fd3-9a98-2c005537f3fa"), "Cỡ giày 41", "Size 41", true, 41 },
                    { new Guid("db083133-befb-41b2-96be-74f53b65df44"), "Cỡ giày 50", "Size 50", true, 50 },
                    { new Guid("dd2d3a09-a4db-4961-83e8-cf5ba9584c27"), "Cỡ giày 46", "Size 46", true, 46 },
                    { new Guid("e3a847f8-b99d-4a61-a243-4d07267027d5"), "Cỡ giày 40", "Size 40", true, 40 }
                });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "MauSacId", "Color", "MoTa", "TenMau", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("05ccaa66-e1ba-4ebb-bae9-a89073d4e9d5"), "#FFFFFF", "Màu trắng", "Trắng", true },
                    { new Guid("12d69dd2-6853-4bbe-83e1-4721eab6ab61"), "#00FF00", "Màu xanh lá cây", "Xanh lá", true },
                    { new Guid("772a1dcd-e259-468c-8d37-605857c195a5"), "#0000FF", "Màu xanh dương cơ bản", "Xanh dương", true },
                    { new Guid("aab9374d-3a77-4ae8-b3af-fb0478a8de9d"), "#FFFF00", "Màu vàng", "Vàng", true },
                    { new Guid("c45ed066-5fac-4e04-b012-cdab2ff13594"), "#000000", "Màu đen", "Đen", true },
                    { new Guid("f17df5da-cf84-4c54-92be-8b44e83e7af6"), "#FF0000", "Màu đỏ cơ bản", "Đỏ", true }
                });

            migrationBuilder.InsertData(
                table: "TaiKhoans",
                columns: new[] { "TaikhoanId", "Ngaytaotaikhoan", "Password", "Username" },
                values: new object[] { new Guid("99999999-9999-9999-9999-999999999999"), new DateTime(2025, 7, 2, 13, 21, 53, 262, DateTimeKind.Local).AddTicks(3426), "admin123", "admin" });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "NhanVienId", "ChucVuId", "Email", "HoTen", "NgayCapNhatCuoiCung", "NgaySinh", "SoDienThoai", "TaikhoanId", "TrangThai" },
                values: new object[] { new Guid("88888888-8888-8888-8888-888888888888"), new Guid("11111111-1111-1111-1111-111111111111"), "admin@shop.com", "Nguyễn Văn Quản Trị", new DateTime(2025, 7, 2, 13, 21, 53, 262, DateTimeKind.Local).AddTicks(3503), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0987654321", new Guid("99999999-9999-9999-9999-999999999999"), true });

            migrationBuilder.CreateIndex(
                name: "IX_Anhs_GiayChiTietId",
                table: "Anhs",
                column: "GiayChiTietId");

            migrationBuilder.CreateIndex(
                name: "IX_diaChiKhachHangs_khachHangId",
                table: "diaChiKhachHangs",
                column: "khachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_GiayChiTiets_GiayId",
                table: "GiayChiTiets",
                column: "GiayId");

            migrationBuilder.CreateIndex(
                name: "IX_GiayChiTiets_KichCoId",
                table: "GiayChiTiets",
                column: "KichCoId");

            migrationBuilder.CreateIndex(
                name: "IX_GiayChiTiets_MauSacId",
                table: "GiayChiTiets",
                column: "MauSacId");

            migrationBuilder.CreateIndex(
                name: "IX_GiayDotGiamGias_GiamGiaId",
                table: "GiayDotGiamGias",
                column: "GiamGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_GiayDotGiamGias_GiayId",
                table: "GiayDotGiamGias",
                column: "GiayId");

            migrationBuilder.CreateIndex(
                name: "IX_Giays_ChatLieuId",
                table: "Giays",
                column: "ChatLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_Giays_DeGiayId",
                table: "Giays",
                column: "DeGiayId");

            migrationBuilder.CreateIndex(
                name: "IX_Giays_KieuDangId",
                table: "Giays",
                column: "KieuDangId");

            migrationBuilder.CreateIndex(
                name: "IX_Giays_TheLoaiGiayId",
                table: "Giays",
                column: "TheLoaiGiayId");

            migrationBuilder.CreateIndex(
                name: "IX_Giays_ThuongHieuId",
                table: "Giays",
                column: "ThuongHieuId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiets_GiayId",
                table: "GioHangChiTiets",
                column: "GiayId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiets_GioHangId",
                table: "GioHangChiTiets",
                column: "GioHangId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangs_KhachHangId",
                table: "GioHangs",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_GiayId",
                table: "HoaDonChiTiets",
                column: "GiayId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_HoaDonId",
                table: "HoaDonChiTiets",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_HinhThucThanhToanId",
                table: "HoaDons",
                column: "HinhThucThanhToanId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangId",
                table: "HoaDons",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_TaiKhoanId",
                table: "HoaDons",
                column: "TaiKhoanId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_VoucherId",
                table: "HoaDons",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHangs_TaiKhoanId",
                table: "KhachHangs",
                column: "TaiKhoanId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_ChucVuId",
                table: "NhanViens",
                column: "ChucVuId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_TaikhoanId",
                table: "NhanViens",
                column: "TaikhoanId",
                unique: true,
                filter: "[TaikhoanId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_TaikhoanId",
                table: "Vouchers",
                column: "TaikhoanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anhs");

            migrationBuilder.DropTable(
                name: "diaChiKhachHangs");

            migrationBuilder.DropTable(
                name: "GiayDotGiamGias");

            migrationBuilder.DropTable(
                name: "GioHangChiTiets");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "ThongBaos");

            migrationBuilder.DropTable(
                name: "GiayChiTiets");

            migrationBuilder.DropTable(
                name: "GiamGias");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "ChucVus");

            migrationBuilder.DropTable(
                name: "Giays");

            migrationBuilder.DropTable(
                name: "KichCos");

            migrationBuilder.DropTable(
                name: "MauSacs");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "hinhThucThanhToans");

            migrationBuilder.DropTable(
                name: "ChatLieus");

            migrationBuilder.DropTable(
                name: "DeGiays");

            migrationBuilder.DropTable(
                name: "KieuDangs");

            migrationBuilder.DropTable(
                name: "TheLoaiGiays");

            migrationBuilder.DropTable(
                name: "ThuongHieus");

            migrationBuilder.DropTable(
                name: "TaiKhoans");
        }
    }
}
