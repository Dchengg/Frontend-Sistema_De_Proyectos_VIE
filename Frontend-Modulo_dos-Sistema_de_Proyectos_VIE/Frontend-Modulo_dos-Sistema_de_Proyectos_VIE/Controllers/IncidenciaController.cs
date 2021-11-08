using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class IncidenciaController : Controller
    {
        /// <summary>
        /// Llama al API para obtener la lista de incidencias del proyecto
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>lista de incidencias del proyecto</returns>
        public static List<Incidencia> getIncidencias(String codigoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Incidencias")
                {
                    Query = string.Format("id={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Incidencia> incidencias = new List<Incidencia>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    incidencias = JsonConvert.DeserializeObject<List<Incidencia>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return incidencias;
            }
        }

        /// <summary>
        /// Llama al API para agregar una nueva incidencia al proyecto
        /// </summary>
        /// <param name="tituloIncidencia"></param>
        /// <param name="descripcion"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>Resultado de inserción, exito o fracaso</returns>
        [HttpPost]
        public static String agregarIncidencia(string tituloIncidencia, string descripcion, string codigoProyecto)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Incidencias/1")
                {

                    Query = string.Format("tituloIncidencia={0}&descripcion={1}&codigoProyecto={2}", tituloIncidencia, descripcion, codigoProyecto)
                };
                var values = new Dictionary<string, string>
                {
                    {"tituloIncidencia", tituloIncidencia},
                    {"descripcion", descripcion },
                    {"codigoProyecto", codigoProyecto}


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
        /// Llama al API para eliminar una incidencia del proyecto
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Resultado de eliminar, exito o fracaso</returns>
        [HttpDelete]
        public static String eliminarIncidencia(string id)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Incidencias/1")
                {

                    Query = string.Format("id={0}", id)
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
