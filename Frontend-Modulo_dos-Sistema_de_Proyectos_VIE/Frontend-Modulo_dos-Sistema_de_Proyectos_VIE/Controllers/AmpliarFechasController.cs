using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;


namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class AmpliarFechasController : Controller
    {
        [HttpPost]
        public static String AmpliarFechas(string fechaAprobacion, string nuevaFechaFinalizacion, string viejaFechaFinalizacion, string observaciones, string codigo)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/ampliacion/AmpliarFecha");
                var values = new Dictionary<string, string>
                {
                    {"fechaAprobacion", fechaAprobacion},
                    {"nuevaFechaFinalizacion", nuevaFechaFinalizacion},
                    {"viejaFechaFinalizacion", viejaFechaFinalizacion},
                    {"observaciones", observaciones},
                    {"codigo", codigo}


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