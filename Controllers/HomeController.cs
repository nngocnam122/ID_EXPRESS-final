using Microsoft.AspNetCore.Mvc;

namespace Renew_IDLine.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "ID Express - Vận Chuyển Quốc Tế Uy Tín Hàng Đầu";
            return View();
        }
    }
}
