using Microsoft.AspNetCore.Mvc;

namespace front2.Controllers
{
    public class Help : Controller
    {
        public IActionResult HELP()
        {
            return View();
        }
    }
}
