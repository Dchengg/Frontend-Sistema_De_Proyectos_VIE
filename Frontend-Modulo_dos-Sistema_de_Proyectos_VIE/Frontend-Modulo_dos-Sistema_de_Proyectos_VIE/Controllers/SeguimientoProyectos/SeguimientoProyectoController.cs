using System;
using System.Collections.Generic;
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
            System.Diagnostics.Debug.WriteLine("IM HERE");
            System.Diagnostics.Debug.WriteLine(codigo);
            Proyecto = ProyectoController.getProyecto(codigo);
            return View(Proyecto);
        }

        [HttpPost]
        public ActionResult DatosProyecto(Proyecto proyecto)
        {
            Proyecto.Descripcion = proyecto.Descripcion;
            return View(Proyecto);
        }

        public ActionResult AreaFrascati()
        {
            return View();
        }

        public ActionResult agregarODS() 
        {
            return View();
        }

        public ActionResult poblacionBeneficiaria() 
        {
            return View();
        }
    }
}