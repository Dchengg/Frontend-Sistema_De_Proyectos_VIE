using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Presupuesto
    {
        #region Variables y Constantes
        [JsonProperty("id")]
        public String id { get; set; }
        [JsonProperty("Nombre")]
        public String Nombre { get; set; }
        [JsonProperty("Ano")]
        public int Ano { get; set; }
        [JsonProperty("Monto")]
        public int Monto { get; set; }
        [JsonProperty("Justificacion")]

        public String Justificacion { get; set; }

        #endregion

    }
}