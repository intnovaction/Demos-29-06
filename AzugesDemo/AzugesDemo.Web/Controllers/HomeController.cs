using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzugesDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pp = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                pp.Add(i);
            }

            return View(pp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}