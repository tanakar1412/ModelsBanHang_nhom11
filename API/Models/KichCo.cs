﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class KichCo
    {
        [Key]
        public Guid KichCoId { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯàáâãèéêìíòóôõùúăđĩũơưẠ-ỹ\s0-9]+$", ErrorMessage = "Tên chỉ được chứa chữ cái tiếng Việt, số và khoảng trắng")]
        public string TenKichCo { get; set; }

        public string MoTa { get; set; }

        public bool TrangThai { get; set; }
        public virtual ICollection<GiayChiTiet> GiayChiTiets { get; set; } = new List<GiayChiTiet>();
    }
}
