using Microsoft.AspNetCore.Mvc;
using PizzaProject.Models;

namespace PizzaProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly PizzaContext db;
        private readonly ISession session;

        public LoginController(PizzaContext _db)  //constructor
        {
            db = _db;


        }



        [HttpGet]
        public IActionResult login()
        {
            //User emp = User.GetSingleEmployeeInfo();
            return View();
        }

        [HttpPost]
        public IActionResult Login(User l)
        {
            var result = (from i in db.Users
                          where i.Username == l.Username && i.Password == l.Password
                          select i).SingleOrDefault();
            if (result != null)
            {
                //HttpContext.Session.SetString("username", l.UserName);
                return RedirectToAction("Create", "User");
            }

            return null;

        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User l)
        {
            db.Users.Add(l);
            db.SaveChanges();
            return RedirectToAction("login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("login");
        }
    }
}
