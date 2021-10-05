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
    public class ComprasController
    {
        /// <summary>
        /// Llama a la api para obtener todas las compras de un proyecto
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>lista de las compras del proyecto</returns>
        public static List<Compras> getCompras(String codigoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Compra")
                {
                    Query = string.Format("id={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Compras> compras = new List<Compras>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    compras = JsonConvert.DeserializeObject<List<Compras>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return compras;
            }
        }

        /// <summary>
        /// Elimina la compra selecionada en la interfaz del proyecto y llama a la API para eliminarla de la base de datos
        /// </summary>
        /// <param name="idCompra"></param>
        /// <returns>String de respuesta de exito o fracaso de eliminar la compra de la base de datos</returns>
        /// 
        [HttpDelete]
        public static String EliminarCompra(String idCompra)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Compra/1")
                {

                    Query = string.Format("id={0}", idCompra)
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