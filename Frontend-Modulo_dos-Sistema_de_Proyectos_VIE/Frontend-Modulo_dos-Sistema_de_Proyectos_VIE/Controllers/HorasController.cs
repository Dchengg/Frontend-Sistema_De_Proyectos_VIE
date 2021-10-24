using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class HorasController : Controller
    {

        public static List<TipoHora> getTipoHoras()
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/TipoHora");

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<TipoHora> TipoHoras = new List<TipoHora>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    TipoHoras = JsonConvert.DeserializeObject<List<TipoHora>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return TipoHoras;
            }
        }

        public static List<Horas> getHoras(String codigoProyecto, String numIdentidad)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Horas")
                {
                    Query = string.Format("numIdentidad={0}&codigoProyecto={1}", numIdentidad,codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Horas> Horas = new List<Horas>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Horas = JsonConvert.DeserializeObject<List<Horas>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Horas;
            }
        }

        [HttpPost]
        public static String AgregarHoras(string idEquipoDeTrabajo, string idTipoHora, string fechaInicio, string fechaFinalizacion, string cantidadHoras)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Horas/4")
                {
                    Query = string.Format("idEquipoDeTrabajo={0}&idTipoHora={1}&fechaInicio={2}&fechaFinalizacion={3}&cantidadHoras={4}", idEquipoDeTrabajo, idTipoHora, fechaInicio, fechaFinalizacion, cantidadHoras)
                };
                var values = new Dictionary<string, string>
                {
                    {"idEquipoDeTrabajo", idEquipoDeTrabajo},
                    {"idTipoHora", idTipoHora},
                    {"fechaInicio", fechaInicio},
                    {"fechaFinalizacion", fechaFinalizacion},
                    {"cantidadHoras", cantidadHoras}


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

    }
}

