using Microsoft.AspNetCore.Mvc;

namespace MeetUp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
