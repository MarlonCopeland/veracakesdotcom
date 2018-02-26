using System;
using System.IO;
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
            IndexViewModel idx = new IndexViewModel();
            ViewBag.Message = "Your next best cake starts here.";

            string strImagesPath = Server.MapPath("~/Content/Images/cakePics/");
            CakePage cakePage = new CakePage();
            DirectoryInfo cakeImageDirectory = new DirectoryInfo(strImagesPath);
            cakePage.lstCakes = cakeImageDirectory.GetFiles().Select(x => x.Name).ToList();

            idx.cakePage = cakePage;

            return View(idx);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your next best cake starts here.";

            string strImagesPath = Server.MapPath("~/Content/Images/cakePics/");
            CakePage cakePageViewModel = new CakePage();
            DirectoryInfo cakeImageDirectory = new DirectoryInfo(strImagesPath);
            cakePageViewModel.lstCakes = cakeImageDirectory.GetFiles().Select(x => x.Name).ToList();

            return View(cakePageViewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}