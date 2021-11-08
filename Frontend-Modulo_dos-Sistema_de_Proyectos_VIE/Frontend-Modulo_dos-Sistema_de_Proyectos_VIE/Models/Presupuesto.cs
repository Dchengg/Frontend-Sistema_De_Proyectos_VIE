using Newtonsoft.Json;
using System;

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
        [JsonProperty("FuenteFinanciamiento")]

        public String FuenteFinanciamiento { get; set; }
        [JsonProperty("Partida")]

        public String Partida { get; set; }

        [JsonProperty("Organizacion")]

        public String Organizacion { get; set; }


        #endregion

    }
}