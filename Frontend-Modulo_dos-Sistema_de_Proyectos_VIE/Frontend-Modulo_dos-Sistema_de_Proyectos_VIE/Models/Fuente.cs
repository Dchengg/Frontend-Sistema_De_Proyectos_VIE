using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Fuente
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("FuenteFinanciamiento1")]
        public String FuenteFinanciamiento { get; set; }

        #endregion
    }
}