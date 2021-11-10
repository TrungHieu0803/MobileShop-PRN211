using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MobileShop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MobileShop.Controllers
{
    public class SanphamController : Controller
    {

        MobileShopContext context = new MobileShopContext();

        public ActionResult Index(int? page, int? Mahang, string? keyword)
        {
            if(Mahang == null)
            {
                if (keyword == null) keyword = "";
                if (page == null) page = 1;
                var sanpham = context.Sanphams.Where(s => s.Tensp.ToLower().Contains(keyword.ToLower())).OrderBy(x => x.Masp);
                int pageSize = 9;
                int pageNumber = (page ?? 1);
                ViewBag.Hangsanxuats = context.Hangsanxuats.ToList();
                if (HttpContext.Session.GetString("UserSession") != null)
                    TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
                
                return View(sanpham.ToPagedList(pageNumber, pageSize));
            }
            else
            {
                if (keyword == null) keyword = "";
                if (page == null) page = 1;
                var sanpham = context.Sanphams.Where(s => s.Tensp.ToLower().Contains(keyword.ToLower()) && s.Mahang == Mahang).OrderBy(x => x.Masp);
                int pageSize = 9;
                int pageNumber = (page ?? 1);
                ViewBag.Hangsanxuats = context.Hangsanxuats.ToList();
                return View(sanpham.ToPagedList(pageNumber, pageSize));
            }
        }

        public IActionResult Detail(int id)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            var sanpham = context.Sanphams.Find(id);
            var hangselected = new SelectList(context.Hangsanxuats, "Mahang", "Tenhang", sanpham.Mahang);
            ViewBag.Mahang = hangselected;
            return View(sanpham);
        }
    }
}
