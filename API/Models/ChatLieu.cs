﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ChatLieu
    {
        [Key]
        public Guid ChatLieuId { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯàáâãèéêìíòóôõùúăđĩũơưẠ-ỹ\s0-9]+$", ErrorMessage = "Tên chỉ được chứa chữ cái tiếng Việt, số và khoảng trắng")]
        public string TenChatLieu { get; set; }

        public string MoTa { get; set; }

        public bool TrangThai { get; set; }
        public virtual ICollection<GiayChiTiet> GiayChiTiets { get; set; } = new List<GiayChiTiet>();
    }
}
