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
    public class PoblacionBeneficiariaController : Controller
    {
        #region Métodos
        /// <summary>
        /// Busca y devuelve lista de ODSs que pertenecen al proyecto en específico
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Lista de las poblaciones beneficiarias del proyecto</returns>
        public static List<Poblacion> getPoblaciones(String codigoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Poblacion")
                {
                    Query = string.Format("id={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Poblacion> poblaciones = new List<Poblacion>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    poblaciones = JsonConvert.DeserializeObject<List<Poblacion>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return poblaciones;
            }
        }
        public static List<Poblacion> getPoblaciones()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/poblacion");

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Poblacion> Poblacion = new List<Poblacion>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Poblacion = JsonConvert.DeserializeObject<List<Poblacion>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Poblacion;
            }
        }
        /// <summary>
        /// Crea una población beneficiaria asociada al proyecto y llama a la API para agregarla a la base de datos
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <param name="poblacionId"></param>
        /// <returns>String de respuesta de exito o fracaso de agregar la población beneficiaria a la base de datos</returns>
        public static String AgregarPoblacion(String codigoProyecto, String poblacionId)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Poblacion/1")
                {

                    Query = string.Format("codigoProyecto={0}&poblacion={1}", codigoProyecto, poblacionId)
                };
                var values = new Dictionary<string, string>
                {
                    {"codigoProyecto", codigoProyecto},
                    {"poblacion", poblacionId}
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
        #endregion
        [HttpDelete]
        public static String EliminarPoblacion(String idPoblacion)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Poblacion/1")
                {

                    Query = string.Format("id={0}", idPoblacion)
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