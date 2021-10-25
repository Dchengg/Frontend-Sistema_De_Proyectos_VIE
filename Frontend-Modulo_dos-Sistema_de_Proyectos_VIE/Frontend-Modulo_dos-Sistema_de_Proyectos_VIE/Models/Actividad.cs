using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Actividad
    {
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("Actividad")]
        public String Nombre { get; set; }

        [JsonProperty("Fecha")]
        public DateTime Fecha { get; set; }

        [JsonProperty("Trimestre")]
        public int Trimestre { get; set; }

        [JsonProperty("DescripcionActividad")]
        public String Descripcion { get; set; }
    }
}