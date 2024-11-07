using HealthAndFinance.Business.Concrete;
using HealthAndFinance.Business.ValidationRules;
using HealthAndFinance.DataAccess.Concrete;
using HealthAndFinance.DataAccess.EntityFrameWork;
using HealthAndFinance.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace HealthAndFinance.WebUI.Controllers
{
    public class UserWeightController : Controller
    {
        HealthEntryManager hem = new HealthEntryManager(new EfHealthEntryRepository());
        Context c = new Context();

        public IActionResult Index()
        {
            var username = User.Identity.Name;

            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();

            var userid = c.Users.Where(x => x.Email == usermail).Select(y => y.Email).FirstOrDefault();


            ViewBag.Name = username;

            return View();
        }

        [HttpGet]
        public IActionResult HealthAdd()
        {
            List<SelectListItem> healthvalues = (from x in hem.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.User.NameSurname,
                                                     Value = x.UserId.ToString()
                                                 }).ToList();
            ViewBag.hv = healthvalues;
            return View();
        }
        [HttpPost]
        public IActionResult HealthAdd(HealthEntry p)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            var userID = c.Users.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            HealthEntryValidator hv = new HealthEntryValidator();
            FluentValidation.Results.ValidationResult results = hv.Validate(p);
            if (results.IsValid)
            {
                p.BKI = p.Weight / p.Height * 2;
                p.Date = DateTime.Now;
                hem.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.PropertyName);
                }
            }
            return View();
        }
    }
}
