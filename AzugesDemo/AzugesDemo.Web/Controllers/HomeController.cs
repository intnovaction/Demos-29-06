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
            System.Diagnostics.Trace.TraceInformation("Al mundo vendrán 13 millones de naves");

            var lista = new List<int>();

            for (int i = 0; i < 12; i++)
            {
                lista.Add(i);
            }

            return View(lista);
            
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