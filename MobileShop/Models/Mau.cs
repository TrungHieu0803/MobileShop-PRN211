using System;
using System.Collections.Generic;

#nullable disable

namespace MobileShop.Models
{
    public partial class Mau
    {
        public Mau()
        {
            Chitietdonhangs = new HashSet<Chitietdonhang>();
            MauSanphams = new HashSet<MauSanpham>();
        }

        public int Mamau { get; set; }
        public string Tenmau { get; set; }

        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }
        public virtual ICollection<MauSanpham> MauSanphams { get; set; }
    }
}
