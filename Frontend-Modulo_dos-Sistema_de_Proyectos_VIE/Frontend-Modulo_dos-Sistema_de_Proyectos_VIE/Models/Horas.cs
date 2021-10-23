using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Horas
    {
        #region Variables y Constantes
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("TipoHora")]
        public String TipoHora { get; set; }
        [JsonProperty("FechaInicio")]
        public String FechaInicio { get; set; }
        [JsonProperty("FechaFinalizacion")]
        public String FechaFinalizacion { get; set; }
        [JsonProperty("CantidadHoras")]
        public String CantidadHoras { get; set; }
        #endregion

    }
}