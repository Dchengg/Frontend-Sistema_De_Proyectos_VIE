using BackendFase1.Objetos.Clases;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers.FichaInvestigador
{
    public class FichaInvestigadorController : Controller
    {
        // GET: FichaInvestigador
        public ActionResult Index()
        {
            //HttpResponseMessage respuesta = GlobalVariables.WebApiClient.GetAsync("Investigador/4").Result;
           // var respuestaAPI = respuesta.Content.ReadAsAsync<oRespuesta<oInvestigador>>().Result;
            var dummy = new oRespuesta<oInvestigador>(); 
            return View(dummy.ObjetoRespuesta);
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
