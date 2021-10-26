using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Proyecto
    {
        #region Variables y Constantes
        [JsonProperty("codigo")]
        public String Codigo { get; set; }
        [JsonProperty("NombreDelProyecto")]
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
        [JsonProperty("EstadoDeProyecto")]
        public String Estado { get; set; }
        [JsonProperty("TipoProyecto")]
        public String TipoProyecto { get; set; }

        [JsonProperty("TipoDeProceso")]
        public String TipoDeProceso { get; set; }

        [JsonProperty("ActaVIE")]
        public String NumeroActaVIE { get; set; }
        [JsonProperty("ActaEscuela")]
        public String NumeroActaEscuela { get; set; }
        [JsonProperty("NombreOficial")]
        public String NombreOficial { get; set; }
        [JsonProperty("NombreModalidad")]
        public String Modalidad { get; set; }
        [JsonProperty("fechaAprobacion")]
        public DateTime? FechaAprobacion { get; set; }
        [JsonProperty("FechaInicioEjecucion")]
        public DateTime? FechaInicioEjecucion { get; set; }
        [JsonProperty("FechaFinEjecucion")]
        public DateTime? FechaFinEjecucion { get; set; }
        [JsonProperty("fechaSuspension")]
        public DateTime? FechaSuspension { get; set; }
        [JsonProperty("NombreCoordinador")]
        public String NombreCoordinador { get; set; }
        [JsonProperty("Apellido1Oficial")]
        public String Apellido1Oficial { get; set; }
        [JsonProperty("Apellido2Oficial")]
        public String Apellido2Oficial { get; set; }
        [JsonProperty("Apellido1Coordinador")]
        public String Apellido1Coordinador { get; set; }
        [JsonProperty("Apellido2Coordinador")]
        public String Apellido2Coordinador { get; set; }
        [JsonProperty("Id")]
        public String Id { get; set; }


        #endregion
    }
}