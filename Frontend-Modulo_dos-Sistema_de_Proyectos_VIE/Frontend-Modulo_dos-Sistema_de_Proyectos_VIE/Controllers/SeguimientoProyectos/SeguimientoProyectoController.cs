using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers.SeguimientoProyectos
{
    public class SeguimientoProyectoController : Controller
    {
        #region Variables y Constantes
        Proyecto Proyecto = new Proyecto();
        #endregion

        #region Métodos

        /// <summary>
        /// Llama al controlador de proyectos y recoge los objetivos del proyecto para enviarlos a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de los objetivos del proyecto</returns>
        public ActionResult UIDatosProyecto(String codigoProyecto)
        {   
            Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["objetivosEspecificos"] = ProyectoController.getObjetivosProyecto(codigoProyecto);
            return View(Proyecto);
        }

        /// <summary>
        /// Llama al controlador de áreas frascati y recoge las áreas frascati del proyecto para enviarlas a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las áreas frascati del proyecto </returns>
        public ActionResult UIAreaFrascati(String codigoProyecto)
        {
            System.Diagnostics.Debug.WriteLine(codigoProyecto);
            List<Frascati> Frascatis = FrascatiController.getFrascatis(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIAreaFrascati", Frascatis);
        }

        /// <summary>
        /// Llama al controlador de áreas frascati y le envia un nuevo área frascati que se debe agregar a la base de datos
        /// </summary>
        /// <param name="formDropdownAreaFrascati"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las áreas frascati del proyecto con el nuevo área frascati agregado</returns>
        [HttpPost]
        public ActionResult UIAreaFrascati(FormCollection formDropdownAreaFrascati, String codigoProyecto)
        {
            String area = formDropdownAreaFrascati["areaDropdown"].ToString();
            String subArea = formDropdownAreaFrascati["subAreaDropdown"].ToString();
            String resultPost = FrascatiController.AgregarAreaFrascati(area, subArea, codigoProyecto);
            System.Diagnostics.Debug.WriteLine(resultPost);
            List<Frascati> Frascatis = FrascatiController.getFrascatis(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            ViewData["codigoProyecto"] = codigoProyecto;
            return View("UIAreaFrascati", Frascatis);
        }

        /// <summary>
        /// Llama al controlador de áreas frascati y le envia el ID del área frascati que se debe eliminar de la base de datos
        /// </summary>
        /// <param name="idArea"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las áreas frascati del proyecto con el área frascati eliminado</returns>
        [HttpPost]
        /* incomplete */
        public ActionResult UIEliminarAreasFrascati(String idArea, string codigoProyecto)
        {

            System.Diagnostics.Debug.WriteLine(idArea);
            System.Diagnostics.Debug.WriteLine(codigoProyecto);
            String resultPost = FrascatiController.EliminarAreaFrascati(idArea);
            System.Diagnostics.Debug.WriteLine(resultPost);

            List<Frascati> Frascatis = FrascatiController.getFrascatis(codigoProyecto);
            ViewData["codigoProyecto"] = codigoProyecto;
            return View("UIAreaFrascati", Frascatis);
        }

        /// <summary>
        /// Llama al controlador de ODS y recoge los ODS del proyecto para enviarlos a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de los ODS del proyecto  </returns>
        public ActionResult UIAgregarODS(String codigoProyecto)
        {
            List<ODS> ODSs = ODSController.getODSs(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["codigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIAgregarODS", ODSs);
        }

        /// <summary>
        /// Llama al controlador de ODS y le envia un nuevo ODS que se debe agregar a la base de datos
        /// </summary>
        /// <param name="formDropdownODS"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de los ODS del proyecto con el nuevo ODS agregado</returns>
        [HttpPost]
        public ActionResult UIAgregarODS(FormCollection formDropdownODS, String codigoProyecto)
        {
            String area = formDropdownODS["areaDropdown"].ToString();
            String subArea = formDropdownODS["subAreaDropdown"].ToString();
            String resultPost = ODSController.AgregarODS(area, subArea, codigoProyecto);
            System.Diagnostics.Debug.WriteLine(resultPost);
            List<ODS> ODSs = ODSController.getODSs(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            ViewData["CodigoProyecto"] = codigoProyecto;
            return View("UIAgregarODS", ODSs);
        }

        /// <summary>
        /// Llama al controlador de poblacion beneficiaria y recoge las poblaciones del proyecto para enviarlas a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las poblaciones beneficiarias del proyecto</returns>
        public ActionResult UIPoblacionBeneficiaria(String codigoProyecto)
        {
            List<Poblacion> poblaciones = PoblacionBeneficiariaController.getPoblaciones(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIPoblacionBeneficiaria", poblaciones);
        }

        /// <summary>
        /// Llama al controlador de poblacion beneficiaria y le envia una nueva población que se debe agregar a la base de datos
        /// </summary>
        /// <param name="formDrowpDownPoblacion"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las poblaciones beneficiarias del proyecto con la nueva población benficiaria agregado</returns>
        [HttpPost]
        public ActionResult UIPoblacionBeneficiaria(FormCollection formDrowpDownPoblacion, String codigoProyecto)
        {
            String poblacion = formDrowpDownPoblacion["PoblacionDropdown"].ToString();
            System.Diagnostics.Debug.WriteLine(poblacion);
            String resultPost = PoblacionBeneficiariaController.AgregarPoblacion(codigoProyecto, poblacion);
            System.Diagnostics.Debug.WriteLine(resultPost);
            List<Poblacion> poblaciones = PoblacionBeneficiariaController.getPoblaciones(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            ViewData["CodigoProyecto"] = codigoProyecto;
            return View("UIPoblacionBeneficiaria", poblaciones);
        }

        /// <summary>
        /// Llama al controlador de compras y recoge las compras para enviarlas a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las compras del proyecto</returns>
        public ActionResult UICompras(String codigoProyecto) {
            List<Poblacion> poblaciones = PoblacionBeneficiariaController.getPoblaciones(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UICompras");
        }

        /// <summary>
        /// Llama al controlador de bitácoras y recoge las bitácoras del proyecto para enviarlas a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las bitácoras del proyecto</returns>
        public ActionResult UIBitacora(String codigoProyecto) {
            List<Poblacion> poblaciones = PoblacionBeneficiariaController.getPoblaciones(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIBitacora");
        }

        /// <summary>
        /// Llama al controlador de incidencias y recoge las incidencias del proyecto para enviarlas a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las incidencias del proyecto</returns>
        public ActionResult UIIncidencias(String codigoProyecto){
            List<Poblacion> poblaciones = PoblacionBeneficiariaController.getPoblaciones(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIIncidencias");
        }

        #endregion
    }
}