using Newtonsoft.Json;
using System;


namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Informe
    {
        #region Variables y Constantes
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("codigoProyecto")]
        public String CodigoProyecto { get; set; }
        [JsonProperty("TituloInforme")]
        public String TituloInforme { get; set; }
        [JsonProperty("Estado")]
        public String Estado { get; set; }
        [JsonProperty("FechaProgramada")]
        public String FechaProgramada { get; set; }
        [JsonProperty("FechaEntrega")]
        public String FechaEntrega { get; set; }
        [JsonProperty("TipoInforme")]
        public String TipoInforme { get; set; }
        #endregion
    }
}