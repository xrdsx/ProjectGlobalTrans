using Microsoft.AspNetCore.Mvc;

namespace GlobalTrans.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
