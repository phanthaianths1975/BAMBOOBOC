using Microsoft.AspNetCore.Mvc;

namespace BOC.Controllers
{
    public class BocController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
