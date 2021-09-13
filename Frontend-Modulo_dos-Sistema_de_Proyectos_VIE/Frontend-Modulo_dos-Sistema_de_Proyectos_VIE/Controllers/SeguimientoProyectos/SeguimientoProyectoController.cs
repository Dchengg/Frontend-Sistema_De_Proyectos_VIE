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
        string CodigoAux;

        // GET: SeguimientoProyecto
        public ActionResult DatosProyecto(String codigo)
        {

            Proyecto = ProyectoController.getProyecto(codigo);
            CodigoAux = codigo;
            ViewData["objetivosEspecificos"] = ProyectoController.getObjetivosProyecto(codigo);
            return View(Proyecto);
        }

        [HttpPost]
        public ActionResult DatosProyecto(Proyecto proyecto)
        {
            Proyecto.Descripcion = proyecto.Descripcion;
            CodigoAux = proyecto.Codigo;
            return View(Proyecto);
        }

        public ActionResult AreaFrascati(string codigo)
        {
            Console.WriteLine(CodigoAux);
            List<Frascati> Frascatis = FrascatiController.getFrascati(CodigoAux);
            
            return View("AreaFrascati",Frascatis);
        }

        public ActionResult agregarODS() 
        {
            
            List<ODS> ODSs = ODSController.getODS(CodigoAux);
            return View("agregarODS", ODSs);
        }

        public ActionResult poblacionBeneficiaria() 
        {
            List<Poblacion> poblaciones = PoblacionBeneficiariaController.getPoblacion(CodigoAux);
            return View("poblacionBeneficiaria", poblaciones);
        }
    }
}