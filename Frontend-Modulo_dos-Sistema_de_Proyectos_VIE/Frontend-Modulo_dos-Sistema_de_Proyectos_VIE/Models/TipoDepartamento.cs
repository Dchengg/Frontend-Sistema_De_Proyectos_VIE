using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class TipoDepartamento
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("TipoDepartamento1")]

        public String TipoDepartamento1 { get; set; }

        #endregion
    }
}