﻿using API.Models.DTO;
using Data.Models;

namespace API.IRepository
{
    //public interface IGioHangRepository
    //{
    //    Task<IEnumerable<GioHang>> GetAllGioHang();
    //    Task<GioHang> GetGioHang(Guid id);
    //    Task CreateGioHang(GioHang gh);
    //    Task UpdateGioHang(GioHang gh);
    //    Task DeleteGioHang(Guid id);
    //}
    public interface IGioHangRepository
    {
        Task<GioHang> GetByTaiKhoanIdAsync(Guid taiKhoanId);
        Task<bool> CapNhatSoLuongAsync(Guid chiTietId, int soLuong);
        Task<bool> XoaSanPhamAsync(Guid chiTietId);
    }
}
