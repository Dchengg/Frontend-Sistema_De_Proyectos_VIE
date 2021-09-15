using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class InicioController : Controller
    {

        public ActionResult Index()
        {
            HttpResponseMessage respuesta = GlobalVariables.WebApiClient.GetAsync("Inicio").Result;
            var datosIniciales = respuesta.Content.ReadAsAsync<oRespuesta<oCatalogos>>().Result;

            // Ligado de catalogos
            oCatalogosGlobal.catalogoTipoIdentificacion = datosIniciales.ObjetoRespuesta.catalogoTipoIdentificacion;
            oCatalogosGlobal.catalogoPais = datosIniciales.ObjetoRespuesta.catalogoPais;
            oCatalogosGlobal.catalogoProvincia = datosIniciales.ObjetoRespuesta.catalogoProvincia;
            oCatalogosGlobal.catalogoCanton = datosIniciales.ObjetoRespuesta.catalogoCanton;
            oCatalogosGlobal.catalogoDistrito = datosIniciales.ObjetoRespuesta.catalogoDistrito;
            oCatalogosGlobal.catalogoCategoriaAcademica= datosIniciales.ObjetoRespuesta.catalogoCategoriaAcademica;
            oCatalogosGlobal.catalogoSituacionLaboral = datosIniciales.ObjetoRespuesta.catalogoSituacionLaboral;
            oCatalogosGlobal.catalogoInstitucion= datosIniciales.ObjetoRespuesta.catalogoInstitucion;
            oCatalogosGlobal.catalogoAreaEstudio = datosIniciales.ObjetoRespuesta.catalogoAreaEstudio;
            oCatalogosGlobal.catalogoTituloAcademico = datosIniciales.ObjetoRespuesta.catalogoTituloAcademico;
            oCatalogosGlobal.catalogoIdioma = datosIniciales.ObjetoRespuesta.catalogoIdioma;
            oCatalogosGlobal.catalogoAreaIdioma = datosIniciales.ObjetoRespuesta.catalogoAreaIdioma;
            oCatalogosGlobal.catalogoNivelIdioma = datosIniciales.ObjetoRespuesta.catalogoNivelIdioma;
            oCatalogosGlobal.catalogoUnidadAcademica = datosIniciales.ObjetoRespuesta.catalogoUnidadAcademica;
            oCatalogosGlobal.catalogoSexo = datosIniciales.ObjetoRespuesta.catalogoSexo;

            return View();

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

        public ActionResult BuscadorProyectos()
        {
            return View();
        }
    }
}