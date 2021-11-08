using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;


namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class UbicacionGeograficaController : Controller
    {
        #region
        /// <summary>
        /// llama al API para obtener las ubicaciones geográficas del proyecto
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>lista de ubicaciones geográficas</returns>
        public static List<UbicacionGeografica> GetUbicacionesGeograficas(String codigoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/UbicacionGeografica")
                {
                    Query = string.Format("id={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<UbicacionGeografica> ubicacionesGeograficas = new List<UbicacionGeografica>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    ubicacionesGeograficas = JsonConvert.DeserializeObject<List<UbicacionGeografica>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return ubicacionesGeograficas;
            }
        }

        public static List<Pais> getPaises()
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Pais");

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Pais> paises = new List<Pais>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    paises = JsonConvert.DeserializeObject<List<Pais>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return paises;
            }
        }

        public static List<Provincia> getProvincias()
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Provincia");

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Provincia> provincias = new List<Provincia>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    provincias = JsonConvert.DeserializeObject<List<Provincia>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return provincias;
            }
        }

        public static List<Region> getRegiones()
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Region");

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Region> regiones = new List<Region>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    regiones = JsonConvert.DeserializeObject<List<Region>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return regiones;
            }
        }

        [HttpPost]
        public static String agregarUbicacionGeografica(string idPais, string idRegion, string idProvincia, string codigoProyecto)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/UbicacionGeografica/1")
                {

                    Query = string.Format("idPais={0}&idRegion={1}&idProvincia={2}&codigoProyecto={3}", idPais, idRegion, idProvincia, codigoProyecto)
                };
                var values = new Dictionary<string, string>
                {

                    {"idPais", idPais},
                    {"idRegion", idRegion},
                    {"idProvincia", idProvincia },
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
        public static String EliminarUbicacionGeografica(String idUbicacion)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/UbicacionGeografica/1")
                {

                    Query = string.Format("id={0}", idUbicacion)
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
