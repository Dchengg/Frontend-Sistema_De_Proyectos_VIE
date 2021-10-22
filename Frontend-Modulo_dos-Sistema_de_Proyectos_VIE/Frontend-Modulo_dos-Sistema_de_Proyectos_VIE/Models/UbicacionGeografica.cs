using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class UbicacionGeografica
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("IdPais")]
        public String IdPais { get; set; }
        [JsonProperty("IdRegion")]
        public String IdRegion { get; set; }
        [JsonProperty("IdProvincia")]
        public String IdProvincia { get; set; }
        [JsonProperty("CodigoProyecto")]
        public String CodigoProyecto { get; set; }

        #endregion
    }
}