using Microsoft.AspNetCore.Mvc;
using MobileShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MobileShop.Controllers
{
    public class UsersController : Controller
    {
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
        public IActionResult Login(Nguoidung model)
        {
            //So sánh Account
            if(ModelState.IsValid && model.Email=="quoc@gmail.vn" && model.Matkhau == "123456")
            {

            }
        }
    }
}
