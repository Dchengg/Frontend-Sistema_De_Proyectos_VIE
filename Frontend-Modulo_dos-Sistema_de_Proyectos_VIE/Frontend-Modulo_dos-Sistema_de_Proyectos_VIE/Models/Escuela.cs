using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Escuela
    {
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("NombreEscuela")]
        public String Nombre { get; set; }
        [JsonProperty("IdSede")]
        public int IdSede { get; set; }
        [JsonProperty("NombreSede")]
        public String NombreSede { get; set; }
    }
}