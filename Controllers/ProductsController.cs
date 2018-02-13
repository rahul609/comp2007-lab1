using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET Products/Details?apple=[value]
        public ActionResult Details(string apple)
        {
            // check for an empty apple
            if (apple ==null)
            {

                //return View("Error");
                return RedirectToAction("Products");

            }
            ViewBag.Apple = apple;
            return View();
        }

    }
}