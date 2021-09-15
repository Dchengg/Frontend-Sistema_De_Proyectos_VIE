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
                    Query = string.Format("id={0}", Id)
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

        [HttpPost]
        public static String CreateAreaFrascati(String area, String subArea, String codigo)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Frascati/3")
                {
                   
                    Query = string.Format("codigoProyecto={0}&area={1}&subArea={2}", codigo, area, subArea)
                };
                var values = new Dictionary<string, string>
                {
                    {"codigoProyecto", codigo},
                    {"area", area},
                    {"subarea", subArea}
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

        public static String deleteAreaFrascati(String id) {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Frascati/1")
                {

                    Query = string.Format("id={0}", id)
                };
                var values = new Dictionary<string, string>
                {
                    {"id", id}
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