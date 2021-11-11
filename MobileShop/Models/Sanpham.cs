using System;
using System.Collections.Generic;

#nullable disable

namespace MobileShop.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Anhs = new HashSet<Anh>();
            Chitietdonhangs = new HashSet<Chitietdonhang>();
            MauSanphams = new HashSet<MauSanpham>();
        }

        public int Masp { get; set; }
        public string Tensp { get; set; }
        public decimal? Giatien { get; set; }
        public int? Soluong { get; set; }
        public string Mota { get; set; }
        public int? Thesim { get; set; }
        public int? Bonhotrong { get; set; }
        public bool? Sanphammoi { get; set; }
        public int? Ram { get; set; }
        public string Anhbia { get; set; }
        public int? Mahang { get; set; }
        public string Hedieuhanh { get; set; }
        public string Manhinh { get; set; }
        public string Chip { get; set; }
        public string Dungluongpin { get; set; }
        public string Dosangtoida { get; set; }
        public string Dophangiai { get; set; }
        public string Kichthuoc { get; set; }

        public virtual Hangsanxuat MahangNavigation { get; set; }
        public virtual ICollection<Anh> Anhs { get; set; }
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }
        public virtual ICollection<MauSanpham> MauSanphams { get; set; }
    }
}
