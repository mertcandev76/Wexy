using Microsoft.AspNetCore.Mvc;

namespace Wexy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
