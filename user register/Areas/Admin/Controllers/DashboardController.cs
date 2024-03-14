using Microsoft.AspNetCore.Mvc;

namespace user_register.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
