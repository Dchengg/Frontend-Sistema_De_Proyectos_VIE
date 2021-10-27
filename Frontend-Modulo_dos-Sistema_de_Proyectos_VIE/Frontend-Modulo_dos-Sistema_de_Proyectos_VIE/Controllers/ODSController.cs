using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class ODSController : Controller
    {
        #region Métodos
        /// <summary>
        /// Busca y devuelve lista de ODSs que pertenecen al proyecto en especifico
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Lista de objetivos de desarrollo sostenible que pertenecen al proyecto</returns>
        public static List<ODS> getODSs(String codigoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/ODS")
                {
                    Query = string.Format("id={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<ODS> ODSs = new List<ODS>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    ODSs = JsonConvert.DeserializeObject<List<ODS>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return ODSs;
            }
        }
        public static List<ODS> getODS()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/ods");

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<ODS> ODS = new List<ODS>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    ODS = JsonConvert.DeserializeObject<List<ODS>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return ODS;
            }
        }

        public static List<SubODS> getsubODS()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/SubODS");

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<SubODS> SubODS = new List<SubODS>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    SubODS = JsonConvert.DeserializeObject<List<SubODS>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return SubODS;
            }
        }
        /// <summary>
        /// Crea un ODS asociado al proyecto y llama a la API para agregarlo a la base de datos
        /// </summary>
        /// <param name="area"></param>
        /// <param name="subArea"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>String de respuesta de exito o fracaso de agregar el ODS a la base de datos</returns>
        [HttpPost]
        public static String AgregarODS(String idODS, String idSubODS, String codigoProyecto)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/ODS/3")
                {

                    Query = string.Format("codigoProyecto={0}&idODS={1}&idSubODS={2}", codigoProyecto, idODS, idSubODS)
                };
                var values = new Dictionary<string, string>
                {
                    {"codigoProyecto", codigoProyecto},
                    {"idODS", idODS},
                    {"idSubODS", idSubODS}
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
        public static String EliminarODS(String idODS)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/ODS/1")
                {

                    Query = string.Format("id={0}", idODS)
                };


                var responseTask = client.DeleteAsync(builder.Uri.AbsoluteUri);
                responseTask.Wait();
                var result = responseTask.Result;
                var responseResult = "Failed";
                if (result.IsSuccessStatusCode) responseResult = "Sucess";
                return responseResult;
            }
        }
        #endregion
    }
}