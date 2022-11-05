using Microsoft.AspNetCore.Mvc;
using PizzaProject.Models;
using System.Security.AccessControl;

namespace PizzaProject.Controllers
{
    public class UserController : Controller
    {
        private readonly PizzaContext _db;

        public UserController(PizzaContext db)  //constructor
        {
            _db = db;
        }


        public IActionResult Index()
        {

            if (ViewBag.MyName != null)
            {
                return View(_db.Products.ToList());
            }
            else
            {
                return RedirectToAction("Create", "User");
            }
        }


        public IActionResult Create(int PizzaId)
        {
            //Product u = _db.Products.Find(PizzaId);
            return View(_db.Products.ToList());
        }

       
        public IActionResult Details(int id)
        {
            Product p = _db.Products.Find(id);
            return View(p);
        }

        public IActionResult Customize()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Customize(CustomAce cs)
        {
            //_db.PaymentTabs.Add(cs);
            //_db.SaveChanges();
            return RedirectToAction("ChangesInOrder");
        }

        public IActionResult ChangesInOrder()
        {
            return View();

        }


        public IActionResult PaymentTab()
        {
            return View();
            
        }

        [HttpPost]
        public IActionResult PaymentTab(PaymentTab py)
        {
            //_db.PaymentTabs.Add(py);
            //_db.SaveChanges();
            return RedirectToAction("Order");
        }


        public IActionResult Order()
        {
            return View();

        }


        public IActionResult Contact()
        {
            return View();
            
        }

    }
}


