using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Proyecto
    {
        [JsonProperty("codigo")]
        public String Codigo { get; set; }
        [JsonProperty("nombre")]
        public String Nombre { get; set; }
        [JsonProperty("descripcion")]
        public String Descripcion { get; set; }
        [JsonProperty("justificacion")]
        public String Justificacion { get; set; }
        [JsonProperty("fechaIngreso")]
        public DateTime FechaIngreso { get; set; }
        [JsonProperty("objetivoGeneral")]
        public String ObjetivoGeneral { get; set; }
        [JsonProperty("objetivoEspecifico")]
        public String ObjetivoEspecifico { get; set; }
        [JsonProperty("estado")]
        public String Estado { get; set; }
        [JsonProperty("tipo")]
        public String Tipo { get; set; }
        [JsonProperty("numeroDeActaVIE")]
        public String NumeroActaVIE { get; set; }
        [JsonProperty("numeroDeActaEscuela")]
        public String NumeroActaEscuela { get; set; }
        [JsonProperty("oficialDeProyecto")]
        public String OficialDeProyecto { get; set; }
        [JsonProperty("modalidad")]
        public String Modalidad { get; set; }
        [JsonProperty("fechaAprobacion")]
        public DateTime? FechaAprobacion { get; set; }
        [JsonProperty("fechaInicio")]
        public DateTime? FechaInicio { get; set; }
        [JsonProperty("fechaFinalizacion")]
        public DateTime? FechaFinalizacion { get; set; }
        [JsonProperty("fechaSuspension")]
        public DateTime? FechaSuspension { get; set; }
        [JsonProperty("investigadorCoordinador")]
        public String InvestigadorCoordinador { get; set; }
    }
}