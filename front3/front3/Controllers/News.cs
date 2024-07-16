using Microsoft.AspNetCore.Mvc;

namespace front3.Controllers
{
    public class News : Controller
    {
        public IActionResult NEWS()
        {
            return View();
        }
    }
}
