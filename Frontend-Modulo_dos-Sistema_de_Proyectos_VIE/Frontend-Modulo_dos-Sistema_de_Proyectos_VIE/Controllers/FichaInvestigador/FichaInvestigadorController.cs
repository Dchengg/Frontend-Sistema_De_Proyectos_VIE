using AutoMapper;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UIProcess.Consultas;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers.FichaInvestigador
{
    public class FichaInvestigadorController : Controller
    {
        // Métodos

        // GET: FichaInvestigador
        public ActionResult Lista()
        {
            return View();
        }

        // GET: FichaInvestigador/Details/5
        public ActionResult Details(string id)
        {
            return View();
        }

        // GET: FichaInvestigador/Create
        public ActionResult Create()
        {
            var modelo = ViewModelMapper.MapearCatalogosFichaInvestigador();
            return View(modelo);
        }

        // POST: FichaInvestigador/Create
        [HttpPost]
        public ActionResult Create(FichaInvestigadorViewModel modelo)
        {
            try
            {
                if (ModelState.IsValid)
                {

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FichaInvestigador/Edit/5
        public ActionResult Edit(string id)
        {
            UipRespuesta<UipInvestigadorConsultar> respuesta = Consultor.ConsultarInvestigador(id);
            if (respuesta.estaSinErrores())
            {
                FichaInvestigadorViewModel modeloFichaInvestigador = ViewModelMapper.MapearFichaInvestigador(respuesta.ObjetoRespuesta);
                return View(modeloFichaInvestigador);
            }
            else
            {
                // Manejo de un error
                return RedirectToAction("Error", routeValues: new { respuesta });
            }
        }

        // GET: FichaInvestigador/Error
        public ActionResult Error(object objeto)
        {
            return View(objeto);
        }

        // POST: FichaInvestigador/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Console.WriteLine(collection.Count);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FichaInvestigador/Delete/5
        public ActionResult Delete(string numeroIdentidad)
        {
            return View();
        }

        // POST: FichaInvestigador/Delete/5
        [HttpPost]
        public ActionResult Delete(FichaInvestigadorViewModel modelo)
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
