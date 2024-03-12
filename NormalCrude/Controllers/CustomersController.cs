using Microsoft.AspNetCore.Mvc;
using NormalCrude.DAL;
using NormalCrude.Models;
using System.Text.RegularExpressions;

namespace NormalCrude.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            var customerInDb = _context.baseModels.ToList();
            //var membarshipInDb = _context.Membarships.ToList();

            //var baseModel = customerInDb;
            //var baseModel1 = membarshipInDb;

            //var one = new 
            //{ 
            //    baseModel = customerInDb,
            //    baseModel1 = membarshipInDb
            
            //};
           // ViewBag.MembarshipInDb = _context.Membarships.Where(c => c.MembarshipName == "Membarship");

            return View(customerInDb);
        }
        [HttpGet]
        public IActionResult Add() 
        {
            ViewBag.MembarshipList = _context.Membarships.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            if(customer == null)
                return View("Error");

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("List","Customers");
        }
    }
}
