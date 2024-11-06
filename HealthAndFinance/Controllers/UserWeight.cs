using HealthAndFinance.DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HealthAndFinance.WebUI.Controllers
{
    public class UserWeight : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            var username = User.Identity.Name;

            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();

            var userid = c.Users.Where(x => x.Email == usermail).Select(y => y.Email).FirstOrDefault();


            ViewBag.Name = username;

            return View();
        }

        public IActionResult HealthAdd()
        {
            return View();
        }
    }
}
