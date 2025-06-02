﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Voucher
    {
        [Key]
        public Guid VoucherId { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯàáâãèéêìíòóôõùúăđĩũơưẠ-ỹ\s0-9]+$", ErrorMessage = "Tên chỉ được chứa chữ cái tiếng Việt, số và khoảng trắng")]
        public string TenVoucher { get; set; }

        [Required]
        public DateTime NgayBatDau { get; set; }

        [Required]
        public DateTime NgayKetThuc { get; set; }

        [Range(0, 100)]
        public float PhanTram { get; set; }

        public bool TrangThai { get; set; }

        public int SoLuong { get; set; }

        public string MaTaiKhoan { get; set; }

        public void Validate()
        {
            if (NgayBatDau.Date < DateTime.Today)
                throw new Exception("Ngày bắt đầu không hợp lệ.");
            if (NgayKetThuc <= NgayBatDau)
                throw new Exception("Ngày kết thúc phải sau ngày bắt đầu.");
        }
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }

}
