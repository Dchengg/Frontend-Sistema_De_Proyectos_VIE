using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.Inicio;
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
            var datosIniciales = respuesta.Content.ReadAsAsync<oRespuesta<UipCatalogos>>().Result;

            // Ligado de catalogos
            UipCatalogosGlobal.CatalogoTipoIdentificacion = datosIniciales.ObjetoRespuesta.CatalogoTipoIdentificacion;
            UipCatalogosGlobal.CatalogoPais = datosIniciales.ObjetoRespuesta.catalogoPais;
            UipCatalogosGlobal.catalogoProvincia = datosIniciales.ObjetoRespuesta.catalogoProvincia;
            UipCatalogosGlobal.catalogoCanton = datosIniciales.ObjetoRespuesta.catalogoCanton;
            UipCatalogosGlobal.catalogoDistrito = datosIniciales.ObjetoRespuesta.catalogoDistrito;
            UipCatalogosGlobal.catalogoCategoriaAcademica= datosIniciales.ObjetoRespuesta.catalogoCategoriaAcademica;
            UipCatalogosGlobal.catalogoSituacionLaboral = datosIniciales.ObjetoRespuesta.catalogoSituacionLaboral;
            UipCatalogosGlobal.catalogoInstitucion= datosIniciales.ObjetoRespuesta.catalogoInstitucion;
            UipCatalogosGlobal.catalogoAreaEstudio = datosIniciales.ObjetoRespuesta.catalogoAreaEstudio;
            UipCatalogosGlobal.catalogoTituloAcademico = datosIniciales.ObjetoRespuesta.catalogoTituloAcademico;
            UipCatalogosGlobal.catalogoIdioma = datosIniciales.ObjetoRespuesta.catalogoIdioma;
            UipCatalogosGlobal.catalogoAreaIdioma = datosIniciales.ObjetoRespuesta.catalogoAreaIdioma;
            UipCatalogosGlobal.catalogoNivelIdioma = datosIniciales.ObjetoRespuesta.catalogoNivelIdioma;
            UipCatalogosGlobal.catalogoUnidadAcademica = datosIniciales.ObjetoRespuesta.catalogoUnidadAcademica;
            UipCatalogosGlobal.catalogoSexo = datosIniciales.ObjetoRespuesta.catalogoSexo;*/

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