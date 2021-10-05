using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class DepartamentosController : Controller
    {

        #region Métodos
        /// <summary>
        /// Recupera las áreas frascati del proyecto, dado el codigo del proyecto
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns>Lista de las áreas frascati del proyecto</returns>
        public static List<Departamento> getDepartamentos(String idDepartamento)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Departamento") 
                {
                    Query = string.Format("id={0}", idDepartamento)
                };


                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Departamento> departamento = new List<Departamento>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    departamento = JsonConvert.DeserializeObject<List<Departamento>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return departamento;
            }
        }
        #endregion


        #region Métodos
        /// <summary>
        /// Recupera las áreas frascati del proyecto, dado el codigo del proyecto
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns>Lista de las áreas frascati del proyecto</returns>
        public static List<Departamento> getDepartamento(string idDepartamento)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Departamento")
                {
                    Query = string.Format("id={0}", idDepartamento)
                };

                var responseTask = client.GetAsync(builder.Uri);
                responseTask.Wait();
                var result = responseTask.Result;
                List<Departamento> departamento = new List<Departamento>();
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync();
                    response.Wait();
                    departamento = JsonConvert.DeserializeObject<List<Departamento>>(response.Result);
                    System.Diagnostics.Debug.WriteLine("Success");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
                return departamento;
            }
        }
        #endregion

        /// <summary>
        /// Agrega un área frascati al proyecto y llama a la API para agregarla a la base de datos
        /// </summary>
        /// <param name="area"></param>
        /// <param name="subArea"></param>
        /// <param name="codigoProyecto"></param>
        /// <returns>String de respuesta de exito o fracaso de agregar el área frascati a la base de datos</returns>
        [HttpPost]
        public static String AgregarDepartamento(String idTipoDepartamento, String idDepartamento, String codigoProyecto)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Departamento/3")
                {

                    Query = string.Format("codigoProyecto={0}&idDepartamento={1}&idTipoDepartamento={2}", codigoProyecto, idDepartamento, idTipoDepartamento)
                };
                var values = new Dictionary<string, string>
                {
                    {"codigoProyecto", codigoProyecto},
                    {"idDepartamento", idDepartamento},
                    {"idTipoDepartamento", idTipoDepartamento}
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
        /// <summary>
        /// Elimina el area frascati selecionada en la interfaz del proyecto y llama a la API para eliminarlo de la base de datos
        /// </summary>
        /// <param name="idAreaFrascati"></param>
        /// <returns>String de respuesta de exito o fracaso de agregar el área frascati a la base de datos</returns>
        /// 
        [HttpDelete]
        public static String EliminarDepartamento(String idDepartamento)
        {
            using (var client = new HttpClient())
            {

                UriBuilder builder = new UriBuilder("https://localhost:44394/api/Departamento/")
                {

                    Query = string.Format("id={0}", idDepartamento)
                };
                var values = new Dictionary<string, string>
                {
                    {"id", idDepartamento}
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