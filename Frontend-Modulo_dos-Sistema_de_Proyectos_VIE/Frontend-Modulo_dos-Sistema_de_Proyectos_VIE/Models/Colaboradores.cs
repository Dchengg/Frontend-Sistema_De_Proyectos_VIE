using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Colaboradores
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("Nombre")]
        public String Nombre { get; set; }
        [JsonProperty("PrimerApellido")]
        public String PrimerApellido { get; set; }
        [JsonProperty("SegundoApellido")]
        public String SegundoApellido { get; set; }



        #endregion
    }
}