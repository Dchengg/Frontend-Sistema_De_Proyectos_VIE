using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class ResultadoReporte
    {
        [JsonProperty("Codigo")]
        public String CodigoProyecto { get; set; }
        [JsonProperty("NombreDelProyecto")]
        public String NombreProyecto { get; set; }
    }
}