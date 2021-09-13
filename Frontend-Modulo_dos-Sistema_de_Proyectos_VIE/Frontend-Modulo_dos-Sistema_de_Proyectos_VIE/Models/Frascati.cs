﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Frascati
    {
        [JsonProperty("codigoProyecto")]
        public String CodigoProyecto { get; set; }
        [JsonProperty("idArea")]
        public String IdArea { get; set; }
        [JsonProperty("subArea")]
        public String SubArea { get; set; }
        [JsonProperty("area")]
        public String Area { get; set; }
        [JsonProperty("Proyecto")]
        public String Proyecto { get; set; }
    }
}