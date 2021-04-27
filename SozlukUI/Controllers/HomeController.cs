using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SozlukUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()//Ana sayfa ve listeleme yapılırken kullanılıyor.
        {
            return View();
        }

        public ActionResult About()//Hakkında sayfası
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Test()
        {
            return View();
        }
        
    }
}