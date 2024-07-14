using Microsoft.AspNetCore.Mvc;

namespace front2.Controllers
{
    public class Donations : Controller
    {
        public IActionResult Donate()
        {
            return View();
        }
    }
}
