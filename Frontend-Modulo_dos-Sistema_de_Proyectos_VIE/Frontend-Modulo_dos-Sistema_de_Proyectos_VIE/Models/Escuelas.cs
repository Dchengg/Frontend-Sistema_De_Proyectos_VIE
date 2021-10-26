using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Escuelas
    {
        #region Variables y Constantes
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("NombreEscuela")]
        public String NombreEscuela { get; set; }
        [JsonProperty("IdSede")]
        public int IdSede { get; set; }
        [JsonProperty("Sede")]
        public String Sede { get; set; }

        #endregion

    }
}