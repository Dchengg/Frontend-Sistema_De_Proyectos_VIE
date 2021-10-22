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
    public class BitacoraController : Controller
    {
        #region

        /// <summary>
        /// Llama al API para obtener la lista de bitácoras del proyecto
        /// </summary>
        /// <param name="codigoProyecto"></param>
        /// <returns>Lista de bitácoras del proyecto</returns>
        public static List<Bitacora> getBitacoras(String codigoProyecto)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Bitacora")
                {
                    Query = string.Format("id={0}", codigoProyecto)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Bitacora> bitacoras = new List<Bitacora>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    bitacoras = JsonConvert.DeserializeObject<List<Bitacora>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return bitacoras;
            }

            #endregion
        }
    }
}
