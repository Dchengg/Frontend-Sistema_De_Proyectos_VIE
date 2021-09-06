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
        // GET: SeguimientoProyecto
        public ActionResult DatosProyecto()
        {
            Proyecto ProyectoPrueba = new Proyecto
            {
                CodigoProyecto = "1234567",
                NombreProyecto = "Proyecto de prueba",
                Descripcion = "Esto es una descripción"
            };
            return View(ProyectoPrueba);
        }

        public ActionResult AreaFrascati()
        {
            return View();
        }
    }
}