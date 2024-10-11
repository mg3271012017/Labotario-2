using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labotario_2.Controllers
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
        public ActionResult Documentos()
        {
            ViewBag.Message = "Mis Documentos.";

            return View();
        }

        public ActionResult Resumen()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Habilidades()
        {
            ViewBag.Message = "Mis Documentos.";

            return View();
        }
        public ActionResult Repositorios()
        {
            ViewBag.Message = "Mis Repositorios.";

            return View();
        }
    }

}