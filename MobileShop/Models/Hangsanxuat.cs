﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MobileShop.Models
{
    public partial class Hangsanxuat
    {
        public Hangsanxuat()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public int Mahang { get; set; }
        public string Tenhang { get; set; }

        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
