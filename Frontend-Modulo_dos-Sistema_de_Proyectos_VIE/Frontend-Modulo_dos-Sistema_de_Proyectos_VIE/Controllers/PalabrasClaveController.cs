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
    public class PalabrasClaveController : Controller
    {
        #region Métodos
        public static List<PalabrasClave> getPalabrasClave(string idPalabrasClave)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/PalabrasClave")
                {
                    Query = string.Format("id={0}", idPalabrasClave)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<PalabrasClave> palabrasClave = new List<PalabrasClave>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    palabrasClave = JsonConvert.DeserializeObject<List<PalabrasClave>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return palabrasClave;
            }
        }

        public static String AgregarPalabraClave(String PalabraClave, String codigoProyecto)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/PalabraClave/2")
                {

                    Query = string.Format("codigoProyecto={0}&palabraClave={1}", codigoProyecto, PalabraClave)
                };
                var values = new Dictionary<string, string>
                {
                    {"codigoProyecto", codigoProyecto},
                    {"PalabraClave", PalabraClave},
                    
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
        /// Elimina la palabra clave selecionada en la interfaz del proyecto y llama a la API para eliminarla de la base de datos
        /// </summary>
        /// <param name="idPalabraClave"></param>
        /// <returns>String de respuesta de exito o fracaso de eliminar la palabra clave de la base de datos</returns>
        /// 
        [HttpDelete]
        public static String EliminarPalabraClave(String idPalabraClave)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/PalabrasClave/1")
                {

                    Query = string.Format("id={0}", idPalabraClave)
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