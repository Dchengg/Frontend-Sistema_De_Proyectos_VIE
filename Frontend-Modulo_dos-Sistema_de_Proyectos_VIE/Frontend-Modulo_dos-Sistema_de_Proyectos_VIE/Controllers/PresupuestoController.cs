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
    public class PresupuestoController : Controller
    {
        #region Métodos
        /// <summary>
        /// Llama a la api para obtener todas las palabras clave de un proyecto
        /// </summary>
        /// <param name="idPalabrasClave"></param>
        /// <returns>Las palabras clave en forma de lista</returns>
        public static List<Presupuesto> getPresupuesto(string codigoProyecto)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Presupuesto")
                {
                    Query = string.Format("id={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Presupuesto> palabrasClave = new List<Presupuesto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    palabrasClave = JsonConvert.DeserializeObject<List<Presupuesto>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return palabrasClave;
            }
        }


        public static List<Partida> getPartidas()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Partida");



                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Partida> tipo = new List<Partida>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    tipo = JsonConvert.DeserializeObject<List<Partida>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return tipo;
            }
        }

            
        public static List<Fuente> getFuente()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Fuente");



                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Fuente> tipo = new List<Fuente>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    tipo = JsonConvert.DeserializeObject<List<Fuente>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return tipo;
            }
        }
        /// <summary>
        /// Llama a la api para insertar una nueva palabra clave a la base de datos
        /// </summary>
        /// <param name="Presupuesto"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>String de respuesta de exito o fracaso de agregar la palabra clave de la base de datos</returns>
        [HttpPost]
        public static String AgregarPresupuesto(string idFuenteFinanciamiento, string organizacion, string idPartida, string ano, string monto, string codigoProyecto)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/presupuesto/1")
                {

                    Query = string.Format("idFuenteFinanciamiento={0}&organizacion={1}&idPartida={2}&ano={3}&monto={4}&codigoProyecto={5}", idFuenteFinanciamiento, organizacion, idPartida, ano, monto, codigoProyecto)
                };
                var values = new Dictionary<string, string>
                {
                    {"idFuenteFinanciamiento", idFuenteFinanciamiento},
                    {"organizacion", organizacion},
                    {"idPartida", idPartida},
                    {"ano", ano},
                    {"monto", monto},
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
        /// Elimina la palabra clave selecionada en la interfaz del proyecto y llama a la API para eliminarla de la base de datos
        /// </summary>
        /// <param name="idPalabraClave"></param>
        /// <returns>String de respuesta de exito o fracaso de eliminar la palabra clave de la base de datos</returns>
        ///     
        [HttpDelete]
        public static String EliminarPresupuesto(String idPalabraClave)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/presupuesto/1")
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