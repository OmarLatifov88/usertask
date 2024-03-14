using Microsoft.AspNetCore.Mvc;

namespace user_register.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
