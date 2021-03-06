using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Poblacion
    {
        #region Variables y Constantes
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("codigoProyecto")]
        public String Codigoproyecto { get; set; }
        [JsonProperty("IdPoblacionBeneficiaria")]
        public String IdPoblacionBeneficiaria { get; set; }

        [JsonProperty("NombrePoblacion")]
        public String Nombre { get; set; }
        #endregion
    }
}