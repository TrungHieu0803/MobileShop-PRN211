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
            //So sánh Account
            if(ModelState.IsValid /*&& model.Email=="quoc@gmail.com" && model.Matkhau=="123456"*/)
            {

                
                var data = db.Nguoidungs.Where(s => s.Email.Equals(model.Email) && s.Matkhau.Equals(model.Matkhau)).ToList();
                //Tao 1 Session 
                HttpContext.Session.SetString("UserSession", JsonConvert.SerializeObject(model));
                return RedirectToAction("index", "Home");

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
            return View();
        }
        
        [HttpPost]
        
        public ActionResult Register(Nguoidung nguoidung)
        {
            if (ModelState.IsValid)
            {
                var check = db.Nguoidungs.FirstOrDefault(s => s.Email == nguoidung.Email );
                if (check == null)
                {
              
                    db.Nguoidungs.Add(nguoidung);
                    
                    db.SaveChanges();
                    HttpContext.Session.SetString("UserSession", JsonConvert.SerializeObject(nguoidung));
                    return RedirectToAction("index","Login");
                }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View();
                }


            }
            return View();


        }

    }
}
