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

        public static List<Investigador> getInvestigador(string numIdentidad)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Reportes/GetIdentidad/") 
                {
                    Query = string.Format("numIdentidad={0}", numIdentidad)
                };

                var responseTask = client.GetAsync(builder.Uri);
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

        public static List<Disciplina> getDisciplinaInvestigador(string numIdentidad)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/DiscipliInvestigador/{0}", numIdentidad));

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Disciplina> disciplinas = new List<Disciplina>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    disciplinas = JsonConvert.DeserializeObject<List<Disciplina>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return disciplinas;
            }
            
        }

        public static List<Escuela> getEscuelaInvestigador(string numIdentidad)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/EscuelaInvestigador/{0}", numIdentidad));

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Escuela> escuelas = new List<Escuela>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    escuelas = JsonConvert.DeserializeObject<List<Escuela>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return escuelas;
            }

        }

        public static List<Idioma> getIdiomaInvestigador(string numIdentidad)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/IdiomasInvestigador/{0}", numIdentidad));

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Idioma> idiomas = new List<Idioma>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    idiomas = JsonConvert.DeserializeObject<List<Idioma>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return idiomas;
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

        public static List<Proyecto> ProyectoXUbicacion(String estado, String pais, String region, String provincia)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/ReporteUbicacion/{0}/{1}/{2}/{3}", estado, pais, region, provincia));
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

        public static List<Proyecto> ProyectoInformes()
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Reportes/ProyectoInformesPendientes/");
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

        public static List<Proyecto> ProyectoXInvestigador(String investigador)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/InvestigadorParticipante/{0}/", investigador));
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

        public static List<Proyecto> CantidadPresupuesto(String fechaInicio, String fechaFinal, String departamento, String tipoDepartamento, String estado)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(String.Format("https://localhost:44394/api/Reportes/ReportePresupuesto/{0}/{1}/{2}/{3}/{4}", fechaInicio, fechaFinal, departamento, tipoDepartamento, estado));
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

        public JsonResult GetPaises()
        {
            List<Pais> paises  = UbicacionGeograficaController.getPaises();
            return Json(paises, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetRegiones()
        {
            List<Region> regiones = UbicacionGeograficaController.getRegiones();
            return Json(regiones, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetProvincias()
        {
            List<Provincia> provincias = UbicacionGeograficaController.getProvincias();
            return Json(provincias, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetInvestigadores()
        {
            List<Investigador> investigadores = InvestigadorController.getInvestigadores();
            return Json(investigadores, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTipoDepartamento()
        {
            List<TipoDepartamento> tipos = DepartamentosController.getTiposDepartamento();
            return Json(tipos, JsonRequestBehavior.AllowGet);
        }
    }
}