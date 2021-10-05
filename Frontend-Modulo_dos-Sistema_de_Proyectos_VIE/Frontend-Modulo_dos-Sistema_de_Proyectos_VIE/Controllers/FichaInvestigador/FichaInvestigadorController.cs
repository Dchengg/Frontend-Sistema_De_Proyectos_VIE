using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.Inicio;
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
            var investigador = respuesta.Content.ReadAsAsync<oRespuesta<InvestigadorConsultar>>().Result;
            
            mVistaInvestigador objetoVista = new mVistaInvestigador();
            objetoVista.investigador = investigador.ObjetoRespuesta;
            objetoVista.catalogos = mCatalogosInvestigador;

            // Asociacion de catalogos
            objetoVista.catalogos.CatalogoTipoIdentificacion = UipCatalogos.CatalogoTipoIdentificacion;
            objetoVista.catalogos.modeloPais = UipCatalogosGlobal.catalogoPais;
            objetoVista.catalogos.modeloCategoriaAcademica = UipCatalogosGlobal.catalogoCategoriaAcademica;
            objetoVista.catalogos.modeloSituacionLaboral = UipCatalogosGlobal.catalogoSituacionLaboral;
            objetoVista.catalogos.modeloInstitucion = UipCatalogosGlobal.catalogoInstitucion;
            objetoVista.catalogos.modeloTituloAcademico = UipCatalogosGlobal.catalogoTituloAcademico;
            objetoVista.catalogos.modeloIdioma = UipCatalogosGlobal.catalogoIdioma;
            objetoVista.catalogos.modeloNivelIdioma = UipCatalogosGlobal.catalogoNivelIdioma;
            objetoVista.catalogos.modeloUnidadAcademica = UipCatalogosGlobal.catalogoUnidadAcademica;

             ViewBag.catalogoTipoIdentificacion = UipCatalogosGlobal.catalogoTipoIdentificacion;
             ViewBag.catalogoPais = UipCatalogosGlobal.catalogoPais;
             ViewBag.catalogoCategoriaAcademica = UipCatalogosGlobal.catalogoCategoriaAcademica;
             ViewBag.catalogoSituacionLaboral = UipCatalogosGlobal.catalogoSituacionLaboral;
             ViewBag.catalogoInstitucion = UipCatalogosGlobal.catalogoInstitucion;
             ViewBag.catalogoTituloAcademico = UipCatalogosGlobal.catalogoTituloAcademico;
             ViewBag.catalogoIdioma = UipCatalogosGlobal.catalogoIdioma;
             ViewBag.catalogoAreaIdioma = UipCatalogosGlobal.catalogoAreaIdioma;
             ViewBag.catalogoNivelIdioma = UipCatalogosGlobal.catalogoNivelIdioma;
             ViewBag.catalogoUnidadAcademica = UipCatalogosGlobal.catalogoUnidadAcademica;
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
