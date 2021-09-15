using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Poblacion
    {
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("codigoProyecto")]
        public String Codigoproyecto { get; set; }
        [JsonProperty("codigoPoblacion")]
        public String CodigoPoblacion { get; set; }
        [JsonProperty("poblacion")]
        //Cuidado con el nombre del atributo
        public String PoblacionBeneficiaria { get; set; }
        [JsonProperty("Proyecto")]
        public String Proyecto { get; set; }
    }
}