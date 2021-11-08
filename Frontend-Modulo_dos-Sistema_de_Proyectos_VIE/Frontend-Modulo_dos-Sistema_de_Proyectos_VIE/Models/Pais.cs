using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Pais
    {
        #region Variables y Constantes
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("NombrePais")]
        public String Nombre { get; set; }

        #endregion
    }
}