using Microsoft.AspNetCore.Mvc;
using MobileShop.Models;
using System.Linq;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace MobileShop.Controllers
{
    public class AdminController : Controller
    {
        MobileShopContext context = new MobileShopContext();
        public ActionResult Index(int? page)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            if (page == null) page = 1;
            var sanpham = context.Sanphams.OrderBy(x => x.Masp);
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            ViewBag.Hangsanxuats = context.Hangsanxuats.ToList();
            return View(sanpham.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult AddProduct()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            var sanpham = context.Sanphams.Find(id);
            var hangselected = new SelectList(context.Hangsanxuats, "Mahang", "Tenhang", sanpham.Mahang);
            ViewBag.Mahang = hangselected;
            ViewBag.Mau = context.Maus.ToList();
            ViewBag.MauDaChon = context.MauSanphams.Where(m => m.Masp == id);
            ViewBag.Anh = context.Anhs.Where(a => a.Masp == id).ToList();
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            if (page == null) page = 1;
            var donhang = context.Donhangs.ToList();
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            ViewBag.Chitietdonhangs = context.Chitietdonhangs.ToList();
            return View(donhang.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult EditDonhang(int id)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            var donhang = context.Donhangs.Find(id);
            ViewBag.Nguoidungs = context.Nguoidungs.ToList();
            ViewBag.Chitietdonhangs = context.Chitietdonhangs.Where(s => s.Madon == id).ToList();
            ViewBag.Sanphams = context.Sanphams.ToList();
            ViewBag.Maus = context.Maus.ToList();
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
                return RedirectToAction("DonhangIndex");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult NguoidungIndex(int? page)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            if (page == null) page = 1;
            var nguoidung = context.Nguoidungs.Include(x => x.IdquyenNavigation);
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            ViewBag.Hangsanxuats = context.Hangsanxuats.ToList();
            return View(nguoidung.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult EditNguoidung(int id)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            var nguoidung = context.Nguoidungs.Find(id);
            var quyenselected = new SelectList(context.PhanQuyens, "Idquyen", "TenQuyen", nguoidung.Idquyen);
            ViewBag.IDQuyen = quyenselected;
            return View(nguoidung);
        }
        [HttpPost]
        public ActionResult EditNguoidung(Nguoidung nguoidung)
        {
            try
            {
                var nguoidungcu = context.Nguoidungs.Find(nguoidung.MaNguoiDung);
                nguoidungcu.Hoten = nguoidung.Hoten;
                nguoidungcu.Email = nguoidung.Email;
                nguoidungcu.Dienthoai = nguoidung.Dienthoai;
                nguoidungcu.Matkhau = nguoidung.Matkhau;
                nguoidungcu.Idquyen = nguoidung.Idquyen;

                context.SaveChanges();
                return RedirectToAction("NguoidungIndex");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteNguoidung(int id)
        {
            try
            {
                var nguoidung = context.Nguoidungs.FirstOrDefault(s => s.MaNguoiDung == id);
                context.Nguoidungs.Remove(nguoidung);
                context.SaveChanges();
                return RedirectToAction("NguoidungIndex");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult HangsanxuatIndex(int? page)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            if (page == null) page = 1;
            var hangsanxuat = context.Hangsanxuats.ToList();
            int pageSize = 8;
            int pageNumber = (page ?? 1);

            return View(hangsanxuat.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult EditHang(int id)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            var hangsanxuat = context.Hangsanxuats.Find(id);


            return View(hangsanxuat);
        }
        [HttpPost]
        public ActionResult EditHang(Hangsanxuat hangsanxuat)
        {
            try
            {
                var hangcu = context.Hangsanxuats.Find(hangsanxuat.Mahang);
                hangcu.Tenhang = hangsanxuat.Tenhang;
                context.SaveChanges();
                return RedirectToAction("HangsanxuatIndex");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteHang(int id)
        {
            try
            {
                var hangsanxuat = context.Hangsanxuats.FirstOrDefault(s => s.Mahang == id);
                context.Hangsanxuats.Remove(hangsanxuat);
                context.SaveChanges();
                return RedirectToAction("HangsanxuatIndex");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddHang()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));

            return View();
        }
        [HttpPost]
        public ActionResult AddHang(Hangsanxuat hangsanxuat)
        {
            try
            {
                context.Hangsanxuats.Add(hangsanxuat);
                context.SaveChanges();
                return RedirectToAction("HangsanxuatIndex");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteAnh(int id)
        {
            try
            {
                var anh = context.Anhs.FirstOrDefault(s => s.Maanh == id);
                context.Anhs.Remove(anh);
                context.SaveChanges();
                return RedirectToAction("EditProduct", new { id = anh.Masp });
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult AddAnh(string url, int masp)
        {
            try
            {
                var anh = new Anh() { Url = url, Masp = masp };
                context.Anhs.Add(anh);
                context.SaveChanges();
                return RedirectToAction("EditProduct", new { id = masp });
            }
            catch
            {
                return RedirectToAction("EditProduct", new { id = masp });
            }
        }


        public ActionResult MauIndex(int? page)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            if (page == null) page = 1;
            var mau = context.Maus.ToList();
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(mau.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult EditMau(int id)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            var mau = context.Maus.Find(id);
            return View(mau);
        }
        [HttpPost]
        public ActionResult EditMau(Mau mau)
        {
            try
            {
                var maucu = context.Maus.Find(mau.Mamau);
                maucu.Tenmau = mau.Tenmau;
                context.SaveChanges();
                return RedirectToAction("MauIndex");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteMau(int id)
        {
            try
            {
                var mau = context.Maus.FirstOrDefault(s => s.Mamau == id);
                context.Maus.Remove(mau);
                context.SaveChanges();
                return RedirectToAction("MauIndex");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult AddMau()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            return View();
        }
        [HttpPost]
        public ActionResult AddMau(Mau mau)
        {
            try
            {
                context.Maus.Add(mau);
                context.SaveChanges();
                return RedirectToAction("MauIndex");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult AddMauSanpham(int masp, int mamau)
        {
            try
            {
                MauSanpham mauSanpham = new MauSanpham() { Masp = masp, Mamau = mamau };
                context.MauSanphams.Add(mauSanpham);
                context.SaveChanges();
                return RedirectToAction("EditProduct", new { id = masp });
            }
            catch
            {
                return RedirectToAction("EditProduct", new { id = masp });
            }
        }
        public ActionResult DeleteMauSanpham(int masp, int mamau)
        {
            try
            {
                var mausanpham = context.MauSanphams.FirstOrDefault(s => s.Mamau == mamau && s.Masp == masp);
                context.MauSanphams.Remove(mausanpham);
                context.SaveChanges();
                return RedirectToAction("EditProduct", new { id = masp });
            }
            catch
            {
                return RedirectToAction("EditProduct", new { id = masp });
            }
        }
    }
}
