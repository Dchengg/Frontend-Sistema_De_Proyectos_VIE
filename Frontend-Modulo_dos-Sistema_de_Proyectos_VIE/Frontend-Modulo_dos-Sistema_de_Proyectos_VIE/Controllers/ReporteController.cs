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
                List<Investigador> investigadores = new List<Investigador>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    investigadores = JsonConvert.DeserializeObject<List<Investigador>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return investigadores;
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
                List<Investigador> investigadores = new List<Investigador>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    investigadores = JsonConvert.DeserializeObject<List<Investigador>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return investigadores;
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
                List<Investigador> investigadores = new List<Investigador>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    investigadores = JsonConvert.DeserializeObject<List<Investigador>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return investigadores;
            }
        }

        public static List<Investigador> InvestigadoresInformesPendientes()
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Reportes/InvestigadorInformesPendientes/");

                var responseTask = client.PostAsync(builder.Uri, null);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Investigador> investigadores = new List<Investigador>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    investigadores = JsonConvert.DeserializeObject<List<Investigador>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return investigadores;
            }
        }

        public static List<Proyecto> ProyectoXEstado(String estado)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/ResporteEstado/{0}", estado));
                var responseTask = client.PostAsync(builder.Uri, null);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Proyecto> proyectos= new List<Proyecto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return proyectos;
            }
        }

        public static List<Proyecto> ProyectoXBeneficiaria(String estado, String poblacion)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/ReporteBeneficiaria/{0}/{1}", estado, poblacion));
                var responseTask = client.PostAsync(builder.Uri, null);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Proyecto> proyectos = new List<Proyecto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return proyectos;
            }
        }

        public static List<Proyecto> ProyectoXTipo(String estado, String tipoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/ReporteTIpoProyecto/{0}/{1}", estado, tipoProyecto));
                var responseTask = client.PostAsync(builder.Uri, null);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Proyecto> proyectos = new List<Proyecto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return proyectos;
            }
        }

        public static List<Proyecto> ProyectoXModalidad(String estado, String modalidad)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/ResporteModalidad/{0}/{1}", estado, modalidad));
                var responseTask = client.PostAsync(builder.Uri, null);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Proyecto> proyectos = new List<Proyecto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return proyectos;
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

        public JsonResult GetPoblacionesBeneficiarias()
        {
            List<Poblacion> poblaciones = PoblacionBeneficiariaController.getPoblaciones();
            return Json(poblaciones, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTiposProyecto()
        {
            List<TipoProyecto> tipos = ProyectoController.getTiposProyecto();
            return Json(tipos, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetModalidades()
        {
            List<ModalidadProyecto> modalidades = ProyectoController.getModalidad();
            return Json(modalidades, JsonRequestBehavior.AllowGet);
        }
    }
}