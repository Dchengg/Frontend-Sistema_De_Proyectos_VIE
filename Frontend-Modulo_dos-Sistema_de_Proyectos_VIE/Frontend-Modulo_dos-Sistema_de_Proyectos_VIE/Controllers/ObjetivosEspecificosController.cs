using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class ObjetivosEspecificosController : Controller
    {
        public static List<Producto> getProductos(String idObjetivo)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/producto")
                {
                    Query = string.Format("id={0}", idObjetivo)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Producto> Producto = new List<Producto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Producto = JsonConvert.DeserializeObject<List<Producto>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Producto;
            }
        }


        [HttpPost]
        public static String AgregarProducto(string actividad, string idInvestigadorEncargado, string idColaboradorEncargado, string idNivelDeResponsabilidad, string nombre, string idObjetivoEspecifico, string ano, string trimestre, string fecha)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/producto/3")
                {

                    Query = string.Format("actividad={0}&idInvestigadorEncargado={1}&idColaboradorEncargado={2}&idNivelDeResponsabilidad={3}&nombre={4}&idObjetivoEspecifico={5}&ano={6}&trimestre={7}&fecha={8}", actividad, idInvestigadorEncargado, idColaboradorEncargado, idColaboradorEncargado, idNivelDeResponsabilidad, nombre, idObjetivoEspecifico, ano, trimestre, fecha)
                };
                var values = new Dictionary<string, string>
                {
                    {"actividad", actividad},
                    {"idInvestigadorEncargado", idInvestigadorEncargado},
                    {"idColaboradorEncargado", idColaboradorEncargado},
                    {"idNivelDeResponsabilidad", idNivelDeResponsabilidad},
                    {"nombre", nombre},
                    {"idObjetivoEspecifico", idObjetivoEspecifico},
                    {"ano", ano},
                    {"trimestre", trimestre},
                    {"fecha", fecha}
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

        public static List<ObjetivoEspecifico> getGetObjetivoByCodigo(String idObjetivo)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/ObjetivosEspecificos")
                {
                    Query = string.Format("idObjetivo={0}", idObjetivo)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<ObjetivoEspecifico> obj = new List<ObjetivoEspecifico>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    obj = JsonConvert.DeserializeObject<List<ObjetivoEspecifico>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return obj;
            }
        }

        public static List<Actividad> getActividades(String codigoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Actividades")
                {
                    Query = string.Format("CodigoProyecto={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Actividad> Actividades = new List<Actividad>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Actividades = JsonConvert.DeserializeObject<List<Actividad>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Actividades;
            }
        }

        public static List<Meta> getMetas(String idObjetivo)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Metas")
                {
                    Query = string.Format("id={0}", idObjetivo)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Meta> Metas = new List<Meta>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Metas = JsonConvert.DeserializeObject<List<Meta>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Metas;
            }
        }
        [HttpPost]
        public static String AgregarMeta(string nombre, string estaCumplida, string idObjectivoEspecifico, string descripcion)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/metas/4")
                {

                    Query = string.Format("nombre={0}&estaCumplida={1}&idObjectivoEspecifico={2}&descripcion={3}", nombre, estaCumplida, idObjectivoEspecifico, descripcion)
                };
                var values = new Dictionary<string, string>
                {
                    {"nombre", nombre},
                    {"estaCumplida", estaCumplida},
                    {"idObjectivoEspecifico", idObjectivoEspecifico},
                    {"descripcion", descripcion}

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

        public static String EliminarMeta(String idMeta)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/metas/1")
                {

                    Query = string.Format("id={0}", idMeta)
                };


                var responseTask = client.DeleteAsync(builder.Uri.AbsoluteUri);
                responseTask.Wait();
                var result = responseTask.Result;
                var responseResult = "Failed";
                if (result.IsSuccessStatusCode) responseResult = "Sucess";
                return responseResult;
            }
        }
        public static List<Riesgo> getRiesgo(String idObjetivo)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/riesgo")
                {
                    Query = string.Format("id={0}", idObjetivo)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Riesgo> riesgo = new List<Riesgo>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    riesgo = JsonConvert.DeserializeObject<List<Riesgo>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return riesgo;
            }
        }

        [HttpPost]
        public static String AgregarRiesgo(string nombre, string accionesMitagacion, string idObjetivoEspecifico)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/riesgo/3")
                {

                    Query = string.Format("nombre={0}&accionesMitagacion={1}&idObjetivoEspecifico={2}", nombre, accionesMitagacion, idObjetivoEspecifico)
                };
                var values = new Dictionary<string, string>
                {
                    {"nombre", nombre},
                    {"accionesMitagacion", accionesMitagacion},
                    {"idObjetivoEspecifico", idObjetivoEspecifico}
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

        public static String EliminarRiesgo(String idRiesgo)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/riesgo/1")
                {

                    Query = string.Format("id={0}", idRiesgo)
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