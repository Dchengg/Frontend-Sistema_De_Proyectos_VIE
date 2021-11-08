using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class UbicacionGeografica
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("NombrePais")]
        public String NombrePais { get; set; }
        [JsonProperty("NombreRegion")]
        public String NombreRegion { get; set; }
        [JsonProperty("IdProvincia")]
        public String IdProvincia { get; set; }
        [JsonProperty("CodigoProyecto")]
        public String CodigoProyecto { get; set; }
        [JsonProperty("Nombre")]
        public String Nombre { get; set; }



        #endregion
    }
}