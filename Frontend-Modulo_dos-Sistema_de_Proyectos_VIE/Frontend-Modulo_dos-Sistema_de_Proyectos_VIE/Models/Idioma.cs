using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Idioma
    {
        [JsonProperty("NombreIdioma")]
        public String NombreIdioma { get; set; }
        [JsonProperty("NivelLectura")]
        public String NivelLectura { get; set; }
        [JsonProperty("NivelHabla")]
        public String NivelHabla { get; set; }
        [JsonProperty("NivelEscritura")]
        public String NivelEscritura { get; set; }
    }
}