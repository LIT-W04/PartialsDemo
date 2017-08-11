using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialsDemo.Models;

namespace PartialsDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageOne()
        {
            return View(new PageOneViewModel() { SomeText = "Page one stuff", Number = 12345 });
        }

        public ActionResult PageTwo()
        {
            return View(new PageTwoViewModel()
            {
                UserEmail = "info@lakewoodprogramming.com",
                Number = 987654
            });
        }
    }
}