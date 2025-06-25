﻿using API.IRepository;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class GiayRepository : IGiayRepository
    {
        private readonly DbContextApp _context;

        public GiayRepository(DbContextApp context)
        {
            _context = context;
        }

        public async Task<Giay> AddAsync(Giay giay)
        {
            giay.GiayId = Guid.NewGuid();
            giay.NgayTao = DateTime.UtcNow;
            _context.Giays.Add(giay);
            await _context.SaveChangesAsync();
            return giay;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var giay = await _context.Giays.FindAsync(id);
            if (giay == null) return false;

            _context.Giays.Remove(giay);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Giay>> GetAllAsync()
        {
            return await _context.Giays
                .Include(g => g.ThuongHieu)
                .Include(g => g.ChatLieu)
                .Include(g => g.DeGiay)
                .Include(g => g.TheLoaiGiay)
                .Include(g => g.KieuDang)
                .Include(g => g.GiayChiTiets)
                    .ThenInclude(ct => ct.MauSac)
                .Include(g => g.GiayChiTiets)
                    .ThenInclude(ct => ct.KichCo)
                .ToListAsync();
        }


        public async Task<Giay> GetByIdAsync(Guid id)
        {
            return await _context.Giays
                .Include(g => g.ThuongHieu)
                .Include(g => g.ChatLieu)
                .Include(g => g.DeGiay)
                .Include(g => g.TheLoaiGiay)
                .Include(g => g.KieuDang)
                .Include(g => g.GiayChiTiets)
                    .ThenInclude(ct => ct.MauSac)
                .Include(g => g.GiayChiTiets)
                    .ThenInclude(ct => ct.KichCo)
                .FirstOrDefaultAsync(g => g.GiayId == id);
        }

        public async Task<IEnumerable<Giay>> SearchByTenAsync(string keyword)
        {
            return await _context.Giays
                .Where(g => g.TenGiay.Contains(keyword))
                .Include(g => g.ThuongHieu)
                .Include(g => g.ChatLieu)
                .Include(g => g.DeGiay)
                .Include(g => g.TheLoaiGiay)
                .Include(g => g.KieuDang)
                .Include(g => g.GiayChiTiets)
                    .ThenInclude(ct => ct.MauSac)
                .Include(g => g.GiayChiTiets)
                    .ThenInclude(ct => ct.KichCo)
                .ToListAsync();
        }


        public async Task<Giay> UpdateAsync(Giay giay)
        {
            var existing = await _context.Giays.FindAsync(giay.GiayId);
            if (existing == null) return null;

            existing.TenGiay = giay.TenGiay;
            existing.TrangThai = giay.TrangThai;
            existing.ThuongHieuId = giay.ThuongHieuId;
            existing.ChatLieuId = giay.ChatLieuId;
            existing.DeGiayId = giay.DeGiayId;
            existing.KieuDangId = giay.KieuDangId;
            existing.TheLoaiGiayId = giay.TheLoaiGiayId;

            await _context.SaveChangesAsync();
            return existing;
        }
    }
}