using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers.SeguimientoProyectos
{
    public class SeguimientoProyectoController : Controller
    {
        Proyecto Proyecto = new Proyecto();

        // GET: SeguimientoProyecto
        public ActionResult DatosProyecto(String codigo)
        {

            Proyecto = ProyectoController.getProyecto(codigo);
            ViewData["codigoProyecto"] = codigo;
            ViewData["objetivosEspecificos"] = ProyectoController.getObjetivosProyecto(codigo);
            return View(Proyecto);
        }

        public ActionResult AreaFrascati(String codigo)
        {
            System.Diagnostics.Debug.WriteLine(codigo);
            List<Frascati> Frascatis = FrascatiController.getFrascati(codigo);
            Proyecto Proy = ProyectoController.getProyecto(codigo);
            ViewData["codigoProyecto"] = codigo;
            ViewData["nombreProyecto"] = Proy.Nombre;
            return View("AreaFrascati",Frascatis);
        }

        [HttpPost]
        public ActionResult AreaFrascati(FormCollection form, String codigo)
        {
            String area = form["areaDropdown"].ToString();
            String subArea = form["subAreaDropdown"].ToString();
            String resultPost = FrascatiController.CreateAreaFrascati(area, subArea, codigo);
            System.Diagnostics.Debug.WriteLine(resultPost);
            List<Frascati> Frascatis = FrascatiController.getFrascati(codigo);
            Proyecto Proy = ProyectoController.getProyecto(codigo);
            ViewData["nombreProyecto"] = Proy.Nombre;
            ViewData["codigoProyecto"] = codigo;
            return View("AreaFrascati", Frascatis);
        }
        [HttpPost]
        /* incomplete */
        public ActionResult EliminarAreasFrascati(String idArea, string codigo) {
            
            System.Diagnostics.Debug.WriteLine(idArea);
            System.Diagnostics.Debug.WriteLine(codigo);
            String resultPost = FrascatiController.deleteAreaFrascati(idArea);
            System.Diagnostics.Debug.WriteLine(resultPost);

            List<Frascati> Frascatis = FrascatiController.getFrascati(codigo);
            ViewData["codigoProyecto"] = codigo;
            return View("AreaFrascati", Frascatis);
        }

        public ActionResult AgregarODS(String codigo) 
        {
            List<ODS> ODSs = ODSController.getODS(codigo);
            Proyecto Proy = ProyectoController.getProyecto(codigo);
            ViewData["codigoProyecto"] = codigo;
            ViewData["nombreProyecto"] = Proy.Nombre;
            return View("agregarODS", ODSs);
        }

        [HttpPost]
        public ActionResult AgregarODS(FormCollection form, String codigo)
        {
            String area = form["areaDropdown"].ToString();
            String subArea = form["subAreaDropdown"].ToString();
            String resultPost = ODSController.CreateODS(area, subArea, codigo);
            System.Diagnostics.Debug.WriteLine(resultPost);
            List<ODS> ODSs = ODSController.getODS(codigo);
            Proyecto Proy = ProyectoController.getProyecto(codigo);
            ViewData["nombreProyecto"] = Proy.Nombre;
            ViewData["codigoProyecto"] = codigo;
            return View("agregarODS", ODSs);
        }

        public ActionResult PoblacionBeneficiaria(String codigo) 
        {
            List<Poblacion> poblaciones = PoblacionBeneficiariaController.getPoblacion(codigo);
            Proyecto Proy = ProyectoController.getProyecto(codigo);
            ViewData["codigoProyecto"] = codigo;
            ViewData["nombreProyecto"] = Proy.Nombre;
            return View("poblacionBeneficiaria", poblaciones);
        }
        [HttpPost]
        public ActionResult poblacionBeneficiaria(FormCollection form, String codigo)
        {
            String poblacion = form["poblacionDropdown"].ToString();
            System.Diagnostics.Debug.WriteLine(poblacion);
            String resultPost = PoblacionBeneficiariaController.createPoblacion(codigo, poblacion);
            System.Diagnostics.Debug.WriteLine(resultPost);
            List<Poblacion> poblaciones = PoblacionBeneficiariaController.getPoblacion(codigo);
            Proyecto Proy = ProyectoController.getProyecto(codigo);
            ViewData["nombreProyecto"] = Proy.Nombre;
            ViewData["codigoProyecto"] = codigo;
            return View("poblacionBeneficiaria", poblaciones);
        }


    }
}