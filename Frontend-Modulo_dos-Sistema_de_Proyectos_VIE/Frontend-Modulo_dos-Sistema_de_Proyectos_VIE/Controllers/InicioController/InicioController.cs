﻿using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class InicioController : Controller
    {
        /// <summary>
        /// Controlador para la vista de inicio cuando arranca la página web
        /// </summary>
        /// <returns>ActionResult</returns>
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

        public ActionResult BuscadorProyectos()
        {
            return View();
        }
    }
}