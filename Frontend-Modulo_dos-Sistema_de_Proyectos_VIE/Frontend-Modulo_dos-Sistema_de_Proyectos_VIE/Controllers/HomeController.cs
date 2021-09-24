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
            List<SelectListItem> criteriosBusqueda = new List<SelectListItem>();
            criteriosBusqueda.Add(new SelectListItem { Text = "Todos los proyectos", Value = "" });
            criteriosBusqueda.Add(new SelectListItem { Text = "Código del proyecto", Value = "Código de proyecto"});
            criteriosBusqueda.Add(new SelectListItem { Text = "Nombre del proyecto", Value = "Nombre de proyecto"});
            criteriosBusqueda.Add(new SelectListItem { Text = "Oficial de proyecto", Value = "Oficial de proyecto"});
            criteriosBusqueda.Add(new SelectListItem { Text = "Investigador coordinador", Value = "Investigador coordinador" });
            ViewData["criteriosBusqueda"] = criteriosBusqueda;
            return View("UIBuscadorProyectos", proyectos);
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            String criterioBusqueda = form["criteriosBusqueda"].ToString();
            String parametros = form["parametrosInput"].ToString();
            List<Proyecto> proyectos = new List<Proyecto>();
            if (criterioBusqueda == "")
            {
                proyectos = ProyectoController.getProyectos();
            }
            else
            {
                proyectos = ProyectoController.buscarProyectos(criterioBusqueda, parametros);
            }
            List<SelectListItem> criteriosBusqueda = new List<SelectListItem>();
            criteriosBusqueda.Add(new SelectListItem { Text = "Todos los proyectos", Value = "" });
            criteriosBusqueda.Add(new SelectListItem { Text = "Código del proyecto", Value = "Código de proyecto" });
            criteriosBusqueda.Add(new SelectListItem { Text = "Nombre del proyecto", Value = "Nombre de proyecto" });
            criteriosBusqueda.Add(new SelectListItem { Text = "Oficial de proyecto", Value = "Oficial de proyecto" });
            criteriosBusqueda.Add(new SelectListItem { Text = "Investigador coordinador", Value = "Investigador coordinador" });
            ViewData["criteriosBusqueda"] = criteriosBusqueda;
            return View("UIBuscadorProyectos", proyectos);
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