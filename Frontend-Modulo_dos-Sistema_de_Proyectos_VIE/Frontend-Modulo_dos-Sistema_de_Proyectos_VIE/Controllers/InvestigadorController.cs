using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class InvestigadorController : Controller
    {
        public static List<Investigador> getInvestigadores()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44394/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Reportes");
                responseTask.Wait();
                var result = responseTask.Result;
                List<Investigador> investigadores = new List<Investigador>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    investigadores = JsonConvert.DeserializeObject<List<Investigador>>(response.Result);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR");
                }
                return investigadores;
            }
        }
    }
}
