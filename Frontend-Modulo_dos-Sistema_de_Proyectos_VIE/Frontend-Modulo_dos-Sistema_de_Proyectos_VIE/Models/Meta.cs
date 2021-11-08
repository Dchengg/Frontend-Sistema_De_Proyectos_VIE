using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Meta
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("Nombre")]
        public String Nombre { get; set; }
        [JsonProperty("EstaCumplida")]
        public bool EstaCumplida { get; set; }

        [JsonProperty("Descripcion")]
        public String descripcion { get; set; }

        #endregion
    }
}