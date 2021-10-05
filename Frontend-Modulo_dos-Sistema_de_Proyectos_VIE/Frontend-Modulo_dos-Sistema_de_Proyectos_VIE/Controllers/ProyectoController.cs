using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class ProyectoController : Controller
    {
        public static List<Proyecto> getProyectos()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44394/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Proyecto");
                responseTask.Wait();
                var result = responseTask.Result;
                List<Proyecto> proyectos = new List<Proyecto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(response.Result);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR");
                }
                return proyectos;
            }
        }
        public static List<TipoProyecto> getTiposProyecto()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/tipodeproyecto");



                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<TipoProyecto> tipo = new List<TipoProyecto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    tipo = JsonConvert.DeserializeObject<List<TipoProyecto>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return tipo;
            }
        }

        public static List<EstadoProyecto> getEstadoProyecto()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/estadoproyecto");



                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<EstadoProyecto> tipo = new List<EstadoProyecto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    tipo = JsonConvert.DeserializeObject<List<EstadoProyecto>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return tipo;
            }
        }
        public static List<TipoProceso> getTiposProceso()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/TipoProceso");



                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<TipoProceso> tipo = new List<TipoProceso>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    tipo = JsonConvert.DeserializeObject<List<TipoProceso>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return tipo;
            }
        }
        public static List<ModalidadProyecto> getModalidad ()
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/modalidad");



                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<ModalidadProyecto> tipo = new List<ModalidadProyecto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    tipo = JsonConvert.DeserializeObject<List<ModalidadProyecto>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return tipo;
            }
        }
        public static Proyecto getProyecto(String codigo)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Proyecto")
                {
                    Query = string.Format("id={0}", codigo)
                };
                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Proyecto> proyecto = new List<Proyecto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(response);
                    response.Wait();
                    proyecto = JsonConvert.DeserializeObject<List<Proyecto>>(response.Result);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR");
                    System.Diagnostics.Debug.WriteLine(result);
                
                }
                return proyecto[0];
            }
        }

        public static List<ObjetivoEspecifico> getObjetivosProyecto(String codigo)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/ObjetivosEspecificos")
                {
                    Query = string.Format("id={0}", codigo)
                };
                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<ObjetivoEspecifico> objetivos = new List<ObjetivoEspecifico>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(response);
                    response.Wait();
                    objetivos = JsonConvert.DeserializeObject<List<ObjetivoEspecifico>>(response.Result);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR");
                    System.Diagnostics.Debug.WriteLine(result);

                }
                return objetivos;
            }
        }

        public static List<Proyecto> buscarProyectos(String criteriosBusqueda, String parametros)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Proyecto")
                {
                    Query = string.Format("criterioBusqueda={0}&parametros={1}", criteriosBusqueda, parametros)
                };
                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Proyecto> proyectos= new List<Proyecto>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(response);
                    response.Wait();
                    proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(response.Result);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR");
                    System.Diagnostics.Debug.WriteLine(result);

                }
                return proyectos;
            }
        }
        [HttpPost]
        public static String ModificarProyecto(string codigoProyecto, string nuevoNombre, string nuevoObjetivoGeneral, string nuevaActaVIE, string nuevaActaEscuela, string nuevaDescripcion, string nuevaJustificacion)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/proyecto/3")
                {

                    Query = string.Format("codigoProyecto={0}&nuevoNombre={1}&nuevoObjetivoGeneral={2}&nuevaActaVIE={3}&nuevaActaEscuela={4}&nuevaDescripcion={5}&nuevaJustificacion={6}", codigoProyecto, nuevoNombre, nuevoObjetivoGeneral, nuevaActaVIE, nuevaActaEscuela, nuevaDescripcion, nuevaJustificacion)
                };
                var values = new Dictionary<string, string>
                {
                    {"codigoProyecto", codigoProyecto},
                    {"nuevoNombre", nuevoNombre},
                    {"nuevoObjetivoGeneral", nuevoObjetivoGeneral},
                    {"nuevaActaVIE", nuevaActaVIE},
                    {"nuevaActaEscuela", nuevaActaEscuela},
                    {"nuevaDescripcion", nuevaDescripcion},
                    {"nuevaJustificacion", nuevaJustificacion}


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
    }
}
