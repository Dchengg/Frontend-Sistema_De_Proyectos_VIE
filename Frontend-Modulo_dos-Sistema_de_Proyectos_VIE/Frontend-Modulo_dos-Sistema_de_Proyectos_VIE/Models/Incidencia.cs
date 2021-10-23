using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Incidencia
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("TituloIncidencia")]
        public String TituloIncidencia { get; set; }
        [JsonProperty("Descripcion")]
        public String Descripcion { get; set; }
               
        #endregion
    }
}