using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangOto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Car()
        {
            return View();
        }
        public ActionResult Pricing()
        {
            return View();
        }
        public ActionResult CarDetails()
        {
            return View();
        }
    }
}