using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MobileShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MobileShop.Controllers
{
    public class SanphamController : Controller
    {

        MobileShopContext db = new MobileShopContext();

        public IActionResult Index()
        {
            ViewData["iphone"] = db.Sanphams.Where(n => n.Mahang == 1).Take(4).ToList();
            ViewData["samsung"] = db.Sanphams.Where(n => n.Mahang == 2).Take(4).ToList();
            ViewData["xiaomi"] = db.Sanphams.Where(n => n.Mahang == 4).Take(4).ToList();
            return View();

            //if (page == null) page = 1;
            //var sanpham = db.Sanphams.OrderBy(x => x.Masp);
            //int pageSize = 8;
            //int pageNumber = (page ?? 1);
            //ViewBag.Hangsanxuats = db.Hangsanxuats.ToList();
            //return View(sanpham.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult Detail(int id)
        {
            var sanpham = db.Sanphams.Find(id);
            var hangselected = new SelectList(db.Hangsanxuats, "Mahang", "Tenhang", sanpham.Mahang);
            ViewBag.Mahang = hangselected;
            return View(sanpham);
        }
    }
}
