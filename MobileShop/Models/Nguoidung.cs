using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MobileShop.Models
{
    public partial class Nguoidung
    {
        public Nguoidung()
        {
            Donhangs = new HashSet<Donhang>();
        }

        public int MaNguoiDung { get; set; }
        public string Hoten { get; set; }

        [Required(AllowEmptyStrings=false,ErrorMessage = "Email not empty.")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }
        public string Dienthoai { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password not empty.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        public string Matkhau { get; set; }
        public int? Idquyen { get; set; }
        public string Diachi { get; set; }

        public virtual PhanQuyen IdquyenNavigation { get; set; }
        public virtual ICollection<Donhang> Donhangs { get; set; }


        [NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Matkhau")]
        public string NhaplaiMatkhau { get; set; }

    }
}
