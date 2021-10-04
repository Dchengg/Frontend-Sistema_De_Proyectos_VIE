using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers.FichaInvestigador
{
    public class FichaInvestigadorController : Controller
    {
        // GET: FichaInvestigador
        public ActionResult Index()
        {
            HttpResponseMessage respuesta = GlobalVariables.WebApiClient.GetAsync("Investigador/123456789").Result;
            var investigador = respuesta.Content.ReadAsAsync<oRespuesta<oInvestigadorConsultar>>().Result;
            /*
             oVistaInvestigador objetoVista = new oVistaInvestigador();
             objetoVista.investigador = investigador.ObjetoRespuesta;
             objetoVista.catalogos = new oModelosCatalogosInvestigador();

             // Asociacion de catalogos
             objetoVista.catalogos.modeloTipoIdentificacion = oCatalogosGlobal.catalogoTipoIdentificacion;
             objetoVista.catalogos.modeloPais = oCatalogosGlobal.catalogoPais;
             objetoVista.catalogos.modeloCategoriaAcademica = oCatalogosGlobal.catalogoCategoriaAcademica;
             objetoVista.catalogos.modeloSituacionLaboral = oCatalogosGlobal.catalogoSituacionLaboral;
             objetoVista.catalogos.modeloInstitucion = oCatalogosGlobal.catalogoInstitucion;
             objetoVista.catalogos.modeloTituloAcademico = oCatalogosGlobal.catalogoTituloAcademico;
             objetoVista.catalogos.modeloIdioma = oCatalogosGlobal.catalogoIdioma;
             objetoVista.catalogos.modeloNivelIdioma = oCatalogosGlobal.catalogoNivelIdioma;
             objetoVista.catalogos.modeloUnidadAcademica = oCatalogosGlobal.catalogoUnidadAcademica;

             ViewBag.catalogoTipoIdentificacion = oCatalogosGlobal.catalogoTipoIdentificacion;
             ViewBag.catalogoPais = oCatalogosGlobal.catalogoPais;
             ViewBag.catalogoCategoriaAcademica = oCatalogosGlobal.catalogoCategoriaAcademica;
             ViewBag.catalogoSituacionLaboral = oCatalogosGlobal.catalogoSituacionLaboral;
             ViewBag.catalogoInstitucion = oCatalogosGlobal.catalogoInstitucion;
             ViewBag.catalogoTituloAcademico = oCatalogosGlobal.catalogoTituloAcademico;
             ViewBag.catalogoIdioma = oCatalogosGlobal.catalogoIdioma;
             ViewBag.catalogoAreaIdioma = oCatalogosGlobal.catalogoAreaIdioma;
             ViewBag.catalogoNivelIdioma = oCatalogosGlobal.catalogoNivelIdioma;
             ViewBag.catalogoUnidadAcademica = oCatalogosGlobal.catalogoUnidadAcademica;
*/

            //return View(objetoVista);
            return View();
        }

        // GET: FichaInvestigador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FichaInvestigador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FichaInvestigador/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FichaInvestigador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FichaInvestigador/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FichaInvestigador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FichaInvestigador/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
