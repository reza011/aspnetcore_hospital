using Microsoft.AspNetCore.Mvc;

namespace hospital
{
    public class AdminController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}