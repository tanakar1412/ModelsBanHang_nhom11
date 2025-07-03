﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Models
{
    public class DiaChiKhachHang
    {
        [Key]
        public Guid DiaChiKhachHangId { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(200)]
        public string DiaChiCuThe { get; set; }

        [StringLength(100)]
        public string PhuongXa { get; set; }

        [StringLength(100)]
        public string QuanHuyen { get; set; }

        [StringLength(100)]
        public string ThanhPho { get; set; }

        public Guid KhachHangId { get; set; }

        public bool TrangThai { get; set; } = true;

        public bool IsDefault { get; set; } = false;

        public virtual KhachHang KhachHang { get; set; }

        public string DiaChiDayDu =>
            $"{DiaChiCuThe}, {PhuongXa}, {QuanHuyen}, {ThanhPho}"
            .Trim(' ', ',');
    }


}
