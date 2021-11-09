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
            return View(model);
        }
        [HttpPost]
        public IActionResult Login(Nguoidung model)
        {


            //So sánh Account
            var data = db.Nguoidungs.Where(s => s.Email.Equals(model.Email) && s.Matkhau.Equals(model.Matkhau)).ToList();
            //Tao 1 Session 
            if (data != null)
            {
                HttpContext.Session.SetString("UserSession", JsonConvert.SerializeObject(model));




                return RedirectToAction("index", "Home");

            }
            else
            {
                return RedirectToAction("Register");
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
                var check = db.Nguoidungs.FirstOrDefault(s => s.Email == nguoidung.Email);
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
                    return RedirectToAction("index", "Home");
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
            return View("Login");
        }

    }

}
