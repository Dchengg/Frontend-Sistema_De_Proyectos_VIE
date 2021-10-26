using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class ReporteController : Controller
    {
        public static List<Investigador> InvestigadoresXEstado(String estado)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/SeleccionarEstado/{0}", estado));

                var responseTask = client.PostAsync(builder.Uri, null);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Investigador> Investigador = new List<Investigador>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Investigador = JsonConvert.DeserializeObject<List<Investigador>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Investigador;
            }
        }

        public static List<Investigador> InvestigadoresXDisciplina(String estado,String disciplina)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/SeleccionarDiciplina/{0}/{1}", estado, disciplina));

                var responseTask = client.PostAsync(builder.Uri, null);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Investigador> Investigador = new List<Investigador>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Investigador = JsonConvert.DeserializeObject<List<Investigador>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Investigador;
            }
        }

        public static List<Investigador> InvestigadoresXEscuela(String estado, String escuela)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/SeleccionarEscuela/{0}/{1}", estado, escuela));

                var responseTask = client.PostAsync(builder.Uri, null);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Investigador> Investigador = new List<Investigador>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Investigador = JsonConvert.DeserializeObject<List<Investigador>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Investigador;
            }
        }

        public JsonResult GetDisciplinas()
        {
            List<Disciplina> disciplinas = DisciplinasController.getDisciplinas();
            return Json(disciplinas, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEscuelas()
        {
            List<Escuela> escuelas = EscuelaController.getEscuelas();
            return Json(escuelas, JsonRequestBehavior.AllowGet);
        }
    }
}