using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class ReporteHoras : ResultadoReporte
    {
        [JsonProperty("HorasTotales")]
        public int HorasTotales { get; set; }
    }
}