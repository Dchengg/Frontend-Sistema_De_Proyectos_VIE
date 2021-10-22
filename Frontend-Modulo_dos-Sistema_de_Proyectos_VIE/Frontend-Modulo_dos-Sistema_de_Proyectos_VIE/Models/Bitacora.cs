using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Bitacora
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("Responsable")]
        public String Responsable { get; set; }
        [JsonProperty("Descripcion")]
        public String Descripcion { get; set; }
        [JsonProperty("FechaYHora")]
        public String FechaYHora { get; set; }


        #endregion
    }
}