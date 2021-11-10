using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using UIProcess.Modelos;

namespace UIProcess.Consultas
{
    public class Consultor
    {
        public static HttpClient Api = new HttpClient();

        static Consultor()
        {
            Api.BaseAddress = new Uri("https://localhost:44338/api/");
            Api.DefaultRequestHeaders.Clear();
            Api.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Consulta los catálogos necesarios para la vista del investigador de la API
        /// </summary>
        /// <returns>Objeto UipRespuesta con los catálogos, un código y un mensaje de respuesta</returns>
        public static UipRespuesta<UipCatalogosInvestigador> ConsultarCatalogos()
        {
            try
            {
                HttpResponseMessage respuesta = Api.GetAsync("Inicio").Result;
                return respuesta.Content.ReadAsAsync<UipRespuesta<UipCatalogosInvestigador>>().Result;
            }
            catch (HttpRequestException)
            {
                return new UipRespuesta<UipCatalogosInvestigador>()
                {
                    CodigoRespuesta = -101,
                    MensajeRespuesta = "Hubo un error al realizar la solicitud al servidor. Verifique que está conectado e inténtelo de nuevo.",
                    ObjetoRespuesta = null,
                    Estado = false
                };
            }
            catch (AggregateException)
            {
                return new UipRespuesta<UipCatalogosInvestigador>()
                {
                    CodigoRespuesta = -102,
                    MensajeRespuesta = "Hubo un error durante la lectura de los datos del investigador, inténtelo de nuevo.",
                    ObjetoRespuesta = null,
                    Estado = false
                };
            }

        }

        /// <summary>
        /// Consulta los datos de un investigador en la API dado el número de identidad.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objeto UipRespuesta con los datos del investigador, un código y un mensaje de respuesta</returns>
        public static UipRespuesta<UipInvestigadorConsultar> ConsultarInvestigador(string id)
        {
            try
            {
                HttpResponseMessage respuesta = Api.GetAsync("Investigador/" + id).Result;
                return respuesta.Content.ReadAsAsync<UipRespuesta<UipInvestigadorConsultar>>().Result;
            }
            catch (ArgumentNullException)
            {
                return new UipRespuesta<UipInvestigadorConsultar>()
                {
                    CodigoRespuesta = -100,
                    MensajeRespuesta = "El número de identificación del usuario no fue especificado.",
                    ObjetoRespuesta = null,
                    Estado = false
                };
            }
            catch (HttpRequestException)
            {
                return new UipRespuesta<UipInvestigadorConsultar>()
                {
                    CodigoRespuesta = -101,
                    MensajeRespuesta = "Hubo un error al realizar la solicitud al servidor. Verifique que está conectado e inténtelo de nuevo.",
                    ObjetoRespuesta = null,
                    Estado = false
                };
            }
            catch (AggregateException)
            {
                return new UipRespuesta<UipInvestigadorConsultar>()
                {
                    CodigoRespuesta = -102,
                    MensajeRespuesta = "Hubo un error durante la lectura de los datos del investigador, inténtelo de nuevo.",
                    ObjetoRespuesta = null,
                    Estado = false
                };
            }

        }

        /// <summary>
        /// Consulta a la API una lista de datos generales de todos los investigadores registrados en el sistema.
        /// </summary>
        /// <returns>Objeto UipRespuesta con la lista de datos generales de investigadores, 
        ///          un código y un mensaje de respuesta</returns>
        public static UipRespuesta<List<UipInvestigadorListar>> ConsultarListaInvestigadores()
        {
            try
            {
                HttpResponseMessage respuesta = Api.GetAsync("Investigador/").Result;
                return respuesta.Content.ReadAsAsync<UipRespuesta<List<UipInvestigadorListar>>>().Result;
            }
            catch (HttpRequestException)
            {
                return new UipRespuesta<List<UipInvestigadorListar>>()
                {
                    CodigoRespuesta = -101,
                    MensajeRespuesta = "Hubo un error al realizar la solicitud al servidor. Verifique que está conectado e inténtelo de nuevo.",
                    ObjetoRespuesta = null,
                    Estado = false
                };
            }
            catch (AggregateException)
            {
                return new UipRespuesta<List<UipInvestigadorListar>>()
                {
                    CodigoRespuesta = -102,
                    MensajeRespuesta = "Hubo un error durante la lectura de la lista de los investigadores, inténtelo de nuevo.",
                    ObjetoRespuesta = null,
                    Estado = false
                };
            }

        }

        /// <summary>
        /// Realiza la solicitud a la API de eliminar a un investigador dado su número de identidad
        /// </summary>
        /// <param name="id"></param>
        public static void EliminarInvestigador(string id)
        {
            HttpResponseMessage respuesta = Api.DeleteAsync("Investigador/" + id).Result;
        }
    }
}
