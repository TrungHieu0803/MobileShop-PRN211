using Microsoft.AspNetCore.Mvc;
using MobileShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace MobileShop.Controllers
{
    public class UsersController : Controller
    {
        MobileShopContext db = new MobileShopContext();
        // Login 
        public IActionResult Index()
        {
            // khi chưa có quyền sẽ điều hướng về Login
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            Nguoidung model = new Nguoidung();
            return View();
        }
        [HttpPost]
        public IActionResult Login(Nguoidung model )
        {
            Nguoidung data = db.Nguoidungs.SingleOrDefault(s => s.Email.Equals(model.Email) && s.Matkhau.Equals(model.Matkhau));
            //So sánh Account
            if (!ModelState.IsValid && data != null)
            {
                HttpContext.Session.SetString("UserSession", JsonConvert.SerializeObject(model));
                if (data.Idquyen == 1)
                {
                    return RedirectToAction("index", "Admin");
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }


        //Register
        [HttpGet]
        public IActionResult Register()
        {
            Nguoidung nguoidung = new Nguoidung();
            return View(nguoidung);
        }
        
        [HttpPost]
        
        public ActionResult Register(Nguoidung nguoidung)
        {
            if (ModelState.IsValid)
            {
                var check = db.Nguoidungs.FirstOrDefault(s => s.Email == nguoidung.Email );
                Nguoidung user = new Nguoidung()
                {
                    Hoten = nguoidung.Hoten,
                    Email = nguoidung.Email,
                    Dienthoai = nguoidung.Dienthoai,
                    Diachi = nguoidung.Diachi,
                    Matkhau = nguoidung.Matkhau,
                    Idquyen = 2
                };
                if (check == null)
                {
              
                    db.Nguoidungs.Add(user);
                    
                    db.SaveChanges();
                    HttpContext.Session.SetString("UserSession", JsonConvert.SerializeObject(user));
                    return RedirectToAction("Login","Users");
                }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View();
                }

            }
            return View();
        }
        public ActionResult Logout(Nguoidung nguoidung)
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
