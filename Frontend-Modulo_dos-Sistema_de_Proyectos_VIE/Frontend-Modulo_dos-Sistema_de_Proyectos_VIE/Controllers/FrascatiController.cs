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
    public class FrascatiController : Controller
    {
        // GET: Frascati
        public static List<Frascati> getFrascati(string Id)
        {
            using (var client = new HttpClient()) {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Frascati")
                {
                    Query = string.Format("codigoProyecto={0}", Id)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Frascati> frascatis = new List<Frascati>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    frascatis = JsonConvert.DeserializeObject<List<Frascati>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return frascatis;
            }
        }

    }
}