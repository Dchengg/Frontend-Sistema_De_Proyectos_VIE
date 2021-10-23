using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class ObjetivoEspecifico
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("ObjetivoEspecifico")]
        public String Objetivo { get; set; }

        [JsonProperty("ObjetivoEspecifico1")]
        private string ObjetivoEspecifico1 { set { Objetivo = value; } }


        [JsonProperty("Metodologia")]
        public String Metodologia { get; set; }
        #endregion
    }
}