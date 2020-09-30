using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutValidation.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Bienvenido()
        {
            return View();
        }

        public ActionResult Index(string id)
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
    }
}