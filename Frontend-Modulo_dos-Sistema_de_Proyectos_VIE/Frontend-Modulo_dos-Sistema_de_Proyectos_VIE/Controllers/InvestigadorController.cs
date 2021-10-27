using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class InvestigadorController : Controller
    {
        public static List<Investigador> getInvestigadores()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44394/api/investigador");
                //HTTP GET
                var responseTask = client.GetAsync("Reportes");
                responseTask.Wait();
                var result = responseTask.Result;
                List<Investigador> investigadores = new List<Investigador>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    investigadores = JsonConvert.DeserializeObject<List<Investigador>>(response.Result);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR");
                }
                return investigadores;
            }
        }

        public static List<Investigador> getInvestigadores(String codigoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Investigador")
                {
                    Query = string.Format("id={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
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

        [HttpPost]
        public static String CambiarCoordinador(string numIdentidad, string codigo)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Investigador/")
                {
                    Query = string.Format("numIdentidad={0}&codigo={1}", numIdentidad, codigo)
                };
                var values = new Dictionary<string, string>
                {
                    {"numIdentidad", numIdentidad},
                    {"codigo", codigo}


                };
                var content = new FormUrlEncodedContent(values);
                var responseTask = client.PostAsync(builder.Uri, content);
                responseTask.Wait();
                var result = responseTask.Result;
                var responseResult = "Failed";
                if (result.IsSuccessStatusCode) responseResult = "Sucess";
                return responseResult;
            }
        }


        /// <summary>
        /// Llama a la API para agregar un nuevo investigador asociado al proyecto
        /// </summary>
        /// <param name="numIdentidad"></param>
        /// <param name="idSetDatos"></param>
        /// <param name="idCondicionDeParticipacion"></param>
        /// <param name="idEscuela"></param>
        /// <param name="areaConocimiento"></param>
        /// <returns>Resultado de inserción</returns>
        [HttpPost]
        public static String AgregarInvestigadorAsociado(string numIdentidad, string idSetDatos, string idCondicionDeParticipacion, string idEscuela, string areaConocimiento)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Investigador/5")
                {

                    Query = string.Format("numIdentidad={0}&idSetDatos={1}&idCondicionDeParticipacion={2}&idEscuela={3}&areaConocimiento={4}", numIdentidad, idSetDatos, idCondicionDeParticipacion, idEscuela, areaConocimiento)
                };
                var values = new Dictionary<string, string>
                {
                    {"numIdentidad", numIdentidad},
                    {"idSetDatos", idSetDatos},
                    {"idCondicionDeParticipacion", idCondicionDeParticipacion},
                    {"idEscuela",idEscuela },
                    {"areaConocimiento", areaConocimiento}
                };
                var content = new FormUrlEncodedContent(values);
                var responseTask = client.PostAsync(builder.Uri, content);
                responseTask.Wait();
                var result = responseTask.Result;
                var responseResult = "Failed";
                if (result.IsSuccessStatusCode) responseResult = "Sucess";
                return responseResult;
            }
        }

        [HttpDelete]
        public static String EliminarInvestigadorAsociado(String idInvestigadorAsociado, String idSetDatos)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Investigador/1")
                {

                    Query = string.Format("numIdentidad={0}&idSetDatos={1}", idInvestigadorAsociado, idSetDatos)
                };
                var responseTask = client.DeleteAsync(builder.Uri.AbsoluteUri);
                responseTask.Wait();
                var result = responseTask.Result;
                var responseResult = "Failed";
                if (result.IsSuccessStatusCode) responseResult = "Sucess";
                return responseResult;
            }
        }

    }
}

