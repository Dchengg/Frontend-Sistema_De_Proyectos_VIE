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
    public class ColaboradoresController : Controller
    {
        #region
        /// <summary>
        /// llama al API para obtener las ubicaciones geográficas del proyecto
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>lista de ubicaciones geográficas</returns>
        public static List<Colaboradores> GetColaboradores(String codigoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/colaboradores")
                {
                    Query = string.Format("id={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Colaboradores> Colaboradores = new List<Colaboradores>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    Colaboradores = JsonConvert.DeserializeObject<List<Colaboradores>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return Colaboradores;
            }
        }
        #endregion
    }
}
