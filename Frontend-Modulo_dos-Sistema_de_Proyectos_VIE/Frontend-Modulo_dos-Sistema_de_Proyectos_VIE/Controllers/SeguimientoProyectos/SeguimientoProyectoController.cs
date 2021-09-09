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
        readonly Proyecto ProyectoPrueba = new Proyecto
        {
            CodigoProyecto = "1234567",
            NombreProyecto = "Proyecto de prueba",
            Descripcion = "Esto es una descripción"
        };

        // GET: SeguimientoProyecto
        public ActionResult DatosProyecto()
        {
            return View(ProyectoPrueba);
        }

        [HttpPost]
        public ActionResult DatosProyecto(Proyecto proyecto)
        {
            ProyectoPrueba.Descripcion = proyecto.Descripcion;
            return View(ProyectoPrueba);
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