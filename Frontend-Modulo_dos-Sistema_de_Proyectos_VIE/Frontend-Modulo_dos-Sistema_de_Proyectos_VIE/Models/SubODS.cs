using Newtonsoft.Json;
using System;
namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class SubODS
    {
        #region Variables y Constantes
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("codigoProyecto")]

        public String codigoProyecto { get; set; }
        [JsonProperty("SubODS1")]
        public String area { get; set; }
        [JsonProperty("IdODS")]

        public String IdODS { get; set; }
        #endregion
    }
}