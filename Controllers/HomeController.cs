using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Acerca de.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contactame.";

            return View();
        }
        public ActionResult Formacion()
        {
            ViewBag.Message = "Pagina de mi formacion academica.";

            return View();
        }
        public ActionResult Experiencia()
        {
            ViewBag.Message = "Pagina de mi experiencia.";

            return View();
        }
        public ActionResult Habilidades()
        {
            ViewBag.Message = "Pagina de mis habilidades.";

            return View();
        }
        public ActionResult Repositos()
        {
            ViewBag.Message = "Pagina de mis Repositos.";

            return View();
        }
    }
}
