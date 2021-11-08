using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Disciplina
    {
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("DisciplinaCientifica")]
        public String Nombre { get; set; }
        [JsonProperty("Subdisciplina")]
        public String Subdisciplina { get; set; }

    }
}