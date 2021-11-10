using System;
using System.Collections.Generic;

#nullable disable

namespace MobileShop.Models
{
    public partial class Donhang
    {
        public int Madon { get; set; }
        public DateTime? Ngaydat { get; set; }
        public int? Tinhtrang { get; set; }
        public int? MaNguoidung { get; set; }

        public virtual Nguoidung MaNguoidungNavigation { get; set; }
    }
}
