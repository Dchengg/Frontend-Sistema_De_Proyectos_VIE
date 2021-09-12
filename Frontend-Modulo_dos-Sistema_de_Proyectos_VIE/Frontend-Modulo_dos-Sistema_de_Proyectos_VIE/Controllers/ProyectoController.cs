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
                Proyecto proyecto = new Proyecto();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(response);
                    response.Wait();
                    proyecto = JsonConvert.DeserializeObject<Proyecto>(response.Result);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR");
                    System.Diagnostics.Debug.WriteLine(result);
                
                }
                return proyecto;
            }
        }

        public static List<ObjetivoEspecifico> getObjetivosProyecto(String codigo)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Objetivos")
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
    }
}
