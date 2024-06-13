﻿using CoreWebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication1.Controllers
{
    public class DemoController : Controller
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
            ViewData["Message"] = "Customer Management System";
            ViewData["CustomerCount"] = customers.Count();
            ViewData["CustomerList"] = customers;
            return View();
        }

        // TempData
        public IActionResult Method1()
        {
            TempData["Message"] = "Customer Management System";
            TempData["CustomerCount"] = customers.Count();
            TempData["CustomerList"] = customers;
            return View();
        }
        public IActionResult Method2()
        {
            if (TempData["Message"] == null)
                return RedirectToAction("Index");
            TempData["Message"] = TempData["Message"].ToString();
            return View();
        }
    }
}
