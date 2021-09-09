﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models;
using Newtonsoft.Json;

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
    }
}
