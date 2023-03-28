using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskEcomSite.DataAccess.Data;
using TaskEcomSite.Models;

namespace TaskEcomSite.Areas.User.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext _db;
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

         public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }

        // Dashboard
        public IActionResult Index()
        {
            return View();
        }



        // Login Any User
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {

            // logic for login user


            return RedirectToAction("Index");
        }

        // SignUp only dealer...

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Dealerdb dealerdb)
        {
            // logic for signup dealer
            return RedirectToAction("Login");

        }

    }
}
