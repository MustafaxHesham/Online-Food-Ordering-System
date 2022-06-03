using Microsoft.AspNetCore.Mvc;

namespace OFOS.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
