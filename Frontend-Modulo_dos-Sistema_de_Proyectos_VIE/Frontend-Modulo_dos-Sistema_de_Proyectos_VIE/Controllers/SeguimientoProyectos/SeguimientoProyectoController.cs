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


            List<EstadoProyecto>estadoPicker = ProyectoController.getEstadoProyecto();

            TempData["estadoPicker"] = estadoPicker;


            List<TipoProceso> procesoPicker = ProyectoController.getTiposProceso();

            TempData["procesoPicker"] = procesoPicker;

            List<TipoProyecto> tipoproyectoPicker = ProyectoController.getTiposProyecto();

            TempData["tipoproyectoPicker"] = tipoproyectoPicker;

            List<ModalidadProyecto> modalidadPicker = ProyectoController.getModalidad();

            TempData["modalidadPicker"] = modalidadPicker;
            Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["objetivosEspecificos"] = ProyectoController.getObjetivosProyecto(codigoProyecto);
            return View(Proyecto);
        }

        [HttpPost]
        public ActionResult UIDatosProyecto(FormCollection formProyecto, String codigoProyecto)
        {
            Proyecto = ProyectoController.getProyecto(codigoProyecto);


            String nombreProyectoInput = formProyecto["nombreProyectoInput"].ToString();


            String descripcionInput = formProyecto["descripcionInput"].ToString();

            String justificacionInput = formProyecto["justificacionInput"].ToString();

            String objetivoGeneralInput = formProyecto["objetivoGeneralInput"].ToString();


            String resultPost =  ProyectoController.ModificarProyecto(codigoProyecto, nombreProyectoInput, objetivoGeneralInput, Proyecto.NumeroActaVIE, Proyecto.NumeroActaEscuela, descripcionInput, justificacionInput);


            System.Diagnostics.Debug.WriteLine(resultPost);


            List<EstadoProyecto> estadoPicker = ProyectoController.getEstadoProyecto();

            TempData["estadoPicker"] = estadoPicker;


            List<TipoProceso> procesoPicker = ProyectoController.getTiposProceso();

            TempData["procesoPicker"] = procesoPicker;

            List<TipoProyecto> tipoproyectoPicker = ProyectoController.getTiposProyecto();

            TempData["tipoproyectoPicker"] = tipoproyectoPicker;

            List<ModalidadProyecto> modalidadPicker = ProyectoController.getModalidad();
            Proyecto = ProyectoController.getProyecto(codigoProyecto);

            TempData["modalidadPicker"] = modalidadPicker;
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
        public ActionResult UIPresupuesto(String codigoProyecto)
        {
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIPresupuesto");
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
        
        /*maybe*/
        [HttpDelete]
        /* incomplete */
        public ActionResult UIAreasFrascati(String idArea, string codigoProyecto)
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
            List<Poblacion> poblacionPicker = PoblacionBeneficiariaController.getPoblaciones();

            TempData["poblacionPicker"] = poblacionPicker;

            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIPoblacionBeneficiaria", poblaciones);
        }
        /// <summary>
        /// Llama al controlador de palabras clave y recoge las palabras clave del proyecto para enviarlas a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las palabras clave del proyecto</returns>
        public ActionResult UIPalabrasClave(String codigoProyecto)
        {
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<PalabrasClave> palabrasClave = PalabrasClaveController.getPalabrasClave(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIPalabrasClave", palabrasClave);

        }
        /// <summary>
        /// Llama al controlador de palabras clave y inserta una nueva plabra clave a la base de datos
        /// </summary>
        /// <param name="fromInputPalabraClave"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista con la nueva palabra clave insertada</returns>
        [HttpPost]
        public ActionResult UIPalabrasClave(FormCollection fromInputPalabraClave, String codigoProyecto)
        {
            String palabraClave = fromInputPalabraClave["palabraInput"].ToString();
            ViewData["CodigoProyecto"] = codigoProyecto;

            String Result = PalabrasClaveController.AgregarPalabraClave(palabraClave, codigoProyecto);
            System.Diagnostics.Debug.WriteLine(Result);


            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<PalabrasClave> palabrasClave = PalabrasClaveController.getPalabrasClave(codigoProyecto);
            
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIPalabrasClave",palabrasClave);
        }
        /// <summary>
        /// Elimina la palabra clave selecionada de la interfaz y llama al controlador para eliminarla en la base de datos
        /// </summary>
        /// <param name="idPalabraClave"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista actualizada sin la palabra clave eliminada</returns>
        [HttpDelete]
        public ActionResult UIPalabrasClave(String idPalabraClave, String codigoProyecto)
        {

            String resultPost = PalabrasClaveController.EliminarPalabraClave(idPalabraClave);
            System.Diagnostics.Debug.WriteLine(resultPost);

            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<PalabrasClave> palabrasClave = PalabrasClaveController.getPalabrasClave(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIPalabrasClave", palabrasClave);

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
            List<Poblacion> poblacionPicker = PoblacionBeneficiariaController.getPoblaciones();

            TempData["poblacionPicker"] = poblacionPicker;

            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIPoblacionBeneficiaria", poblaciones);
        }

        /// <summary>
        /// Elimina la poblacion selecionada y llama al controaldor para eliminarla de la base de datos
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista actualizada sin la poblacion que se eliminó</returns>
        [HttpDelete]
        public ActionResult UIPoblacionBeneficiaria(String idPoblacion, String codigoProyecto)
        {


            String resultPost = PoblacionBeneficiariaController.EliminarPoblacion(idPoblacion);
            System.Diagnostics.Debug.WriteLine(resultPost);




            List<Poblacion> poblaciones = PoblacionBeneficiariaController.getPoblaciones(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<Poblacion> poblacionPicker = PoblacionBeneficiariaController.getPoblaciones();

            TempData["poblacionPicker"] = poblacionPicker;

            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIPoblacionBeneficiaria", poblaciones);

        }

        /// <summary>
        /// Llama al controlador de compras y recoge las compras del proyecto para enviarlas a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las compras del proyecto</returns>
        public ActionResult UICompras(String codigoProyecto) {
            
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<Compras> compras = ComprasController.getCompras(codigoProyecto);
            long total = 0;
            foreach(Compras elem in compras)
            {
                int precio = Int32.Parse(elem.PrecioTotal);
                total = total + precio;

            }

            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            ViewData["Total"] = total;
            return View("UICompras", compras);
        }

        /// <summary>
        /// Llama al controlador de compras e inserta una nueva compra a la base de datos
        /// </summary>
        /// <param name="fromInputPalabraClave"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista con la nueva compra recien insertada</returns>
        [HttpPost]
        public ActionResult UICompras(FormCollection formInputCompra, String codigoProyecto)
        {
            String nombreDelProducto = formInputCompra["nombreDelProducto"].ToString();
            String cantidadDelProducto = formInputCompra["cantidadDelProducto"].ToString();
            String precioTotalDeLaCompra = formInputCompra["precioTotalDeLaCompra"].ToString();


            ViewData["CodigoProyecto"] = codigoProyecto;

            String Result = ComprasController.AgregarCompra(nombreDelProducto, cantidadDelProducto, precioTotalDeLaCompra, codigoProyecto);
            System.Diagnostics.Debug.WriteLine(Result);


            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<Compras> compras = ComprasController.getCompras(codigoProyecto);
            long total = 0;
            foreach (Compras elem in compras)
            {
                int precio = Int32.Parse(elem.PrecioTotal);
                total = total + precio;

            }
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            ViewData["Total"] = total;
            return View("UICompras", compras);
        }

        /// <summary>
        /// Elimina la compra selecionada de la interfaz y llama al controlador para eliminarla en la base de datos
        /// </summary>
        /// <param name="idCompra"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista actualizada sin la compra eliminada</returns>
        [HttpDelete]
        public ActionResult UICompras(String idCompra, String codigoProyecto)
        {

            String resultPost = ComprasController.EliminarCompra(idCompra);
            System.Diagnostics.Debug.WriteLine(resultPost);

            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<Compras> compras = ComprasController.getCompras(codigoProyecto);
            long total = 0;
            foreach (Compras elem in compras)
            {
                int precio = Int32.Parse(elem.PrecioTotal);
                total = total + precio;

            }
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            ViewData["Total"] = total;
            return View("UICompras", compras);

        }

        /// <summary>
        /// Llama al controlador de bitácoras y recoge las bitácoras del proyecto para enviarlas a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Vista de las bitácoras del proyecto</returns>
        public ActionResult UIBitacora(String codigoProyecto) {
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
           
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIIncidencias");
        }

        /// <summary>
        /// Llama al controlador de programación de informes y recoge los informes tanto entregados como por entregar del proyecto para enviarlos a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns></returns>
        public ActionResult UIProgramacionInformes(String codigoProyecto){

            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<Informe> informes = InformeController.getInformes(codigoProyecto);
            
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIProgramacionInformes", informes);
        }

        /// <summary>
        /// Llama al controlador de departamentos y recoge los departamentos del proyecto para enviarlos a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns></returns>
       [HttpPost]

        public ActionResult UIDepartamentos(FormCollection formDepartamentoDropdown, String codigoProyecto) {

            String departamento = formDepartamentoDropdown["DepartamentoDropdown"].ToString();
            System.Diagnostics.Debug.WriteLine(departamento);
            String idTipoDepartamento = formDepartamentoDropdown["tipoDepartamentoDropdown"].ToString();
            System.Diagnostics.Debug.WriteLine(idTipoDepartamento);
            String resultPost = DepartamentosController.AgregarDepartamento(idTipoDepartamento, departamento, codigoProyecto );
            System.Diagnostics.Debug.WriteLine(resultPost);
            List<Departamento> departamentos = DepartamentosController.getDepartamento(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<Departamento> departamentosPicker = DepartamentosController.getDepartamentos();
            List<TipoDepartamento> tipoDepartamentosPicker = DepartamentosController.getTiposDepartamento();

            TempData["tipoDepartamentosPicker"] = tipoDepartamentosPicker;

            TempData["departamentoPicker"] = departamentosPicker;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            ViewData["CodigoProyecto"] = codigoProyecto;
            return View("UIDepartamentos", departamentos);

        }

        [HttpDelete]
        public ActionResult UIDepartamentos(String idDepartamento, String codigoProyecto)
        {


            String resultPost = DepartamentosController.EliminarDepartamento(idDepartamento);
            System.Diagnostics.Debug.WriteLine(resultPost);





            List<Departamento> departamentos = DepartamentosController.getDepartamento(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<Departamento> departamentosPicker = DepartamentosController.getDepartamentos();
            List<TipoDepartamento> tipoDepartamentosPicker = DepartamentosController.getTiposDepartamento();

            TempData["tipoDepartamentosPicker"] = tipoDepartamentosPicker;

            TempData["departamentoPicker"] = departamentosPicker;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            ViewData["CodigoProyecto"] = codigoProyecto;
            return View("UIDepartamentos", departamentos);

        }
        public ActionResult UIDepartamentos( String codigoProyecto)
        {

            List<Departamento> departamentos = DepartamentosController.getDepartamento(codigoProyecto);
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<Departamento> departamentosPicker = DepartamentosController.getDepartamentos();

            List<TipoDepartamento> tipoDepartamentosPicker = DepartamentosController.getTiposDepartamento();


            TempData["tipoDepartamentosPicker"] = tipoDepartamentosPicker;

            TempData["departamentoPicker"] = departamentosPicker;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            ViewData["CodigoProyecto"] = codigoProyecto;
            return View("UIDepartamentos", departamentos);

        }

        /// <summary>
        /// Llama al controlador de ubicación geográfica y recoge la información del proyecto para enviarla a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns></returns>
        public ActionResult UIUbicacionGeografica(String codigoProyecto){
            
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIUbicacionGeografica");
        }

        /// <summary>
        /// Llama al controlador de contratos y recoge los contratos del proyecto para enviarlos a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns></returns>
        public ActionResult UIContratos(String codigoProyecto){
            
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIContratos");

        }

        /// <summary>
        /// Llama al controlador de informes y recoge los informes del proyecto para enviarlos a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns></returns>
        public ActionResult UIIngresarInforme(String codigoProyecto) {
            
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            List<Informe> informes = InformeController.getInformes(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIIngresarInforme", informes);
        }

        /// <summary>
        /// Llama al controlador de ampliar fechas y levanta el servicio de ampliar fechas
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns></returns>
        public ActionResult UIAmpliarFechas(String codigoProyecto) {
            
            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIAmpliarFechas");
        }

        /// <summary>
        /// Llama al controlador de investigadores asociados y recoge los investigadores del proyecto para enviarlos a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns></returns>
        public ActionResult UIInvestigadoresAsociados(String codigoProyecto)
        {

            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UIInvestigadoresAsociados");
        }

        /// <summary>
        /// Llama al controlador de cambiar investigador coordinador y recoge el coordinador y los otros investigadores del proyecto para enviarlos a la vista
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns></returns>
        public ActionResult UICambiarInvestigadorCoordinador(String codigoProyecto)
        {

            Proyecto Proyecto = ProyectoController.getProyecto(codigoProyecto);
            ViewData["CodigoProyecto"] = codigoProyecto;
            ViewData["NombreProyecto"] = Proyecto.Nombre;
            return View("UICambiarInvestigadorCoordinador");
        }

        #endregion
    }
}