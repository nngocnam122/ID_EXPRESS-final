using Microsoft.AspNetCore.Mvc;

namespace Renew_IDLine.Controllers
{
    public class DichVuController : Controller
    {
        [Route("van-chuyen-duong-hang-khong")]
        public IActionResult Air()
        {
            ViewBag.Title = "Vận chuyển đường Hàng Không | ID EXPRESS";
            return View();
        }
        [Route("van-chuyen-duong-bien")]
        public IActionResult Sea()
        {
            ViewBag.Title = "Vận chuyển đường Biển | ID EXPRESS";
            return View();
        }
        [Route("E-packet")]
        public IActionResult E_packet()
        {
            ViewBag.Title = "Vận chuyển Kiện Hàng Nhỏ (E-Packet) | ID EXPRESS";
            return View();
        }
        [Route("hang-cong-kenh")]
        public IActionResult Hang_cong_kenh()
        {
            ViewBag.Title = "Vận chuyển Hàng Cồng Kềnh | ID EXPRESS";
            return View();
        }
        [Route("nhan-ho-luu-kho")]
        public IActionResult Nhan_ho_luu_kho()
        {
            ViewBag.Title = "Nhận hàng hộ và Lưu kho | ID EXPRESS";
            return View();
        }
        [Route("hang-dac-thu")]
        public IActionResult Hang_dac_thu()
        {
            ViewBag.Title = "Vận chuyển hàng Đặc thù & Hạn chế | ID EXPRESS";
            return View();
        }
        
    }
}
