using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers.SeguimientoProyectos
{
    public class FrascatiController : Controller
    {
        #region Métodos
        /// <summary>
        /// Recupera las áreas frascati del proyecto, dado el codigo del proyecto
        /// </summary>
        /// <param name="idAreaFrascati"></param>
        /// <returns>Lista de las áreas frascati del proyecto</returns>
        public static List<Frascati> getFrascatis(string idAreaFrascati)
        {
            using (var client = new HttpClient()) {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Frascati")
                {
                    Query = string.Format("id={0}", idAreaFrascati)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Frascati> frascatis = new List<Frascati>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    frascatis = JsonConvert.DeserializeObject<List<Frascati>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return frascatis;
            }
        }


        public static List<Frascati> getFrascatis()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Frascati");

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Frascati> Frascati = new List<Frascati>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Frascati = JsonConvert.DeserializeObject<List<Frascati>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Frascati;
            }
        }

        public static List<SubFrascati> getSubFrascatis()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/subfrascati");

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<SubFrascati> SubFrascati = new List<SubFrascati>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    SubFrascati = JsonConvert.DeserializeObject<List<SubFrascati>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return SubFrascati;
            }
        }
        /// <summary>
        /// Agrega un área frascati al proyecto y llama a la API para agregarla a la base de datos
        /// </summary>
        /// <param name="area"></param>
        /// <param name="subArea"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>String de respuesta de exito o fracaso de agregar el área frascati a la base de datos</returns>
        [HttpPost]
        public static String AgregarAreaFrascati(String area, String subArea, String codigoProyecto)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Frascati/3")
                {
                   
                    Query = string.Format("codigoProyecto={0}&area={1}&subArea={2}", codigoProyecto, area, subArea)
                };
                var values = new Dictionary<string, string>
                {
                    {"codigoProyecto", codigoProyecto},
                    {"area", area},
                    {"subarea", subArea}
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
        /// Elimina el area frascati selecionada en la interfaz del proyecto y llama a la API para eliminarlo de la base de datos
        /// </summary>
        /// <param name="idAreaFrascati"></param>
        /// <returns>String de respuesta de exito o fracaso de agregar el área frascati a la base de datos</returns>
        public static String EliminarAreaFrascati(String idAreaFrascati) {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Frascati/1")
                {

                    Query = string.Format("id={0}", idAreaFrascati)
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