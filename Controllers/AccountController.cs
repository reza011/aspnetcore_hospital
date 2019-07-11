using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using hospital.Models;
using System.Linq;

namespace hospital
{
    public class AccountController : Controller
    {
        public IActionResult Login(){
            return View();
        }

        public ActionResult Validate(Admins admin)
        {
            MyDbContext db = new MyDbContext();
            var _admin = db.Admins.Where(s => s.Email == admin.Email);
            if(_admin.Any()){
                if(_admin.Where(s => s.Password == admin.Password).Any()){
                    
                    return Json(new { status = true, message = "با موفقیت وارد شدید"});
                }
                else
                {
                    return Json(new { status = false, message = "نام کاربری یا رمز عبور اشتباه است"});
                }
            }
            else
            {
                return Json(new { status = false, message = "نام کاربری یا رمز عبور اشتباه است"});
            }
        }
    }
}