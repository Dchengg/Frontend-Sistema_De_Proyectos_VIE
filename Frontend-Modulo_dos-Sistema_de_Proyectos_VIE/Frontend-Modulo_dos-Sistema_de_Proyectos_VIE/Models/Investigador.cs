using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Investigador
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("NumIdentidad")]
        public String NumIdentidad { get; set; }
        [JsonProperty("Nombre")]
        public String Nombre { get; set; }
        [JsonProperty("PrimerApellido")]
        public String PrimerApellido { get; set; }
        [JsonProperty("SegundoApellido")]
        public String SegundoApellido { get; set; }

        [JsonProperty("CorreoElectronico")]
        public String CorreoElectronico { get; set; }

        [JsonProperty("TelefonoMovil")]
        public String TelefonoMovil { get; set; }

        [JsonProperty("EstadoActual")]
        public String EstadoActual { get; set; }

        [JsonProperty("Sexo")]
        public String Sexo { get; set; }

        [JsonProperty("PaisNacimiento")]
        public String PaisNacimiento { get; set; }
        [JsonProperty("TipoParticipacion")]
        public String TipoParticipacion { get; set; }
        #endregion
    }
}