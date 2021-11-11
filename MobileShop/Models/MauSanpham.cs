using System;
using System.Collections.Generic;

#nullable disable

namespace MobileShop.Models
{
    public partial class MauSanpham
    {
        public int Masp { get; set; }
        public int Mamau { get; set; }

        public virtual Mau MamauNavigation { get; set; }
        public virtual Sanpham MaspNavigation { get; set; }
    }
}
