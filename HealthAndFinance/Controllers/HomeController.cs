using HealthAndFinance.DataAccess.Concrete;
using HealthAndFinance.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HealthAndFinance.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Context c = new Context();
            var username = User.Identity.Name;

            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();

            var userid = c.Users.Where(x => x.Email == usermail).Select(y => y.Email).FirstOrDefault();

            
            ViewBag.Name = username;
            
           
            return View();
        }

        public PartialViewResult NavBar()
        {
            return PartialView();
        }




    }
}
