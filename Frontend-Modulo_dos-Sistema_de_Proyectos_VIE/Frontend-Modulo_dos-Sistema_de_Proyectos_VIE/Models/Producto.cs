using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Producto
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("Actividad")]
        public String Actividad { get; set; }
        [JsonProperty("IdInvestigadorEncargado")]
        public String IdInvestigadorEncargado { get; set; }

        [JsonProperty("IdColaboradorEncargado")]
        public String IdColaboradorEncargado { get; set; }
        [JsonProperty("IdNivelDeResponsabilidad")]
        public String IdNivelDeResponsabilidad { get; set; }
        [JsonProperty("Nombre")]
        public String Nombre { get; set; }
        [JsonProperty("IdObjetivoEspecifico")]
        public String IdObjetivoEspecifico { get; set; }
        [JsonProperty("Ano")]
        public String Ano { get; set; }
        [JsonProperty("Trimestre")]
        public String Trimestre { get; set; }
        [JsonProperty("Fecha")]
        public String Fecha { get; set; }
        [JsonProperty("Colaborador")]
        public String Colaborador { get; set; }
        [JsonProperty("NivelDeResponsabilidad")]
        public String NivelDeResponsabilidad { get; set; }

        [JsonProperty("EncargadoNombre")]
        public String EncargadoNombre { get; set; }
        

        #endregion
    }
}