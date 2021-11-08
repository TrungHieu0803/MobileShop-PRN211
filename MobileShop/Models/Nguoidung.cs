using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public string Email { get; set; }
        public string Dienthoai { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password not empty.")]
        public string Matkhau { get; set; }
        public int? Idquyen { get; set; }
        public string Diachi { get; set; }

        public virtual PhanQuyen IdquyenNavigation { get; set; }
        public virtual ICollection<Donhang> Donhangs { get; set; }
    }
}
