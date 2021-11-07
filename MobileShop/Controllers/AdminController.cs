using Microsoft.AspNetCore.Mvc;
using MobileShop.Models;
using System.Linq;
using PagedList;
using System.Web.Mvc;


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
            return View(sanpham.ToPagedList(pageNumber, pageSize));
        }
        
    }
}
