using Microsoft.AspNetCore.Mvc;

namespace Renew_IDLine.Controllers
{
    public class CountryController : Controller
    {
        [Route("gui-hang-di-USA ")]
        public IActionResult USA()
        {
            return View();
        }
        [Route("gui-hang-di-Australia")]
        public IActionResult AUS()
        {
            return View();
        }
        [Route("gui-hang-di-Canada")]
        public IActionResult CAN()
        {
            return View();
        }
        [Route("gui-hang-di-Chau-Au")]
        public IActionResult ChauAU()
        {
            return View();
        }
        [Route("gui-hang-di-TrungQuoc-NhatBan-HanQuoc")]
        public IActionResult CNE_JPN_KOR()
        {
            return View();
        }
        [Route("gui-hang-di-Malaysia-Singapore")]
        public IActionResult MY_SGP()
        {
            return View();
        }
    }
}
