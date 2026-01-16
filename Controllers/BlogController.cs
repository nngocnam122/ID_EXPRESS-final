using Microsoft.AspNetCore.Mvc;

namespace Renew_IDLine.Controllers
{
    public class BlogController : Controller
    {
        [Route("chi-tiet-bai-viet-1")]
        public IActionResult Post_1()
        {
            ViewBag.Title = "Gửi hàng đi Mỹ giá rẻ: Đừng để mất tiền oan vì đóng gói sai cách | ID EXPRESS";
            return View();
        }

        [Route("chi-tiet-bai-viet-2")]
        public IActionResult Post_2()
        {
            ViewBag.Title = "Từ A-Z quy trình vận chuyển hàng hóa đi Úc cho người lần đầu | ID EXPRESS";
            return View();
        }

        [Route("chi-tiet-bai-viet-3")]
        public IActionResult Post_3()
        {
            ViewBag.Title = "Gửi yến sào, thuốc tây đi nước ngoài: Những điều kiện bắt buộc phải biết | ID EXPRESS";

            return View();
        }
    }
}
