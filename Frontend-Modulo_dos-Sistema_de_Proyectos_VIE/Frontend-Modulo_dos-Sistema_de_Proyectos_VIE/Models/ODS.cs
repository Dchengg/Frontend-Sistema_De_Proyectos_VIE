using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class ODS
    {
        #region Variables y Constantes
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("codigoProyecto")]
        public String Codigoproyecto { get; set; }
        [JsonProperty("codigoDeArea")]
        public String CodigoDeArea { get; set; }
        [JsonProperty("SubODS")]
        public String SubArea { get; set; }
        [JsonProperty("ODS")]
        public String Area { get; set; }
        [JsonProperty("Proyecto")]
        public String Proyecto { get; set; }
        [JsonProperty("ODS1")]
        public String ODS1 { get; set; }
        #endregion
    }
}