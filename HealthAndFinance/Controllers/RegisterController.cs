using HealthAndFinance.Entities.Concrete;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthAndFinance.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {

        

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
