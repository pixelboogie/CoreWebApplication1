
using CoreWebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication1.Controllers
{
    public class CustomerController : Controller
    {

        public static List<Customer> customers = new List<Customer>()
        {
            new Customer(){Id = 101, Name = "King", Amount = 12000},
            new Customer(){Id = 102, Name = "King2", Amount = 12000},
        };
        public IActionResult Index()
        {
           ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        // *****************************
        //  Routing
        // The Message Action Method will execture
        // if user accesses "~/sample/message"
        // attribute routing  overlaods conventional routing
        // *****************************
        // [Route("~/")]
        [Route("~/sample/message")]
        public IActionResult Message()
        {
            return View();
        }

    }
}
