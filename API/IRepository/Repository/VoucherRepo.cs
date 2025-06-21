﻿using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API.IRepository.Repository
{
    public class VoucherRepo : IVoucherRepo
    {
        private readonly DbContextApp _context;
        public VoucherRepo(DbContextApp context)
        {
            _context = context;
        }
        public async Task Create(Voucher voucher)
        {
            try
            {
                // Gán ID nếu chưa có
                if (voucher.VoucherId == Guid.Empty)
                {
                    voucher.VoucherId = Guid.NewGuid();
                }

                // Xử lý tài khoản nếu là Guid.Empty
                if (voucher.IdTaiKhoan == Guid.Empty)
                {
                    voucher.IdTaiKhoan = null;
                }
                if (voucher.IdTaiKhoan != null)
                {
                    var tk = await _context.TaiKhoans.FindAsync(voucher.IdTaiKhoan);
                    if (tk == null)
                        throw new Exception("Tài khoản không tồn tại.");
                }


                voucher.Validate();

                _context.Vouchers.Add(voucher);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo voucher: {ex.Message} -- {(ex.InnerException != null ? ex.InnerException.Message : "Không có chi tiết nội bộ")}");
            }
        }

        public async Task<bool> Delete(Guid id)
        {
            var voucher = await _context.Vouchers.FindAsync(id);
            if (voucher == null)
            {
                return false; 
            }

            _context.Vouchers.Remove(voucher);
            await _context.SaveChangesAsync();
            return true; 
        }

        public async Task<List<Voucher>> GetAll() => await _context.Vouchers.ToListAsync();


        public async Task<Voucher> GetById(Guid id) => await _context.Vouchers.FindAsync(id) ?? throw new KeyNotFoundException("Voucher not found with the provided ID.");

        public async Task Update(Voucher voucher)
        {
            _context.Vouchers.Update(voucher);
            await _context.SaveChangesAsync();
        }
    }
}
