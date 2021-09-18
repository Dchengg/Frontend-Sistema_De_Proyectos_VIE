using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class ObjetivoEspecifico
    {
        #region Variables y Constantes
        [JsonProperty("codigoProyecto")]
        public String CodigoProyecto { get; set; }
        [JsonProperty("objetivoEspecifico")]
        public String Objetivo { get; set; }
        #endregion
    }
}