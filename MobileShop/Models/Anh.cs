using System;
using System.Collections.Generic;

#nullable disable

namespace MobileShop.Models
{
    public partial class Anh
    {
        public int Maanh { get; set; }
        public string Url { get; set; }
        public int Masp { get; set; }

        public virtual Sanpham MaspNavigation { get; set; }
    }
}
