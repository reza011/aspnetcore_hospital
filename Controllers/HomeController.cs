using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using hospital.Models;


namespace hospital
{
    public class HomeController : Controller{
        private MyDbContext db = new MyDbContext();
        public IActionResult Index()
        {
            DashboardViewModel dashboard = new DashboardViewModel();
            
            dashboard.doctors_count = db.Doctors.Count();
            dashboard.nurses_count = db.Nurses.Count();
            dashboard.patients_count = db.Patients.Count();
            return View(dashboard);
        }
    }   
}