using HealthAndFinance.Business.Concrete;
using HealthAndFinance.Business.ValidationRules;
using HealthAndFinance.DataAccess.Concrete;
using HealthAndFinance.DataAccess.EntityFrameWork;
using HealthAndFinance.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Entity;
using System.Security.Claims;



namespace HealthAndFinance.WebUI.Controllers
{
	public class UserWeightController : Controller
	{
		HealthEntryManager hem = new HealthEntryManager(new EfHealthEntryRepository());
		private readonly UserManager<AppUser> _userManager;
		private readonly Context _context;

		public UserWeightController(UserManager<AppUser> userManager, Context context)
		{
			_userManager = userManager;
			_context = context;
		}

		public IActionResult Index()
		{
			ViewBag.name = User.Identity.Name;
			var values = hem.GetList();
			return View(values);
		}

        [HttpGet]
        public IActionResult HealthEntry()
        {
						ViewBag.name = User.Identity.Name;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HealthEntry(HealthEntry model)
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
            {
                return Unauthorized(); 
            }


            model.UserId = int.Parse(userId);


            _context.HealthEntries.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("UserHealthEntries");
        }

        [HttpGet]
        public IActionResult HealthAdd()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
            {
                return Unauthorized();
            }

            var entries = _context.HealthEntries
                .Where(e => e.UserId == int.Parse(userId))
                .ToList();

            return View(entries);
        }
        [HttpPost]
        public async Task<IActionResult> HealthAdd(HealthEntry model)
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
            {
                return Unauthorized(); 
            }


            model.UserId = int.Parse(userId);


            _context.HealthEntries.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("UserHealthEntries"); 
        }
    }
}
