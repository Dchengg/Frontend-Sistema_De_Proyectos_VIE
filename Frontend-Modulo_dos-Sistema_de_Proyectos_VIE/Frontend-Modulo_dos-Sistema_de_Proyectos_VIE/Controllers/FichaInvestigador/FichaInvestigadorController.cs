using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using UIProcess.Consultas;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers.FichaInvestigador
{
    public class FichaInvestigadorController : Controller
    {
        // Métodos

        // GET: FichaInvestigador
        public ActionResult Index()
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

        [HttpPost]
        public ActionResult EditarTelefono(IEnumerable<TelefonoViewModel> telefonos)
        {
            Console.WriteLine(telefonos);
            return View();
        }

        [HttpPost]
        public ActionResult EliminarTelefono(TelefonoViewModel telefono)
        {
            Console.WriteLine(telefono);
            return View();
        }

        [HttpPost]
        public ActionResult AgregarTelefono(IEnumerable<TelefonoViewModel> telefonos)
        {
            return View(telefonos);
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

        // GET: FichaInvestigador/List
        public ActionResult List()
        {
            UipRespuesta<List<UipInvestigadorListar>> respuesta = Consultor.ConsultarListaInvestigadores();
            if (respuesta.estaSinErrores())
            {
                List<InvestigadorListarViewModel> lista = new List<InvestigadorListarViewModel>();
                foreach (var item in respuesta.ObjetoRespuesta)
                {
                    lista.Add(new InvestigadorListarViewModel());
                }
                List<InvestigadorListarViewModel> modeloListarInvestigadores = ViewModelMapper.MapearListaInvestigadores(respuesta.ObjetoRespuesta);
                return View(modeloListarInvestigadores);
            }
            else
            {
                // Manejo de un error
                return RedirectToAction("Error", routeValues: new { respuesta });
            }
        }

        // POST: FichaInvestigador/Delete/5
        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                Consultor.EliminarInvestigador(id);
                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }
    }
}
