﻿using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;



namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
          
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BuscadorProyectos()
        {
            return View();
        }
    }
}