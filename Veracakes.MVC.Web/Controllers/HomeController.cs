using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unjaded.Core.MVC;
using Unjaded.MVC.Core;

namespace Veracakes.MVC.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MagnifyingGlass x = new MagnifyingGlass();
            int tops = x.Rings;

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
    }
}