using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Proyecto> proyectos = ProyectoController.getProyectos();
            return View("BuscadorProyectos", proyectos);
        }

        public ActionResult ResultadoBusqueda()
        {
            String criterioBusqueda = Request.Form["criterioBusqueda"].ToString();
            System.Diagnostics.Debug.WriteLine(criterioBusqueda);
            List<Proyecto> proyectos = ProyectoController.getProyectos();
            return View("BuscadorProyectos", proyectos);
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