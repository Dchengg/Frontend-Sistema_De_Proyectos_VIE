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
    public class UbicacionGeograficaController : Controller
    {
        #region
        /// <summary>
        /// llama al API para obtener las ubicaciones geográficas del proyecto
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>lista de ubicaciones geográficas</returns>
        public static List<UbicacionGeografica>  GetUbicacionesGeograficas(String codigoProyecto)
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

        #endregion

    }
}
