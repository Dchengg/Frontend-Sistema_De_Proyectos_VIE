using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class TipoHora
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("TipoHora1")]
        public String TipoHora1 { get; set; }
        #endregion
    }
}