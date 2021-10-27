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
            List<ResultadoReporte> resultadosEspeciales = new List<ResultadoReporte>();

            TempData["investigadores"] = investigadores;
            TempData["proyectos"] = proyectos;
            TempData["resultadosEspeciales"] = resultadosEspeciales;
            TempData["tipoReporte"] = "Pendiente";
            TempData["tituloCatalogo"] = "Pendiente";
            List<string> titulos = new List<string>(new string[] { "Número identidad", "Nombre Completo", "Correo Electronico" });
            TempData["titulos"] = titulos;
            return View("UIReportes");
        }

        [HttpPost]
        public ActionResult Reportes(FormCollection ReporteForm)
        {
            String tipoDeReportes = ReporteForm["reporteDropdown"].ToString();
            String criterio = "pendiente";
            if (ReporteForm["catalogoDropdown"] != null)
            {
                criterio = ReporteForm["catalogoDropdown"].ToString();
            }
            String estado = ReporteForm["estadoDropdown"].ToString();
            List<Investigador> investigadores = new List<Investigador>();
            List<Proyecto> proyectos = new List<Proyecto>();
            List<ResultadoReporte> resultadosEspeciales = new List<ResultadoReporte>();
            var tipoReporte = "Pendiente";
            List<string> titulos = new List<string>();
            List<string> titulosInvestigador = new List<string>(new string[] { "Número de identidad", "Nombre Completo", "Correo Electronico" });
            List<string> titulosProyecto = new List<string>(new string[] { "Código", "Nombre del proyecto", "Investigador coordinador", "Fecha de inicio", "Fecha de finalización", "Oficial del proyecto" });
            switch (tipoDeReportes){
                case "InvestigadorXCodigo":
                    String codigo = ReporteForm["criterioInput"].ToString();
                    investigadores = ReporteController.InvestigadoresXCodigo(codigo);
                    tipoReporte = "Investigadores";
                    titulos = titulosInvestigador;
                    break;
                case "ListadoInvestigadores":
                    investigadores = ReporteController.InvestigadoresXEstado("Activos");
                    tipoReporte = "Investigadores";
                    titulos = titulosInvestigador;
                    break;
                case "InvestigadoresXDisciplina":
                    investigadores = ReporteController.InvestigadoresXDisciplina(estado, criterio);
                    tipoReporte = "Investigadores";
                    titulos = titulosInvestigador;
                    break;
                case "InvestigadoresXEscuela":
                    investigadores = ReporteController.InvestigadoresXEscuela(estado, criterio);
                    tipoReporte = "Investigadores";
                    titulos = titulosInvestigador;
                    break;
                case "InvestigadoresInformes":
                    investigadores = ReporteController.InvestigadoresInformesPendientes();
                    tipoReporte = "Investigadores";
                    titulos = titulosInvestigador;
                    break;
                case "InvestigadoresXGenero":
                    investigadores = ReporteController.InvestigadoresXGenero(criterio);
                    tipoReporte = "Investigadores";
                    titulos = titulosInvestigador;
                    break;
                case "InvestigadoresCoordinadores":
                    investigadores = ReporteController.InvestigadoresCoordinadores();
                    tipoReporte = "Investigadores";
                    titulos = titulosInvestigador;
                    break;
                case "ProyectoXEstado":
                    proyectos = ReporteController.ProyectoXEstado(estado);
                    tipoReporte = "Proyectos";
                    titulos = titulosProyecto;
                    break;
                case "ProyectoXUbicacion":
                    var region = ReporteForm["catalogo2Dropdown"].ToString();
                    var provincia = ReporteForm["catalogo3Dropdown"].ToString();
                    proyectos = ReporteController.ProyectoXUbicacion(estado, criterio, region, provincia);
                    tipoReporte = "Proyectos";
                    titulos = titulosProyecto;
                    break;
                case "ProyectoXBeneficiaria":
                    proyectos = ReporteController.ProyectoXBeneficiaria(estado, criterio);
                    tipoReporte = "Proyectos";
                    titulos = titulosProyecto;
                    break;
                case "ProyectoXTipo":
                    proyectos = ReporteController.ProyectoXTipo(estado, criterio);
                    tipoReporte = "Proyectos";
                    titulos = titulosProyecto;
                    break;
                case "ProyectoXModalidad":
                    proyectos = ReporteController.ProyectoXModalidad(estado, criterio);
                    tipoReporte = "Proyectos";
                    titulos = titulosProyecto;
                    break;
                case "ProyectoInformes":
                    proyectos = ReporteController.ProyectoInformes();
                    tipoReporte = "Proyectos";
                    titulos = titulosProyecto;
                    break;
                case "ProyectoXInvestigador":
                    proyectos = ReporteController.ProyectoXInvestigador(criterio);
                    tipoReporte = "Proyectos";
                    titulos = titulosProyecto;
                    break;
                case "CantidadProyectosXEscuela":
                    var fechaInicio = ReporteForm["fechaInput"].ToString();
                    var fechaFinal = ReporteForm["fecha2Input"].ToString();
                    var tipoDepartamento = ReporteForm["catalogo2Dropdown"].ToString();
                    proyectos = ReporteController.CantidadProyectosXEscuela(fechaInicio, fechaFinal, criterio, tipoDepartamento, estado);
                    tipoReporte = "Proyectos";
                    titulos = titulosProyecto;
                    break;
                case "CantidadPresupuesto":
                    fechaInicio = ReporteForm["fechaInput"].ToString();
                    fechaFinal = ReporteForm["fecha2Input"].ToString();
                    tipoDepartamento = ReporteForm["catalogo2Dropdown"].ToString();
                    resultadosEspeciales = ReporteController.CantidadPresupuesto(fechaInicio, fechaFinal, criterio, tipoDepartamento, estado).Cast<ResultadoReporte>().ToList();
                    tipoReporte = "EspecialPresupuesto";
                    titulos.AddRange(new string[] { "Presupuesto Total", "Código del proyecto", "Nombre del proyecto" });
                    break;
                case "CantidadHorasProyecto":
                    fechaInicio = ReporteForm["fechaInput"].ToString();
                    fechaFinal = ReporteForm["fecha2Input"].ToString();
                    tipoDepartamento = ReporteForm["catalogo2Dropdown"].ToString();
                    resultadosEspeciales = ReporteController.CantidadHorasProyecto(fechaInicio, fechaFinal, criterio, tipoDepartamento, estado).Cast<ResultadoReporte>().ToList();
                    tipoReporte = "EspecialHoras";
                    titulos.AddRange(new string[] { "Cantidad de horas totales", "Código del proyecto", "Nombre del proyecto" });
                    break;
                default:
                    break;
            }
            TempData["investigadores"] = investigadores;
            TempData["proyectos"] = proyectos;
            TempData["tipoReporte"] = tipoReporte;
            TempData["resultadosEspeciales"] = resultadosEspeciales;
            TempData["titulos"] = titulos;
            return View("UIReportes");
        }
    }
}