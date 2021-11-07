using Microsoft.AspNetCore.Mvc;
using MobileShop.Models;
using System.Linq;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace MobileShop.Controllers
{
    public class AdminController : Controller
    {
        MobileShopContext context = new MobileShopContext();
        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;
            var sanpham = context.Sanphams.OrderBy(x => x.Masp);
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            ViewBag.Hangsanxuats = context.Hangsanxuats.ToList();
            return View(sanpham.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult AddProduct()
        {
            var hangselected = new SelectList(context.Hangsanxuats, "Mahang", "Tenhang");
            ViewBag.Mahang = hangselected;
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Sanpham sanpham)
        {
            try
            {
                context.Sanphams.Add(sanpham);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult EditProduct(int id)
        {
            var sanpham = context.Sanphams.Find(id);
            var hangselected = new SelectList(context.Hangsanxuats, "Mahang", "Tenhang", sanpham.Mahang);
            ViewBag.Mahang = hangselected;
            return View(sanpham);
        }
        [HttpPost]
        public ActionResult EditProduct(Sanpham sanpham)
        {
            try
            {
                var sanphamcu = context.Sanphams.Find(sanpham.Masp);
                sanphamcu.Tensp = sanpham.Tensp;
                sanphamcu.Giatien = sanpham.Giatien;
                sanphamcu.Soluong = sanpham.Soluong;
                sanphamcu.Mota = sanpham.Mota;
                sanphamcu.Anhbia = sanpham.Anhbia;
                sanphamcu.Bonhotrong = sanpham.Bonhotrong;
                sanphamcu.Ram = sanpham.Ram;
                sanphamcu.Thesim = sanpham.Thesim;
                sanphamcu.Mahang = sanpham.Mahang;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteProduct(int id)
        {
            try
            {
                var sanpham = context.Sanphams.FirstOrDefault(s => s.Masp == id);
                context.Sanphams.Remove(sanpham);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DonhangIndex(int? page)
        {
            if (page == null) page = 1;
            var donhang = context.Donhangs.ToList();
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            ViewBag.Chitietdonhangs = context.Chitietdonhangs.ToList();
            return View(donhang.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult EditDonhang(int id)
        {
            var donhang = context.Donhangs.Find(id);
            ViewBag.Chitietdonhangs = context.Chitietdonhangs.ToList();
            return View(donhang);
        }
        [HttpPost]
        public ActionResult EditDonhang(Donhang donhang)
        {
            try
            {
                var donhangcu = context.Donhangs.Find(donhang.Madon);
                donhangcu.Tinhtrang = donhang.Tinhtrang;
                donhangcu.Ngaydat = donhang.Ngaydat;
                donhangcu.MaNguoidung = donhang.MaNguoidung;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
