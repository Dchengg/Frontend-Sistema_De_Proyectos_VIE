using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class BitacoraController : Controller
    {
        /// <summary>
        /// Llama a la api para obtener todas las Bitacoras de un proyecto
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>lista de las Bitacora del proyecto</returns>
        public static List<Bitacora> getBitacora(String codigoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/bitacora")
                {
                    Query = string.Format("id={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Bitacora> Bitacora = new List<Bitacora>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Bitacora = JsonConvert.DeserializeObject<List<Bitacora>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Bitacora;
            }
        }

        /// <summary>
        /// Llama a la api para insertar una nueva palabra clave a la base de datos
        /// </summary>
        /// <param name="PalabraClave"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>String de respuesta de exito o fracaso de agregar la palabra clave de la base de datos</returns>
        [HttpPost]
        public static String AgregarBitacora(string descripcion, string responsable, string cedulaResponsable, string fechaYHora, string codigoProyecto)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/bitacora/AgregarBitacora");
                var values = new Dictionary<string, string>
                {
                    {"descripcion", descripcion},
                    {"responsable", responsable},
                    {"cedulaResponsable", cedulaResponsable},
                    {"fechaYHora", fechaYHora},
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
        /// Elimina la Bitacora selecionada en la interfaz del proyecto y llama a la API para eliminarla de la base de datos
        /// </summary>
        /// <param name="idBitacora"></param>
        /// <returns>String de respuesta de exito o fracaso de eliminar la Bitacora de la base de datos</returns>
        /// 
        [HttpDelete]
        public static String EliminarBitacora(int idBitacora)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Bitacora/1")
                {

                    Query = string.Format("id={0}", idBitacora)
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