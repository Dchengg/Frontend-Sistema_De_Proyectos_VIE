using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class EstadoProyecto
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("EstadoDeProyecto1")]

        public String EstadoDeProyecto { get; set; }

        #endregion
    }
}