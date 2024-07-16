using Microsoft.AspNetCore.Mvc;

namespace front3.Controllers
{
    public class Donations : Controller
    {
        public IActionResult Donate()
        {
            return View();
        }
    }
}
