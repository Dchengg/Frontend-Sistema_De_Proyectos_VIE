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
    public class InformeController : Controller
    {
        // GET: Informe
        public static List<Informe> getInformes(string idInformes)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Informe")
                {
                    Query = string.Format("id={0}", idInformes)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Informe> informes = new List<Informe>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    informes = JsonConvert.DeserializeObject<List<Informe>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return informes;
            }
        }

        public static List<TipoInforme> getTiposDeInforme()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/tipoinforme");

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<TipoInforme> TipoInforme = new List<TipoInforme>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    TipoInforme = JsonConvert.DeserializeObject<List<TipoInforme>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return TipoInforme;
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
        public static String AgregarInforme(string tituloInforme, string idTipoInforme, string fechaProgramada, string estado, string memorandoDIP, string observaciones, string codigoProyecto)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Informe/AgregarInforme");
                
                var values = new Dictionary<string, string>
                {
                    {"tituloInforme", tituloInforme},
                    {"idTipoInforme", idTipoInforme},
                    {"fechaProgramada", fechaProgramada},
                    {"estado", estado},
                    {"memorandoDIP", memorandoDIP},
                    {"observaciones", observaciones},
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

        [HttpDelete]
        public static String EliminarInforme(String idInforme)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Informe/1")
                {

                    Query = string.Format("id={0}", idInforme)
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
