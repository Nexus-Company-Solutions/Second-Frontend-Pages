using Microsoft.AspNetCore.Mvc;

namespace front3.Controllers
{
    public class Help : Controller
    {
        public IActionResult HELP()
        {
            return View();
        }
    }
}
