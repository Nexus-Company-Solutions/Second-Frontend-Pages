using Microsoft.AspNetCore.Mvc;

namespace front2.Controllers
{
    public class News : Controller
    {
        public IActionResult NEWS()
        {
            return View();
        }
    }
}
