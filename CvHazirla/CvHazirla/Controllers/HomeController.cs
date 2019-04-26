using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvHazirla.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Deneyim()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Egitim()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DilBilgisi()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Bilgisayar()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Referanslar()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}