using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class PalabrasClave
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("PalabraClave")]
        public String PalabraClave { get; set; }
        #endregion
    }
}