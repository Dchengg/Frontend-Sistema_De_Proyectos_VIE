using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using System.Collections.Generic;
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
            criteriosBusqueda.Add(new SelectListItem { Text = "Código del proyecto", Value = "Código de proyecto" });
            criteriosBusqueda.Add(new SelectListItem { Text = "Nombre del proyecto", Value = "Nombre de proyecto" });
            criteriosBusqueda.Add(new SelectListItem { Text = "Oficial de proyecto", Value = "Oficial de proyecto" });
            criteriosBusqueda.Add(new SelectListItem { Text = "Investigador coordinador", Value = "Investigador coordinador" });
            criteriosBusqueda.Add(new SelectListItem { Text = "Palabra Clave", Value = "Palabra Clave" });
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

        public ActionResult Reportes()
        {
            List<Investigador> investigadores = new List<Investigador>();
            List<Proyecto> proyectos = new List<Proyecto>();
            TempData["investigadores"] = investigadores;
            TempData["proyectos"] = proyectos;
            TempData["tipoReporte"] = "Pendiente";
            List<string> titulos = new List<string>(new string[] { "Número identidad", "Nombre Completo", "Correo Electronico" });
            TempData["titulos"] = titulos;
            return View("UIReportes");
        }

        [HttpPost]
        public ActionResult Reportes(FormCollection ReporteForm)
        {
            String tipoDeReportes = ReporteForm["reporteDropdown"].ToString();
            List<Investigador> investigadores = new List<Investigador>();
            List<Proyecto> proyectos = new List<Proyecto>();
            switch(tipoDeReportes){
                case "FichaInvestigador":
                    break;
                case "ListadoInvestigadores":
                    investigadores = ReporteController.InvestigadoresXEstado("Activos");
                    break;
                default:
                    break;
            }
            TempData["investigadores"] = investigadores;
            TempData["proyectos"] = proyectos;
            TempData["tipoReporte"] = "Investigadores";
            List<string> titulos = new List<string>(new string[] { "Número de identidad", "Nombre Completo", "Correo Electronico" });
            TempData["titulos"] = titulos;
            return View("UIReportes");
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