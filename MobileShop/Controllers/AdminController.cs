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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
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
            return View(sanpham);
        }
        [HttpPost]
        public ActionResult EditProduct(Sanpham sanpham)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
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
            return View(donhang);
        }
        [HttpPost]
        public ActionResult EditDonhang(Donhang donhang)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            try
            {
                var anh = context.Anhs.FirstOrDefault(s => s.Maanh == id);
                context.Anhs.Remove(anh);
                context.SaveChanges();
                return RedirectToAction("EditProduct", anh.Masp);
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult AddAnh(Anh anh)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            try
            {
                context.Anhs.Add(anh);
                context.SaveChanges();
                return RedirectToAction("EditProduct",anh.Masp);
            }
            catch
            {
                return View();
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            try
            {
                var maucu = context.Maus.Find(mau.Mamau);
                maucu.Tenmau = mau.Tenmau;
                context.SaveChanges();
                return RedirectToAction("AnhIndex");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteMau(int id)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            try
            {
                var mau = context.Maus.FirstOrDefault(s => s.Mamau == id);
                context.Maus.Remove(mau);
                context.SaveChanges();
                return RedirectToAction("AnhIndex");
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
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            try
            {
                context.Maus.Add(mau);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddMauSanpham(int masp, int mamau)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            var mausanpham = new MauSanpham() { Mamau = mamau, Masp = masp };
            try
            {
                context.MauSanphams.Add(mausanpham);
                context.SaveChanges();
                return RedirectToAction("EditProduct",masp);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteMauSanpham(int masp, int mamau)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            try
            {
                var mausanpham = context.MauSanphams.FirstOrDefault(s => s.Mamau == mamau && s.Masp == masp);
                context.MauSanphams.Remove(mausanpham);
                context.SaveChanges();
                return RedirectToAction("EditProduct",masp);
            }
            catch
            {
                return View();
            }
        }
    }
}
